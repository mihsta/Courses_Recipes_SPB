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
        public PageIngredients()
        {
            InitializeComponent();

            CourseRecipesEntities context = new CourseRecipesEntities();
            LViewIngredients.ItemsSource = context.Ingredients.ToList();
        }

        private void HLinkDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BorderNewIngredient_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
