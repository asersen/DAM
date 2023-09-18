namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n1, n2;
            Console.WriteLine("Entra dos numeros:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n = n1 - n2;
            if (n < 0) Console.WriteLine(n * -1);
            else Console.WriteLine(n);
        }
    }
}