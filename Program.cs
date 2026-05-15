using CleaningStoreSystem.Models;
using CleaningStoreSystem.Managers;
using CleaningStoreSystem.Utilities;

InventoryManager manager = new InventoryManager();

manager.LowStockEvent += ShowWarning;

while (true)
{
    Console.WriteLine("\n===== CLEANING STORE SYSTEM =====");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Show Products");
    Console.WriteLine("3. Search Product");
    Console.WriteLine("4. Delete Product");
    Console.WriteLine("5. Update Quantity");
    Console.WriteLine("6. Total Products");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.WriteLine("1. Liquid");
            Console.WriteLine("2. Powder");
            Console.WriteLine("3. Spray");

            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (!ValidationHelper.IsValidQuantity(quantity))
            {
                Console.WriteLine("Invalid quantity.");
                break;
            }

            if (type == 1)
            {
                manager.AddProduct(new LiquidProduct(name, quantity));
            }
            else if (type == 2)
            {
                manager.AddProduct(new PowderProduct(name, quantity));
            }
            else if (type == 3)
            {
                manager.AddProduct(new SprayProduct(name, quantity));
            }

            Console.WriteLine("Product added.");
            break;

        case 2:
            manager.ShowProducts();
            break;

        case 3:
            Console.Write("Enter product name: ");
            string search = Console.ReadLine();

            manager.SearchProduct(search);
            break;

        case 4:
            Console.Write("Enter product ID: ");
            int deleteId = Convert.ToInt32(Console.ReadLine());

            manager.DeleteProduct(deleteId);
            break;

        case 5:

            Console.Write("Enter product ID: ");
            int updateId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            foreach (var product in manager.products)
            {
                if (product.Id == updateId)
                {
                    product.UpdateQuantity(amount);
                    Console.WriteLine("Quantity updated.");
                }
            }

            break;

        case 6:
            Console.WriteLine($"Total Products: {Product.TotalProducts}");
            break;

        case 0:
            return;
    }
}

void ShowWarning(string message)
{
    Console.WriteLine(message);
}