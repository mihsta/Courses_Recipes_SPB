using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Recipes.Models
{
    public class IngredientForDish
    {
        public Ingredient Ingredient { get; set; }
        public Dish Dish { get; set; }
        public double SummaryBaseQuantity { get; set; }
        public double TotalQuantity => ((double)Dish.UserServings / Dish.ServingQuantity) * SummaryBaseQuantity;
        public bool IsEnough => TotalQuantity <= Ingredient.AvailableCount;
        public double Sum => TotalQuantity * Ingredient.Price;
    }
}
