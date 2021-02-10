using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {
        public int ID { get; set; }
        public string Indulas { get; set; }
        public int Tartam { get; set; }

        public  double Megtett { get; set; }

        public double Vitel { get; set; }
        public double Borr { get; set; }

        public string Fizm { get; set; }

        public Fuvar(string sor)
        {
            String[] s = sor.Split(';');
            this.ID = int.Parse(s[0]);
            this.Indulas = s[1];
            this.Tartam = int.Parse(s[2]);
            this.Megtett = double.Parse(s[3]);
            this.Vitel = double.Parse(s[4]);
            this.Borr = double.Parse(s[5]);
            this.Fizm = s[6];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
