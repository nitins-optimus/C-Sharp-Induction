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
using WSR_Creator.Models;
using WSR_Creator.Views;

namespace WSR_Creator
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
            
            System.Diagnostics.Debug.WriteLine(sender.ToString());
            WsrProjectDetail secondWin = new WsrProjectDetail();
            var a = this.DataContext as WsrCollectn; 
            secondWin.Display(a.SelectedWsr);

        }
    }
}
