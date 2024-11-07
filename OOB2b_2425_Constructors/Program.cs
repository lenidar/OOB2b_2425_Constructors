using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB2b_2425_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            Class2 b = new Class2(55);
            Class2 c = new Class2();

            //a.DisplayA();
            //a.a = 45;
            //a.DisplayA();

            b.DisplayA();

            Console.ReadKey();

        }
    }
}
