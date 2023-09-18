namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            while (n2 != 0)
            {
                int aux = n2;
                n2 = n1 % n2;
                n1 = aux;
            }

            Console.WriteLine(n1);
        }
    }
}