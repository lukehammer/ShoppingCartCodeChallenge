using System;

namespace ShoppingCart.Items
{
    public static class ItemFactory
    {
        public static Item GetItem(string itemCode)
        {
            switch (itemCode)
            {
                case "A":
                    return new ItemA();
                case "B":
                    return new ItemB();
                case "C":
                    return new ItemC();
                case "D":
                    return new ItemD();
                default:
                    throw new InvalidOperationException($"{itemCode} is not a valid item code");
            }
        }

    }
}