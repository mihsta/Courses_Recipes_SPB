//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp_Recipes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CookingStage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CookingStage()
        {
            this.IngredientOfStages = new HashSet<IngredientOfStage>();
        }
    
        public int Id { get; set; }
        public int DishId { get; set; }
        public string Description { get; set; }
        public Nullable<int> TimeInMinutes { get; set; }
    
        public virtual Dish Dish { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientOfStage> IngredientOfStages { get; set; }
    }
}
