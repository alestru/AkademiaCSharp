using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharpAleksandraStruck
{
    using System.IO;
    using System.Windows;

    internal class DaneWyniku
    {
        public string Wynik { get; set; }

        public string Data { get; set; }

    }

    internal static class OstatnieWyniki
    {
        public static List<DaneWyniku> Wyniki = new List<DaneWyniku>();

        public static void ZapiszWynik(DaneWyniku wynik)
        {
            try
            {
                StreamWriter writer = new StreamWriter("wynik.csv", true);
                if (writer != null)
                {
                    writer.WriteLine(String.Format(@"{0};{1};", wynik.Wynik, wynik.Data));
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystapil wyjatek: {0}", ex.Message));
            }

        }

        public static void WczytajWyniki()
        {
            try
            {
                StreamReader reader = new StreamReader("wynik.csv");
                if (reader != null)
                {
                    while (!reader.EndOfStream)
                    {
                        string linia = reader.ReadLine();
                        string[] podzielone = linia.Split(';');
                        Wyniki.Add(
                            new DaneWyniku
                                {
                                    Wynik = Convert.ToString(podzielone[0]),
                                    Data = Convert.ToString(podzielone[1])
                                });
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystapil wyjatek: {0}", ex.Message));
            }
        }
    }
}
