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
    /// Interaction logic for PageIngredients.xaml
    /// </summary>
    public partial class PageIngredients : Page
    {
        public PageIngredients()
        {
            InitializeComponent();

            //var context = new CourseRecipesEntities();

            // Add
            //Category newCat = new Category();
            //newCat.Name = "REMOVE ME";
            //context.Categories.Add(newCat);
            //context.SaveChanges();

            // Edit
            //Category editCat= context.Categories.Where(x => x.Id == 20).FirstOrDefault();
            //if (editCat != null)
            //    editCat.Name = "DON'T REMOVE ME PLEASE";
            //context.SaveChanges();

            // Delete
            //Category deleteCat = context.Categories.Where(x => x.Id == 20).FirstOrDefault();
            //if (deleteCat != null)
            //    context.Categories.Remove(deleteCat);
            //context.SaveChanges();
        }

        private void UpdateLabel()
        {
            LblFridgeCost.Text = App.DBContext.Ingredients.ToList().Sum(x => x.AvailableCost).ToString("F0");
        }

        private void UpdateTable()
        {
            LViewIngredients.ItemsSource = App.DBContext.Ingredients.ToList();
        }

        private void HLinkDelete_Click(object sender, RoutedEventArgs e)
        {
            var ingr = (sender as Hyperlink).DataContext as Ingredient;

            if (ingr.IngredientOfStages.Count > 0)
            {
                MessageBox.Show("Не трожь! Ингредиент нам еще нужен");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Точно хотите удалить?", "Разрешение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DBContext.Ingredients.Remove(ingr);
                App.DBContext.SaveChanges();
                UpdateLabel();
                UpdateTable();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            var ingr = (sender as Button).DataContext as Ingredient;
            ingr.AvailableCount++;
            ingr.CountNotify = ingr.AvailableCount;
            App.DBContext.SaveChanges();
            UpdateLabel();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            var ingr = (sender as Button).DataContext as Ingredient;
            ingr.AvailableCount--;
            ingr.CountNotify = ingr.AvailableCount;
            App.DBContext.SaveChanges();
            UpdateLabel();
        }

        private void BorderNewIngredient_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PageAddIngredient());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateLabel();
            UpdateTable();
        }

        private void TxtAvailableCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txtAvailable = sender as TextBox;
            var ingr = txtAvailable.DataContext as Ingredient;
            if (double.TryParse(txtAvailable.Text, out double result))
            {
                ingr.AvailableCount = result;
                ingr.CountNotify = ingr.AvailableCount;
                App.DBContext.SaveChanges();
                UpdateLabel();
            }
        }
    }
}
