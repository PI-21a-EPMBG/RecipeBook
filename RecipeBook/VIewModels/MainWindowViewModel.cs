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
        public Visibility AddRecipeVisibility
        {
            get => _addRecipeVisibility;
            set => Set(ref _addRecipeVisibility, value);
        }
        private Visibility _addRecipeVisibility;


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
                CollapseAll();
                CatalogueVisibility = Visibility.Visible;
            }
                
        }

        public ICommand AddRecipeToggleCommand { get; private set; }
        private bool CanAddRecipeToggleCommandExecute(object p) => true;
        private void OnAddRecipeToggleCommandExecuted(object p)
        {
            if (AddRecipeVisibility == Visibility.Visible)
            {
                AddRecipeVisibility = Visibility.Collapsed;
                MainPageVisibility = Visibility.Visible;
            }
            else
            {
                CollapseAll();
                AddRecipeVisibility = Visibility.Visible;
            }

        }

        public ICommand FavoriteToggleCommand { get; private set; }
        private bool CanFavoriteToggleCommandExecute(object p) => true;
        private void OnFavoriteToggleCommandExecuted(object p)
        {
            if (FavoriteVisibility == Visibility.Visible)
            {
                FavoriteVisibility = Visibility.Collapsed;
                MainPageVisibility = Visibility.Visible;
            }
            else
            {
                CollapseAll();
                FavoriteVisibility = Visibility.Visible;
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
            AddRecipeVisibility = Visibility.Collapsed;

            FavoriteToggleCommand = new LambdaCommand(OnFavoriteToggleCommandExecuted, CanFavoriteToggleCommandExecute);
            CatalogueToggleCommand = new LambdaCommand(OnCatalogueToggleCommandExecuted, CanCatalogueToggleCommandExecute);
            AddRecipeToggleCommand = new LambdaCommand(OnAddRecipeToggleCommandExecuted, CanAddRecipeToggleCommandExecute);
        
        }

        private void CollapseAll()
        {
            MainPageVisibility = Visibility.Collapsed;
            FavoriteVisibility = Visibility.Collapsed;
            CatalogueVisibility = Visibility.Collapsed;
            AddRecipeVisibility = Visibility.Collapsed;
        }
    }
}
