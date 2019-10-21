/* IOrderItemFunctionalityTest.cs
 * Author: Logan Jones
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest
{
    public class IOrderItemFunctionalityTest
    {
        #region Entrees

        [Fact]
        public void BrontowurstShouldHaveEmptySpecialByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void BrontowurstBrontowurstShouldHaveCorrectDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void BrontowurstShouldHaveCorrectSpecialForHoldBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void BrontowurstShouldHaveCorrectSpecialForHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Fact]
        public void BrontowurstShouldHaveCorrectSpecialForHoldOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void BrontowurstShouldHaveCorrectSpecialForHoldAll()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            bw.HoldPeppers();
            Assert.Contains<string>("Hold Bun", bw.Special);
            Assert.Contains<string>("Hold Onion", bw.Special);
            Assert.Contains<string>("Hold Peppers", bw.Special);
        }

        [Fact]
        public void DinoNuggetsShouldHaveEmptySpecialByDefault()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);
        }

        [Fact]
        public void DinoNuggetsShouldHaveCorrectDescription()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(16)]
        public void ShouldHaveCorrectSpecialForExtraNuggets(int extraNuggets)
        {
            DinoNuggets dn = new DinoNuggets();
            for (int i = 0; i < extraNuggets; i++)
            {
                dn.AddNugget();
            }
            Assert.Collection<string>(dn.Special, item =>
            {
                Assert.Equal($"{extraNuggets} Extra Nuggets", item);
            });
        }

        [Fact]
        public void PrehistoricPBJShouldHaveCorrectDescription()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pb.Description);
        }

        [Fact]
        public void PrehistoricPBJShouldHaveEmptySpecialByDefault()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void PrehistoricPBJShouldHaveCorrectSpecialForHoldPeanutButter()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            pb.HoldPeanutButter();
            Assert.Collection<string>(pb.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
        }

        [Fact]
        public void PrehistoricPBJShouldHaveCorrectSpecialForHoldJelly()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            pb.HoldJelly();
            Assert.Collection<string>(pb.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }

        [Fact]
        public void PrehistoricPBJShouldHaveCorrectSpecialForHoldAll()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            pb.HoldJelly();
            pb.HoldPeanutButter();
            Assert.Contains<string>("Hold Jelly", pb.Special);
            Assert.Contains<string>("Hold Peanut Butter", pb.Special);
        }

        [Fact]
        public void PterodactylWingsShouldHaveCorrectDescription()
        {
            PterodactylWings pb = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pb.Description);
        }

        [Fact]
        public void PterodactylWingsShouldHaveEmptySpecialByDefault()
        {
            PterodactylWings pb = new PterodactylWings();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectDescription()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", pb.Description);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveEmptySpecialByDefault()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecialHoldBun()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            pb.HoldBun();
            Assert.Contains<string>("Hold Bun", pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecialHoldPickle()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            pb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecialHoldKetchup()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            pb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecialHoldMustard()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            pb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", pb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecialHoldAll()
        {
            SteakosaurusBurger pb = new SteakosaurusBurger();
            pb.HoldPickle();
            pb.HoldBun();
            pb.HoldKetchup();
            pb.HoldMustard();
            Assert.Contains<string>("Hold Pickle", pb.Special);
            Assert.Contains<string>("Hold Bun", pb.Special);
            Assert.Contains<string>("Hold Ketchup", pb.Special);
            Assert.Contains<string>("Hold Mustard", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectDescription()
        {
            TRexKingBurger pb = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", pb.Description);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveEmptySpecialByDefault()
        {
            TRexKingBurger pb = new TRexKingBurger();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldBun()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldBun();
            Assert.Contains<string>("Hold Bun", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldPickle()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldKetchup()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldMustard()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldLettuce()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldTomato()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldTomato();
            Assert.Contains<string>("Hold Tomato", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldOnion()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldOnion();
            Assert.Contains<string>("Hold Onion", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldMayo()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldMayo();
            Assert.Contains<string>("Hold Mayo", pb.Special);
        }

        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecialHoldAll()
        {
            TRexKingBurger pb = new TRexKingBurger();
            pb.HoldPickle();
            pb.HoldBun();
            pb.HoldKetchup();
            pb.HoldMustard();
            pb.HoldLettuce();
            pb.HoldMayo();
            pb.HoldOnion();
            pb.HoldTomato();
            Assert.Contains<string>("Hold Pickle", pb.Special);
            Assert.Contains<string>("Hold Bun", pb.Special);
            Assert.Contains<string>("Hold Ketchup", pb.Special);
            Assert.Contains<string>("Hold Mustard", pb.Special);
            Assert.Contains<string>("Hold Mayo", pb.Special);
            Assert.Contains<string>("Hold Onion", pb.Special);
            Assert.Contains<string>("Hold Tomato", pb.Special);
            Assert.Contains<string>("Hold Lettuce", pb.Special);
        }

        [Fact]
        public void VelociwrapShouldHaveCorrectDescription()
        {
            VelociWrap pb = new VelociWrap();
            Assert.Equal("Veloci-Wrap", pb.Description);
        }

        [Fact]
        public void VelociwrapShouldHaveEmptySpecialByDefault()
        {
            VelociWrap pb = new VelociWrap();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void VelociwrapShouldHaveCorrectSpecialHoldDressing()
        {
            VelociWrap pb = new VelociWrap();
            pb.HoldDressing();
            Assert.Contains<string>("Hold Dressing", pb.Special);
        }
        [Fact]
        public void VelociwrapShouldHaveCorrectSpecialHoldCheese()
        {
            VelociWrap pb = new VelociWrap();
            pb.HoldCheese();
            Assert.Contains<string>("Hold Cheese", pb.Special);
        }

        [Fact]
        public void VelociwrapShouldHaveCorrectSpecialHoldLettuce()
        {
            VelociWrap pb = new VelociWrap();
            pb.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", pb.Special);
        }

        [Fact]
        public void VelociwrapShouldHaveCorrectSpecialHoldAll()
        {
            VelociWrap pb = new VelociWrap();
            pb.HoldDressing();
            pb.HoldLettuce();
            pb.HoldCheese();
            Assert.Contains<string>("Hold Dressing", pb.Special);
            Assert.Contains<string>("Hold Lettuce", pb.Special);
            Assert.Contains<string>("Hold Cheese", pb.Special);
        }

        #endregion

        #region Drinks

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }

        [Fact]
        public void JurassicJavaShouldHaveEmptySpecialByDefault()
        {
            JurassicJava pb = new JurassicJava();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void JurassicJavaShouldHaveCorrectSpecialRoomForCream()
        {
            JurassicJava pb = new JurassicJava();
            pb.LeaveRoomForCream();
            Assert.Contains<string>("Leave Room For Cream", pb.Special);
        }

        [Fact]
        public void JurassicJavaShouldHaveCorrectSpecialAddIce()
        {
            JurassicJava pb = new JurassicJava();
            pb.AddIce();
            Assert.Contains<string>("Add Ice", pb.Special);
        }

        [Fact]
        public void JurassicJavaShouldHaveCorrectSpecialForAll()
        {
            JurassicJava pb = new JurassicJava();
            pb.AddIce();
            pb.LeaveRoomForCream();
            Assert.Contains<string>("Leave Room For Cream", pb.Special);
            Assert.Contains<string>("Add Ice", pb.Special);
        }

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusDescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SodaSaurusShouldHaveEmptySpecialByDefault()
        {
            Sodasaurus pb = new Sodasaurus();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void SodaSaurusShouldHaveCorrectSpecialHoldIce()
        {
            Sodasaurus pb = new Sodasaurus();
            pb.HoldIce();
            Assert.Contains<string>("Hold Ice", pb.Special);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void TyrannoteaShouldHaveEmptySpecialByDefault()
        {
            Tyrannotea pb = new Tyrannotea();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void TyrannoteaShouldHaveCorrectSpecialAddLemon()
        {
            Tyrannotea pb = new Tyrannotea();
            pb.AddLemon();
            Assert.Contains<string>("Add Lemon", pb.Special);
        }

        [Fact]
        public void TyrannoteaShouldHaveCorrectSpecialHoldIce()
        {
            Tyrannotea pb = new Tyrannotea();
            pb.HoldIce();
            Assert.Contains<string>("Hold Ice", pb.Special);
        }

        [Fact]
        public void TyrannoteaShouldHaveCorrectSpecialAll()
        {
            Tyrannotea pb = new Tyrannotea();
            pb.HoldIce();
            pb.AddLemon();
            Assert.Contains<string>("Hold Ice", pb.Special);
            Assert.Contains<string>("Add Lemon", pb.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        [Fact]
        public void WaterShouldHaveEmptySpecialByDefault()
        {
            Water pb = new Water();
            Assert.Empty(pb.Special);
        }

        [Fact]
        public void WaterShouldHaveCorrectSpecialAddLemon()
        {
            Water pb = new Water();
            pb.AddLemon();
            Assert.Contains<string>("Add Lemon", pb.Special);
        }

        [Fact]
        public void WaterShouldHaveCorrectSpecialHoldIce()
        {
            Water pb = new Water();
            pb.HoldIce();
            Assert.Contains<string>("Hold Ice", pb.Special);
        }

        [Fact]
        public void WaterShouldHaveCorrectSpecialAll()
        {
            Water pb = new Water();
            pb.HoldIce();
            pb.AddLemon();
            Assert.Contains<string>("Hold Ice", pb.Special);
            Assert.Contains<string>("Add Lemon", pb.Special);
        }
        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Fact]
        public void FryceritopsShouldHaveEmptySpecialByDefault()
        {
            Fryceritops pb = new Fryceritops();
            Assert.Empty(pb.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionShouldGiveNameForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.Description);
        }

        [Fact]
        public void MeteorMacAndCheeseShouldHaveEmptySpecialByDefault()
        {
            MeteorMacAndCheese pb = new MeteorMacAndCheese();
            Assert.Empty(pb.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionShouldGiveNameForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.Description);
        }

        [Fact]
        public void MezzorellaSticksShouldHaveEmptySpecialByDefault()
        {
            MezzorellaSticks pb = new MezzorellaSticks();
            Assert.Empty(pb.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void TriceritotsDescriptionShouldGiveNameForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.Description);
        }

        [Fact]
        public void TriceritotsShouldHaveEmptySpecialByDefault()
        {
            Triceritots pb = new Triceritots();
            Assert.Empty(pb.Special);
        }

        #endregion

        #region Combos

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void ComboDescriptionShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        [Fact]
        public void ComboSpecialShouldBeCorrect()
        {
            TRexKingBurger entreeOne = new TRexKingBurger();
            entreeOne.HoldKetchup();
            entreeOne.HoldLettuce();
            CretaceousCombo combo = new CretaceousCombo(entreeOne);
            Assert.Equal("Hold Ketchup", combo.Special[1]);
            Assert.Equal("Hold Lettuce", combo.Special[0]);
            Assert.Equal("Small Fryceritops", combo.Special[2]);
            Assert.Equal("Small Cola Sodasaurus", combo.Special[3]);

            VelociWrap entreeTwo = new VelociWrap();
            Tyrannotea drinkTwo = new Tyrannotea();
            Triceritots sideTwo = new Triceritots();
            entreeTwo.HoldDressing();
            entreeTwo.HoldLettuce();
            combo.Entree = entreeTwo;
            combo.Side = sideTwo;
            combo.Side.Size = Size.Large;
            drinkTwo.AddLemon();
            combo.Drink = drinkTwo;
            Assert.Equal("Hold Dressing", combo.Special[0]);
            Assert.Equal("Hold Lettuce", combo.Special[1]);
            Assert.Equal("Large Triceritots", combo.Special[2]);
            Assert.Equal("Small Tyrannotea", combo.Special[3]);
            Assert.Equal("Add Lemon", combo.Special[4]);

            PrehistoricPBJ entreeThree = new PrehistoricPBJ();
            Water drinkThree = new Water();
            MeteorMacAndCheese sideThree = new MeteorMacAndCheese();
            entreeThree.HoldJelly();
            combo.Entree = entreeThree;
            combo.Side = sideThree;
            combo.Side.Size = Size.Medium;
            drinkThree.AddLemon();
            drinkThree.HoldIce();
            drinkThree.Size = Size.Medium;
            combo.Drink = drinkThree;
            Assert.Equal("Hold Jelly", combo.Special[0]);
            Assert.Equal("Medium Meteor Mac and Cheese", combo.Special[1]);
            Assert.Equal("Medium Water", combo.Special[2]);
            Assert.Equal("Add Lemon", combo.Special[3]);
            Assert.Equal("Hold Ice", combo.Special[4]);
        }

        #endregion

    }
}
