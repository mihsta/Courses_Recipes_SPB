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
    /// Interaction logic for PageCurrentDish.xaml
    /// </summary>
    public partial class PageCurrentDish : Page
    {
        Dish currentDish;
        public PageCurrentDish(Dish dish)
        {
            InitializeComponent();

            currentDish = dish;
            currentDish.UserServings = currentDish.ServingQuantity;
            currentDish.SetOrders();
            //currentDish.SetListIngredients();

            Title = $"Рецепт для \"{dish.Name}\"";
        }

        private void UpdateInfo()
        {
            LblCategory.Content = "Категория: " + currentDish.Category.Name;
            LblFullTime.Content = $"Время на приготовление: {currentDish.FullTime} мин.";
            LblTotalCost.Content = $"Общая стоимость: {currentDish.CostPerUserServings:F0} руб.";

            TxtServings.Text = currentDish.UserServings.ToString();

            BtnMinus.IsEnabled = currentDish.UserServings > 0;

            LViewStages.ItemsSource = currentDish.CookingStages.ToList();

            DGridIngredients.ItemsSource = null;
            DGridIngredients.ItemsSource = currentDish.ListIngredients;
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (currentDish.UserServings >= currentDish.ServingQuantity)
                currentDish.UserServings -= currentDish.ServingQuantity;
            else
                currentDish.UserServings = 0;

            UpdateInfo();
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            currentDish.UserServings += currentDish.ServingQuantity;

            UpdateInfo();
        }

        private void BtnStartCooking_Click(object sender, RoutedEventArgs e)
        {
            if (!currentDish.IsAllEnough)
            {
                var result = MessageBox.Show("Ингредиентов на такое количество порций не хватает!\nИмейте в виду, что вам придется идти в магазин :)", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Cancel)
                    return;
            }
            NavigationService.Navigate(new PageCooking(currentDish));
        }

        private void TxtServings_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(TxtServings.Text, out int result) && result >= 0)
            {
                currentDish.UserServings = result;
                TxtServings.Foreground = Brushes.Black;
                UpdateInfo();
            }
            else
            {
                TxtServings.Foreground = Brushes.DarkRed;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateInfo();
        }
    }
}
