using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Recipes.Models
{
    /// <summary>
    /// Это частичка (partial) основного класса IngredientOfStage. 
    /// Заметьте, что названия классов совпадают = IngredientOfStage, а каждый класс при этом помечен как публичный (public) и частичный (partial).
    /// Из каждой частички класса мы можем получить доступ к свойствам любой другой части, так как класс все-таки один - он просто расположен в разных файлах :)
    /// Полезно использовать такой способ разделения на 2 файла для добавления своих свойств в том случае, если планируется обновление модели данных (EF) из-за обновления СТРУКТУРЫ базы данных (но не самих данных в таблицах).
    /// 
    /// P.S.: обещала показать как безболезненно обновлять модель, но не успела во время наших занятий)
    /// </summary>
    public partial class IngredientOfStage
    {
        public double TotalQuantity => CookingStage.Dish.UserServings / CookingStage.Dish.ServingQuantity * Quantity;
    }
}
