// Toma un número entero y calcula la suma de sus dígitos. 

Console.Write("Ingresa un número entero: ");
string input = Console.ReadLine();
int numero;

while (!int.TryParse(input, out numero))
{
    Console.WriteLine("Número no valido, ingresa un número entero válido: ");
}

int suma = SumarDigitos(numero);
Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");

static int SumarDigitos(int num)
{
    int suma = 0;
    int valorAbsoluto = Math.Abs(num);  

    while (valorAbsoluto > 0)
    {
        suma += valorAbsoluto % 10;
        valorAbsoluto /= 10;  
    }

    return suma;
}