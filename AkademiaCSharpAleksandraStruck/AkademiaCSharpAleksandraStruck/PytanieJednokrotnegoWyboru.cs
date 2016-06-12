using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    public class PytanieJednokrotnegoWyboru : IPytanie
    {
        public string Pytanie { get; set; }

        public List<Odpowiedz> Odpowiedzi { get; set; }

        public bool Sprawdz()
        {
            return Odpowiedzi.FirstOrDefault(o => o.CzyPoprawna).CzyZaznaczone;
        }
    }
}
