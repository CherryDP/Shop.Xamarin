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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            AddToolbarItems();


            List<MenuWendy> menuItems = new List<MenuWendy>()
            {
                new MenuWendy()
                {
                    Name = "Big Mac",
                    Description = "Two all-beef patties, special sauce, lettuce, cheese, pickles, onions on a sesame seed bun",
                    Price = "$3.99",

                },

                 new MenuWendy()
                {
                    Name = "Quarter Pounder with Cheese",
                    Description = "A quarter-pound of 100% pure beef, topped with cheese, onions, pickles, ketchup, and mustard on a toasted sesame seed bun",
                    Price = "$4.99",

                },
                new MenuWendy()
                {
                    Name = "McChicken",
                    Description = "A tender and juicy chicken patty, crisp lettuce and mayonnaise, all served on a toasted bun",
                    Price = "$ 2.99",

                },
                new MenuWendy()
                {
                    Name = "Filet-O-Fish",
                    Description = "Wild-caught Alaska Pollock fillet, topped with melted American cheese and creamy tartar sauce, and served on a soft, steamed bun",
                     Price = "3.49",

                },
                new MenuWendy()
                {
                    Name = "Fries",
                    Description = "World famous fries, golden on the outside, soft and fluffy on the inside",
                    Price = "$1.99",

                },
                new MenuWendy()
                {
                    Name = "Apple Pie",
                    Description = "Warm, crispy and flaky crust, with delicious cinnamon-spiced apples inside",
                    Price = "$1.49",

                },
                new MenuWendy()
                {
                    Name = "McFlurry",
                    Description = "Creamy vanilla soft serve, mixed with your favorite candy or cookie pieces",
                    Price = "$2.49",

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