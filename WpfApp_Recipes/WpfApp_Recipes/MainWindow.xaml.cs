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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Загляните в файлик App.xaml, чтобы понять, откуда взялся этот DBContext.
            App.DBContext = new Models.CourseRecipesEntities();

            MainFrame.Navigate(new PageDishes());
        }

        private void BtnDishes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageDishes());
        }

        private void BtnIngredients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageIngredients());
        }
    }
}
