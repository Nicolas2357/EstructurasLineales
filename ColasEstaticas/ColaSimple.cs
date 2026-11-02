namespace ColasEstaticas;

/// <summary>
/// Operaciones comunes de una cola (FIFO: el primero en entrar es el primero en salir).
/// La implementan la cola simple y la cola circular.
/// </summary>
public interface ICola<T>
{
    int Capacidad { get; }
    int Cantidad { get; }
    int Front { get; }
    int Rear { get; }
    bool IsEmpty();
    bool IsFull();
    void Enqueue(T elemento);
    T Dequeue();
    T Peek();
    void Vaciar();
    bool EstaOcupada(int indice);
    T ElementoEn(int indice);
}

/// <summary>
/// Cola simple (lineal) con arreglo estático. <c>front</c> apunta al primer elemento y
/// <c>rear</c> al último. Al desencolar, <c>front</c> avanza y las posiciones que quedan
/// atrás ya no se reutilizan, por eso puede llenarse aunque tenga espacios libres
/// ("falso desbordamiento"). Todas las operaciones básicas son O(1).
/// </summary>
public class ColaSimple<T> : ICola<T>
{
    private readonly T[] _elementos;
    private int _front;   // índice del primer elemento
    private int _rear;    // índice del último elemento (-1 = ninguno)

    /// <exception cref="ArgumentException">Si la capacidad es menor que 1.</exception>
    public ColaSimple(int capacidad)
    {
        if (capacidad < 1)
            throw new ArgumentException("La capacidad debe ser mayor que 0.");

        _elementos = new T[capacidad];
        _front = 0;
        _rear = -1;
    }

    public int Capacidad => _elementos.Length;
    public int Cantidad => _rear - _front + 1;
    public int Front => _front;
    public int Rear => _rear;

    /// <summary>True si la cola está "llena" pero hay posiciones libres antes de front.</summary>
    public bool FalsoDesbordamiento => IsFull() && _front > 0;

    public bool IsEmpty() => _front > _rear;

    /// <summary>La cola simple se considera llena cuando rear llega al final del arreglo.</summary>
    public bool IsFull() => _rear == _elementos.Length - 1;

    /// <summary>Agrega al final (rear). O(1).</summary>
    /// <exception cref="InvalidOperationException">Desbordamiento.</exception>
    public void Enqueue(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException(_front > 0
                ? $"Desbordamiento: rear llegó al final (falso desbordamiento, hay {_front} espacio(s) libre(s) al inicio)."
                : "Desbordamiento (overflow): la cola está llena.");

        _rear++;
        _elementos[_rear] = elemento;
    }

    /// <summary>Saca y devuelve el elemento del frente. O(1).</summary>
    /// <exception cref="InvalidOperationException">Subdesbordamiento.</exception>
    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la cola está vacía.");

        T elemento = _elementos[_front];
        _elementos[_front] = default!;
        _front++;

        if (_front > _rear)      // quedó vacía: se reinician los índices
        {
            _front = 0;
            _rear = -1;
        }
        return elemento;
    }

    /// <summary>Devuelve el elemento del frente sin sacarlo. O(1).</summary>
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la cola está vacía.");

        return _elementos[_front];
    }

    public void Vaciar()
    {
        Array.Clear(_elementos);
        _front = 0;
        _rear = -1;
    }

    public bool EstaOcupada(int indice) => !IsEmpty() && indice >= _front && indice <= _rear;

    public T ElementoEn(int indice)
    {
        if (indice < 0 || indice >= _elementos.Length)
            throw new ArgumentOutOfRangeException(nameof(indice));

        return _elementos[indice];
    }
}