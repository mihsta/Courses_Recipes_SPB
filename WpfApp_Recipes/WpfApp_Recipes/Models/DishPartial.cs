using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Recipes.Models
{
    /// <summary>
    /// Это частичка (partial) основного класса Dish. 
    /// Заметьте, что названия классов совпадают = Dish, а каждый класс при этом помечен как публичный (public) и частичный (partial).
    /// Из каждой частички класса мы можем получить доступ к свойствам любой другой части, так как класс все-таки один - он просто расположен в разных файлах :)
    /// Полезно использовать такой способ разделения на 2 файла для добавления своих свойств в том случае, если планируется обновление модели данных (EF) из-за обновления СТРУКТУРЫ базы данных (но не самих данных в таблицах).
    /// 
    /// P.S.: обещала показать как безболезненно обновлять модель, но не успела во время наших занятий)
    /// </summary>
    public partial class Dish
    {
        public string ImagePath
        {
            get
            {
                //return @"C:\Users\annet_000\Downloads\imagetest\" + Image;
                return @"DishImages/" + Image;
            }
        }

        public double PricePerServing
        {
            get
            {
                List<IngredientOfStage> listIngredientsOfStage = CookingStages.SelectMany(x => x.IngredientOfStages).ToList();
                double sumAllServings = listIngredientsOfStage.Sum(x => (double)x.Quantity * x.Ingredient.Price);
                return sumAllServings / ServingQuantity;
            }
        }

        public int FullTime
        {
            get
            {
                return (int)CookingStages.Sum(x => x.TimeInMinutes);
            }
        }

        public double CostPerUserServings => UserServings * PricePerServing;

        public int UserServings { get; set; }

        // public List<IngredientForDish> ListIngredients { get; set; }
        public List<IngredientForDish> ListIngredients
        {
            get
            {
                var listResult = new List<IngredientForDish>();
                var list = CookingStages.SelectMany(x => x.IngredientOfStages).GroupBy(x => x.Ingredient).ToList();
                foreach (var group in list)
                {
                    IngredientForDish ingredientForDish = new IngredientForDish
                    {
                        Ingredient = group.Key,
                        SummaryBaseQuantity = group.Sum(x => x.Quantity),
                        Dish = this
                    };

                    listResult.Add(ingredientForDish);
                }

                return listResult;
            }
        }

        public bool IsAllEnough => ListIngredients.All(x => x.IsEnough == true);

        public void SetOrders()
        {
            int order = 1;
            foreach (var stage in CookingStages)
            {
                stage.OrderNumber = order++;
            }
        }

        //public void SetListIngredients()
        //{
        //    ListIngredients = new List<IngredientForDish>();
        //    var list = CookingStages.SelectMany(x => x.IngredientOfStages).GroupBy(x => x.Ingredient).ToList();
        //    foreach (var group in list)
        //    {
        //        IngredientForDish ingredientForDish = new IngredientForDish
        //        {
        //            Ingredient = group.Key,
        //            SummaryBaseQuantity = group.Sum(x => x.Quantity),
        //            Dish=this
        //        };

        //        ListIngredients.Add(ingredientForDish);
        //    }
        //}
    }
}
