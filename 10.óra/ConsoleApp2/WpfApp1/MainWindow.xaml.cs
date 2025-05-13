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
using ConsoleApp2;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            metodusok metodusok = new metodusok();

            fajl_tartalma.ItemsSource = metodusok.fajlbol_olvasas();

            sorrend_valtas.Content = "Növekvő sorrend";

            atlag.Text = metodusok.atlag_szamitas().ToString();
        }

        private void sorrend_valtas_Click(object sender, RoutedEventArgs e)
        {
            sorrend_valtas.Content = "Csökkenő sorrend";
            metodusok metodusok = new metodusok();

            fajl_tartalma.ItemsSource = metodusok.novekvo_sorrend();
        }
    }
}
