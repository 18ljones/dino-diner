/*  Entree.cs
 *  Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// represents the Entree base objext
    /// </summary>
    public abstract class Entree : MenuItem, IOrderItem
    {
        /// <summary>
        /// represents the list of ingredients
        /// </summary>
        public override List<string> Ingredients => throw new NotImplementedException();
    }
}
