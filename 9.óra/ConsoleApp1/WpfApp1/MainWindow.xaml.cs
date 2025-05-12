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
using ConsoleApp1;

namespace WpfApp1 
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Metodusok met = new Metodusok();

            fajl_tartalma.ItemsSource = met.Fajlbol_olvasas("autok.txt");
            ar_atlag.Text = met.atlag_szamitas().ToString();
        }
    }
}
