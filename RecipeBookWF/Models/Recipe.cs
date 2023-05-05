using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecipeBookWF.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingridients { get; set; }
        
        [JsonIgnore] public string IngridientsString => string.Join(", ", Ingridients);

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

        public override string ToString()
        {
            return Name;
        }
    }
}
