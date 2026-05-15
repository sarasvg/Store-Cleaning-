namespace CleaningStoreSystem.Models
{
    class LiquidProduct : Product
    {
        public LiquidProduct(string name, int quantity)
            : base(name, quantity)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Liquid] ID: {Id} | Name: {Name} | Quantity: {Quantity}");
        }
    }
}