using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("hello");
            string fileel = @"C:\Users\user\Documents\emelt\e_digkultfor_25okt_fl\Forras\3_Sebesseg\ut.txt";
            List<List<string>> hatarok = new List<List<string>>();
            //Ezzel adok hozzá fájlt
            using (StreamReader bemenet = new StreamReader(fileel))
            {   //Számá alakitjuk az első sort és hozzá adjuk  a hosszhoz
                int hossz = int.Parse(bemenet.ReadLine().Trim());
                string sor;
                while ((sor = bemenet.ReadLine()) != null)
                {
                    string[] reszek = sor.Trim().Split(' ');
                    reszek[0] = int.Parse(reszek[0]).ToString();
                    hatarok.Add(new List<string>(reszek));
                }
                for (int i = 1; i < hatarok.Count; i++)
                {
                    if (hatarok[i][1][0] == 'V')
                    {
                        Console.WriteLine(string.Join(" ", hatarok[i][1]));
                    }
                }
                /*if i[1][0]=="v":
                print(i[1])*/
            }
            
        }
    }
}
