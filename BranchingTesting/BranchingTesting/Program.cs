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
            Cheer("Kriptonájt");
            Future();
            Console.ReadLine();
        }

        public static void Cheer(string className)
        {
            Console.WriteLine(className);
        }

        public static void Future()
        {
            Console.WriteLine("Gemini");
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
