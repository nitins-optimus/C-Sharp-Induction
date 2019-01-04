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
using WSR_MVVM.ViewModels;

namespace WSR_MVVM.Views
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Window
    {
          public HomeScreen()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void Wsr_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            //System.Diagnostics.Debug.WriteLine(sender.ToString());
            //WsrProjectDetail secondWin = new WsrProjectDetail();
            //var a = this.DataContext as WsrCollectn;
            //secondWin.Display(a.SelectedWsr);

        }
    }
}
