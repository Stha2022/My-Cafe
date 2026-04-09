namespace CampusCafeKiosk
{
    public class DrinkOrder
    {
        public string CustomerName { get; set; }
        public double BasePrice { get; set; }

        public virtual double CalculateTotal()
        {
            return BasePrice;
        }
    }

    public class PremiumDrink : DrinkOrder
    {
        public string SyrupFlavor { get; set; }

        public override double CalculateTotal()
        {
            return BasePrice + 5.50;
        }
    }
}
