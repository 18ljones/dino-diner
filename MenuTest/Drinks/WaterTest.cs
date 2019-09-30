using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // the correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }
        // the correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }
        // the correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }
        // the correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }
        // correct default lemon
        [Fact]
        public void HasCorrectDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }
        // correct calories after setting small
        [Fact]
        public void HasCorrectCaloriesSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }
        // correct price after setting small
        [Fact]
        public void HasCorrectPriceSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }
        // correct calories after setting medium
        [Fact]
        public void HasCorrectCaloriesMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }
        // correct price after setting medium
        [Fact]
        public void HasCorrectPriceMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }
        // correct calories setting large
        [Fact]
        public void HasCorrectCaloriesLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }
        // correct price after setting large
        [Fact]
        public void HasCorrectPriceLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }
        // invoke HoldIce()
        [Fact]
        public void HasCorrectHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        // invoke AddLemon()
        [Fact]
        public void HasCorrectAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
        // correct ingredients
        [Fact]
        public void ShouldListIngredients()
        {
            Water w = new Water();
            w.AddLemon();
            List<string> ingredients = w.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
