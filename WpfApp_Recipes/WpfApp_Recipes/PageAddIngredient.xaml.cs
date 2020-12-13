using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_Recipes.Models;

namespace WpfApp_Recipes
{
    /// <summary>
    /// Interaction logic for PageAddIngredient.xaml
    /// </summary>
    public partial class PageAddIngredient : Page
    {
        public PageAddIngredient()
        {
            InitializeComponent();

            CmbUnit.ItemsSource = App.DBContext.Units.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Ingredient ingr = new Ingredient();

            ingr.Name = TxtName.Text;

            bool convertCost = int.TryParse(TxtPrice.Text, out int resultCost);
            if (convertCost == true)
                ingr.Cost = resultCost;
            else
            {
                MessageBox.Show("Неправильная цена");
                return;
            }

            bool convertCount = double.TryParse(TxtForCount.Text, out double resultCount);
            if (convertCount == true)
                ingr.CostForCount = resultCount;
            else
            {
                MessageBox.Show("Неправильное количество");
                return;
            }

            bool convertAvailable = double.TryParse(TxtForCount.Text, out double resultAvailable);
            if (convertAvailable == true)
                ingr.AvailableCount = resultAvailable;
            else
            {
                MessageBox.Show("Неправильный холодильник");
                return;
            }

            var unit=CmbUnit.SelectedItem as Unit;
            ingr.Unit = unit;
            //ingr.UnitId = unit.Id;


            App.DBContext.Ingredients.Add(ingr);
            App.DBContext.SaveChanges();

            NavigationService.GoBack();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
