using System.Collections.Generic;
using LOR.Pizzeria.Common;

namespace LOR.Pizzeria
{
    class BrisbaneFactory : PizaFactory
    {
        private readonly string factoryCode = "1";
        private readonly string factoryName = "Brisbane";

        public List<Pizza> AvailablePizzas { get; set; }

        public BrisbaneFactory()
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
            AvailablePizzas = new List<Pizza> { new Capriciosa(20), new Florenza(21), new Margherita(22) };
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
                return new Capriciosa(20);
            }
            else if (sType == "2")
            {
                return new Florenza(21);
            }
            else if (sType == "3")
            {
                return new Margherita(22);
            }

            else return null;

        }
    }
}
