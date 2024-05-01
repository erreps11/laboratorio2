// Calcula la suma de los números pares en un rango especificado por el usuario. 

Console.WriteLine("Ingresa el límite inferior del rango:");
int limiteInferior = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el límite superior del rango:");
int limiteSuperior = int.Parse(Console.ReadLine());

int sumaPares = SumarNumerosPares(limiteInferior, limiteSuperior);
Console.WriteLine($"La suma de los números pares entre {limiteInferior} y {limiteSuperior} es: {sumaPares}");

static int SumarNumerosPares(int inicio, int fin)
{
    int suma = 0;
    if (inicio > fin)
    {
        int temp = inicio;
        inicio = fin;
        fin = temp;
    }

    if (inicio % 2 != 0)
    {
        inicio++;
    }

    for (int i = inicio; i <= fin; i += 2)
    {
        suma += i;
    }

    return suma;
}
