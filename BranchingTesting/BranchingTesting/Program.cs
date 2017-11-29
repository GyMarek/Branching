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
            Future("Ox", "June");
            Cheer("Lovári", "Kriptonájt");
            Future("Ox", "June");
            Count(3,3);
            Greet("Hi", "Reka");
            Console.ReadLine();
        }

        public static void Cheer(string className, string classNameTrue)
        {
            Console.WriteLine($"Your class is {classNameTrue} or {className}?");
        }

        public static void Future(string chineseHoroscope, string month)
        {
            Console.WriteLine(chineseHoroscope, month);
        }

        public static void Greet(string greet, string name)
        {
            Console.WriteLine($"{greet} {name}!");
        }

        public static void Count(int month, int year)
        {
            Console.WriteLine(month);
            Console.WriteLine(year);
        }
    }
}
