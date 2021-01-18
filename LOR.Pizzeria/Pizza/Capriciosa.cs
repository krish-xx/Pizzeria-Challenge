using System;
using System.Collections.Generic;

namespace LOR.Pizzeria.Pizza
{
    class Capriciosa : Pizza
    {
        public string m_Code = "1";

        private string m_Name = "Capriciosa";
        private double m_Price = 200.0;
        private List<string> m_Ingredients = new List<string>();

        public Capriciosa()
        {
            setupIngredients();
        }

        private void setupIngredients()
        {
            m_Ingredients = new List<string> { "Mushrooms", "Cheese", "Ham", "Mozarella" };
        }

        public Capriciosa(double dPrice)
        {
            setupIngredients();
            m_Price = dPrice;
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
