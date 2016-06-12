using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    public class TestBiologicznoMedyczny : Test
    {
        public TestBiologicznoMedyczny()
        {
            this.NazwaTestu = "Test biologiczno-medyczny";
            this.ListaPytan = this.GenerujListePytan();
        }

        private List<IPytanie> GenerujListePytan()
        {
            return new List<IPytanie>
            {
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Ile przeciętnie trwa mrugnięcie oka?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("0.3 sek", true, "Pyt1"),
                        new Odpowiedz("0.8 sek", false, "Pyt1"),
                        new Odpowiedz("1.2 sek", false, "Pyt1")
                    }
                },
                new PytanieWielokrotnegoWyboru()
                {
                    Pytanie = "Co pomaga na ból głowy?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Zjedzenie cytryny", false),
                        new Odpowiedz("Zjedzenie 20 kwaśnych wiśni", true), 
                        new Odpowiedz("Zjedzenie dwóch słodkich bananaów", false), 
                        new Odpowiedz("Zażycie tabletki przeciwbólowej", true)
                    }
                },
                new PytanieWielokrotnegoWyboru()
                {
                    Pytanie = "Ile funkcji pełni ludzka wątroba?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Mniej niż 100", false),
                        new Odpowiedz("Około 300", false),
                        new Odpowiedz("Ponad 500", true), 
                        new Odpowiedz("Mniej niż 1000", true)
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Które płuco u czowieka jest większe?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Oba są równe", false, "Pyt4"),
                        new Odpowiedz("Lewe", false, "Pyt4"),
                        new Odpowiedz("Prawe", true, "Pyt4")
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Dzieci urodzone w jakim miesiącu są przeciętnie najcięższe?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("W styczniu", false, "Pyt5"),
                        new Odpowiedz("W maju", true, "Pyt5"), 
                        new Odpowiedz("We wrześniu", false, "Pyt5"),
                        new Odpowiedz("W grudniu", false, "Pyt5")
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Ile przeciętnie trwa ziewnięcie?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("2 sek", false, "Pyt6"),
                        new Odpowiedz("6 sek", true, "Pyt6"), 
                        new Odpowiedz("9 sek", false, "Pyt6"),
                        new Odpowiedz("11 sek", false, "Pyt6")
                    }
                }
            };

        }
    }
}
