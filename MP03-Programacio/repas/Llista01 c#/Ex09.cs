using System.Diagnostics.CodeAnalysis;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un numero");
            int r;
            int n = Convert.ToInt32(Console.ReadLine());
            n++;
            for (int i = 1; i < n; i++)
            {
                r = 0;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    if (j < i) { Console.Write(" + "); }
                    r += j;
                }
                Console.WriteLine(" = "+ r);

            }
        }

        
    }
}