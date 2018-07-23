using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado
{
    class Program
    {
        public static UInt64[,] aux = new UInt64[101, 101];
        public static int[] seq = new int[101];
        public static int n, k;
        public static UInt64 resp;

        public static string[] line;

        static void Main(string[] args)
        {
            line = Console.ReadLine().Split();
            n = int.Parse(line[0]);
            k = int.Parse(line[1]);
            while (n != 0 && k != 0)
            {
                line = Console.ReadLine().Split();

                for (int i = 1; i <= n; i++)
                {
                    seq[i] = int.Parse(line[i - 1]);
                    aux[1, i] = 1;
                }

                for (int i = 2; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        for (int l = 1; l < j; l++)
                        {
                            if (seq[l] < seq[j])
                            {
                                aux[i, j] += aux[i - 1, l];
                            }
                        }

                    }

                }
                resp = 0;
                for (int i = 1; i <= n; i++)
                {
                    resp += aux[k, i];
                }
                Console.WriteLine(resp);

                Array.Clear(seq, 0, n + 1);
                Array.Clear(aux, 0, aux.Length);

                line = Console.ReadLine().Split();
                n = int.Parse(line[0]);
                k = int.Parse(line[1]);

            }
        }
    }
}
