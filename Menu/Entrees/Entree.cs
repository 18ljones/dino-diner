using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// represents the Entree base objext
    /// </summary>
    public class Entree : MenuItem
    {
        /// <summary>
        /// represents the list of ingredients
        /// </summary>
        public override List<string> Ingredients => throw new NotImplementedException();
    }
}
