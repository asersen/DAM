using System.Collections.Concurrent;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            string str;
            Console.WriteLine("Entreu una hora del dia amb el següent format hh:mm:ss");
            str = Console.ReadLine();
            string[] parts = str.Split(':');
            h = int.Parse(parts[0]);
            m = int.Parse(parts[1]);
            s = int.Parse(parts[2]);

            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59) throw new Exception("Error format de hora incorrecte");
            s++;
            if (s >= 60)
            {
                s = 0;
                m++;
                if (m >= 60)
                {
                    m = 0;
                    h++;
                }
            }
            Console.WriteLine($"{h:00}:{m:00}:{s:00}");
        }
    }
}