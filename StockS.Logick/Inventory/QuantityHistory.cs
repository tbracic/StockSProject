namespace StockS.Logic.Inventory
{
    public class QuantityHistory
    {
        public int IdItem { get; set; }
        public int IdInventory { get; set; }
        public int Quantity { get; set; }

        public QuantityHistory(int idItem, int idInventory, int quantity)
        {
            IdItem = idItem;
            IdInventory = idInventory;
            Quantity = quantity;
        }
    }
}
