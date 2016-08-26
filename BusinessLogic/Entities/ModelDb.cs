namespace WinHomeMeal
{
    using System.Data.Entity;

    public class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}