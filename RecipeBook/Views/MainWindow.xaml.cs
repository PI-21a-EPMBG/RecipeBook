using System.Windows;

namespace RecipeBook
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void menuBorder_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    menuBorder.Visibility = Visibility.Collapsed;
        //    border.Visibility = Visibility.Visible;
        //}

        //private void Border_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    menuBorder.Visibility = Visibility.Visible;
        //    border.Visibility = Visibility.Collapsed;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Показываем третью кнопку и три надписи
        //    if (main_page.Visibility == Visibility.Collapsed)
        //    {
        //        main_page.Visibility = Visibility.Visible;
        //        catalog.Visibility = Visibility.Collapsed;
        //        heading.Text = " СОЗДАЙ СВОЙ КУЛИНАРНЫЙ ШЕДЕВР ";
        //    }
        //    else
        //    {
        //        main_page.Visibility = Visibility.Collapsed;
        //        catalog.Visibility = Visibility.Visible;
        //        heading.Text = " КАТАЛОГ ";
        //    }
        //}
    }
}