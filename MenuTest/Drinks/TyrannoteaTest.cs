using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // the correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<uint>(8, t.Calories);
        }
        // the correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<double>(0.99, t.Price);
        }
        // the correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.True(t.Ice);
        }
        // the correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, t.Size);
        }
        // correct default lemon
        [Fact]
        public void HasCorrectDefaultLemon()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Lemon);
        }
        // correct default sweet
        [Fact]
        public void HasCorrectDefaultSweet()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Sweet);
        }
        // correct calories after setting small
        [Fact]
        public void HasCorrectCaloriesSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
        }
        // correct price after setting small
        [Fact]
        public void HasCorrectPriceSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<double>(0.99, t.Price);
        }
        // correct calories after setting medium
        [Fact]
        public void HasCorrectCaloriesMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }
        // correct price after setting medium
        [Fact]
        public void HasCorrectPriceMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<double>(1.49, t.Price);
        }
        // correct calories setting large
        [Fact]
        public void HasCorrectCaloriesLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        // correct price after setting large
        [Fact]
        public void HasCorrectPriceLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<double>(1.99, t.Price);
        }
        // invoking HoldIce()
        [Fact]
        public void HasCorrectHoldIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        // invoking AddLemon()
        [Fact]
        public void HasCorrectAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.Lemon);
        }
        // adding sweetener with small size
        [Fact]
        public void HasCorrectCaloriesSweetSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            t.Sweet = true;
            Assert.Equal<uint>(16, t.Calories);
        }
        // adding sweetener with medium size
        [Fact]
        public void HasCorrectCaloriesSweetMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Sweet = true;
            Assert.Equal<uint>(32, t.Calories);
        }
        // adding sweetener with large size
        [Fact]
        public void HasCorrectCaloriesSweetLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Sweet = true;
            Assert.Equal<uint>(64, t.Calories);
        }
        // removing sweetener with small size
        [Fact]
        public void HasCorrectCaloriesRemoveSweetSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            t.Sweet = true;
            t.Sweet = false;
            Assert.Equal<uint>(8, t.Calories);
        }
        // removing sweetener with medium size
        [Fact]
        public void HasCorrectCaloriesRemoveSweetMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Sweet = true;
            t.Sweet = false;
            Assert.Equal<uint>(16, t.Calories);
        }
        // removing sweetener with large size
        [Fact]
        public void HasCorrectCaloriesRemoveSweetLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Sweet = true;
            t.Sweet = false;
            Assert.Equal<uint>(32, t.Calories);
        }
        // correct ingredients
        [Fact]
        public void ShouldListIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            t.AddLemon();
            List<string> ingredients = t.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }
    }
}
