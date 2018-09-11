using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_factorial_csharp_net
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid number of arguments.\n" +
                                  "Usage: 'factorial.exe [number]");
                System.Environment.Exit(-1);
            } else
            {
                UInt64 number;
                bool success = UInt64.TryParse(args[0], out number);

                if (success)
                {
                    Console.WriteLine(factorial(number));
                } else
                {
                    Console.WriteLine("Failed to convert argument to UInt64.\n" +
                                      "Is it even a number?");
                    System.Environment.Exit(-2);
                }
            }
        }

        static UInt64 factorial(UInt64 number)
        {
            if (number == 0)
            {
                return 1;
            } else
            {
                return factorial(number - 1) * number;
            }
        }
    }
}
