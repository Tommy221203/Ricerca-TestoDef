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

namespace Ricerca_Testo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnricerca_Click(object sender, RoutedEventArgs e)
        {
            bool ricerca;
            string testoiniziale = txttesto.Text;
            string testodacercare = txtricerca.Text;
            ricerca = testoiniziale.Contains(testodacercare);
            if(ricerca==true)
            {
               int posizione1= testoiniziale.IndexOf(testodacercare+1);
               int posizione2 = posizione1 - 1;
            }
        }
    }
}
