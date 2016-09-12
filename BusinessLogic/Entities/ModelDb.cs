namespace WinHomeMeal
{
    using System.Data.Entity;

    public class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            Database.SetInitializer(
       new DropCreateDatabaseIfModelChanges<ModelDb>());



            //Database.SetInitializer<ModelDb>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishImage> DishImages { get; set; }
    }
}