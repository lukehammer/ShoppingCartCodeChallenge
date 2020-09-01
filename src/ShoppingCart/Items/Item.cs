namespace ShoppingCart.Items
{
    public abstract class Item
    {
        public abstract decimal PricePerEach {get;}
        public virtual decimal GetPriceForQuantity(int quantity)
        {
            return PricePerEach * quantity;
        }
    }
}