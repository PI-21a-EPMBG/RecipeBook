using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class Dish
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long? Recipe { get; set; }

    public long CookeryId { get; set; }

    public long? CookingTime { get; set; }

    public virtual Cookery Cookery { get; set; } = null!;
}
