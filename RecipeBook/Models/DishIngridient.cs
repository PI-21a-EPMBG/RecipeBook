using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class DishIngridient
{
    public long DishId { get; set; }

    public long IngridientId { get; set; }

    public long Quantity { get; set; }

    public long MeasureUnitId { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Ingridient Ingridient { get; set; } = null!;

    public virtual MeasureUnit MeasureUnit { get; set; } = null!;
}
