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

namespace gitProva7
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        //commento da githubbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
            InitializeComponent();
        }
<<<<<<< HEAD
        int cosaACAso;

        private void btnSuca_Click(object sender, RoutedEventArgs e)
        {
            int suca;
            txtFiga.Text = "suca";
=======

        private void btnPallona_Click(object sender, RoutedEventArgs e)
        {
            string ciao;
            foreach(int i in Enum.GetValues(typeof(string)))
            {
                ciao = i.ToString();
            }
>>>>>>> Biblioteca
        }
    }
}
