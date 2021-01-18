using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class Inferno : Pizza
    {
        public string code = "4";

        private string name = "Inferno";
        private double price = 200.0;
        private List<string> ingredients = new List<string>();

        public Inferno()
        {
            setupIngredients();
        }

        public Inferno(double dPrice)
        {
            setupIngredients();
            price = dPrice;
        }

        private void setupIngredients()
        {
            ingredients = new List<string> { "Chili Peppers", "Mozzarella", "Chicken", "Cheese" };
        }

        public override string GetCode()
        {
            return code;
        }

        public override string GetName()
        {
            return name;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override List<string> GetIngediants()
        {
            return ingredients;
        }

        public override string GetIngediantsToShow()
        {
            return string.Join(",", ingredients);
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name + "...");
            string sIngredients = string.Join(",", ingredients);
            Console.WriteLine("Adding " + sIngredients);
            Console.WriteLine("Preperation done...!!!");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pizza for 30 minutes at 200 degrees...");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into 8 slices...");
        }
        public override void Box()
        {
            Console.WriteLine("Putting pizza into a nice box...");
        }
    }
}
