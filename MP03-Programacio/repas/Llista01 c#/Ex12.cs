namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radi; double r;
            bool sortir = false;
            do
            {
                Console.WriteLine("1. Calcular la longitud d'una circumferència.");
                Console.WriteLine("2. Calcular l'àrea d'un cercle.");
                Console.WriteLine("3. Calcular el volum d'una esfera.");
                Console.WriteLine("4. Sortir.");

                int opcio = Convert.ToInt32(Console.ReadLine());

                switch (opcio)
                {
                    case 1:
                        Console.Write("Introdueix el radi: ");
                        radi = Convert.ToDouble(Console.ReadLine());
                        r = 2 * Math.PI * radi;
                        Console.WriteLine("La longitud de la circumferencia es: " + r);
                        break;

                    case 2:
                        Console.Write("Introdueix el radi: ");
                        radi = Convert.ToDouble(Console.ReadLine());
                        r = Math.PI * radi * radi;
                        Console.WriteLine("L'area del cercle es: " + r);
                        break;

                    case 3:
                        Console.Write("Introdueix el radi: ");
                        radi = Convert.ToDouble(Console.ReadLine());
                        r = (4.0 / 3.0) * Math.PI * radi * radi * radi;
                        Console.WriteLine("El volum de l'esfera es: " + r);
                        break;

                    case 4:
                        sortir = true;
                        break;

                    default:
                        Console.WriteLine("Opció no vàlida. Torna a intentar.");
                        break;
                }
            } while (!sortir);
        }
    }
}