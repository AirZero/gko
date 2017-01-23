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

namespace Mylly
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Avaa värikartan.
        /// </summary>
        private void Varit(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog varikartta = new System.Windows.Forms.ColorDialog();
            varikartta.ShowDialog();
            
            if (sender.ToString() == vaihdaLauta.ToString())
            {
                esikatseluNappulat.Fill = new SolidColorBrush(Color.FromRgb(varikartta.Color.R, varikartta.Color.G, varikartta.Color.B));
            }  
             //   MessageBox.Show(varikartta.Color.R.ToString() + "," + varikartta.Color.R.ToString() + "," + varikartta.Color.B.ToString());  
            //Messagebox.Show(sender.ToString());
           
      //      if (sender == vaihdaNappula) {
                esikatseluLauta.Fill = new SolidColorBrush(Color.FromRgb(varikartta.Color.R, varikartta.Color.G, varikartta.Color.B));
      //      }
            

        }

  


        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }

        /// <summary>
        /// Sulkee Settings-ikkunan
        /// </summary>
        private void Sulje(object sender, ExecutedRoutedEventArgs e)
        {
        this.Close();
        }


        /// <summary>
        /// Tallentaa valitut väriarvot.
        /// </summary>
        private void Tallenna(object sender, ExecutedRoutedEventArgs e)
        {
            //Todo tee valmiiksi
            this.Close();
           // Gameboard.ruudukko.Fill = esikatseluNappulat.Fill;
        }

    }
}
