/*  OrderTest.cs
 *  Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderSubtotalCostShouldBeCorrect()
        {
            Order o = new Order();
            PrehistoricPBJ pb1 = new PrehistoricPBJ();
            PrehistoricPBJ pb2 = new PrehistoricPBJ();
            PrehistoricPBJ pb3 = new PrehistoricPBJ();
            Triceritots tt = new Triceritots();
            Sodasaurus ss = new Sodasaurus();
            o.Items.Add(pb1);
            o.Items.Add(pb2);
            o.Items.Add(pb3);
            o.Items.Add(tt);
            o.Items.Add(ss);

            double subtotal = pb1.Price + pb2.Price + pb3.Price + tt.Price + ss.Price;
            Assert.Equal<double>(subtotal, o.SubtotalCost);
        }

        [Fact]
        public void OrderSubtotalCostShouldNotDropBelowZero()
        {
            Order o = new Order();
            DinoNuggets dn = new DinoNuggets();
            VelociWrap vw = new VelociWrap();
            dn.Price = -9000;
            vw.Price = -1;
            o.Items.Add(dn);
            o.Items.Add(vw);
            Assert.Equal<double>(0.00, o.SubtotalCost);
        }

        [Fact]
        public void OrderSalesTaxCostShouldBeCorrect()
        {
            Order o = new Order();
            PrehistoricPBJ pb1 = new PrehistoricPBJ();
            PrehistoricPBJ pb2 = new PrehistoricPBJ();
            PrehistoricPBJ pb3 = new PrehistoricPBJ();
            Triceritots tt = new Triceritots();
            Sodasaurus ss = new Sodasaurus();
            o.Items.Add(pb1);
            o.Items.Add(pb2);
            o.Items.Add(pb3);
            o.Items.Add(tt);
            o.Items.Add(ss);

            double salesTax = (pb1.Price + pb2.Price + pb3.Price + tt.Price + ss.Price) * o.SalesTaxRate;
            Assert.Equal<double>(salesTax, o.SalesTaxCost);
        }

        [Fact]
        public void OrderTotalCostShouldBeCorrect()
        {
            Order o = new Order();
            PrehistoricPBJ pb1 = new PrehistoricPBJ();
            PrehistoricPBJ pb2 = new PrehistoricPBJ();
            PrehistoricPBJ pb3 = new PrehistoricPBJ();
            Triceritots tt = new Triceritots();
            Sodasaurus ss = new Sodasaurus();
            o.Items.Add(pb1);
            o.Items.Add(pb2);
            o.Items.Add(pb3);
            o.Items.Add(tt);
            o.Items.Add(ss);

            double salesTax = (pb1.Price + pb2.Price + pb3.Price + tt.Price + ss.Price) * o.SalesTaxRate;
            double subtotal = pb1.Price + pb2.Price + pb3.Price + tt.Price + ss.Price;
            double total = salesTax + subtotal;
            Assert.Equal<double>(total, o.TotalCost);
        }

    }
}
