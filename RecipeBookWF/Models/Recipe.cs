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
        public List<string> Ingridients { get; set; }
        public string Descriptions;

        public Recipe()
        {
            Ingridients = new List<string>();
        }
    }
}
