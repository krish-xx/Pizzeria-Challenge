using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class Florenza : Pizza
    {
        public string code = "2";

        private string name = "Florenza";
        private double price = 200.0;
        private List<string> ingredients = new List<string>();

        public Florenza()
        {
            setupIngredients();
        }

        public Florenza(double dPrice)
        {
            setupIngredients();
            price = dPrice;
        }

        private void setupIngredients()
        {
            ingredients = new List<string> { "Olives", "Pastrami", "Mozarella", "Onion" };
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
            Console.WriteLine("Cutting pizza into 6 slices...");
        }

        public override void Box()
        {
            Console.WriteLine("Putting pizza into a nice box...");
        }
    }
}
