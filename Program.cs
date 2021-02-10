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
            
            Console.ReadKey();
        }
    }
}
