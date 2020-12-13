using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Recipes.Models
{
    /// <summary>
    /// Это частичка (partial) основного класса Ingredient. 
    /// Заметьте, что названия классов совпадают = Ingredient, а каждый класс при этом помечен как публичный (public) и частичный (partial).
    /// Из каждой частички класса мы можем получить доступ к свойствам любой другой части, так как класс все-таки один - он просто расположен в разных файлах :)
    /// Полезно использовать такой способ разделения на 2 файла для добавления своих свойств в том случае, если планируется обновление модели данных (EF) из-за обновления СТРУКТУРЫ базы данных (но не самих данных в таблицах).
    /// 
    /// P.S.: обещала показать как безболезненно обновлять модель, но не успела во время наших занятий)
    /// </summary>
    public partial class Ingredient : INotifyPropertyChanged
    {
        private double countNotify;

        public double Price
        {
            get
            {
                return Cost / CostForCount;
            }
        }

        public double AvailableCost => Price * AvailableCount;

        public double CountNotify
        {
            get
            {
                return AvailableCount;
            }

            set
            {
                countNotify = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
