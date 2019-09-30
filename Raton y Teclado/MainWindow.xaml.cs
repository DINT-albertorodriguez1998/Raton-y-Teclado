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

namespace Raton_y_Teclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            IzquierdaBotonesTextBox.Background = Brushes.Green;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DerechaBotonesTextBox.Background = Brushes.Green;
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IzquierdaBotonesTextBox.Background = Brushes.White;
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            DerechaBotonesTextBox.Background = Brushes.White;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonTextBox.Text = "";
            
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextBox.Text = ((TextBox)sender).Name;
        }


        private void TextBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                TextBox_2.Text = "Ayuda";
            }
        }

        private void TextBox_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox_1.Text = TextBox_1.Text.ToString().ToUpper();
        }
    }
}
