using System.Runtime.InteropServices;

namespace WinHomeMeal
{
    public class CookingDay
    {
        
        private string _name;
        private bool _isWeekDay;
        private Breakfast _breakfast;
        private Dinner _dinner;
        private Supper _supper;
        private int _number;

        public delegate void FullNameChangeEventHandler(object sender,string fullName);
        public event FullNameChangeEventHandler OnFullNameChangeEventHandler;

        public delegate void BreakfastDishChangeEventHandler(object sender);
        public event BreakfastDishChangeEventHandler OnBreakfastDishChange;

        public delegate void DinnerDishChangeEventHandler(object sender);
        public event DinnerDishChangeEventHandler OnDinnerDishChange;

        public delegate void SupperDishChangeEventHandler(object sender);
        public event SupperDishChangeEventHandler OnSupperDishChange;


        public string FullName { get { return Name + " " + Number; } }
        public CookingDay( int id )
        {
            Id = id;
            _breakfast = new Breakfast();
        }

        public int Id { get;  private set; }

        public string Name  
        {
            get { return _name; }
            set
            {
                _name = value;
                OnOnFullNameChangeEventHandler(FullName);
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnOnFullNameChangeEventHandler(FullName);
            }
        }

        public bool IsWeekDay   
        {
            get { return _isWeekDay; }
            set { _isWeekDay = value; }
        }

        public Breakfast Breakfast  
        {
            get { return _breakfast; }
            set {
                if (value != null)
                {
                    _breakfast = value;
                    OnOnBreakfastDishChange();
                }
            }
        }
        public Dinner Dinner        
        {
            get { return _dinner; }
            set
            {
                if (value != null)
                {
                   _dinner = value;
                    OnOnDinnerDishChange(); 
                }                  
            }
        }
        public Supper Supper    
        {
            get { return _supper; }
            set
            {
                if (value != null)
                {
                    _supper = value;
                    OnOnSupperDishChange();
                }
               
            }
        }

        
        protected virtual void OnOnFullNameChangeEventHandler(string fullname)
        {
            OnFullNameChangeEventHandler?.Invoke(this, fullname);
        }

        protected virtual void OnOnBreakfastDishChange()
        {
            OnBreakfastDishChange?.Invoke(this);
        }

        protected virtual void OnOnDinnerDishChange()
        {
            OnDinnerDishChange?.Invoke(this);   
        }

        protected virtual void OnOnSupperDishChange()
        {
            OnSupperDishChange?.Invoke(this);   
        }
    }

    public class Breakfast
    {

        private static string _name = "Завтрак";
        private Dish _breakfastDish;
       
        public string Name => _name;
        public  Dish BreakfastDish
        {
            get { return _breakfastDish; }
            set
            {
                _breakfastDish = value;
            }
        }
    }

    public class Dessert
    {
        private static string _name = "Десерт";
        public string Name => _name;
        public Dish DessertDish { get; set; }
    }


    public class Dinner
    {
        private static string _name = "Обед";
        public string Name => _name;
        public Dish FirstDish { get; set; }
        public Dish SecondDish { get; set; }
    }
    public class Supper
    {
        private static string _name = "Ужин";
        public string Name => _name;
        public Dish SupperDish { get; set; }
    }



}