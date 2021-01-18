using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria.Outlets
{
    /// <summary>
    /// Base class for factory (location based stores)
    /// </summary>
    abstract class PizaFactory
    {
        /// <summary>
        /// select factory
        /// </summary>
        /// <returns></returns>
        public abstract string GetFactoryCode();

        public abstract string GetFactoryName();

        /// <summary>
        /// setup the available pizzas for the specific factory
        /// </summary>
        public abstract void SetupAvailablePizzas();

        /// <summary>
        /// Create a textual string for prompt
        /// </summary>
        /// <returns></returns>
        public abstract string PromptAvailablePizzas();

        /// <summary>
        /// Return a pizza based on type and location
        /// </summary>
        /// <param name="sType"></param>
        /// <returns></returns>
        public abstract Pizza.Pizza GetPizza(string sType);
    }
}
