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
    /// Interaction logic for PageIngredients.xaml
    /// </summary>
    public partial class PageIngredients : Page
    {
        CourseRecipesEntities context;
        public PageIngredients()
        {
            InitializeComponent();

            context = new CourseRecipesEntities();

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

            LViewIngredients.ItemsSource = context.Ingredients.ToList();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            //LViewIngredients.ItemsSource = context.Ingredients.ToList();
            LblFridgeCost.Text = context.Ingredients.ToList().Sum(x => x.AvailableCost).ToString("F0");
        }

        private void HLinkDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            var ingr = (sender as Button).DataContext as Ingredient;
            ingr.AvailableCount++;
            context.SaveChanges();
            UpdateInfo();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            var ingr = (sender as Button).DataContext as Ingredient;
            ingr.AvailableCount--;
            context.SaveChanges();
            UpdateInfo();
        }

        private void BorderNewIngredient_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
