// Toma una cadena de texto y muestra su inversión. 

// Usando Array.Reverse()

Console.WriteLine("Usando Array.Reverse()");
Console.Write("Ingresa una cadena de texto: ");
string textoOriginal = Console.ReadLine();
string textoInvertido = InvertirCadena(textoOriginal);

Console.WriteLine($"Cadena invertida: {textoInvertido}");
static string InvertirCadena(string texto)
{
    char[] arregloChar = texto.ToCharArray();
    Array.Reverse(arregloChar);
    return new string(arregloChar);
}
