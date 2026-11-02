namespace ColasEstaticas;

/// <summary>
/// Cola circular con arreglo estático. Los índices <c>front</c> y <c>rear</c> avanzan con
/// aritmética modular: (índice + 1) % capacidad. Al llegar al final del arreglo vuelven a la
/// posición 0, así que reutilizan los espacios liberados. Un contador distingue entre
/// cola vacía y cola llena. Todas las operaciones básicas son O(1).
/// </summary>
public class ColaCircular<T> : ICola<T>
{
    private readonly T[] _elementos;
    private int _front;      // índice del primer elemento
    private int _rear;       // índice del último elemento (-1 al inicio)
    private int _cantidad;   // número de elementos guardados

    /// <exception cref="ArgumentException">Si la capacidad es menor que 1.</exception>
    public ColaCircular(int capacidad)
    {
        if (capacidad < 1)
            throw new ArgumentException("La capacidad debe ser mayor que 0.");

        _elementos = new T[capacidad];
        _front = 0;
        _rear = -1;
        _cantidad = 0;
    }

    public int Capacidad => _elementos.Length;
    public int Cantidad => _cantidad;
    public int Front => _front;
    public int Rear => _rear;

    public bool IsEmpty() => _cantidad == 0;
    public bool IsFull() => _cantidad == _elementos.Length;

    /// <summary>Agrega al final; rear da la vuelta al llegar al último índice. O(1).</summary>
    /// <exception cref="InvalidOperationException">Desbordamiento.</exception>
    public void Enqueue(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException("Desbordamiento (overflow): la cola circular está llena.");

        _rear = (_rear + 1) % _elementos.Length;   // avance circular
        _elementos[_rear] = elemento;
        _cantidad++;
    }

    /// <summary>Saca el elemento del frente; front da la vuelta al llegar al último índice. O(1).</summary>
    /// <exception cref="InvalidOperationException">Subdesbordamiento.</exception>
    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la cola circular está vacía.");

        T elemento = _elementos[_front];
        _elementos[_front] = default!;
        _front = (_front + 1) % _elementos.Length; // avance circular
        _cantidad--;
        return elemento;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la cola circular está vacía.");

        return _elementos[_front];
    }

    public void Vaciar()
    {
        Array.Clear(_elementos);
        _front = 0;
        _rear = -1;
        _cantidad = 0;
    }

    /// <summary>Una posición está ocupada si su distancia circular desde front es menor que la cantidad.</summary>
    public bool EstaOcupada(int indice) =>
        _cantidad > 0 && (indice - _front + _elementos.Length) % _elementos.Length < _cantidad;

    public T ElementoEn(int indice)
    {
        if (indice < 0 || indice >= _elementos.Length)
            throw new ArgumentOutOfRangeException(nameof(indice));

        return _elementos[indice];
    }
}