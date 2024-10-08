using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur longt hoppade Elin, mätt i meter");
            string Elin = Console.ReadLine();
            Console.WriteLine("hur longt hoppade Alma, mätt i meter");
            string alma = Console.ReadLine();
            int A = int.Parse(Elin);
            int B = int.Parse(alma);
            int skillnad = A - B;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma");






        }

    }

}