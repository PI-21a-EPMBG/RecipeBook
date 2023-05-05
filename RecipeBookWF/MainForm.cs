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
        private BindingList<Recipe> _recipes; 

        public MainForm()
        {
            InitializeComponent();
            _isEdited = false;
            _recipes = new BindingList<Recipe>();

            //dataGrid.DataSource = _recipes;

            //dataGrid.Columns["Name"].HeaderText = "Название";

            //dataGrid.Columns["IngridientsString"].HeaderText = "Ингридиенты";
            //dataGrid.Columns["Description"].HeaderText = "Рецепт";

            Name = "Книга без названия | Кулинарная книга";
            saveFileDialog.Filter = "Книга рецептов|*.book";
            openFileDialog.Filter = "Книга рецептов|*.book";
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
                //dataGrid.Update();
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
                _recipes = (BindingList<Recipe>)JsonConvert.DeserializeObject(json);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось прочитать файл");
            }
            
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

            var json = JsonConvert.SerializeObject(_recipes);

            File.WriteAllText(_fileName, json);
        }

        private void UpdateHeader()
        {
            Name = _isEdited ? 
                "* " + _fileName + "| Кулинарная книга" : 
                       _fileName + "| Кулинарная книга"; 
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
