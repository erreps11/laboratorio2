// Verifica si un número ingresado por el usuario es primo o no. 

Console.Write("ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

if (EsPrimo(numero))
{
    Console.WriteLine($"{numero} es un número primo.");
}
else
{
    Console.WriteLine($"{numero} no es un número primo.");
}

static bool EsPrimo(int n)
{
    if (n < 2)
    {
        return false;
    }

    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}


