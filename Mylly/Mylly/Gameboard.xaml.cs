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
    /// Interaction logic for Gameboard.xaml
    /// </summary>
    public partial class Gameboard : UserControl
    {


        public Gameboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lisää pelikentän ympyröitä klikattaessa nappulan kyseisen ympyrän päälle.
        /// </summary>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LisaaNappula(sender as CheckBox);
   
        }

        /// <summary>
        /// Luo uuden nappulan pelikentälle klikatun ympyrän päälle.
        /// </summary>
        private void LisaaNappula(CheckBox checkBox)
        {
            Nappula nappula = new Nappula();
         //   checkBox.GetValue(Grid.ColumnProperty);
            nappula.SetValue(Grid.ColumnProperty, checkBox.GetValue(Grid.ColumnProperty));
            nappula.SetValue(Grid.RowProperty, checkBox.GetValue(Grid.RowProperty));
            ruudukko.Children.Add(nappula);
            
           
        }


        /// <summary>
        /// Poistaa valitun nappulan.
        /// </summary>
        public void Poista() {

                var lista = ruudukko.Children.OfType<Nappula>();

                Nappula nappi = null;

                foreach (var item in lista)
                {
                   
                    if (item.pelinappula.IsChecked == true) {
                        nappi = item;
                    }
                }

                ruudukko.Children.Remove(nappi);
                

        }

        /// <summary>
        /// Poistetaan vanhat nappulat että voidaan aloittaa uusi peli.
        /// </summary>
        public void UusiPeli() {
            var lista = ruudukko.Children.OfType<Nappula>().ToList();
            foreach(var item in lista){
                // ruudukko.Children.Remove(item);
            }
            varitin(Brushes.Pink);


        }



        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }

        public void varitin(Brush suti) {
            
            var lista2 = ruudukko.Children.OfType<Nappula>().ToList();
            foreach (var item in lista2)
            {
                
                Height = 111111;
                Background = Brushes.Pink;
                //  ruudukko.Children.
                MessageBox.Show("Hello, world!");
            }
            
        

        }


        
      
       }

   }
