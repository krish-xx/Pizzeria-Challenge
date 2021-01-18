using System;
using System.Collections.Generic;

namespace LOR.Pizzeria.Pizza
{
    class Margherita : Pizza
    {
        public string m_Code = "3";
        private string m_Name = "Margherita";
        private double m_Price = 200.0; 
        private List<string> m_Ingredients = new List<string>();

        public Margherita()
        {
            setupIngredients();
        }

        public Margherita(double dPrice)
        {
            setupIngredients();
            m_Price = dPrice;
        }

        private void setupIngredients()
        {
            m_Ingredients = new List<string> { "Mozarella", "Onion", "Garlic", "Oregano" };
        }

        public override string GetCode()
        {
            return m_Code;
        }

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }

        public override List<string> GetIngediants()
        {
            return m_Ingredients;
        }

        public override string GetIngediantsToShow()
        {
            return string.Join(",", m_Ingredients);
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + m_Name + "...");
            string sIngredients = string.Join(",", m_Ingredients);
            Console.WriteLine("Adding " + sIngredients);
            Console.WriteLine("Preperation done...!!!");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pizza for 15 minutes at 200 degrees...");
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
