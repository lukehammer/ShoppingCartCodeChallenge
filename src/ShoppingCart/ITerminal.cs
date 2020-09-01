namespace ShoppingCart
{
    public interface ITerminal
    {
        void Scan(string itemCode);
        decimal Total();
    }
}