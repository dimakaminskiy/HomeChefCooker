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
                Days[i] = new CookingDay(DateTime.Now.AddDays(i));
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
