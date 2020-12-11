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
    /// Interaction logic for PageDishes.xaml
    /// </summary>
    public partial class PageDishes : Page
    {
        public PageDishes()
        {
            InitializeComponent();

            CourseRecipesEntities context = new CourseRecipesEntities();
            CmbCategories.ItemsSource = context.Categories.ToList();

            // Заполняем таблицу блюд данными из БД
            //DGridDishes.ItemsSource = context.Dishes.ToList();
            LViewDishes.ItemsSource = context.Dishes.ToList();
        }

        private void CmbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
