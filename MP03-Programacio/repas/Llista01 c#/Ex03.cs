namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Entra dos numeros:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == 0 || n2 == 0) throw new Exception("ERROR HI HA UN 0");
            else Console.WriteLine(n1 % n2 == 0 || n2 % n1 == 0? "Son divisors" : "No son divisors") ;
        }
    }
}