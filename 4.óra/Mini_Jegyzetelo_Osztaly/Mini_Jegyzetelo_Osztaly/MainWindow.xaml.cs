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

namespace Mini_Jegyzetelo_Osztaly
{
    public class Jegyzet 
    {
        public string Tartalom { get; set; }

        public void Mentes(string fajlNev)
        {
            File.WriteAllText(fajlNev, Tartalom);
        }

        public string Betolt(string fajlNev)
        {
            return File.ReadAllText(fajlNev).ToString();
        }
    }


    public partial class MainWindow : Window
    {
        Jegyzet jegyzet = new Jegyzet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {
            jegyzet.Tartalom = Input.Text;
            jegyzet.Mentes("notes.txt");
            MessageBox.Show("Le mentetted ");
        }

        private void Betolt(object sender, RoutedEventArgs e)
        {
            Input.Text = jegyzet.Betolt("notes.txt");
            MessageBox.Show("Betölttöted");
        }
    }
}
