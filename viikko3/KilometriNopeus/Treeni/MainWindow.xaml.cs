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

namespace Treeni
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

        private void Nappi_Click(object sender, RoutedEventArgs e)
        {
            string text = kilometri.GetLineText(0);
            int km = int.Parse(text);
            Console.WriteLine(km);
            try
            {
                
            }
              
            catch (ArgumentOutOfRangeException ex)
            {

            }

        }

        
        
    }
}
