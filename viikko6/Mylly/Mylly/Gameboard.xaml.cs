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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LisaaNappula(sender as CheckBox);
            //            Handle(sender as CheckBox);
        }

        private void LisaaNappula(CheckBox checkBox)
        {
            Nappula nappula = new Nappula();
            checkBox.GetValue(Grid.ColumnProperty);
            nappula.SetValue(Grid.ColumnProperty, checkBox.GetValue(Grid.ColumnProperty));
            ruudukko.Children.Add(nappula);
          //  MessageBox.Show("jee");
            
        }


        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }

      
        }

    }
