//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp_Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.CookingStages = new HashSet<CookingStage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ServingQuantity { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string RecipeLink { get; set; }



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


        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CookingStage> CookingStages { get; set; }
    }
}
