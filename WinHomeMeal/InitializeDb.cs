﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Repository.implementation;

namespace WinHomeMeal
{
   public class InitializerDb
    {
        public UnitOfWork DataManager { get; set; }

        public InitializerDb(UnitOfWork dataManager)
        {
            DataManager = dataManager;
        }
        public void Run()
        {

           

            InitializeCategoryRepository();
            InitializeMeasureRepository();
            InitializeProductRepository();
            DataManager.Save();
            InitializeDishRepository();
           
        }


       public void InitializeDishRepository()
       {
           var dish = new Dish();
            var categories = DataManager.CategoryRepository.Get();
           dish.CategoryId = DataManager.CategoryRepository.Get().First().Id;
           dish.Name = "Тест";
            DataManager.Save();
            DataManager.DishRepository.Insert(dish);
           dish.Ingredients = new List<Ingredient>();
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});
           dish.Ingredients.Add(new Ingredient() {MeasureId = 1, ProductId = 1, Value = 0, DishId = dish.Id});

            DataManager.Save();

        }






       private void InitializeMeasureRepository()
        {
           DataManager.MeasureRepository.Insert(new Measure() { Name = "------" });
           DataManager.MeasureRepository.Insert(new Measure() { Name = "шт" });
           DataManager.MeasureRepository.Insert(new Measure() { Name = "г." });
           DataManager.MeasureRepository.Insert(new Measure() { Name = "чайная ложка" });
           DataManager.MeasureRepository.Insert(new Measure() { Name = "столовая ложка" });
        }
        private void InitializeProductRepository()
        {
            var lines = System.IO.File.ReadAllLines(@"Продукты.txt", Encoding.UTF8).ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length - 1; j++)
                {
                    if (needToReOrder(lines[j], lines[j + 1]))
                    {
                        string s = lines[j];
                        lines[j] = lines[j + 1];
                        lines[j + 1] = s;
                    }
                }
            }

            DataManager.ProductRepository.Insert(new Product() { Name = "------" });

            foreach (string line in lines)
            {
                DataManager.ProductRepository.Insert( new Product() {Name = line});
            }
        

        }
        protected static bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
        private void InitializeCategoryRepository()
       {
           string[] categories = { "------", "Завтрак","Первые блюда", "Вторые блюда", "Мясное", "Рыба", "Десерт","Разное"};

           foreach (var category in categories)
           {
                DataManager.CategoryRepository.Insert( new Category() {Name = category});
            }
       }

    }
}
