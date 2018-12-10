using System;
using System.Collections.Generic;
using MealPlanner.Models;
using Xamarin.Forms;

namespace MealPlanner.Pages
{
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems { get; set; }

        public MainMenu()
        {
            // Set the binding context to this code behind.
            BindingContext = this;

            // Build the Menu
            MainMenuItems = new List<MainMenuItem>()
            { 
                new MainMenuItem() { Title = "Schedule", Icon = "menu_inbox.png", TargetType = typeof(Schedule) },
                new MainMenuItem() { Title = "Edit schedule", Icon = "menu_stock.png", TargetType = typeof(ScheduleEdit) },
                new MainMenuItem() { Title = "Meals list", Icon = "menu_stock.png", TargetType = typeof(MealList) },
                new MainMenuItem() { Title = "Items list", Icon = "menu_stock.png", TargetType = typeof(ItemList) }
            };

            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new Schedule());

            InitializeComponent();
        }

        // When a MenuItem is selected.
        public void MainMenuItem_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuItem = e.SelectedItem as MainMenuItem;
            if (menuItem != null)
            {
                if (menuItem.Title.Equals("Schedule"))
                {
                    Detail = new NavigationPage(new Schedule());
                }
                else if (menuItem.Title.Equals("Edit schedule"))
                {
                    Detail = new NavigationPage(new ScheduleEdit());
                }
                else if (menuItem.Title.Equals("Meals list"))
                {
                    Detail = new NavigationPage(new MealList());
                }
                else if (menuItem.Title.Equals("Items list"))
                {
                    Detail = new NavigationPage(new ItemList());
                }
                MenuListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
