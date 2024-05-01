// Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

Console.Write("Ingresa el número del cual quieres la tabla de multiplicar: ");
int numero;

while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Por favor, ingresa un número válido."); 
}

Console.WriteLine($"Tabla de multiplicar del {numero}:");

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}