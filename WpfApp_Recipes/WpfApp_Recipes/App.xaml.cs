using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Recipes.Models;

namespace WpfApp_Recipes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Единый контекст базы данных, который будет доступен из любой точки приложения (из любой странички Page, например).
        /// </summary>
        public static CourseRecipesEntities DBContext { get; set; }
    }
}
