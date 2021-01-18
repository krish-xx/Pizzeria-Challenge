namespace LOR.Pizzeria.Toppings
{
    class OliveOilTopping : Topping
    {
        public OliveOilTopping(Pizza.Pizza baseComponent)
            : base(baseComponent)
        {
            this._name = "Olive Oil";
            this._price = 3.0;
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
