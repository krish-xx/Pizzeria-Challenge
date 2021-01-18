using LOR.Pizzeria.Common;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class SydneyFactory : PizaFactory
    {
        private readonly string factoryCode = "2";
        private readonly string factoryName = "Sydney";

        public List<Pizza> AvailablePizzas { get; set; }

        public SydneyFactory()
        {
            SetupAvailablePizzas();
        }

        public override string GetFactoryCode()
        {
            return factoryCode;
        }

        public override string GetFactoryName()
        {
            return factoryName;
        }

        public override void SetupAvailablePizzas()
        {
            AvailablePizzas = new List<Pizza> { new Capriciosa(30), new Inferno(31) };
        }

        public override string PromptAvailablePizzas()
        {
            string sItems = "";
            foreach (Pizza p in AvailablePizzas)
            {
                sItems += "\n " + p.GetCode() + " " + p.GetName() + " (" + p.GetPrice() + " " + Constants.G_CURRENCY_SYMBOL + ")";
            }
            return "\nMENU"
                + "\n==========================="
                + sItems + "\n What would you like to order? (Enter number)";
        }

        public override Pizza GetPizza(string sType)
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
