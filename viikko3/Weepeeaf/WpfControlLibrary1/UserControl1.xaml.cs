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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }



        private void nappula_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double km = Convert.ToInt16(kilometrinopeus.Text);
                double time = Convert.ToInt16(aika.Text);
                double tulos = km / time;
                vastaus.Text = tulos.ToString("F2");
            }
            catch (Exception)
            {
            
            }

        }

        public int Laskuri
        {
            get ;
            set;

        }

    }
}
