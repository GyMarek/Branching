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
            Future("Ox");
            Cheer("Kriptonájt");
            Count(33);
            Greet("Reka");
            Console.ReadLine();
        }

        public static void Cheer(string className)
        {
            Console.WriteLine(className);
        }

        public static void Future(string chineseHoroscope)
        {
            Console.WriteLine(chineseHoroscope);
        }

        public static void Greet(string name)
        {
            Console.WriteLine(name);
        }

        public static void Count(int age)
        {
            Console.WriteLine(age);
        }
    }
}
