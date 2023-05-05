using RecipeBookWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookWF
{
    public partial class CreateRecipe : Form
    {

        public Recipe Recipe { get; private set; }
        public bool Result; 

        public CreateRecipe()
        {
            InitializeComponent();
            Name = "Добавление рецепта в книгу";

            Result = false;

            // Ресайз
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text)) throw new ArgumentNullException("Название");
                else if (string.IsNullOrEmpty(ingridientsTextBox.Text)) throw new ArgumentNullException("Ингриденты");
                else if (string.IsNullOrEmpty(recipeTextBox.Text)) throw new ArgumentNullException("Рецепт");
                else if (cookingTimeTextBox.Value == 0) throw new ArgumentException("Время готовки не может быть равно нулю");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Не заполнено поле: " + ex.ParamName);
                return;
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var name = nameTextBox.Text;
            var ingString = ingridientsTextBox.Text.Replace(", ", ",");
            var ingridients = ingString.Split('\n').ToList();
            var description = recipeTextBox.Text;
            int time = (int)cookingTimeTextBox.Value;

            Recipe = new Recipe
            {
                Name = name,
                Ingridients = ingridients,
                Description = description,
                CookingTime = time,
                IsFavorite = false
            };
            Result = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
