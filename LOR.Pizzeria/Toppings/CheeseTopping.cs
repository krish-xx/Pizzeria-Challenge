namespace LOR.Pizzeria.Toppings
{
    class CheeseTopping : Topping
    {
        public CheeseTopping(Pizza.Pizza baseComponent)
            : base(baseComponent)
        {
            this._name = "Extra Cheese";
            this._price = 5.0;
        }

        public string GetToppingName()
        {
            return _name;
        }
        public double GetToppingPrice()
        {
            return _price;
        }
    }
}
