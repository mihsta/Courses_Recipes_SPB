﻿using System;
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
    /// Interaction logic for PageCooking.xaml
    /// </summary>
    public partial class PageCooking : Page
    {
        Dish currentDish;
        CookingStage currentStage;

        List<CookingStage> listPreviousStages = new List<CookingStage>();
        List<CookingStage> listNextStages = new List<CookingStage>();

        int stage;

        public PageCooking(Dish dish)
        {
            InitializeComponent();

            currentDish = dish;
            Title = $"Приготовление блюда \"{dish.Name}\"";

            stage = 1;
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            currentStage = currentDish.CookingStages.ElementAt(stage-1);

            listPreviousStages = currentDish.CookingStages.Take(stage - 1).ToList();
            listNextStages = currentDish.CookingStages.Skip(stage).ToList();


            LViewPreviousStages.ItemsSource = listPreviousStages;
            LblStage.Text = stage.ToString();
            LblTimeOfStage.Text = currentStage.TimeInMinutes.ToString() + " мин";
            DGridIngredients.ItemsSource = currentStage.IngredientOfStages.ToList();
            LblCookingDescription.Text = currentStage.Description;
            LViewNextStages.ItemsSource = listNextStages;


            if (stage > 1)
                BtnBack.IsEnabled = true;
            else
                BtnBack.IsEnabled = false;

            if (stage == currentDish.CookingStages.Count)
                BtnNext.IsEnabled = false;
            else
                BtnNext.IsEnabled = true;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            stage--;
            UpdateInfo();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            stage++;
            UpdateInfo();
        }
    }
}
