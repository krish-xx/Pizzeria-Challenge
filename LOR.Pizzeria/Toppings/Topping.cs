using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria.Toppings
{
    public abstract class Topping : Pizza.Pizza
    {
        Pizza.Pizza _baseComponent = null;

        protected string _name = "Undefined Decorator";
        protected double _price = 0.0;

        protected Topping(Pizza.Pizza baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public override string GetCode()
        {
            return _baseComponent.GetCode();
        }

        public override string GetName()
        {
            return string.Format("{0}, {1}", _baseComponent.GetName(), _name);
        }


        public override double GetPrice()
        {
            return _price + _baseComponent.GetPrice();
        }

        /// <summary>
        /// Implementation of the base class to comply implementation of the abstract class
        /// </summary>
        /// <returns></returns>
        public override List<string> GetIngediants()
        {
            return _baseComponent.GetIngediants();
        }

        public override string GetIngediantsToShow()
        {
            return _baseComponent.GetIngediantsToShow();
        }

        public override void Prepare()
        {
            _baseComponent.Prepare();
        }

        public override void Bake()
        {
            _baseComponent.Bake();
        }

        public override void Cut()
        {
            _baseComponent.Cut();
        }

        public override void Box()
        {
            _baseComponent.Box();
        }
    }
}
