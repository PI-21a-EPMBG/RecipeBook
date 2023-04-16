using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class DishTag
{
    public long DishId { get; set; }

    public long TagId { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
