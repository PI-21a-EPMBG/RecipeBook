using RecipeBook;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
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

namespace RecipeBook
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void menuBorder_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void menuBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            menuBorder.Visibility = Visibility.Collapsed;
            border.Visibility = Visibility.Visible;
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            menuBorder.Visibility = Visibility.Visible;
            border.Visibility = Visibility.Collapsed;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Показываем третью кнопку и три надписи
            if(Label1.Visibility == Visibility.Collapsed)
            {
                Label1.Visibility = Visibility.Visible;
                Label2.Visibility = Visibility.Visible;
                Label3.Visibility = Visibility.Visible;

                // Сдвигаем третью кнопку вниз)

                myGrid.RowDefinitions[4].Height = new GridLength(2, GridUnitType.Star);        
                myGrid.RowDefinitions[12].Height = new GridLength(38, GridUnitType.Star);
                Grid.SetRow(Button3, 11);
            }
            else
            {
                Label1.Visibility = Visibility.Collapsed;
                Label2.Visibility = Visibility.Collapsed;
                Label3.Visibility = Visibility.Collapsed;

                // Сдвигаем третью кнопку вниз)

                myGrid.RowDefinitions[4].Height = new GridLength(5, GridUnitType.Star);
                myGrid.RowDefinitions[12].Height = new GridLength(35, GridUnitType.Star);

                Grid.SetRow(Button3, 5);
            }
        }

    }
}