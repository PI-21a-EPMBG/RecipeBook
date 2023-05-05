using System.Windows;
using System.Windows.Controls;

namespace RecipeBook
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScrollViewer_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }


        private void catalogueListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}