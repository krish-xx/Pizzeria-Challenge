using LOR.Pizzeria.Common;
using LOR.Pizzeria.Pizza;
using System.Collections.Generic;

namespace LOR.Pizzeria.Outlets
{
    class SydneyFactory : PizaFactory
    {
        private string mFactoryCode = "2";
        private string mFactoryName = "Sydney";

        public List<Pizza.Pizza> AvailablePizzas { get; set; }

        public SydneyFactory()
        {
            SetupAvailablePizzas();
        }

        public override string GetFactoryCode()
        {
            return mFactoryCode;
        }

        public override string GetFactoryName()
        {
            return mFactoryName;
        }

        public override void SetupAvailablePizzas()
        {
            AvailablePizzas = new List<Pizza.Pizza> { new Capriciosa(30), new Inferno(31) };
        }

        public override string PromptAvailablePizzas()
        {
            string sItems = "";
            foreach (Pizza.Pizza p in AvailablePizzas)
            {
                sItems += "\n " + p.GetCode() + " " + p.GetName() + " (" + p.GetPrice() + " " + Constants.G_CURRENCY_SYMBOL + ")";
            }
            return "\nMENU"
                + "\n==========================="
                + sItems + "\n What would you like to order? (Enter number)";
        }

        public override Pizza.Pizza GetPizza(string sType)
        {
            if (sType == "1")
            {
                return new Capriciosa(30);
            }
            else if (sType == "4")
            {
                return new Inferno(31);
            }
            else 
                return null;

        }
    }
}
