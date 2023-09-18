namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preu, pagament,n;
            Console.WriteLine("Quin es el canvi");
            preu = double.Parse(Console.ReadLine());
            pagament = double.Parse(Console.ReadLine());
            if (preu > pagament) Console.WriteLine("Si no hi haguès canvi no es pagués amb prou diners, cal informar d'aquest fet.");
            else
            {
                n = pagament - preu;
                Console.WriteLine($"{n / 2:0} monedes de 2 euros");
                n = n % 2;
                Console.WriteLine($"{n / 1:0} monedes de 1 euro");
                n = n % 1;
                Console.WriteLine($"{n / 0.5:0} monedes de 50 centims");
                n = n % 0.5;
                Console.WriteLine($"{n / 0.2:0} monedes de 20 centims");
                n = n % 0.2;
                Console.WriteLine($"{n / 0.1:0} monedes de 10 centims");
                n = n % 0.1;
                Console.WriteLine($"{n / 0.05:0} monedes de 5 centims");
                n = n % 0.05;
                Console.WriteLine($"{n / 0.02:0} monedes de 2 centims");
                n = n % 0.02;
                Console.WriteLine($"{n / 0.01:0} monedes de 1 centim");
                n = n % 0.01;
            }
        }
    }
}