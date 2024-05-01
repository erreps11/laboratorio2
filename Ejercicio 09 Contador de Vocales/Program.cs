// Cuenta el número de vocales en una cadena de texto. 

Console.Write("Ingresa una cadena de texto: ");
string texto = Console.ReadLine();
int contadorVocales = ContarVocales(texto);

Console.WriteLine($"Número de vocales en el texto: {contadorVocales}");

static int ContarVocales(string texto)
{
    int contador = 0;
    string vocales = "aeiouAEIOU";  

    foreach (char c in texto)
    {
        if (vocales.Contains(c))
        {
            contador++;
        }
    }

    return contador;
}
