using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize notunuzu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());

            double basariNotu = (vize * 0.4) + (final * 0.6);

            if (basariNotu > 60)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else if (basariNotu>=50)
            {
                Console.WriteLine("Şartlı geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }
            Console.ReadKey();
        }
    }
}
