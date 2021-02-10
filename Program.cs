using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sorok = File.ReadAllLines("fuvar.csv");
            List<Fuvar> fuvarok = new List<Fuvar>();
            for (int i = 1; i < sorok.Length; i++)
            {
                fuvarok.Add(new Fuvar(sorok[i]));
            }

            Console.WriteLine("3.feladat: " +fuvarok.Count + " fuvar");


            int db = 0;
            double fiz = 0;
            for (int i = 0; i < fuvarok.Count; i++)
            {
                if(fuvarok.ElementAt(i).ID == 6185)
                {
                    db++;
                    fiz += fuvarok.ElementAt(i).Vitel;
                    fiz += fuvarok.ElementAt(i).Borr;
                }
            }

            Console.WriteLine($"4 feladat: {db} fuvar alatt: {fiz:N3}");


            Dictionary<string, int> fizetesimodok = new Dictionary<string, int>();
            foreach (Fuvar fuvar1 in fuvarok)
            {
                if(fizetesimodok.ContainsKey(fuvar1.Fizm))
                {
                    fizetesimodok[fuvar1.Fizm]++;
                }
                else
                {
                    fizetesimodok.Add(fuvar1.Fizm, 1);
                }

              

            }
            Console.WriteLine("5. feladat:");
            foreach (KeyValuePair<string, int> item in fizetesimodok)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} fuvar");
            }

            double km = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                
                km += (fuvar.Megtett)/1.6;
                
            }

            Console.WriteLine($"6. feladat: {km:N2}km");
            Console.ReadKey();
        }
    }
}
