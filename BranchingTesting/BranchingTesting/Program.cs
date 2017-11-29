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
            Count(33);
            Cheer();
            Future();
            Greet("Reka");
            Console.ReadLine();
        }

        public static void Cheer()
        {
            Console.WriteLine("Kriptonájt");
        }

        public static void Future()
        {
            Console.WriteLine("Gemini");
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
