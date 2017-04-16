using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            Console.WriteLine("Learn your squares an cubes!");
            while (play)
            {
                Console.Write("Enter and integer: \t");

                string _upTo = Console.ReadLine();
                int upTo = Convert.ToInt16(_upTo), i;
                char pad = ' ';

                Console.WriteLine("\nNumber\tSquared\tCubed ");
                Console.WriteLine("======\t======\t======");
                for (i = 1; i < upTo + 1; i++)
                {
                    string
                        numStr = Convert.ToString(i).PadRight(6, pad),
                        square = Convert.ToString(Math.Pow(i, 2)).PadRight(6, pad),
                        cube = Convert.ToString(Math.Pow(i, 3)).PadRight(6, pad);

                    Console.WriteLine("{0}\t{1}\t{2}", numStr, square, cube);
                }
                Console.Write("\nWould you like to continue? y/n\t");
                play = Console.ReadLine()[0] == 'y';
            }

            Console.Write("\nBye...(Press Enter to exit)");
            Console.ReadLine();
        }

    }
}

