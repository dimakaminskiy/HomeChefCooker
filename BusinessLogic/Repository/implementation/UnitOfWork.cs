using System;
using WinHomeMeal;

namespace BusinessLogic.Repository.implementation
{

   public class UnitOfWork : IDisposable
    {
        private static UnitOfWork unitOfWork;
        private UnitOfWork()
        {
            disposed = false;
        }

        public static UnitOfWork GetInstance()
        {
            if (unitOfWork == null)
            {
                unitOfWork = new UnitOfWork();
            }
            return unitOfWork;
        }




       public ScheduleDayRepository ScheduleDayRepository
       {
           get
           {
               if (this._scheduleDayRepository == null)
               {
                   this._scheduleDayRepository=  new ScheduleDayRepository();
               }
               return _scheduleDayRepository;
           }
       }

       private ScheduleDayRepository _scheduleDayRepository;


        private readonly ModelDb _context = new ModelDb();
        private GenericRepository<Product> _productRepository;
        private GenericRepository<Dish> _dishRepository;
        private GenericRepository<Category> _categoryRepository;
        private GenericRepository<Ingredient> _ingredientRepository;
        private GenericRepository<Measure> _measureRepository;
        private GenericRepository<DishImage> _dishImageRepository;


        public GenericRepository<DishImage> DishImageRepository
        {
            get
            {

                if (this._dishImageRepository == null)
                {
                    this._dishImageRepository = new GenericRepository<DishImage>(_context);
                }
                return _dishImageRepository;
            }
        }


        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this._productRepository == null)
                {
                    this._productRepository = new GenericRepository<Product>(_context);
                }
                return _productRepository;
            }
        }
        public GenericRepository<Dish> DishRepository
        {
            get
            {

                if (this._dishRepository == null)
                {
                    this._dishRepository = new GenericRepository<Dish>(_context);
                }
                return _dishRepository;
            }
        }
        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                if (this._categoryRepository == null)
                {
                    this._categoryRepository = new GenericRepository<Category>(_context);
                }
                return _categoryRepository;
            }
        }
        public GenericRepository<Ingredient> IngredientRepository
        {
            get
            {

                if (this._ingredientRepository == null)
                {
                    this._ingredientRepository = new GenericRepository<Ingredient>(_context);
                }
                return _ingredientRepository;
            }
        }
        public GenericRepository<Measure> MeasureRepository
        {
            get
            {

                if (this._measureRepository == null)
                {
                    this._measureRepository = new GenericRepository<Measure>(_context);
                }
                return _measureRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!unitOfWork.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            unitOfWork.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    public class ScheduleDayRepository
    {
        private readonly ScheduleDay[] _array =
        {
            new ScheduleDay() { Id = 1,FullName = "Понедельник", Name ="Пн"},
            new ScheduleDay() { Id = 1,FullName = "Вторник", Name ="ВТ"},
            new ScheduleDay() { Id = 1,FullName = "Среда", Name ="СР"},
            new ScheduleDay() { Id = 1,FullName = "Четверг", Name ="ЧТ"},
            new ScheduleDay() { Id = 1,FullName = "Пятница", Name ="ПТ"},
            new ScheduleDay() { Id = 1,FullName = "Суббота", Name ="СБ"},
            new ScheduleDay() { Id = 1,FullName = "Воскресенье", Name ="ВС"},

        };

        public ScheduleDay[] Get()
        {
            return _array;
        }
    }
}
