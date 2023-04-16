using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class Favorite
{
    public long DishId { get; set; }

    public string DateAdded { get; set; } = null!;

    public virtual Dish Dish { get; set; } = null!;
}
