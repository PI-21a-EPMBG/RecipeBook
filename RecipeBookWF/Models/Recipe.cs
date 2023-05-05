using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookWF.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingridients { get; set; }
        public string IngridientsString => string.Join(", ", Ingridients);

        public Recipe()
        {
            Ingridients = new List<string>();
        }

        public Recipe(Recipe other)
        {
            Name = other.Name;
            Description = other.Description;
            Ingridients = new List<string>(other.Ingridients);
        }
    }
}
