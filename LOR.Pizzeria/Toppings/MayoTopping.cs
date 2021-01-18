namespace LOR.Pizzeria.Toppings
{
    class MayoTopping : Topping
    {
        public MayoTopping(Pizza.Pizza baseComponent)
            : base(baseComponent)
        {
            this._name = "Mayo";
            this._price = 2.0;
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
