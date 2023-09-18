namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduïu un any: ");
            int any = int.Parse(Console.ReadLine());

            if (EsAnyDeTraspas(any))
            {
                Console.WriteLine($"{any} és un any de traspàs.");
            }
            else
            {
                Console.WriteLine($"{any} no és un any de traspàs.");
            }
        }

        static bool EsAnyDeTraspas(int any)
        {
            if ((any % 4 == 0 && any % 100 != 0) || (any % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}