using CleaningStoreSystem.Interfaces;

namespace CleaningStoreSystem.Models
{
    abstract class Product : IProductActions
    {
        private static int counter = 1;

        private int id;
        private string name;
        private int quantity;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            protected set { quantity = value; }
        }

        public static int TotalProducts { get; private set; }

        public Product(string name, int quantity)
        {
            id = counter++;
            Name = name;
            Quantity = quantity;

            TotalProducts++;
        }

        public void UpdateQuantity(int amount)
        {
            Quantity += amount;
        }

        public abstract void DisplayInfo();
    }
}