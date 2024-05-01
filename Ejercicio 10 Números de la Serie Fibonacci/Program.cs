// Genera los primeros 10 números de la serie Fibonacci

List<int> fibNumbers = Fibonacci(10);
Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
foreach (int number in fibNumbers)
{
    Console.WriteLine(number);
}

static List<int> Fibonacci(int n)
{
    List<int> result = new List<int>();
    int a = 0, b = 1;

    while (result.Count < n)
    {
        result.Add(a);
        int temp = a;
        a = b;
        b = temp + b;
    }

return result;

}