using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kototehtävät
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[40];
            //int[] omarivi = new int[40];
            int mennyt = 0, voitot = 0;
            int i, vars = 0, lisa = 0, arvottu;
            Random rnd = new Random();
            int[] vl = new int[5]; // [0] 7 oikein, [1] 6+1

            // syötä tänne oma rivi
            Console.WriteLine("Anna 7 varsinaista numeroa: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna 2 lisänumeroa: ");
            int num8 = int.Parse(Console.ReadLine());
            int num9 = int.Parse(Console.ReadLine());

            int[] omarivi = new int[40];
            omarivi[num1] = 1;
            omarivi[num2] = 1;
            omarivi[num3] = 1;
            omarivi[num4] = 1;
            omarivi[num5] = 1;
            omarivi[num6] = 1;
            omarivi[num7] = 1;
            omarivi[num8] = 1;
            omarivi[num9] = 1;


            do
            {
                // lisää mennyt muuttujaan loton hinta eli 1€ per kierros eli 1€ per viikko
                mennyt++;

                // joka kierroksen aluksi alusta lottorivi
                for (i = 1; i < lotto.Length; i++)
                {
                    lotto[i] = 0;
                }

                // arvo 7 varsinaista numeroa eli merkkaa aina lottotaulukkoon 1
                for (i = 1; i <= 7; i++)
                {
                    arvottu = rnd.Next(1, 40);

                    if (lotto[arvottu] == 0) // ei oltu vielä arvottu
                    {
                        lotto[arvottu] = 1;
                    }
                    else
                    {
                        i--;
                    }
                }

                // arvo 2 lisänumeroa eli merkkaa lottotaulukkoon 2 (muista tarkistus molemmissa)
                for (i = 1; i <= 2; i++)
                {
                    arvottu = rnd.Next(1, 40);

                    if (lotto[arvottu] == 0) // ei oltu vielä arvottu
                    {
                        lotto[arvottu] = 2;
                    }
                    else
                    {
                        i--;
                    }
                }

                vars = 0;
                lisa = 0;
                // laske montako oli oikein eli kuinka monta varsinaista ja montako lisänumeroa
                for (i = 1; i < lotto.Length; i++)
                {
                    if (lotto[i] == 1 && omarivi[i] == 1)
                    {
                        vars++;
                    }
                    else if (lotto[i] == 2 && omarivi[i] == 1)
                    {
                        lisa++;
                    }
                }

                // lisää voittosummaan voitettu summa
                // 7    2500000
                // 6+1    50000
                // 6       2000
                // 5         50
                // 4         10
                if (vars == 7)
                {
                    voitot += 2500000;
                    vl[0]++;
                }
                else if (vars == 6 && lisa == 1)
                {
                    voitot += 50000;
                    vl[1]++;
                }
                else if (vars == 6)
                {
                    voitot += 2000;
                    vl[2]++;
                }
                else if (vars == 5)
                {
                    voitot += 50;
                    vl[3]++;
                }
                else if (vars == 4)
                {
                    voitot += 10;
                    vl[4]++;
                }

                if (vars == 7 || mennyt % 1000 == 0)
                {
                    // tulostus
                    Console.Clear();
                    Console.WriteLine("VOITOT EUROINA : {0}", voitot);
                    Console.WriteLine("RAHAA MENNYT EUROINA : {0}", mennyt);
                    Console.WriteLine("KULUNUT AIKA : {0} vuotta {1} vkoa", mennyt / 52, mennyt % 52);
                    Console.WriteLine("VOITTOPROSENTTI : {0:f1} %", ((double)voitot / mennyt) * 100);


                    // kuinka monta kpl eri voittoluokkia on tullut
                    Console.WriteLine("7\t{0}", vl[0]);
                    Console.WriteLine("6 + 1\t{0}", vl[1]);
                    Console.WriteLine("6\t{0}", vl[2]);
                    Console.WriteLine("5\t{0}", vl[3]);
                    Console.WriteLine("4\t{0}", vl[4]);
                }
            } while (vars != 7);


        }
    }
}