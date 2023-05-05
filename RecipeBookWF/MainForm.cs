using Newtonsoft.Json;
using RecipeBookWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RecipeBookWF
{
    public partial class MainForm : Form
    {
        private int _selectedIndex;
        private string _fileName;
        private bool _isEdited;
        private Recipe _selectedRecipe;
        private BindingList<Recipe> _recipes;
        private BindingList<Recipe> _favorites;

        public bool IsEdited
        {
            get => _isEdited;
            set
            {
                _isEdited = value;
                UpdateHeader();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            IsEdited = false;
            _recipes = new BindingList<Recipe>();
            _favorites = new BindingList<Recipe>();

            listBox.DataSource = _recipes;
            listBox_favourites.DataSource = _favorites;

            //Text = "Книга без названия | Кулинарная книга";
            saveFileDialog.Filter = "Книга рецептов|*.book";
            openFileDialog.Filter = "Книга рецептов|*.book";

            editRecipeButton.Enabled = false;
            editRecipeButton_favourites.Enabled = false;
            AddToFavoritesButton.Enabled = false;
            RemoveFromFavoritesButton.Enabled = false;
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
            IsEdited = false;
            try
            {
                var json = File.ReadAllText(_fileName);
                var recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);

                _recipes.Clear();
                _favorites.Clear();
                foreach (var recipe in recipes)
                {
                    _recipes.Add(new Recipe(recipe));
                }
                foreach (var recipe in _recipes.Where(r => r.IsFavorite).ToList())
                {
                    _favorites.Add(recipe);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось прочитать файл");
                return;
            }

            AddToFavoritesButton.Enabled = false;
            editRecipeButton.Enabled = false;

            MessageBox.Show("Книга успешно открыта из файла '" + _fileName.Split('\\').Last() + "'", "Открытие книги",
               MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Save()
        {
            saveFileDialog.FileName = "Новая книга";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _fileName = saveFileDialog.FileName;

            var content = _recipes.ToList();
            var json = JsonConvert.SerializeObject(content, Formatting.Indented);
            File.WriteAllText(_fileName, json);

            IsEdited = false;
        }

        private void UpdateHeader()
        {
            var fileName = _fileName == null ? "Книга без названия" : _fileName.Split('\\').Last();

            Text = _isEdited ?
                "* " + fileName + " | Кулинарная книга" :
                       fileName + " | Кулинарная книга";
        }

        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            Save();
            MessageBox.Show("Книга успешно сохранена в файл '" + _fileName.Split('\\').Last() + "'", "Сохранение книги",
               MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        private void ToggleReadOnlyMode()
        {
            recipeName.ReadOnly = !recipeName.ReadOnly;
            recipeDescriptionTextBox.ReadOnly = !recipeDescriptionTextBox.ReadOnly;
            cookingTimeTextBox.ReadOnly = !cookingTimeTextBox.ReadOnly;
            recipeIngridientsTextBox.ReadOnly = !recipeIngridientsTextBox.ReadOnly;

            editRecipeButton.Text = recipeName.ReadOnly ? "Редактировать" : "Сохранить";
        }

        private void AddToFavoritesButton_Click(object sender, EventArgs e)
        {
            _favorites.Add(_selectedRecipe);
            _selectedRecipe.IsFavorite = true;
            ClearSelect();
        }
        private void RemoveFromFavoritesButton_Click(object sender, EventArgs e)
        {
            _favorites.Remove(_selectedRecipe);
            _selectedRecipe.IsFavorite = false;
            ClearSelect();
        }
        private void CreateRecipeCatalogueButton_Click(object sender, EventArgs e)
        {
            var view = new CreateRecipe();

            view.ShowDialog();

            if (view.Result)
            {
                _recipes.Add(new Recipe(view.Recipe));
                IsEdited = true;
            }
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            if (!recipeName.ReadOnly)
            {
                _selectedRecipe.Name = recipeName.Text;
                _selectedRecipe.Ingridients = recipeIngridientsTextBox.Text.Replace("-", "").Split('\n', ',').ToList();
                _selectedRecipe.Description = recipeDescriptionTextBox.Text;
                _selectedRecipe.CookingTime = Convert.ToInt32(cookingTimeTextBox.Text.Split(' ')[0]);

                IsEdited = true;
            }

            ToggleReadOnlyMode();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (!recipeName.ReadOnly)
            {
                if (MessageBox.Show("Вы не сохранили рецепт. Продолжить?", "Несохранённые изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ToggleReadOnlyMode();
                }
            }

            if (index == -1) return;

            _selectedRecipe = (Recipe)listBox.Items[index];

            AddToFavoritesButton.Enabled = true;
            editRecipeButton.Enabled = true;

            recipeName.Text = _selectedRecipe.Name;
            recipeDescriptionTextBox.Text = _selectedRecipe.Description;
            recipeIngridientsTextBox.Text = "-" + string.Join("\n-", _selectedRecipe.Ingridients);
            cookingTimeTextBox.Text = _selectedRecipe.CookingTime.ToString() + " мин.";
        }
        private void listBox_favourites_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_favourites.SelectedIndex;

            if (!recipeName_favourites.ReadOnly)
            {
                if (MessageBox.Show("Вы не сохранили рецепт. Продолжить?", "Несохранённые изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ToggleReadOnlyMode();
                }
            }

            if (index == -1) return;

            _selectedRecipe = (Recipe)listBox_favourites.Items[index];

            RemoveFromFavoritesButton.Enabled = true;
            editRecipeButton_favourites.Enabled = true;

            recipeName_favourites.Text = _selectedRecipe.Name;
            recipeDescriptionTextBox_favourites.Text = _selectedRecipe.Description;
            recipeIngridientsTextBox_favourites.Text = "-" + string.Join("\n-", _selectedRecipe.Ingridients);
            cookingTimeTextBox_favorites.Text = _selectedRecipe.CookingTime.ToString() + " мин.";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelect();
        }

        private void ClearSelect()
        {
            _selectedRecipe = null;

            recipeName.Text = string.Empty;
            recipeDescriptionTextBox.Text = string.Empty;
            recipeIngridientsTextBox.Text = string.Empty;
            cookingTimeTextBox.Text = string.Empty;

            recipeName_favourites.Text = string.Empty;
            recipeDescriptionTextBox_favourites.Text = string.Empty;
            recipeIngridientsTextBox_favourites.Text = string.Empty;
            cookingTimeTextBox_favorites.Text = string.Empty;

            AddToFavoritesButton.Enabled = false;
            RemoveFromFavoritesButton.Enabled = false;

            editRecipeButton.Enabled = false;
            editRecipeButton_favourites.Enabled = false;
        }

        private void CreateNewBookButton_Click(object sender, EventArgs e)
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

            _recipes.Clear();
            _favorites.Clear();
            ClearSelect();
            _isEdited = false;
        }

        private void RemoveRecipeButton_Click(object sender, EventArgs e)
        {

            if (_recipes.Count == 0)
            {
                MessageBox.Show("Для удаление требуется добавить минимум 1 рецепт из списка", "Не добавлен рецепт",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_selectedRecipe == null)
            {
                MessageBox.Show("Для удаление требуется выбрать минимум 1 рецепт из списка", "Не выбран рецепт",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IsEdited = true;

            if (_selectedRecipe.IsFavorite)
                _favorites.Remove(_selectedRecipe);

            _recipes.Remove(_selectedRecipe);

            ClearSelect();

            MessageBox.Show("Рецепт успешно удалён", "Удаление рецепта",
                MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Control parent = control.Parent;

            Bitmap behind = new Bitmap(parent.Width, parent.Height);

            foreach (Control c in parent.Controls)
                if (c != control)
                    c.DrawToBitmap(behind, c.Bounds);

            float opacity = 0.8f;
            Color bgColor = Color.FromArgb(Convert.ToInt32(255 * opacity), 0, 0, 0);

            Graphics g = Graphics.FromImage(behind);

            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            g.FillRectangle(Brush, 0, 0, parent.Width, parent.Height);

            // Добавляем текст
            string text = "Рецепт не выбран";
            Font font = new Font("Arial", 30, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.White);

            // Вычисляем размеры текста
            SizeF textSize = g.MeasureString(text, font);

            // Вычисляем координаты для вывода текста по центру элемента управления PictureBox
            float x = (control.Width - textSize.Width) / 2;
            float y = (control.Height - textSize.Height) / 2;

            g.DrawString(text, font, brush, new PointF(x, y));

            e.Graphics.DrawImage(behind, -control.Left, -control.Top);
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Control parent = control.Parent;

            Bitmap behind = new Bitmap(parent.Width, parent.Height);

            foreach (Control c in parent.Controls)
                if (c != control)
                    c.DrawToBitmap(behind, c.Bounds);

            float opacity = 0.8f;
            Color bgColor = Color.FromArgb(Convert.ToInt32(255 * opacity), 0, 0, 0);

            Graphics g = Graphics.FromImage(behind);

            SolidBrush Brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            g.FillRectangle(Brush, 0, 0, parent.Width, parent.Height);

            // Добавляем текст
            string text = "Рецепт не выбран";
            Font font = new Font("Arial", 30, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.White);

            // Вычисляем размеры текста
            SizeF textSize = g.MeasureString(text, font);

            // Вычисляем координаты для вывода текста по центру элемента управления PictureBox
            float x = (control.Width - textSize.Width) / 2;
            float y = (control.Height - textSize.Height) / 2;

            g.DrawString(text, font, brush, new PointF(x, y));

            e.Graphics.DrawImage(behind, -control.Left, -control.Top);
        }
    }
}
