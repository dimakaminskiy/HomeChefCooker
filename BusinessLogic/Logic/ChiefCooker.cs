using System;
using System.Collections.Generic;
using WinHomeMeal;

namespace BusinessLogic.Logic
{
    public class ChiefCooker
    {
        public delegate void CreatedMenu();
        public event CreatedMenu OnCreatedMenu;

        public delegate void CountMeatDayChangeEventHandler(int value);
        public event CountMeatDayChangeEventHandler OnCountMeatDayChangeEventHandler;

        public delegate void CountFishDayChangeEventHandler(int value);
        public event CountFishDayChangeEventHandler OnCountFishDayChangeEventHandler;

        public CookingDay[] Days { get; private set;}
        public int CountFishDays        
        {
            get { return _countFishDays; }
            set
            {
                if (value < 0) value = 0;
                _countFishDays = value;
                OnOnCountFishDayChangeEventHandler(value);
            }
        }
        public int CountMeatDay
        {
            get { return _countMeatDay; }
            set
            {
                if (value < 0) value = 0;
                _countMeatDay = value;
                OnOnCountMeatDayChangeEventHandler(value);
            }
        }

        private readonly int _maxDays = 14;
        private int _countMeatDay;
        private int _countFishDays;

        public ChiefCooker()
        {
            Days = new CookingDay[_maxDays];

            for (int i = 0; i < _maxDays; i++)
            {
                Days[i] = new CookingDay(i+1);
            }


            _countMeatDay = 0;
            _countFishDays = 0;
          
        }

        public  void InitializeDays()
        {
            var data = DateTime.Now;
            var culture = new System.Globalization.CultureInfo("ru-ru");
            for (int i = 0; i < _maxDays; i++)
            {
                var day = Days[i];
                day.Name = culture.DateTimeFormat.GetShortestDayName(data.DayOfWeek);
                day.Number = data.Day;
                day.Mounth= culture.DateTimeFormat.GetMonthName(data.Month);

                //= new CookingDay(i+1)
                //{
                //    Number = data.Day,
                //    Name = culture.DateTimeFormat.GetShortestDayName(data.DayOfWeek)
                //};

                if (day.Name != "Cб" && day.Name != "Вс")
                {
                    day.IsWeekDay = false;
                }
                else
                {
                    day.IsWeekDay = true;
                }

              //  Days.Add(day);
                data = data.AddDays(1);
            }
         }


        private void _createMenu()
        {
            
        }


        public void CreateMenu()
        {
           
            OnOnCreatedMenu();
        }

        public void WriteToExel(string path)
        {

        }

        protected virtual void OnOnCreatedMenu()
        {
            OnCreatedMenu?.Invoke();
        }

        protected virtual void OnOnCountMeatDayChangeEventHandler(int value)
        {
            OnCountMeatDayChangeEventHandler?.Invoke(value);    
        }

        protected virtual void OnOnCountFishDayChangeEventHandler(int value)
        {
            OnCountFishDayChangeEventHandler?.Invoke(value);    
        }
    }




}
