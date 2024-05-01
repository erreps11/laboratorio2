// Pide el radio de un círculo al usuario y calcula su área:
Console.Write("Ingresa el radio del círculo: ");
double radio;

while (!double.TryParse(Console.ReadLine(), out radio) || radio < 0)
{
    Console.WriteLine("Por favor, ingresa un número válido para el radio.");
}


double area = Math.PI * radio * radio; // Area = πr²
Console.WriteLine($"El área del círculo con radio {radio} es: {area:N2}");
