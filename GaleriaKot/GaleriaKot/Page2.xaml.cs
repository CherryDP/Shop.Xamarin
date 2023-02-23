using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GaleriaKot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
             InitializeComponent();
             AddToolbarItems();
            

            List<MenuWendy> menuItems = new List<MenuWendy>()
            {
                new MenuWendy()
                {
                    Name = "Zinger Burger",
                    Description = "Zinger Burger Meal with fries and drink",
                    Price = "$7.99",
                    
                },

                 new MenuWendy()
                {
                    Name = "Popcorn Chicken",
                    Description = "Bucket of Popcorn Chicken with fries and drink",
                    Price = "$10.99",
                    
                },
                new MenuWendy()
                {
                    Name = "Twister",
                    Description = "Twister Wrap Meal with fries and drink",
                    Price = "$8.49",
                    
                },
                new MenuWendy()
                {
                    Name = "Fillet Burger",
                    Description = "Fillet Burger",
                     Price = "$6.99",
                    
                },
                new MenuWendy()
                {
                    Name = "Mighty Bucket",
                    Description = "Mighty Bucket Meal with fries and drink",
                    Price = "$12.99",
                    
                },
                new MenuWendy()
                {
                    Name = "BBQ Wrap",
                    Description = "BBQ Wrap Meal with fries and drink",
                    Price = "$8.99",
                    
                },
                new MenuWendy()
                {
                    Name = "Original Recipe Chicken",
                    Description = "Original Recipe Chicken Meal with fries and drink",
                    Price = "$9.99",
                    
                },
            };

            // Set the collection as the source of the collection view
            MenuCollection.ItemsSource = menuItems;
        }
        
        private void MenuCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Navigate to the detail page for the selected item
            MenuItem selectedItem = (MenuItem)e.CurrentSelection[0];
            Navigation.PushAsync(new WendyMenuItemDetailPage(selectedItem));
            MenuCollection.SelectedItem = null;
        }
        private void AddToolbarItems()
        {
            ToolbarItem homeItem = new ToolbarItem
            {
                Text = "Strona główna",
                Order = ToolbarItemOrder.Primary,
                Priority = 0
            };
            homeItem.Clicked += async (sender, e) =>
            {
                await Navigation.PopToRootAsync();
            };
            ToolbarItems.Add(homeItem);
        }

        private void MenuItemCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox != null)
            {
                var menuWendy = checkbox.BindingContext as MenuWendy;
                if (menuWendy != null)
                {
                    menuWendy.IsSelected = e.Value;
                }
            }
        }
    }
}