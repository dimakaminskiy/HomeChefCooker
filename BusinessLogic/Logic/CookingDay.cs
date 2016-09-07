using System;
namespace WinHomeMeal
{
    public class CookingDay
    {
        public CookingDay(DateTime dateTime)
        {
            _dateTime = dateTime;
            Id = _counter;
            _counter++;
        }
        public  int Id { get; private set; }
        public int Day { get { return _dateTime.Day; } }
        public string Mounth { get { return _mounths[_dateTime.Month]; } }
        public  string DayOfWeek { get { return _daysOfWeek[(int) CurrentDateTime.DayOfWeek]; } }
        public  DateTime CurrentDateTime { get { return _dateTime; } }
        public string FullName { get { return string.Format("{0} {1} {2}", DayOfWeek, Mounth, Day); } }
        public  bool IsWeekDay { get { return DayOfWeek == "ВС" || DayOfWeek == "СБ"; } }

        public delegate void BreakfastDishChangeEventHandler(object sender, Breakfast breakfast);
        public event BreakfastDishChangeEventHandler OnBreakfastDishChange;

        public delegate void DinnerDishChangeEventHandler(object sender, Dinner dinner);
        public event DinnerDishChangeEventHandler OnDinnerDishChange;

        public delegate void SupperDishChangeEventHandler(object sender, Supper supper);
        public event SupperDishChangeEventHandler OnSupperDishChange;


        public Breakfast Breakfast
        {
            get { return _breakfast; }
            set
            {
                _breakfast = value;
                OnOnBreakfastDishChange(value);
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
                   OnOnSupperDishChange(value);
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
                    OnOnDinnerDishChange(value);
                }
            }
        }


        private string[] _mounths =
        {
            "","Января", "Февраля", "Марта",
            "Апреля", "Мая", "Июня", "Июля", "Августа",
            "Сентября", "Октября", "Ноября", "Декабря"
        };

        private readonly string[] _daysOfWeek = {"", "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС"};
        private static int _counter = 1;
        private readonly DateTime _dateTime;
        private Breakfast _breakfast;
        private Supper _supper;
        private Dinner _dinner;


        protected virtual void OnOnBreakfastDishChange(Breakfast breakfast)
        {
            OnBreakfastDishChange?.Invoke(this, breakfast); 
        }

        protected virtual void OnOnDinnerDishChange(Dinner dinner)
        {
            OnDinnerDishChange?.Invoke(this, dinner);   
        }

        protected virtual void OnOnSupperDishChange(Supper supper)
        {
            OnSupperDishChange?.Invoke(this, supper);   
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