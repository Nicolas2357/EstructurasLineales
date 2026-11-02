namespace ColasEstaticas;

/// <summary>
/// Interfaz de las colas: aplica cada operación a la cola simple y a la circular,
/// dibuja ambos arreglos con sus índices front y rear (la circular también como anillo)
/// y corre las pruebas automáticas.
/// </summary>
public partial class Form1 : Form
{
    private static readonly Color ColorAzul = Color.FromArgb(31, 58, 96);
    private static readonly Color ColorOcupada = Color.FromArgb(210, 228, 250);
    private static readonly Color ColorDesperdicio = Color.FromArgb(228, 228, 228);
    private static readonly Color ColorFront = Color.FromArgb(25, 135, 60);
    private static readonly Color ColorRear = Color.FromArgb(230, 120, 30);
    private static readonly Color ColorError = Color.FromArgb(190, 40, 40);
    private const TextFormatFlags Centrado = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;

    private readonly Random _random = new();
    private readonly Font _fuenteValor = new("Segoe UI", 11F, FontStyle.Bold);
    private readonly Font _fuenteTitulo = new("Segoe UI", 11F, FontStyle.Bold);
    private readonly Font _fuenteChica = new("Consolas", 8.5F);
    private readonly Font _fuentePuntero = new("Segoe UI", 8.5F, FontStyle.Bold);
    private readonly SolidBrush _pincel = new(Color.White);

    private ColaSimple<int> _simple = new(6);
    private ColaCircular<int> _circular = new(6);
    private int _aprobadas, _total;

    public Form1()
    {
        InitializeComponent();
        picColas.Resize += (_, _) => picColas.Invalidate();
    }

    private void Form1_Load(object? sender, EventArgs e) => CrearColas();

    // ═══════════════════════ OPERACIONES ═══════════════════════

    private void BtnCrear_Click(object? sender, EventArgs e) => CrearColas();

    private void CrearColas()
    {
        int capacidad = (int)nudCapacidad.Value;
        _simple = new ColaSimple<int>(capacidad);
        _circular = new ColaCircular<int>(capacidad);
        lstHistorial.Items.Clear();
        Registrar($"Colas creadas: arreglos de {capacidad} posiciones, front = 0, rear = -1");
        picColas.Invalidate();
    }

    private void BtnEncolar_Click(object? sender, EventArgs e)
    {
        int valor = (int)nudValor.Value;
        string simple = Intentar(() => { _simple.Enqueue(valor); return $"✔ rear = {_simple.Rear}"; });
        string circular = Intentar(() => { _circular.Enqueue(valor); return $"✔ rear = {_circular.Rear}"; });
        Registrar($"Enqueue({valor})  |  Simple: {simple}  |  Circular: {circular}");
        nudValor.Value = _random.Next(1, 100);     // sugiere el siguiente valor
    }

    private void BtnDesencolar_Click(object? sender, EventArgs e)
    {
        string simple = Intentar(() => { int v = _simple.Dequeue(); return $"✔ {v} (front = {_simple.Front})"; });
        string circular = Intentar(() => { int v = _circular.Dequeue(); return $"✔ {v} (front = {_circular.Front})"; });
        Registrar($"Dequeue()  |  Simple: {simple}  |  Circular: {circular}");
    }

    private void BtnPeek_Click(object? sender, EventArgs e)
    {
        string simple = Intentar(() => $"✔ {_simple.Peek()}");
        string circular = Intentar(() => $"✔ {_circular.Peek()}");
        Registrar($"Peek()  |  Simple: {simple}  |  Circular: {circular}");
    }

    private void BtnVaciar_Click(object? sender, EventArgs e)
    {
        _simple.Vaciar();
        _circular.Vaciar();
        Registrar("Vaciar() en ambas colas → front = 0, rear = -1");
    }

    private void BtnAleatorio_Click(object? sender, EventArgs e) => nudValor.Value = _random.Next(1, 100);

    /// <summary>Ejecuta una operación y devuelve su resultado o el mensaje de error.</summary>
    private static string Intentar(Func<string> operacion)
    {
        try
        {
            return operacion();
        }
        catch (InvalidOperationException ex)
        {
            return "✖ " + ex.Message;
        }
    }

    private void Registrar(string texto)
    {
        lstHistorial.Items.Insert(0, $"{DateTime.Now:HH:mm:ss}  {texto}");
        lblEstado.Text = texto;
        picColas.Invalidate();
    }

    // ═══════════════════════ DIBUJO ═══════════════════════

    private void PicColas_Paint(object? sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        int ancho = picColas.Width;
        int mitad = picColas.Height / 2;
        int celda = Math.Max(26, Math.Min(48, (ancho - 300) / _simple.Capacidad));

        // Cola simple (mitad superior)
        DibujarFila(g, _simple, "Cola simple", 20, 6, celda, true);
        if (_simple.FalsoDesbordamiento)
            TextRenderer.DrawText(g, $"⚠ Falso desbordamiento: {_simple.Front} espacio(s) antes de front no se pueden reutilizar",
                _fuentePuntero, new Point(20, 6 + celda + 128), ColorError);
        DibujarLeyenda(g, ancho - 255, 14);

        g.DrawLine(Pens.Gainsboro, 10, mitad, ancho - 10, mitad);

        // Cola circular (mitad inferior): arreglo y anillo
        DibujarFila(g, _circular, "Cola circular", 20, mitad + 6, celda, false);
        DibujarAnillo(g, _circular, new Point(ancho - 125, mitad + 98), 62);
    }

    /// <summary>Dibuja el arreglo de una cola con sus índices, los punteros y su estado.</summary>
    private void DibujarFila(Graphics g, ICola<int> cola, string titulo, int x, int y0, int celda, bool marcarDesperdicio)
    {
        TextRenderer.DrawText(g, titulo, _fuenteTitulo, new Point(x, y0), ColorAzul);
        int yCeldas = y0 + 40;

        for (int i = 0; i < cola.Capacidad; i++)
        {
            var rect = new Rectangle(x + i * celda, yCeldas, celda, celda);
            bool ocupada = cola.EstaOcupada(i);
            bool desperdicio = marcarDesperdicio && !ocupada && i < cola.Front;

            _pincel.Color = ocupada ? ColorOcupada : desperdicio ? ColorDesperdicio : Color.White;
            g.FillRectangle(_pincel, rect);
            g.DrawRectangle(Pens.Gray, rect);

            TextRenderer.DrawText(g, $"[{i}]", _fuenteChica, new Rectangle(rect.X, y0 + 22, celda, 16),
                Color.DimGray, TextFormatFlags.HorizontalCenter);

            if (ocupada)
                TextRenderer.DrawText(g, cola.ElementoEn(i).ToString(), _fuenteValor, rect, Color.Black, Centrado);
            else if (desperdicio)
                TextRenderer.DrawText(g, "×", _fuenteValor, rect, Color.Gray, Centrado);
        }

        DibujarPuntero(g, "front", cola.Front, x, celda, yCeldas + celda + 4, ColorFront);
        DibujarPuntero(g, "rear", cola.Rear, x, celda, yCeldas + celda + 22, ColorRear);

        TextRenderer.DrawText(g, $"front = {cola.Front}   rear = {cola.Rear}   cantidad = {cola.Cantidad}/{cola.Capacidad}",
            _fuenteChica, new Point(x, yCeldas + celda + 46), Color.Black);
        TextRenderer.DrawText(g, $"IsEmpty() = {(cola.IsEmpty() ? "true" : "false")}   IsFull() = {(cola.IsFull() ? "true" : "false")}",
            _fuenteChica, new Point(x, yCeldas + celda + 62), cola.IsFull() ? ColorError : Color.Black);
    }

    private void DibujarPuntero(Graphics g, string nombre, int indice, int x, int celda, int y, Color color)
    {
        if (indice < 0)
            TextRenderer.DrawText(g, $"{nombre} = -1", _fuentePuntero, new Point(x, y), color);
        else
            TextRenderer.DrawText(g, $"▲ {nombre}", _fuentePuntero, new Rectangle(x + indice * celda - 20, y, celda + 40, 18),
                color, TextFormatFlags.HorizontalCenter);
    }

    /// <summary>Dibuja la cola circular como un anillo para mostrar que el índice da la vuelta.</summary>
    private void DibujarAnillo(Graphics g, ColaCircular<int> cola, Point centro, int radio)
    {
        const int r = 17;
        int capacidad = cola.Capacidad;

        using var lapizAnillo = new Pen(Color.FromArgb(190, 198, 210), 2F);
        using var lapizFront = new Pen(ColorFront, 3F);
        using var lapizRear = new Pen(ColorRear, 3F);
        g.DrawEllipse(lapizAnillo, centro.X - radio, centro.Y - radio, radio * 2, radio * 2);

        for (int i = 0; i < capacidad; i++)
        {
            double angulo = (-90 + 360.0 * i / capacidad) * Math.PI / 180;
            float px = centro.X + (float)(radio * Math.Cos(angulo));
            float py = centro.Y + (float)(radio * Math.Sin(angulo));
            var nodo = new RectangleF(px - r, py - r, 2 * r, 2 * r);
            bool ocupada = cola.EstaOcupada(i);

            _pincel.Color = ocupada ? ColorOcupada : Color.White;
            g.FillEllipse(_pincel, nodo);
            g.DrawEllipse(Pens.Gray, nodo);

            if (i == cola.Rear)
                g.DrawEllipse(lapizRear, nodo.X - 4, nodo.Y - 4, nodo.Width + 8, nodo.Height + 8);
            if (i == cola.Front)
                g.DrawEllipse(lapizFront, nodo);

            if (ocupada)
                TextRenderer.DrawText(g, cola.ElementoEn(i).ToString(), _fuenteValor, Rectangle.Round(nodo), Color.Black, Centrado);

            float ix = centro.X + (float)((radio + 30) * Math.Cos(angulo));
            float iy = centro.Y + (float)((radio + 30) * Math.Sin(angulo));
            TextRenderer.DrawText(g, $"[{i}]", _fuenteChica, new Rectangle((int)ix - 16, (int)iy - 8, 32, 16), Color.DimGray, Centrado);
        }

        TextRenderer.DrawText(g, "vista\ncircular", _fuenteChica, new Rectangle(centro.X - 30, centro.Y - 15, 60, 30),
            Color.DimGray, Centrado);
    }

    private void DibujarLeyenda(Graphics g, int x, int y)
    {
        DibujarElementoLeyenda(g, x, y, ColorOcupada, "Posición ocupada");
        DibujarElementoLeyenda(g, x, y + 20, Color.White, "Posición libre");
        DibujarElementoLeyenda(g, x, y + 40, ColorDesperdicio, "Libre pero no reutilizable (×)");
        TextRenderer.DrawText(g, "▲ front: primer elemento (sale)", _fuentePuntero, new Point(x, y + 62), ColorFront);
        TextRenderer.DrawText(g, "▲ rear: último elemento (entra)", _fuentePuntero, new Point(x, y + 80), ColorRear);
    }

    private void DibujarElementoLeyenda(Graphics g, int x, int y, Color color, string texto)
    {
        _pincel.Color = color;
        g.FillRectangle(_pincel, x, y + 2, 14, 14);
        g.DrawRectangle(Pens.Gray, x, y + 2, 14, 14);
        TextRenderer.DrawText(g, texto, _fuenteChica, new Point(x + 20, y + 2), Color.Black);
    }

    // ═══════════════════════ PRUEBAS AUTOMÁTICAS ═══════════════════════

    private void BtnPruebas_Click(object? sender, EventArgs e)
    {
        lstPruebas.Items.Clear();
        _aprobadas = _total = 0;

        // ----- Cola simple -----
        var s = new ColaSimple<int>(4);
        Verificar("Simple nueva: IsEmpty() = true, front = 0, rear = -1", s.IsEmpty() && s.Front == 0 && s.Rear == -1);

        s.Enqueue(1); s.Enqueue(2); s.Enqueue(3); s.Enqueue(4);
        Verificar("Simple: 4 Enqueue con capacidad 4 → IsFull() = true, rear = 3", s.IsFull() && s.Rear == 3);
        Verificar("Simple: Enqueue en cola llena lanza desbordamiento", Lanza<InvalidOperationException>(() => s.Enqueue(5)));
        Verificar("Simple: Peek() devuelve 1 sin eliminarlo", s.Peek() == 1 && s.Cantidad == 4);
        Verificar("Simple: Dequeue() respeta el orden FIFO: 1, 2", s.Dequeue() == 1 && s.Dequeue() == 2);
        Verificar("Simple: falso desbordamiento (2 lugares libres pero IsFull() = true)",
            s.IsFull() && s.Cantidad == 2 && s.FalsoDesbordamiento && Lanza<InvalidOperationException>(() => s.Enqueue(5)));

        s.Dequeue(); s.Dequeue();
        Verificar("Simple: al vaciarse se reinician los índices (front = 0, rear = -1)", s.IsEmpty() && s.Front == 0 && s.Rear == -1);
        Verificar("Simple: Dequeue en cola vacía lanza subdesbordamiento", Lanza<InvalidOperationException>(() => s.Dequeue()));

        // ----- Cola circular -----
        var c = new ColaCircular<int>(4);
        Verificar("Circular nueva: IsEmpty() = true, front = 0, rear = -1", c.IsEmpty() && c.Front == 0 && c.Rear == -1);

        c.Enqueue(1); c.Enqueue(2); c.Enqueue(3); c.Enqueue(4);
        Verificar("Circular: 4 Enqueue con capacidad 4 → IsFull() = true, rear = 3", c.IsFull() && c.Rear == 3);
        Verificar("Circular: Dequeue() respeta el orden FIFO: 1, 2 → front = 2", c.Dequeue() == 1 && c.Dequeue() == 2 && c.Front == 2);

        c.Enqueue(5); c.Enqueue(6);
        Verificar("Circular: reutiliza los espacios liberados (rear da la vuelta: 3 → 0 → 1)", c.Rear == 1 && c.IsFull());
        Verificar("Circular: Enqueue en cola llena lanza desbordamiento", Lanza<InvalidOperationException>(() => c.Enqueue(7)));
        Verificar("Circular: orden FIFO después de la vuelta: 3, 4, 5, 6",
            c.Dequeue() == 3 && c.Dequeue() == 4 && c.Dequeue() == 5 && c.Dequeue() == 6);
        Verificar("Circular: Dequeue en cola vacía lanza subdesbordamiento", Lanza<InvalidOperationException>(() => c.Dequeue()));

        // ----- Validación -----
        Verificar("Capacidad 0 lanza ArgumentException en ambas colas",
            Lanza<ArgumentException>(() => new ColaSimple<int>(0)) && Lanza<ArgumentException>(() => new ColaCircular<int>(0)));

        MostrarResumen();
    }

    private void Verificar(string descripcion, bool aprobada)
    {
        _total++;
        if (aprobada) _aprobadas++;
        lstPruebas.Items.Add($"{(aprobada ? "✔" : "✖")}  {_total,2}. {descripcion}");
    }

    /// <summary>Devuelve true si la acción lanza la excepción esperada.</summary>
    private static bool Lanza<TExcepcion>(Action accion) where TExcepcion : Exception
    {
        try
        {
            accion();
            return false;
        }
        catch (TExcepcion)
        {
            return true;
        }
    }

    private void MostrarResumen()
    {
        bool todas = _aprobadas == _total;
        lblResumen.Text = $"{_aprobadas} de {_total} pruebas aprobadas";
        lblResumen.ForeColor = todas ? Color.FromArgb(25, 110, 50) : Color.FromArgb(170, 30, 30);
        lblEstado.Text = lblResumen.Text;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _fuenteValor.Dispose();
        _fuenteTitulo.Dispose();
        _fuenteChica.Dispose();
        _fuentePuntero.Dispose();
        _pincel.Dispose();
        base.OnFormClosed(e);
    }
}