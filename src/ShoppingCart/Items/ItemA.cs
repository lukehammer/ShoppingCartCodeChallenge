using System;

namespace ShoppingCart.Items
{
    public class ItemA : Item
    {
        private const decimal PricePer4 = 7.00m;
        public override decimal PricePerEach => 2.00m;

        public override decimal GetPriceForQuantity(int quantity)
        {
            int groupsOf4 = Math.DivRem(quantity, 4, out var remainder);
            var total = groupsOf4 * PricePer4;
            total += remainder * PricePerEach;
            return total;
        }
    }
}