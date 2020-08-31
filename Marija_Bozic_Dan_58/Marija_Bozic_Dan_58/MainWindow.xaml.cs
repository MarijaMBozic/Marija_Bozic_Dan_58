using Marija_Bozic_Dan_58.Model;
using Marija_Bozic_Dan_58.ViewModel;
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

namespace Marija_Bozic_Dan_58
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainModel;
        public MainWindow()
        {
            
            mainModel = new MainViewModel(this);
            this.DataContext = mainModel;
            InitializeComponent();
        }

        private void lbl33_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_33.ValueXY = "X";
            mainModel.Filde_33.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();           
        }

        private void lbl32_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_32.ValueXY = "X";
            mainModel.Filde_32.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl31_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_31.ValueXY = "X";
            mainModel.Filde_31.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl23_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_23.ValueXY = "X";
            mainModel.Filde_23.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl22_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_22.ValueXY = "X";
            mainModel.Filde_22.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl21_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_21.ValueXY = "X";
            mainModel.Filde_21.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl13_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_13.ValueXY = "X";
            mainModel.Filde_13.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl12_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_12.ValueXY = "X";
            mainModel.Filde_12.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }

        private void lbl11_Click(object sender, RoutedEventArgs e)
        {
            mainModel.Filde_11.ValueXY = "X";
            mainModel.Filde_11.IsEnabled = false;
            mainModel.CheckTheWinner();
            mainModel.SecectO();            
        }
    }
}
