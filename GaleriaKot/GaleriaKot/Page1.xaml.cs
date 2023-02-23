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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            
            InitializeComponent();
            AddToolbarItems();
            

        List<MenuWendy> menuItems = new List<MenuWendy>()
            {
                new MenuWendy()
                {
                    Name = "Baconator",
                    Description = "Two 1/4 lb* patties topped with 6 strips of crispy Applewood smoked bacon, 2 slices of American cheese, 2 crispy onion rings, and creamy mayo.",
                    Price = "$8.99",

                },

                 new MenuWendy()
                {
                    Name = "Dave's Single",
                    Description = "A quarter-pound* of fresh, never frozen beef, Applewood smoked bacon, American cheese, crisp lettuce, tomato, pickle, ketchup, mayo, and onion on a toasted bun.",
                    Price = "$6.49",

                },
                new MenuWendy()
                {
                    Name = "Spicy Chicken Sandwich",
                    Description = "A juicy chicken breast marinated and breaded in our unique, fiery blend of peppers and spices taken to the next level with pickled jalapeños, Applewood smoked bacon, American cheese, crispy fried onions, a savory cheese sauce and a smoky jalapeño sauce. ",
                    Price = "$7.99",

                },
                new MenuWendy()
                {
                     Name = "Homestyle Chicken Sandwich",
                    Description = "A juicy, lightly breaded chicken breast, crisp lettuce and tomato, and just enough mayo, all on a toasted bun.",
                    Price = "$7.19",

                },
                new MenuWendy()
                {
                    Name = "Dave's Double",
                    Description = "Double the fresh beef* and double the other fresh, delicious ingredients, including Applewood smoked bacon, made Dave’s Double® the Dave’s most deluxe hamburger ever.",
                    Price = "$8.49",

                },
                new MenuWendy()
                {
                    Name = "10 PC Spicy Nuggs",
                    Description = "10 Piece Spicy Chicken Nuggets made with all white-meat chicken, lightly breaded and seasoned with bold flavors. Try them now with your choice of dipping sauce.",
                    Price = "$5.49",

                },
                new MenuWendy()
                {
                    Name = "Classic Chicken Nuggets",
                    Description = "All-white meat chicken nuggets, lightly breaded and seasoned to perfection. Dip them in any (or all) of our delicious dipping sauces.",
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

                    qwe.Text = menuWendy.Name;
                }

            }
        }
    }
}