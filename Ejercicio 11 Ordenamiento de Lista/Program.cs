// Ordena una lista de números ingresados por el usuario de menor a mayor. 

List<int> numeros = new List<int>();

Console.WriteLine("Ingresa números para ordenar y escribe 'fin' para terminar:");

while (true)
{
    Console.Write("Ingresa un número: ");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "fin")
    {
        break;
    }

    if (int.TryParse(entrada, out int numero))
    {
        numeros.Add(numero);
    }
    else
    {
        Console.WriteLine("Por favor, ingresa un número válido o 'fin' para terminar.");
    }
}

numeros.Sort();
Console.WriteLine("Números ordenados de menor a mayor:");
foreach (int num in numeros)
{
    Console.WriteLine(num);
}


