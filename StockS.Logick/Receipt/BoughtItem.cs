namespace StockS.Logic.Receipt
{
    public class BoughtItem
    {
        public int IdItem { get; set; }
        public int IdReceipt { get; set; }
        public int Quantity { get; set; }
        public float PurchusePrice { get; set; }

        public BoughtItem(int idItem, int idReceipt, int quantity, float purchusePrice)
        {
            this.IdItem = idItem;
            this.IdReceipt = idReceipt;
            this.Quantity = quantity;
            this.PurchusePrice = purchusePrice;
        }
    }
}