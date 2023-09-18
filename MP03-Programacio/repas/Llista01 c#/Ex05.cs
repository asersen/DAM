namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,s, m, h, d;
            Console.WriteLine("Pasar segons a dies, hores:minuts:segons");
            Console.Write("Entra els segons->");
            n = Convert.ToInt32(Console.ReadLine());
            d = n / 86400;
            n = n % 86400;
            h = n / 3600;
            n = n % 3600;
            m = n / 60;
            s = n % 60;

            Console.WriteLine($"{d}, {h}:{m}:{s}");


        }
    }
}