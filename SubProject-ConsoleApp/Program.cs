using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubProject_ClassLibrary;

namespace SubProject_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 2)
            {
                try
                {
                    Console.WriteLine(SubProjectClass.AddFromStrings(args[0], args[1]));
                }
                catch
                {
                    Console.WriteLine("Could not parse to ints");
                }
            }
        }
    }
}
