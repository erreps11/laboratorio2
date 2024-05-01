// Crea una función que calcule la factorial de un número. 

Console.Write("Ingrese un número para calcular su factorial: ");
int numero = int.Parse(Console.ReadLine());
long factorial = Factorial_Iterativo(numero);
Console.WriteLine($"El factorial del {numero} es: {factorial}");

static long Factorial_Iterativo(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("no se puede calcular el factorial de numeros negativos");
    }

    long resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;   
}


