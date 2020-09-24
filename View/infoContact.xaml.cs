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
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Logique d'interaction pour infoContact.xaml
    /// </summary>
    public partial class infoContact : Window
    {
        public infoContact()
        {
            InitializeComponent();
        }

        private void enregistrerContact(object sender, MouseEventArgs e)
        {

          



        }

        private void RetourMenuContact(object sender, RoutedEventArgs e)
        {


            this.Hide();
            new MainWindow().Show();


        }
    }
}
