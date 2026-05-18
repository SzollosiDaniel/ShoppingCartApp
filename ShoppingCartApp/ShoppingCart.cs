namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        public readonly List<CartItem> _items;

        public ShoppingCart()
        {
            _items = new List<CartItem>();
        }

        // Ha az item neve már szerepel (kis-nagybetű független), növeli a mennyiségét
        public void AddItem(string name, double unitPrice, int quantity)
        {
            foreach (var item in _items)
            {
                if (item.Name == name)
                {
                    item.UpdateQuantity(item.Quantity + 1);
                    return;
                }
            }
            _items.Add(new CartItem(name, unitPrice, quantity));
        }

        // true ha megtalálta és törölte, false ha nem szerepelt
        public bool RemoveItem(string name)
        {
            foreach (var item in _items)
            {
                if (item.Name == name)
                {
                    _items.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public int GetItemCount()
        {
            return _items.Count;
        }

        // Összeg = minden item (UnitPrice * Quantity) összege
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += Convert.ToDecimal(item.UnitPrice * item.Quantity);
            }
            return total;
        }

        public IReadOnlyList<CartItem> GetItems()
        {
            return _items;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
