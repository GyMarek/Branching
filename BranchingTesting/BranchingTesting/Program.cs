using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheer();
            Future("Gemini");
            Console.ReadLine();
        }

        public static void Cheer()
        {
            Console.WriteLine("Kriptonájt");
        }

        public static void Future(string horoscope)
        {
            Console.WriteLine(horoscope);
        }

        public static void Greet()
        {
            Console.WriteLine("Reka");
        }

        public static void Count()
        {
            Console.WriteLine("33");
        }
    }
}
