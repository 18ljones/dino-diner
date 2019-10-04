using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// public class fof JurrasicJava
    /// </summary>
    public class JurassicJava : Drink
    {
        private Size size;
        /// <summary>
        /// specifies whether the is room for cream
        /// </summary>
        public bool RoomForCream { get; set; }
        /// <summary>
        /// specifies whether it is decaf
        /// </summary>
        public bool Decaf { get; set; }
        /// <summary>
        /// default constuctor for JurrasicJava
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
            Decaf = false;
            RoomForCream = false;
        }

        /// <summary>
        /// specifies the size and sets other values accordingly
        /// </summary>
        public override Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// returns the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            if(Decaf) return Size.ToString() + " Decaf Jurassic Java";
            else return Size.ToString() + " Jurassic Java";
        }


        /// <summary>
        /// leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// adds ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
