using System;
using System.Collections.Generic;
using WinHomeMeal;

namespace BusinessLogic.Logic
{
    public class ChiefCooker
    {
        public delegate void CreatedMenu();
        public event CreatedMenu OnCreatedMenu;
        public List<CookingDay> Days { get; set;}
       
        private readonly int _maxDays = 14;
        public ChiefCooker()
        {
            Days = new List<CookingDay>();
            InitializeDays();
        }

        private void InitializeDays()
        {
            var data = DateTime.Now;
            var culture = new System.Globalization.CultureInfo("ru-ru");
            for (int i = 0; i < _maxDays; i++)
            {

                var day = new CookingDay(i+1)
                {
                    Number = data.Day,
                    Name = culture.DateTimeFormat.GetShortestDayName(data.DayOfWeek)
                };

                if (day.Name != "Cб" && day.Name != "Вс")
                {
                    day.IsWeekDay = false;
                }
                else
                {
                    day.IsWeekDay = true;
                }

                Days.Add(day);
                data = data.AddDays(1);
            }
         }


        private void _createMenu(string desertDayOfWeek,  int countMeat, int countFish)
        {
            
        }


        public void CreateMenu()
        {
            _createMenu("Понедельник", 2,1);
            OnOnCreatedMenu();
        }

        public void WriteToExel(string path)
        {

        }

        protected virtual void OnOnCreatedMenu()
        {
            OnCreatedMenu?.Invoke();
        }
    }




}
