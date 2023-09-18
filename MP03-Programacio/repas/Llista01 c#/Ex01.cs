using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int n, n1;
        bool equal = false;
        Console.WriteLine("QUIN ES EL NUMERO MÉS GRAN");
        Console.Write("Entra el primer numero->");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el segon numero->");
        n1 = Convert.ToInt32(Console.ReadLine());
        if (n1>n) n = n1;
        else if (n1 == n) equal = true;
        Console.Write("Entra el tercer numero->");
        n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 > n)
        {
            n = n1;
            equal = false;
        }
        else if (n1 == n) equal = true;
        Console.Write($"El numero més gran es->{n}");
        if (equal)Console.WriteLine(" i apareix més d'un cop");
    }
}