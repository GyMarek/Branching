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
            Future("Gemini");
            Cheer("Kriptonájt");
            Count(3);
            Greet("Reka");
            Console.ReadLine();
        }

        public static void Cheer(string className)
        {
            Console.WriteLine(className);
        }

        public static void Future(string horoscope)
        {
            Console.WriteLine(horoscope);
        }

        public static void Greet(string name)
        {
            Console.WriteLine(name);
        }

        public static void Count(int month)
        {
            Console.WriteLine(month);
        }
    }
}
