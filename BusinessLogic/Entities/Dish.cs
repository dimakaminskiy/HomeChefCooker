﻿using System.Collections.Generic;

namespace WinHomeMeal
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Ingredient> IngredientS { get; set; }
    }
}