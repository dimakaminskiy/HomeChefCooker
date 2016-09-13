using System.Collections.Generic;

namespace WinHomeMeal
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<DishImage> DishImages { get; set; }

    }

    public class DishImage
    {
        public int Id { get; set; }
        public int DishId { get;  set; }
        public byte[] Image { get; set; }
        public virtual Dish Dish { get; set; }

    }


}