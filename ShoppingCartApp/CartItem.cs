namespace ShoppingCartApp
{
    public class CartItem
    {
        public string Name { get; }
        public double UnitPrice { get; }
        public int Quantity { get; set; }

        // name nem lehet null/üres, unitPrice > 0, quantity >= 1
        public CartItem(string name, double unitPrice, int quantity)
        {
            if (String.IsNullOrEmpty(name) || 0 >= unitPrice || 0 >= quantity)
                throw new ArgumentException();
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        // UnitPrice * Quantity
        public double GetLineTotal()
        {
            return UnitPrice * Quantity;
        }

        // quantity >= 1, különben ArgumentException
        public void UpdateQuantity(int quantity)
        {
            if (0 >= quantity)
                throw new ArgumentException();
            Quantity = quantity;
        }
    }
}
