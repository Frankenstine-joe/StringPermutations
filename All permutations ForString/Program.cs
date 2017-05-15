using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_permutations_ForString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C# crawler Website Code

            var x = Stopwatch.StartNew();

            Permute p = new Permute();

            string c = "abcdefghi";

            char[] c2 = c.ToCharArray();

            /*calling the permute*/

            p.setper(c2);

            x.Stop();

            Console.WriteLine(x.Elapsed);

            Console.ReadKey();

            #endregion

            #region Frank Code

            //Console.Write("Enter Digits : ");

            //int Digits = int.Parse(Console.ReadLine());

            //int End = 'a' + Digits;

            //char EndChar = (char)End;

            //Console.WriteLine(EndChar.ToString());

            //Console.WriteLine(End);


            //List<string> Output = new List<string>();

            //for (int i = 'a'; i < EndChar; i++)
            //{
            //    string temp=
            //    Output.Add("");
            //}

            int sum = 1;
            for (int i = 14; i > 0; i--)
            {
                sum = sum * i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
            #endregion
        }




    }
}
