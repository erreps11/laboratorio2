// Solicita un número al usuario y determina si es par o impar. 

double numero;

Console.Write("ingrese un número: ");

while(!double.TryParse(Console.ReadLine(), out numero))
{
    Console.Write("Número no válido. Ingrese otro número ");
}

if(numero % 2 == 0)
{
    Console.WriteLine($"el {numero}: es número par.");
}
else
{
    Console.WriteLine($"el {numero}: es un número impar. ");
}


