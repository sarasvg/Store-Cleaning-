using CleaningStoreSystem.Models;
using CleaningStoreSystem.Events;

namespace CleaningStoreSystem.Managers
{
    class InventoryManager
    {
        public List<Product> products = new List<Product>();

        public event LowStockHandler LowStockEvent;

        public void AddProduct(Product product)
        {
            products.Add(product);

            if (product.Quantity < 5)
            {
                LowStockEvent?.Invoke($"Warning: {product.Name} stock is low!");
            }
        }

        public void ShowProducts()
        {
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }

        public void SearchProduct(string name)
        {
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    product.DisplayInfo();
                    return;
                }
            }

            Console.WriteLine("Product not found.");
        }

        public void DeleteProduct(int id)
        {
            Product found = null;

            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    found = product;
                    break;
                }
            }

            if (found != null)
            {
                products.Remove(found);
                Console.WriteLine("Product deleted.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}