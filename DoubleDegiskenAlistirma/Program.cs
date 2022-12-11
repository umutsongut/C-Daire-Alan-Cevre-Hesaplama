using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDegiskenAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {

            double yaricap,alan,cevre,pi;

            pi = 3.14;

            Console.Write("Yarıçap Uzunluğunu Girin: ");
            yaricap = Convert.ToDouble(Console.ReadLine());

            cevre = pi * yaricap * 2;
            Console.WriteLine("Çevre:" + cevre);

            alan = yaricap * yaricap * pi;
            Console.Write("Alan:"+alan);


            Console.ReadLine();

        }
    }
}
