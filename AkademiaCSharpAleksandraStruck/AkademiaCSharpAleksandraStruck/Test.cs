using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    public class Test
    {
        public List<IPytanie> ListaPytan = new List<IPytanie>();

        public string NazwaTestu { get; set; }

        public string Wynik
        {
            get
            {
                return string.Format("{0}/{1}.", this.ObliczWynik(), this.ListaPytan.Count);
            }
        }

        private int ObliczWynik()
        {
            int wynik = 0;

            foreach (IPytanie pytanie in ListaPytan)
            {
                if (pytanie.Sprawdz())
                {
                    wynik++;
                }
            }

            return wynik;
        }
    }
}
