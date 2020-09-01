using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Items;

namespace ShoppingCart
{
    public class Terminal : ITerminal
    {

        public Terminal()
        {
            Items = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Items { get; set; }


        public void Scan(string itemCode)
        {
            if (Items.ContainsKey(itemCode))
            {
                Items[itemCode]++;
            }
            else
            {
                Items.Add(itemCode,1);
            }
        }

        public decimal Total()
        {

            return Items.Sum(x => ItemFactory.GetItem(x.Key).GetPriceForQuantity(x.Value));
        }

    }
}