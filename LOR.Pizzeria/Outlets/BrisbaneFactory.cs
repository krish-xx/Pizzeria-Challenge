using System.Collections.Generic;
using LOR.Pizzeria.Common;
using LOR.Pizzeria.Pizza;

namespace LOR.Pizzeria.Outlets
{
    class BrisbaneFactory : PizaFactory
    {
        private string mFactoryCode = "1";
        private string mFactoryName = "Brisbane";

        public List<Pizza.Pizza> AvailablePizzas { get; set; }

        public BrisbaneFactory()
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
            AvailablePizzas = new List<Pizza.Pizza> { new Capriciosa(20), new Florenza(21), new Margherita(22) };
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
