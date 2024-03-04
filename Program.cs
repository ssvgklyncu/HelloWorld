using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("sayı tahmin oyunu:");
            
            Console.WriteLine("aklınızdan sayı tutunuz:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tuttuğunuz sayı:");
            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
