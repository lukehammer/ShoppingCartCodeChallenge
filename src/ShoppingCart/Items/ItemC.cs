using System;

namespace ShoppingCart.Items
{
    public class ItemC : Item
    {
        private const decimal PricePer6 = 6.00m;
        public override decimal PricePerEach { get; } = 1.25m;
        public override decimal GetPriceForQuantity(int quantity)
        {
            int groupsOf6 = Math.DivRem(quantity, 6, out var remainder);
            var total = groupsOf6 * PricePer6;
            total += remainder * PricePerEach;
            return total;
        }
    }
}