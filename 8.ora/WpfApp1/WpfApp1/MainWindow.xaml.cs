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
using System.IO;
using System.Globalization;

namespace WpfApp1
{
    public class KonyvAdatai
    {
        public KonyvAdatai(string cim, string szerzo, int odalszam, bool elolvasa)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.odalszam = odalszam;
            this.elolvasa = elolvasa;
        }

        public string cim {  get; set; }

        public string szerzo { get; set; }

        public int odalszam { get; set; }

        public bool elolvasa { get; set; }
    }


    public partial class MainWindow : Window
    {
        public List<KonyvAdatai> konyek = new List<KonyvAdatai>();

        public string fajl_nev = "konyvek.txt";

        public MainWindow()
        {
            InitializeComponent();


            if (!File.Exists(fajl_nev))
            {
                File.WriteAllText(fajl_nev, "");
            }

            betoltes();
        }

        public void betoltes()
        {
            if(File.ReadAllText(fajl_nev) == "")
            {
                KonyvLista.Visibility = Visibility.Hidden;

                Task.Delay(1000).ContinueWith(task =>
                {
                    MessageBox.Show("Nincs egy könyv se!");
                });
                
                return;
            }

            var fajl_tartalma = File.ReadAllText(fajl_nev).Split(';');

            for (int i = 0; i < fajl_tartalma.Length; i += 4) 
            {
                konyek.Add(new KonyvAdatai(
                    fajl_tartalma[i].ToString(),
                    fajl_tartalma[i + 1].ToString(),
                    int.Parse(fajl_tartalma[i + 2]),
                    bool.Parse(fajl_tartalma[i + 3])
                ));       
            }

            KonyvLista.ItemsSource = konyek;
        }

        public void mentes()
        {
           foreach(var lista_elem in konyek)
           {
                var fajl_elemek = lista_elem.cim.ToString() + ";" 
                    + lista_elem.szerzo.ToString() + ";" 
                    + lista_elem.odalszam.ToString() + ";" 
                    + lista_elem.elolvasa.ToString() + ";";
                
                File.AppendAllText(fajl_nev, fajl_elemek);
           }

            
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            mentes();
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            urlap.Visibility = Visibility.Visible;
        }

        private void urlap_ok_Click(object sender, RoutedEventArgs e)
        {
            if(urlap_bevitel_cim.Text == "")
            {
                MessageBox.Show("Nincs kitöltve a cim!");
                return;
            }

            if (urlap_bevitel_szerzo.Text == "")
            {
                MessageBox.Show("Nincs kitöltve a szerző!");
                return;
            }

            if (urlap_bevitel_oldalSzam.Text == "")
            {
                MessageBox.Show("Nincs kitöltve az oldalszám!");
                return;
            }


            string cim = urlap_bevitel_cim.Text.Trim();
            string szerzo = urlap_bevitel_szerzo.Text.Trim();

            int oldal_szam = int.Parse(urlap_bevitel_oldalSzam.Text.Trim());

            bool elolvasva = urlap_bevitel_elolvasva.IsChecked == true ? true : false;

            konyek.Add(new KonyvAdatai(
                   cim,
                   szerzo,
                   oldal_szam,
                   elolvasva
               ));



            
            mentes();
        }

        private void urlap_bezaras_Click(object sender, RoutedEventArgs e)
        {
            urlap.Visibility = Visibility.Hidden;
            betoltes();
        }
    }
}
