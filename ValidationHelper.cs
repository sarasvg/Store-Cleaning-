namespace CleaningStoreSystem.Utilities
{
    static class ValidationHelper
    {
        public static bool IsValidQuantity(int quantity)
        {
            return quantity >= 0;
        }
    }
}