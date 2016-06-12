using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    public class PytanieWielokrotnegoWyboru : IPytanie
    {
        public string Pytanie { get; set; }

        public List<Odpowiedz> Odpowiedzi { get; set; }

        public bool Sprawdz()
        {
            foreach (Odpowiedz odpowiedz in Odpowiedzi)
            {
                if (!odpowiedz.CzyPoprawna && odpowiedz.CzyZaznaczone)
                {
                    return false;
                }
                if (odpowiedz.CzyPoprawna && !odpowiedz.CzyZaznaczone)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
