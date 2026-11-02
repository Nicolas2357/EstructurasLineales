using System.Drawing.Drawing2D;

namespace PilaEstatica;

/// <summary>
/// Interfaz de la pila: ejecuta las operaciones, dibuja el arreglo con el índice top,
/// lleva el historial y corre las pruebas automáticas.
/// </summary>
public partial class Form1 : Form
{
    private static readonly Color ColorAzul = Color.FromArgb(31, 58, 96);
    private static readonly Color ColorOcupada = Color.FromArgb(210, 228, 250);
    private static readonly Color ColorPush = Color.FromArgb(200, 240, 200);
    private static readonly Color ColorPop = Color.FromArgb(255, 210, 210);
    private static readonly Color ColorPeek = Color.FromArgb(255, 243, 176);

    private readonly Random _random = new();
    private readonly Font _fuenteValor = new("Segoe UI", 12F, FontStyle.Bold);
    private readonly Font _fuenteIndice = new("Consolas", 9F);
    private readonly Font _fuentePuntero = new("Segoe UI", 10F, FontStyle.Bold);
    private readonly SolidBrush _pincel = new(Color.White);

    private PilaEstatica<int> _pila = new(6);
    private int _indiceResaltado = -1;     // celda de la última operación
    private Color _colorResaltado;
    private int _aprobadas, _total;

    public Form1()
    {
        InitializeComponent();
        picPila.Resize += (_, _) => picPila.Invalidate();
    }

    private void Form1_Load(object? sender, EventArgs e) => CrearPila();

    // ═══════════════════════ OPERACIONES ═══════════════════════

    private void BtnCrear_Click(object? sender, EventArgs e) => CrearPila();

    private void CrearPila()
    {
        _pila = new PilaEstatica<int>((int)nudCapacidad.Value);
        _indiceResaltado = -1;
        lstHistorial.Items.Clear();
        Registrar($"Pila creada: arreglo de {_pila.Capacidad} posiciones, top = -1");
        Actualizar();
    }

    private void BtnPush_Click(object? sender, EventArgs e)
    {
        int valor = (int)nudValor.Value;
        Ejecutar(() =>
        {
            _pila.Push(valor);
            Resaltar(_pila.Top, ColorPush);
            Registrar($"Push({valor}) → top = {_pila.Top}");
        });
    }

    private void BtnPop_Click(object? sender, EventArgs e) => Ejecutar(() =>
    {
        int valor = _pila.Pop();
        Resaltar(_pila.Top + 1, ColorPop);   // la posición que quedó libre
        Registrar($"Pop() = {valor} → top = {_pila.Top}");
    });

    private void BtnPeek_Click(object? sender, EventArgs e) => Ejecutar(() =>
    {
        int valor = _pila.Peek();
        Resaltar(_pila.Top, ColorPeek);
        Registrar($"Peek() = {valor} (no se elimina)");
    });

    private void BtnVaciar_Click(object? sender, EventArgs e)
    {
        _pila.Vaciar();
        _indiceResaltado = -1;
        Registrar("Vaciar() → top = -1");
        Actualizar();
    }

    private void BtnAleatorio_Click(object? sender, EventArgs e) => nudValor.Value = _random.Next(1, 100);

    /// <summary>Ejecuta una operación y muestra los errores de desbordamiento o subdesbordamiento.</summary>
    private void Ejecutar(Action operacion)
    {
        try
        {
            operacion();
        }
        catch (InvalidOperationException ex)
        {
            _indiceResaltado = -1;
            Registrar("✖ " + ex.Message);
            MessageBox.Show(ex.Message, "Operación no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        Actualizar();
    }

    private void Resaltar(int indice, Color color)
    {
        _indiceResaltado = indice;
        _colorResaltado = color;
    }

    private void Registrar(string texto)
    {
        lstHistorial.Items.Insert(0, $"{DateTime.Now:HH:mm:ss}  {texto}");
        lblEstado.Text = texto;
    }

    private void Actualizar()
    {
        lblCapacidadValor.Text = _pila.Capacidad.ToString();
        lblCantidadValor.Text = _pila.Cantidad.ToString();
        lblTopValor.Text = _pila.Top.ToString();
        lblVaciaValor.Text = _pila.IsEmpty() ? "true" : "false";
        lblLlenaValor.Text = _pila.IsFull() ? "true" : "false";
        lblVaciaValor.ForeColor = _pila.IsEmpty() ? Color.FromArgb(190, 40, 40) : Color.Black;
        lblLlenaValor.ForeColor = _pila.IsFull() ? Color.FromArgb(190, 40, 40) : Color.Black;
        picPila.Invalidate();
    }

    // ═══════════════════════ DIBUJO DEL ARREGLO ═══════════════════════

    private void PicPila_Paint(object? sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int capacidad = _pila.Capacidad;
        int alto = Math.Min(48, (picPila.Height - 90) / capacidad);
        const int ancho = 150;
        int x = (picPila.Width - ancho) / 2 - 40;
        int yBase = picPila.Height - 40;        // borde inferior de la posición [0]

        TextRenderer.DrawText(g, $"Arreglo estático  T[{capacidad}]", _fuentePuntero, new Point(12, 10), ColorAzul);

        for (int i = 0; i < capacidad; i++)
        {
            var rect = new Rectangle(x, yBase - (i + 1) * alto, ancho, alto);
            bool ocupada = i <= _pila.Top;

            _pincel.Color = i == _indiceResaltado ? _colorResaltado : ocupada ? ColorOcupada : Color.White;
            g.FillRectangle(_pincel, rect);
            g.DrawRectangle(Pens.Silver, rect);

            if (ocupada)
                TextRenderer.DrawText(g, _pila.ElementoEn(i).ToString(), _fuenteValor, rect, Color.Black,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            TextRenderer.DrawText(g, $"[{i}]", _fuenteIndice, new Rectangle(x - 48, rect.Y, 42, alto), Color.DimGray,
                TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
        }

        // Contenedor en forma de "U" (la pila solo se abre por arriba)
        using var lapizContenedor = new Pen(ColorAzul, 3F);
        int yArriba = yBase - capacidad * alto;
        g.DrawLine(lapizContenedor, x - 2, yArriba, x - 2, yBase + 2);
        g.DrawLine(lapizContenedor, x + ancho + 2, yArriba, x + ancho + 2, yBase + 2);
        g.DrawLine(lapizContenedor, x - 2, yBase + 2, x + ancho + 2, yBase + 2);

        // Flecha del índice top
        int yTop = _pila.Top >= 0 ? yBase - (_pila.Top + 1) * alto + alto / 2 : yBase + 18;
        using var flecha = new Pen(Color.FromArgb(0, 90, 200), 2.5F) { CustomEndCap = new AdjustableArrowCap(5, 5) };
        g.DrawLine(flecha, x + ancho + 70, yTop, x + ancho + 10, yTop);
        string textoTop = _pila.Top >= 0 ? $"top = {_pila.Top}" : "top = -1 (vacía)";
        TextRenderer.DrawText(g, textoTop, _fuentePuntero, new Point(x + ancho + 74, yTop - 10), Color.FromArgb(0, 90, 200));
    }

    // ═══════════════════════ PRUEBAS AUTOMÁTICAS ═══════════════════════

    private void BtnPruebas_Click(object? sender, EventArgs e)
    {
        lstPruebas.Items.Clear();
        _aprobadas = _total = 0;

        var p = new PilaEstatica<int>(3);
        Verificar("Pila nueva: IsEmpty() = true, IsFull() = false, top = -1", p.IsEmpty() && !p.IsFull() && p.Top == -1);

        p.Push(10); p.Push(20); p.Push(30);
        Verificar("Push(10), Push(20), Push(30): Cantidad = 3 y top = 2", p.Cantidad == 3 && p.Top == 2);
        Verificar("Con 3 de 3 elementos: IsFull() = true", p.IsFull());
        Verificar("Push en pila llena lanza desbordamiento (overflow)", Lanza<InvalidOperationException>(() => p.Push(40)));
        Verificar("Peek() devuelve 30 y no lo elimina (Cantidad sigue en 3)", p.Peek() == 30 && p.Cantidad == 3);
        Verificar("Pop() respeta el orden LIFO: 30, 20, 10", p.Pop() == 30 && p.Pop() == 20 && p.Pop() == 10);
        Verificar("Después de sacar todo: IsEmpty() = true y top = -1", p.IsEmpty() && p.Top == -1);
        Verificar("Pop en pila vacía lanza subdesbordamiento (underflow)", Lanza<InvalidOperationException>(() => p.Pop()));
        Verificar("Peek en pila vacía lanza subdesbordamiento (underflow)", Lanza<InvalidOperationException>(() => p.Peek()));

        p.Push(1); p.Push(2); p.Push(3); p.Pop(); p.Push(4);
        Verificar("Reutiliza la posición liberada: Pop y Push en pila llena (cima = 4)", p.Peek() == 4 && p.IsFull());

        p.Vaciar();
        Verificar("Vaciar(): la pila queda vacía (top = -1)", p.IsEmpty() && p.Top == -1);

        var unica = new PilaEstatica<int>(1);
        unica.Push(7);
        Verificar("Capacidad 1: un Push la llena y un Pop la vacía", unica.IsFull() && unica.Pop() == 7 && unica.IsEmpty());

        var textos = new PilaEstatica<string>(2);
        textos.Push("A"); textos.Push("B");
        Verificar("Pila genérica con string: Pop() devuelve \"B\" y luego \"A\"", textos.Pop() == "B" && textos.Pop() == "A");

        Verificar("Capacidad 0 lanza ArgumentException", Lanza<ArgumentException>(() => new PilaEstatica<int>(0)));

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
        _fuenteIndice.Dispose();
        _fuentePuntero.Dispose();
        _pincel.Dispose();
        base.OnFormClosed(e);
    }
}