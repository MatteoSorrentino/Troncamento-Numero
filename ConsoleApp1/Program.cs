using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.MaxValue;

            Console.WriteLine(num);

            int num2 = Convert.ToInt16(num);

            Console.WriteLine(num2);

            Console.ReadLine();
        }
    }
}
