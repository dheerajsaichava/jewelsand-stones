using System;
using System.Linq;
namespace jewelsand_stones
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = { 1, 3, 3, 2, 2, 2, 2, 2 };
            int[] y = {1, 3 };

            Console.Write(numjewelsinstones(x, y));
        }
        public static int numjewelsinstones(int[] J, int[] S)
        {
            int count = 0;
            for (int i = 0; i < J.Length; i++)
            {

                for (int j = 0; j < S.Length; j++)
                {
                    if (J[i] == S[j])
                    {
                        count = count + 1;
                    }

                }
                // returning the count of  stones you have whcih are also jewels.

            }
            return count;


        }
        }
    }


