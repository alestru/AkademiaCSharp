using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    public class TestMatematyczny : Test
    {
        public TestMatematyczny()
        {
            this.NazwaTestu = "Test Matematyczny";
            this.ListaPytan = this.GenerujListePytan();
        }

        private List<IPytanie> GenerujListePytan()
        {
            return new List<IPytanie>
            {
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Punkt przecięcia się wszystkich trzech wysokości danego trójkąta to:",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Trójcentrum", false, "Pyt1"),
                        new Odpowiedz("Ortocentrum", true, "Pyt1"),
                        new Odpowiedz("Epicentrum", false, "Pyt1")
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Liczba pierwsza: 2^(13466917)-1, składa się z?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("2 053 946 cyfr", false, "Pyt2"),
                        new Odpowiedz("3 053 946 cyfr", false, "Pyt2"), 
                        new Odpowiedz("4 053 946 cyfr", true, "Pyt2")
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Liczba Pi, to: ",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("3,14157", false, "Pyt3"),
                        new Odpowiedz("3,14158", false, "Pyt3"), 
                        new Odpowiedz("3,14159", true, "Pyt3")
                    }
                },
                new PytanieWielokrotnegoWyboru()
                {
                    Pytanie = "Gdzie i kiedy wynaleziono symbol zera?",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("3 wiek naszej ery", false),
                        new Odpowiedz("Indie", true),
                        new Odpowiedz("5 wiek naszej ery", true), 
                        new Odpowiedz("Rzym, 7 wiek naszej ery", false),
                        new Odpowiedz("Grecja", false)
                    }
                },
                new PytanieJednokrotnegoWyboru()
                {
                    Pytanie = "Ludolfina, to:",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Nazwa hormonu", false, "Pyt5"),
                        new Odpowiedz("Nazwa dawnej miary", false, "Pyt5"), 
                        new Odpowiedz("Inna nazwa liczby Pi", true, "Pyt5")
                    }
                },
                new PytanieWielokrotnegoWyboru()
                {
                    Pytanie = "Piramida Cheopsa: ",
                    Odpowiedzi = new List<Odpowiedz>
                    {
                        new Odpowiedz("Jest największym na świecie ostrosłupem prawidłowym czworokątnym", true),
                        new Odpowiedz("Ma 146 metrów wysokości", true), 
                        new Odpowiedz("Jest jednym z ośmiu cudów świata", false)
                    }
                }
            };

        }
    }
}
