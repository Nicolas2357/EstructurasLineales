namespace PilaEstatica;

/// <summary>
/// Pila (LIFO: el último en entrar es el primero en salir) implementada con un
/// arreglo estático de tamaño fijo y un índice <c>top</c> que apunta a la cima.
/// No usa colecciones de .NET. Todas las operaciones básicas son O(1).
/// </summary>
/// <typeparam name="T">Tipo de los elementos que guarda la pila.</typeparam>
public class PilaEstatica<T>
{
    private readonly T[] _elementos;   // memoria estática: se reserva una sola vez
    private int _top;                  // índice del elemento en la cima (-1 = pila vacía)

    /// <summary>Crea una pila vacía con la capacidad indicada.</summary>
    /// <exception cref="ArgumentException">Si la capacidad es menor que 1.</exception>
    public PilaEstatica(int capacidad)
    {
        if (capacidad < 1)
            throw new ArgumentException("La capacidad debe ser mayor que 0.");

        _elementos = new T[capacidad];
        _top = -1;
    }

    /// <summary>Tamaño fijo del arreglo.</summary>
    public int Capacidad => _elementos.Length;

    /// <summary>Número de elementos guardados.</summary>
    public int Cantidad => _top + 1;

    /// <summary>Índice de la cima (-1 si la pila está vacía).</summary>
    public int Top => _top;

    /// <summary>Indica si la pila no tiene elementos. O(1).</summary>
    public bool IsEmpty() => _top == -1;

    /// <summary>Indica si ya no hay espacio en el arreglo. O(1).</summary>
    public bool IsFull() => _top == _elementos.Length - 1;

    /// <summary>Agrega un elemento en la cima. O(1).</summary>
    /// <exception cref="InvalidOperationException">Desbordamiento: la pila está llena.</exception>
    public void Push(T elemento)
    {
        if (IsFull())
            throw new InvalidOperationException("Desbordamiento (overflow): la pila está llena.");

        _top++;                        // primero se mueve el índice...
        _elementos[_top] = elemento;   // ...y luego se guarda en la nueva cima
    }

    /// <summary>Saca y devuelve el elemento de la cima. O(1).</summary>
    /// <exception cref="InvalidOperationException">Subdesbordamiento: la pila está vacía.</exception>
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la pila está vacía.");

        T elemento = _elementos[_top];
        _elementos[_top] = default!;   // libera la referencia (útil si T es un tipo por referencia)
        _top--;
        return elemento;
    }

    /// <summary>Devuelve el elemento de la cima sin sacarlo. O(1).</summary>
    /// <exception cref="InvalidOperationException">Subdesbordamiento: la pila está vacía.</exception>
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Subdesbordamiento (underflow): la pila está vacía.");

        return _elementos[_top];
    }

    /// <summary>Elimina todos los elementos. O(n).</summary>
    public void Vaciar()
    {
        for (int i = 0; i <= _top; i++)
            _elementos[i] = default!;

        _top = -1;
    }

    /// <summary>Devuelve el elemento guardado en una posición (solo lectura, para mostrar el arreglo).</summary>
    /// <exception cref="ArgumentOutOfRangeException">Si la posición no tiene elemento.</exception>
    public T ElementoEn(int indice)
    {
        if (indice < 0 || indice > _top)
            throw new ArgumentOutOfRangeException(nameof(indice), "La posición no contiene un elemento.");

        return _elementos[indice];
    }
}