namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(n1 + " ");
                int aux = n1;
                n1 = n2;
                n2 = aux + n2;
            }

            Console.WriteLine();
        }
    }
}