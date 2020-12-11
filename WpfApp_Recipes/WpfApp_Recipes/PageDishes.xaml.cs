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
        CourseRecipesEntities context;
        public PageDishes()
        {
            InitializeComponent();

            context = new CourseRecipesEntities();
            FillCombobox();

            // Заполняем таблицу блюд данными из БД
            //DGridDishes.ItemsSource = context.Dishes.ToList();

            UpdateTable();
        }

        private void FillCombobox()
        {
            List<Category> listCategories = context.Categories.ToList();
            Category allCat = new Category();
            allCat.Name = "Все категории";
            listCategories.Insert(0, allCat);
            CmbCategories.ItemsSource = listCategories;
        }

        private void UpdateTable()
        {
            List<Dish> listDishes = context.Dishes.ToList();

            if (CmbCategories.SelectedIndex > 0)
            {
                var category = CmbCategories.SelectedItem as Category;
                listDishes = listDishes.Where(x => x.Category == category).ToList();
            }

            string text = TxtSearch.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(text))
            {
                listDishes = listDishes.Where(x => x.Name.ToLower().Contains(text)).ToList();
            }

            LViewDishes.ItemsSource = listDishes;
        }

        private void CmbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTable();
        }
    }
}
