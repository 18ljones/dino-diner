using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class representing a Combo
    /// </summary>
    public class CretaceousCombo
    {
        /// <summary>
        /// represents the Entree in the combo
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// represents the Drink in the combo
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// represents the Side in the combo
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// represnets the toy in the combo
        /// </summary>
        public string Toy { get; private set; }

        /// <summary>
        /// repsents the total cost of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return (Entree.Price + Side.Price + Drink.Price) - 0.25;
            }
        }

        /// <summary>
        /// represents the total calories in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// represents all the ingredients used to make this combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for a CrestaceousCombo
        /// </summary>
        /// <param name="entree">the entree</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Toy = "PS4";
        }
    }
}
