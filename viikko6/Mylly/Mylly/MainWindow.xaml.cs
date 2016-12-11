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



namespace Mylly
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

        private void InvokePrint(object sender, RoutedEventArgs e)
        {
            // Create the print dialog object and set options
            PrintDialog pDialog = new PrintDialog();
            pDialog.PageRangeSelection = PageRangeSelection.AllPages;
            pDialog.UserPageRangeEnabled = true;

            // Display the dialog. This returns true if the user presses the Print button.
            Nullable<Boolean> print = pDialog.ShowDialog();
            if (print == true)
            {
                PrintDialog dialog = new PrintDialog();
                if (dialog.ShowDialog() == true)
                {
                    dialog.PrintVisual(pelialue, "gamearea");
                }
         //       XpsDocument xpsDocument = new XpsDocument("C:\\FixedDocumentSequence.xps", System.IO.FileAccess.ReadWrite);
         //      FixedDocumentSequence fixedDocSeq = xpsDocument.GetFixedDocumentSequence();
          //     pDialog.PrintDocument(fixedDocSeq.DocumentPaginator, "Test print job");
            }
        }
        private void Aboutbox(object sender, RoutedEventArgs e)
        {
              AboutBox1 About = new AboutBox1();
              About.Show();

            }

    
        
   

        /// <summary>
        /// Kutsuu nappulanpoistajaa.
        /// </summary>
        public void Deletoi(object sender, RoutedEventArgs e) {
            pelikentta.Poista();

        }

        public void Reset(object sender, RoutedEventArgs e)
        {
            pelikentta.UusiPeli();
            }

        private void Varit(object sender, RoutedEventArgs e)
        {

            Settings asetukset = new Settings();
            asetukset.Show();

        }
        

    
    }
        
     

    }



