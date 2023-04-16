﻿using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class Cookery
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
