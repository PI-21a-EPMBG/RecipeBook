using System;
using System.Collections.Generic;

namespace RecipeBook.Models;

public partial class Ingridient
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;
}
