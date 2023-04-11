using RecipeBook.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace RecipeBook.ViewModels
{
    public enum PAGE
    {
        FAVORITE = 0,
        CATALOGUE = 1,
        CREATE = 2
    }

    internal class MainWindowViewModel : BaseViewModel
    {

        #region Свойства

        public Visibility MainPageVisibility
        {
            get => _mainPageVisibility;
            set => Set(ref _mainPageVisibility, value);
        }
        private Visibility _mainPageVisibility;
        public Visibility CatalogueVisibility
        { 
            get => _catalogueVisibility; 
            set => Set(ref _catalogueVisibility, value);  
        }
        private Visibility _catalogueVisibility;
        public Visibility FavoriteVisibility
        {
            get => _favoriteVisibility;
            set => Set(ref _favoriteVisibility, value);
        }
        private Visibility _favoriteVisibility;

        #endregion


        #region Команды

        public ICommand CatalogueToggleCommand { get; private set; }
        private bool CanCatalogueToggleCommandExecute(object p) => true;
        private void OnCatalogueToggleCommandExecuted(object p)
        {
            if(CatalogueVisibility == Visibility.Visible)
            {
                CatalogueVisibility = Visibility.Collapsed;
                MainPageVisibility = Visibility.Visible; 
            }
            else
            {
                CatalogueVisibility = Visibility.Visible;
                MainPageVisibility = Visibility.Collapsed;
            }
                
        }

        #endregion

        public MainWindowViewModel()
        {
            Init();
        }

        private void Init()
        {
            MainPageVisibility = Visibility.Visible;

            CatalogueVisibility = Visibility.Collapsed;
            FavoriteVisibility = Visibility.Collapsed;

            CatalogueToggleCommand = new LambdaCommand(OnCatalogueToggleCommandExecuted, CanCatalogueToggleCommandExecute);
        }
    }
}
