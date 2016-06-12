using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    public class Odpowiedz
    {
        public bool CzyPoprawna;

        public string TrescOdpowiedzi { get; set; }
        public bool CzyZaznaczone { get; set; }
        public string IdPytania { get; set; }

        public Odpowiedz(string tresc, bool czyPoprawna, string idPytania)
        {
            CzyPoprawna = czyPoprawna;
            TrescOdpowiedzi = tresc;
            IdPytania = idPytania;
        }

        public Odpowiedz(string tresc, bool czyPoprawna)
        {
            CzyPoprawna = czyPoprawna;
            TrescOdpowiedzi = tresc;
        }
    }
}
