using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
        [JsonIgnore] public Bitmap Image { get; set; }


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
            Image = other.Image;
        }

        public string ImageBytes
        {
            get
            {
                byte[] bytes = null;

                if (Image != null)
                {
                    ImageConverter converter = new ImageConverter();
                    bytes = converter.ConvertTo(Image, typeof(byte[])) as byte[];

                }

                return BitConverter.ToString(bytes);
            }
            set
            {
                byte[] bytes = value.Split('-').Select(ch => Convert.ToByte(ch, 16)).ToArray();
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image = new Bitmap(ms);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
