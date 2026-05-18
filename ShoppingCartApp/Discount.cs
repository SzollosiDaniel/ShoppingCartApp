namespace ShoppingCartApp
{
    public class Discount
    {
        // percent: 0–100 között, különben ArgumentException
        // Példa: ApplyPercentage(200, 10) -> 180
        public double ApplyPercentage(double total, double percent)
        {
            if (total > 100 || 0 > total) throw new ArgumentException();
            return total * (percent / 100);
        }

        // Az eredmény soha nem lehet negatív — ha a kedvezmény nagyobb, 0-t ad vissza
        // Példa: ApplyFixed(100, 50) -> 50
        public double ApplyFixed(double total, double discountAmount)
        {
            if (total - discountAmount < 0 || total < discountAmount)
                return 0;
            return total - discountAmount;
        }

        // true ha discountValue > 0
        public bool IsValid(double discountValue)
        {
            if (discountValue > 0)
                return true;

            return false;
        }
    }
}
