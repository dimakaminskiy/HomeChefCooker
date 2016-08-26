namespace WinHomeMeal
{
    //Включает в себя продукт и его количество
    public class Ingredient
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Value { get; set; }
        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }
        public virtual Product Product { get; set; }
    }
}