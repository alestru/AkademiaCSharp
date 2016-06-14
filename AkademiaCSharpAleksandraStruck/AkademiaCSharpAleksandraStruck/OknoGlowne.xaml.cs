using System;
using System.Windows;
using System.Windows.Controls;

namespace AkademiaCSharpAleksandraStruck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class OknoGlowne : Window
    {
        private TestBiologicznoMedyczny TestBioMed;
        private TestMatematyczny TestMat;
        public Test aktualnyTest;

        public OknoGlowne()
        {
            InitializeComponent();
            OstatnieWyniki.WczytajWyniki();
            this.InitBindingBioMed();
            ComboBoxListaTestow.SelectedIndex = 0;
        }

        private void InitBindingBioMed()
        {
            TestBioMed = new TestBiologicznoMedyczny();
            WidokListyPytan.ItemsSource = TestBioMed.ListaPytan;
            WidokOstatnieWyniki.ItemsSource = OstatnieWyniki.Wyniki;
            aktualnyTest = TestBioMed;
        }

        private void InitBindingMat()
        {
            TestMat = new TestMatematyczny();
            WidokListyPytan.ItemsSource = TestMat.ListaPytan;
            WidokOstatnieWyniki.ItemsSource = OstatnieWyniki.Wyniki;
            aktualnyTest = TestMat;
        }

        private void ComboBoxListaTestow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Testy test = (Testy)ComboBoxListaTestow.SelectedItem;
            
            if (test == Testy.Biomedyczny)
            {
                InitBindingBioMed();
            }
            else
            {
                InitBindingMat();
            }
            LabelTest.Content = aktualnyTest.NazwaTestu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabelWynik.Content = aktualnyTest.Wynik;
            DaneWyniku wynik = new DaneWyniku
                                   {
                                       Wynik = aktualnyTest.Wynik,
                                       Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                                   };
            OstatnieWyniki.ZapiszWynik(wynik);
            OstatnieWyniki.WczytajWyniki();
            WidokOstatnieWyniki.ItemsSource = OstatnieWyniki.Wyniki;
        }
    }
}
