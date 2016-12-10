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

namespace laskin
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
        
    

        private void Label_MouseMove_1(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Luodaan raahauksen mukana kuskattava data
                // esimerkin vuoksi useita erilaisia muotoja
                // yleensä kaikki muodot sisältävät saman datan esim. kuvasta voisi olla
                // eri muotoja mutta tässä datana on mitä sattuu
                DataObject data = new DataObject();
                // Omadata, Double ja Label ovat ihan mitä tahansa itsekeksittyjä tunnisteita
                // jos halutaan, että raahattava data toimii muissakin ohjelmissa niin on
                // käytettävä DataFormatsin sisältämiä vaihtoehtoja
                data.SetData("OmaData", ((Label)sender).Content);
                data.SetData("Labeli", sender);
                data.SetData("nimi", Name);
                data.SetData("indeksi", paneeli.Children.IndexOf((Label)sender));
         //       MessageBox.Show(data.ToString());
                // Aloitetaan raahaus
                System.Windows.DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
                //((Label)sender).IsVisible = false;

            //    paneeli.Children.Remove((Label)sender);
            }
            // Initialize the drag & drop operation
 
            
        }

        private void DockPanel_Drop_1(object sender, DragEventArgs e)
        {
            string stringData = "Some string data to store...";
            string dataFormat = DataFormats.Text;
            DataObject dataObject = new DataObject(dataFormat, stringData);
            string dataString = (string)e.Data.GetData("OmaData");
        //    MessageBox.Show(dataString);
            
            //Luodaan uusi numero-Label ylös
            //paneeli.Children.Remove();
            Label numero = new Label();
            laskuruutu.Children.Add(numero);
            numero.Content = dataString;
            numero.FontSize = 24;
            
            //Lasketaan tulos
            int ynnattava = Convert.ToInt32(dataString);
            int tulos1 = Convert.ToInt32(tulos.Content);
            int vastaus = (ynnattava + tulos1);
            string vastaus2 = vastaus.ToString();
            tulos.Content = vastaus2;

            //Poistetaan alalaatikon luku
            int luku13 = (int)e.Data.GetData("indeksi");
          //  int luku13 = Convert.ToInt32();
            paneeli.Children.RemoveAt(luku13);


            





        }

   
    }
}
