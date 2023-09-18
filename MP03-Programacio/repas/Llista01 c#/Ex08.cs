namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            n++;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < 11; j++)
                Console.WriteLine($"{i} X {j} = {i*j}");
            }
        }
    }
}