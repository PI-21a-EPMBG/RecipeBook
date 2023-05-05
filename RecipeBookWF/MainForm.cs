using Newtonsoft.Json;
using RecipeBookWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookWF
{
    public partial class MainForm : Form
    {
        private string _fileName;
        private bool _isEdited;
        private Recipe _selectedRecipe;
        private BindingList<Recipe> _recipes;
        private BindingList<Recipe> _favorites;

        public MainForm()
        {
            InitializeComponent();
            _isEdited = false;
            _recipes = new BindingList<Recipe>();
            _favorites = new BindingList<Recipe>();

            listBox.DataSource = _recipes;

            //dataGrid.DataSource = _recipes;

            //dataGrid.Columns["Name"].HeaderText = "Название";

            //dataGrid.Columns["IngridientsString"].HeaderText = "Ингридиенты";
            //dataGrid.Columns["Description"].HeaderText = "Рецепт";

            Name = "Книга без названия | Кулинарная книга";
            saveFileDialog.Filter = "Книга рецептов|*.book";
            openFileDialog.Filter = "Книга рецептов|*.book";

            AddToFavoritesButton.Enabled = false;
            editRecipeButton.Enabled = false;
        }
        private void DeleteRecipeCatalogueMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void EditRecipeCatalogueButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateRecipeCatalogueButton_Click(object sender, EventArgs e)
        {
            var view = new CreateRecipe();

            view.ShowDialog();

            if (view.Result)
            {
                _isEdited=true;
                _recipes.Add(new Recipe(view.Recipe));
                UpdateHeader();
            }
        }

        private void LoadMenuButton_Click(object sender, EventArgs e)
        {
            if (_isEdited)
            {
                var choice = MessageBox.Show("Вы не сохранили изменения. Хотите ли сохранить сейчас?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (choice == DialogResult.Yes)
                {
                    Save();
                }
                else if (choice == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _fileName = openFileDialog.FileName;
            try
            {
                var json = File.ReadAllText(_fileName);
                var recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);

                _recipes.Clear();
                foreach (var recipe in recipes)
                {
                    _recipes.Add(new Recipe(recipe));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось прочитать файл");
                return;
            }

            AddToFavoritesButton.Enabled = false;
            editRecipeButton.Enabled = false;
        }

        private void Save()
        {
            _isEdited = false;

            saveFileDialog.FileName = "Новая книга";
            if(saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _fileName = saveFileDialog.FileName;

            var recipes = _recipes.ToList();
            var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(_fileName, json);

            UpdateHeader();
        }

        private void UpdateHeader()
        {
            Name = _isEdited ? 
                "* " + _fileName + "| Кулинарная книга" : 
                       _fileName + "| Кулинарная книга"; 
        }

        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if(index == -1) return;

            _selectedRecipe = (Recipe)listBox.Items[index];

            AddToFavoritesButton.Enabled = true;
            editRecipeButton.Enabled = true;

            recipeName.Text = _selectedRecipe.Name;
            recipeDescriptionTextBox.Text = _selectedRecipe.Description;
            recipeIngridientsTextBox.Text = "-" + string.Join("\n-", _selectedRecipe.Ingridients);
            cookingTimeTextBox.Text = _selectedRecipe.CookingTime.ToString() + " мин.";
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            if (!recipeName.ReadOnly)
            {
                _selectedRecipe.Name = recipeName.Text;
                _selectedRecipe.Ingridients = recipeIngridientsTextBox.Text.Replace("-", "").Split('\n', ',').ToList();
                _selectedRecipe.Description = recipeDescriptionTextBox.Text;
                _selectedRecipe.CookingTime = Convert.ToInt32(cookingTimeTextBox.Text.Split(' ')[0]);
            }

            recipeName.ReadOnly = !recipeName.ReadOnly;
            recipeDescriptionTextBox.ReadOnly = !recipeDescriptionTextBox.ReadOnly;
            cookingTimeTextBox.ReadOnly = !cookingTimeTextBox.ReadOnly;
            recipeIngridientsTextBox.ReadOnly = !recipeIngridientsTextBox.ReadOnly;

            editRecipeButton.Text = recipeName.ReadOnly ? "Редактировать" : "Сохранить";
        }

        private void AddToFavoritesButton_Click(object sender, EventArgs e)
        {
            _favorites.Add(_selectedRecipe);
        }
    }
}
