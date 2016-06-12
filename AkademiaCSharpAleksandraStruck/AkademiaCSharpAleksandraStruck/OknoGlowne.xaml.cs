using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AkademiaCSharpAleksandraStruck
{
    using System.Collections.ObjectModel;
    using System.Security.RightsManagement;

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
        }
    }
}
