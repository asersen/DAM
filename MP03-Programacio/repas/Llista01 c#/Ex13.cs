namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De minuscula a majuscula");
            char lletra = Console.ReadKey().KeyChar;
            char lletra2 = char.ToUpper(lletra);
            Console.WriteLine();
            Console.WriteLine("La majúscula corresponent és: " + lletra2);

        }
    }
}