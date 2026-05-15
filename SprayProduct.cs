namespace CleaningStoreSystem.Models
{
    class SprayProduct : Product
    {
        public SprayProduct(string name, int quantity)
            : base(name, quantity)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Spray] ID: {Id} | Name: {Name} | Quantity: {Quantity}");
        }
    }
}