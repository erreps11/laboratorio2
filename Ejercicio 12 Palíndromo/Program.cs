// Verifica si una palabra ingresada por el usuario es un palíndromo.

Console.Write("Ingresa una palabra para verificar si es un palíndromo: ");
string entrada = Console.ReadLine();

if (EsPalindromo(entrada))
{
    Console.WriteLine($"La palabra '{entrada}' es un palíndromo.");
}
else
{
    Console.WriteLine($"La palabra '{entrada}' no es un palíndromo.");
}

static bool EsPalindromo(string palabra)
{
    string limpio = palabra.Replace(" ", "").ToLower();

    char[] arr = limpio.ToCharArray();
    Array.Reverse(arr);
    string invertido = new string(arr);

    return limpio == invertido;
}

