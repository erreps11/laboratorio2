// Pide la base y la altura de un triángulo al usuario y calcula su área.

double _base, altura;

Console.Write("Ingrese la base del triangulo: ");

while (!double.TryParse(Console.ReadLine(), out _base))
{
    Console.Write("Base no válido. Ingrese un número válido:  ");
}

Console.Write("Ingrese la altura del triangulo: ");

while (!double.TryParse(Console.ReadLine(),out altura))
{
    Console.Write("Altura no válida, ingrese un numero valido: ");
}

double area_del_triangulo;
area_del_triangulo = _base * altura / 2;

Console.WriteLine($"El area del triangulo es {area_del_triangulo}");





