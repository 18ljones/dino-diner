using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; set; } = new Menu();
        public List<MenuItem> MenuItems { get; private set; }   

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        public void OnGet()
        {
            MenuItems = Menu.AllMenuItems;
        }

        public void OnPost()
        {
            MenuItems = Menu.AllMenuItems;


            if (search != null)
            {
                MenuItems = Menu.OnSearch(MenuItems, search);
            }


            if (menuCategory.Count > 0)
            {
                MenuItems = OnCategoryFilter(MenuItems, menuCategory);
            }
            
            if(minimumPrice is float min && maximumPrice is float max)
            {
                MenuItems = Menu.OnPriceFilter(MenuItems, min, max);
            }
            else if(minimumPrice is float mini)
            {
                MenuItems = Menu.OnPriceFilter(MenuItems, mini, "min");
            }
            else if(maximumPrice is float maxi)
            {
                MenuItems = Menu.OnPriceFilter(MenuItems, maxi, "max");
            }

            if(excludedIngredients.Count > 0)
            {
                MenuItems = Menu.OnIngredientFilter(MenuItems, excludedIngredients);
            }

        }

        //for some reason my sides and drinks won't show up if I use this statically
        //from the menu class...I don't know why I am having this issue
        public static List<MenuItem> OnCategoryFilter(List<MenuItem> menuItems, List<string> filters)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (MenuItem j in menuItems)
            {
                if (filters.Contains("Combo"))
                {
                    if (j is CretaceousCombo combo)
                    {
                        items.Add(combo);
                    }
                }
                if (filters.Contains("Entree"))
                {
                    if (j is Entree entree)
                    {
                        items.Add(entree);
                    }
                }
                if (filters.Contains("Side"))
                {
                    if (j is Side side)
                    {
                        items.Add(side);
                    }
                }
                if (filters.Contains("Drink"))
                {
                    if (j is Drink drink)
                    {
                        items.Add(drink);
                    }
                }
            }

            return items;
        }
    }
}