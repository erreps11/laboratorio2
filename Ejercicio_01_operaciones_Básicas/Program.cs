// Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

double numero1, numero2;

Console.Write("ingresa el primer numero: ");
while(!double.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("Número no válido. Ingrese un número válido");
}

Console.Write("ingresa el primer numero: ");
while (!double.TryParse(Console.ReadLine(), out numero2))
{
    Console.Write("Número no válido. Ingrese un número válido");
}

Console.WriteLine($"Suma: {numero1 + numero2}");
Console.WriteLine($"Resta: {numero1 - numero2}");
Console.WriteLine($"Producto: {numero1 * numero2}");

// Para la division; verificar que el divisor sea diferente de cero:

if (numero2 != 0)
{

    Console.WriteLine($"División: {numero1 / numero2 }");
}
else
{
    Console.WriteLine("No se puede dividir entre cero. ");
}
