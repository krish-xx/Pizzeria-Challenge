using LOR.Pizzeria.Common;
using LOR.Pizzeria.Toppings;
using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            UIManager ui = new UIManager();
            ui.Start(order);
        }
    }
}