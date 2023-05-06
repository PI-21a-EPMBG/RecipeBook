using Newtonsoft.Json;
using RecipeBookWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

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

            listBox.SelectedIndex = -1;
            listBox_favourites.SelectedIndex = -1;
            _selectedIndex = 1;

            FontSizeConverter();
            ClearSelect();
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


            listBox.SelectedIndex = -1;
            listBox_favourites.SelectedIndex = -1;

            ClearSelect();

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
            AddToFavoritesButton.Enabled = false;
            //ClearSelect();
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
            if (index == _selectedIndex) return;

            if (!recipeName.ReadOnly)
            {
                if (MessageBox.Show("Вы не сохранили рецепт. Продолжить?", "Несохранённые изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    listBox.SelectedIndex = _selectedIndex;
                    return;
                }
                else
                {
                    ToggleReadOnlyMode();
                }
            }

            if (index == -1)
            {
                //listBox.SelectedIndex = 0;
                return;
            }

            TurnOffBlackout();

            _selectedIndex = index;
            _selectedRecipe = (Recipe)listBox.Items[index];

            AddToFavoritesButton.Enabled = !_selectedRecipe.IsFavorite;

            editRecipeButton.Enabled = true;

            recipeName.Text = _selectedRecipe.Name;
            recipeDescriptionTextBox.Text = _selectedRecipe.Description;
            recipeIngridientsTextBox.Text = "-" + string.Join("\n-", _selectedRecipe.Ingridients);
            cookingTimeTextBox.Text = _selectedRecipe.CookingTime.ToString() + " мин.";
        }
        private void listBox_favourites_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_favourites.SelectedIndex;
            if (index == _selectedIndex) return;

            if (!recipeName_favourites.ReadOnly)
            {
                if (MessageBox.Show("Вы не сохранили рецепт. Продолжить?", "Несохранённые изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    listBox_favourites.SelectedIndex = _selectedIndex;
                    return;
                }
                else
                {
                    ToggleReadOnlyMode();
                }
            }

            if (index == -1)
            {
                //listBox_favourites.SelectedIndex = 0;
                return;
            }

            TurnOffBlackout();


            _selectedIndex = index;
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
            _selectedIndex = -2;

            listBox.SelectedIndex = -1;
            listBox_favourites.SelectedIndex = -1;

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

            blackout.Visible = true;
            blackoutFavorites.Visible = true;

            recipeName.Enabled = false;
            recipeIngridientsTextBox.Enabled = false;
            recipeDescriptionTextBox.Enabled = false;
            recipeIngridientsTextBox.Enabled = false;
            cookingTimeTextBox.Enabled = false;
            recipePictureBox.Enabled = false;

            recipeName.Visible = false;
            cookingTimeTextBox.Visible = false;
            recipeIngridientsTextBox.Visible = false; label1.Visible = false;
            recipeDescriptionTextBox.Visible = false; label2.Visible = false;
            cookingTimeTextBox.Visible = false;
            recipePictureBox.Visible = false;

            recipeName_favourites.Enabled = false;
            recipeIngridientsTextBox_favourites.Enabled = false;
            recipeDescriptionTextBox_favourites.Enabled = false;
            recipeIngridientsTextBox_favourites.Enabled = false;
            cookingTimeTextBox_favorites.Enabled = false;
            recipePictureBox_favourites.Enabled = false;

            recipeName_favourites.Visible = false;
            cookingTimeTextBox_favorites.Visible = false;
            recipeIngridientsTextBox_favourites.Visible = false; label4.Visible = false;
            recipeDescriptionTextBox_favourites.Visible = false; label5.Visible = false;
            cookingTimeTextBox_favorites.Visible = false;
            recipePictureBox_favourites.Visible = false;

            editRecipeButton_favourites.Visible = false;
            RemoveFromFavoritesButton.Visible = false;

            AddToFavoritesButton.Visible = false;
            editRecipeButton.Visible = false;
        }

        private void TurnOffBlackout()
        {
            blackout.Visible = false;
            blackoutFavorites.Visible = false;

            recipeName.Enabled = true;
            recipeIngridientsTextBox.Enabled = true;
            recipeDescriptionTextBox.Enabled = true;
            recipeIngridientsTextBox.Enabled = true;
            cookingTimeTextBox.Enabled = true;
            recipePictureBox.Enabled = true;

            recipeName.Visible = true;
            cookingTimeTextBox.Visible = true;
            recipeIngridientsTextBox.Visible = true; label1.Visible = true;
            recipeDescriptionTextBox.Visible = true; label2.Visible = true;
            cookingTimeTextBox.Visible = true;
            recipePictureBox.Visible = true;


            recipeName_favourites.Enabled = true;
            recipeIngridientsTextBox_favourites.Enabled = true;
            recipeDescriptionTextBox_favourites.Enabled = true;
            recipeIngridientsTextBox_favourites.Enabled = true;
            cookingTimeTextBox_favorites.Enabled = true;
            recipePictureBox_favourites.Enabled = true;

            recipeName_favourites.Visible = true;
            cookingTimeTextBox_favorites.Visible = true;
            recipeIngridientsTextBox_favourites.Visible = true; label4.Visible = true;
            recipeDescriptionTextBox_favourites.Visible = true; label5.Visible = true;
            cookingTimeTextBox_favorites.Visible = true;
            recipePictureBox_favourites.Visible = true;

            editRecipeButton_favourites.Visible = true;
            RemoveFromFavoritesButton.Visible = true;

            AddToFavoritesButton.Visible = true;
            editRecipeButton.Visible = true;
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


        // ПИСАЛ МАКСИМ БОГОМОЛОВ
        //          |
        //          |
        //          |
        //          |   
        //       \  |  /
        //        \ | /
        //         \|/
        //          v

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

        private void blackoutFavorites_Paint(object sender, PaintEventArgs e)
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

        private void FontSizeConverter()
        {
            float newWidth = this.Width;
            float newHeight = this.Height;
            recipeName.Font = new Font(recipeName.Font.FontFamily, Math.Min(newWidth / 35, newHeight / 35), recipeName.Font.Style);
            recipeDescriptionTextBox.Font = new Font(recipeDescriptionTextBox.Font.FontFamily, Math.Min(newWidth / 50, newHeight / 50), recipeDescriptionTextBox.Font.Style);
            recipeIngridientsTextBox.Font = new Font(recipeIngridientsTextBox.Font.FontFamily, Math.Min(newWidth / 50, newHeight / 50), recipeIngridientsTextBox.Font.Style);
            cookingTimeTextBox.Font = new Font(cookingTimeTextBox.Font.FontFamily, Math.Min(newWidth / 60, newHeight / 60), cookingTimeTextBox.Font.Style); // пример формулы для изменения размера шрифта

            recipeName_favourites.Font = new Font(recipeName_favourites.Font.FontFamily, Math.Min(newWidth / 35, newHeight / 35), recipeName_favourites.Font.Style);
            recipeDescriptionTextBox_favourites.Font = new Font(recipeDescriptionTextBox_favourites.Font.FontFamily, Math.Min(newWidth / 50, newHeight / 50), recipeDescriptionTextBox_favourites.Font.Style);
            recipeIngridientsTextBox_favourites.Font = new Font(recipeIngridientsTextBox_favourites.Font.FontFamily, Math.Min(newWidth / 50, newHeight / 50), recipeIngridientsTextBox_favourites.Font.Style);
            cookingTimeTextBox_favorites.Font = new Font(cookingTimeTextBox_favorites.Font.FontFamily, Math.Min(newWidth / 60, newHeight / 60), cookingTimeTextBox_favorites.Font.Style); // пример формулы для изменения размера шрифта
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            FontSizeConverter();
        }

        private void editRecipeButton_favourites_Click(object sender, EventArgs e)
        {
            if (!recipeName_favourites.ReadOnly)
            {
                _selectedRecipe.Name = recipeName_favourites.Text;
                _selectedRecipe.Ingridients = recipeIngridientsTextBox_favourites.Text.Replace("-", "").Split('\n', ',').ToList();
                _selectedRecipe.Description = recipeDescriptionTextBox_favourites.Text;
                _selectedRecipe.CookingTime = Convert.ToInt32(cookingTimeTextBox_favorites.Text.Split(' ')[0]);

                IsEdited = true;
            }

            ToggleReadOnlyMode_favourites();
        }

        private void ToggleReadOnlyMode_favourites()
        {
            recipeName_favourites.ReadOnly = !recipeName_favourites.ReadOnly;
            recipeDescriptionTextBox_favourites.ReadOnly = !recipeDescriptionTextBox_favourites.ReadOnly;
            cookingTimeTextBox_favorites.ReadOnly = !cookingTimeTextBox_favorites.ReadOnly;
            recipeIngridientsTextBox_favourites.ReadOnly = !recipeIngridientsTextBox_favourites.ReadOnly;

            editRecipeButton_favourites.Text = recipeName_favourites.ReadOnly ? "Редактировать" : "Сохранить";
        }
    }
}
