using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = "1113122113";

            string newChaine = "";

            for (int j = 0; j < 40; ++j)
            {
                for (int i = 0; i < chaine.Length; ++i)
                {
                    newChaine += LookAndSay(chaine[i], chaine, ref i);
                }

                chaine = newChaine;
                newChaine = "";

            }
            
            
            Console.WriteLine(chaine.Length);
        }

        private static string LookAndSay(char chara, string chaine, ref int i)
        {
            int numberOfOccurence = 0;
            while (chaine[i] == chara)
            {
                ++numberOfOccurence;

                if (i + 1 < chaine.Length)
                    ++i;
                else
                    return numberOfOccurence.ToString() + chara;

            }

            --i;
            return numberOfOccurence.ToString() + chara;

            
        }
    }
}
