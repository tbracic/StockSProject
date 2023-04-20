namespace StockS.Logic.Items
{
    public class QuantityHistory
    {
        public int IdItem { get; set; }
        public int IdInventory { get; set; }
        public int Quantity { get; set; }

        public QuantityHistory(int idItem, int idInventory, int quantity)
        {
            this.IdItem = idItem;
            this.IdInventory = idInventory;
            this.Quantity = quantity;
        }
    }
}
