// Crea una lista de los cuadrados de los primeros 10 números naturales. 

List<int> cuadrados = new List<int>();

for (int i = 1; i <= 10; i++)
{
    int cuadrado = i * i;
    cuadrados.Add(cuadrado);
    Console.WriteLine($"El cuadrado de {i} es: {cuadrado}");
}
