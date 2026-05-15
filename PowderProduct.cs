namespace CleaningStoreSystem.Models
{
    class PowderProduct : Product
    {
        public PowderProduct(string name, int quantity)
            : base(name, quantity)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Powder] ID: {Id} | Name: {Name} | Quantity: {Quantity}");
        }
    }
}