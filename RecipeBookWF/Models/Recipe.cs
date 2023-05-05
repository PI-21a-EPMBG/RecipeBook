using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecipeBookWF.Models
{
    public class Recipe
    {
        public static int NextID = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingridients { get; set; }
        public int CookingTime { get; set; }
        public bool IsFavorite { get; set; }
        
        [JsonIgnore] public string IngridientsString => string.Join(", ", Ingridients);

        public Recipe()
        {
            Ingridients = new List<string>();
            Id = NextID;
            NextID++;
        }

        public Recipe(Recipe other)
        {
            Name = other.Name;
            Description = other.Description;
            Ingridients = new List<string>(other.Ingridients);
            CookingTime = other.CookingTime;
            IsFavorite = other.IsFavorite;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
