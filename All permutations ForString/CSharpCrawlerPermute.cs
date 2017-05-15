using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_permutations_ForString
{
    class CSharpCrawlerPermute
    {
    }

    class Permute
    {
        public static List<string> AllCombos { get; set; }

        private void swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;

            b ^= a;

            a ^= b;
        }

        public void setper(char[] list)
        {
            int x = list.Length - 1;

            go(list, 0, x);
        }

        private void go(char[] list, int k, int m)
        {
            int i;

            if (k == m)

            {

                Console.Write(list);

                Console.WriteLine(" ");

            }
            else
                for (i = k; i <= m; i++)
                {

                    swap(ref list[k], ref list[i]);

                    go(list, k + 1, m);

                    swap(ref list[k], ref list[i]);
                }
        }

    }


}
