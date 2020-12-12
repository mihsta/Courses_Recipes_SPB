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

namespace WpfApp_Recipes
{
    /// <summary>
    /// Interaction logic for PageCurrentDish.xaml
    /// </summary>
    public partial class PageCurrentDish : Page
    {
        Dish currentDish;
        public PageCurrentDish(Dish dish)
        {
            InitializeComponent();

            currentDish = dish;
            currentDish.SetOrders();

            Title =$"Рецепт для \"{dish.Name}\"";
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            LblCategory.Content = "Категория: "+currentDish.Category.Name;
            LblFullTime.Content = $"Время на приготовление: {currentDish.FullTime} мин.";
            LblTotalCost.Content = $"Общая стоимость: {currentDish.PricePerServing*currentDish.ServingQuantity:F0} руб.";
            //
            TxtServices.Text = currentDish.ServingQuantity.ToString();

            LViewStages.ItemsSource = currentDish.CookingStages.ToList();
            DGridIngredients.ItemsSource = currentDish.CookingStages.SelectMany(x => x.IngredientOfStages).ToList();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStartCooking_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCooking(currentDish));
        }
    }
}
