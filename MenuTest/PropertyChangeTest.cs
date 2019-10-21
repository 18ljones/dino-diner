/*  PropertyChangeTest.cs
 *  Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class PropertyChangeTest
    {
        [Theory]
        [InlineData("Special")]
        [InlineData("Price")]
        public void AddingNuggetsShouldNotifyOfPropertyChange(string propertyName)
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, propertyName, () =>
            {
                dn.AddNugget();
            });
        }

        [Fact]
        public void BrontowurstShouldNotifyOfPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () => bw.HoldBun());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldOnion());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldPeppers());
        }

        [Fact]
        public void PBJShouldNotifyOfPropertyChange()
        {
            PrehistoricPBJ pj = new PrehistoricPBJ();
            Assert.PropertyChanged(pj, "Special", () => pj.HoldPeanutButter());
            Assert.PropertyChanged(pj, "Special", () => pj.HoldJelly());
        }

        [Fact]
        public void SteakosaurusBurgerShouldNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () => sb.HoldBun());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldPickle());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldKetchup());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldMustard());
        }

        [Fact]
        public void TRexKingBurgerShouldNotifyOfPropertyChange()
        {
            TRexKingBurger kb = new TRexKingBurger();
            Assert.PropertyChanged(kb, "Special", () => kb.HoldBun());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldPickle());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldKetchup());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldMustard());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldTomato());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldOnion());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldLettuce());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldMayo());
        }

        [Fact]
        public void VelociwrapShouldNotifyOfPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () => vw.HoldDressing());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldLettuce());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldCheese());
        }

        [Fact]
        public void JurassicJavaShouldNotifyOfPropertyChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () => jj.LeaveRoomForCream());
            Assert.PropertyChanged(jj, "Special", () => jj.AddIce());

            Assert.PropertyChanged(jj, "Description", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Price", () => jj.Size = Size.Large);

            Assert.PropertyChanged(jj, "Description", () => jj.Decaf = false);
        }

        [Fact]
        public void SodasaurusShouldNotifyOfPropertyChange()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Description", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Description", () => ss.Flavor = SodasaurusFlavor.Vanilla);
            Assert.PropertyChanged(ss, "Special", () => ss.HoldIce());
        }

        [Fact]
        public void TyrannoteaShouldNotifyOfPropertyChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Special", () => tt.AddLemon());
            Assert.PropertyChanged(tt, "Description", () => tt.Sweet = true);
            Assert.PropertyChanged(tt, "Special", () => tt.HoldIce());
        }

        [Fact]
        public void WaterShouldNotifyOfPropertyChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Special", () => w.AddLemon());
            Assert.PropertyChanged(w, "Special", () => w.HoldIce());
        }

        [Fact]
        public void FryceritopsShouldNotifyOfPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Description", () => f.Size = Size.Large);
        }

        [Fact]
        public void MeteorMacAndCheeseShouldNotifyOfPropertyChange()
        {
            MeteorMacAndCheese f = new MeteorMacAndCheese();
            Assert.PropertyChanged(f, "Price", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Description", () => f.Size = Size.Large);
        }

        [Fact]
        public void MezzorellaSticksShouldNotifyOfPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Description", () => f.Size = Size.Large);
        }

        [Fact]
        public void TriceritotsShouldNotifyOfPropertyChange()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Price", () => f.Size = Size.Large);
            Assert.PropertyChanged(f, "Description", () => f.Size = Size.Large);
        }

        [Fact]
        public void CretasousComboShouldNotifyOfPropertyChange()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(cc, "Description", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Price", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Special", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Price", () => cc.Side = new Triceritots());
            Assert.PropertyChanged(cc, "Special", () => cc.Side = new Triceritots());
            Assert.PropertyChanged(cc, "Price", () => cc.Drink = new Water());
            Assert.PropertyChanged(cc, "Special", () => cc.Drink = new Water());
        }
    }
}
