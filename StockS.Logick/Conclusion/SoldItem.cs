namespace StockS.Logic.Conclusion
{
    public class SoldItem
    {
        public int IdItem { get; set; }
        public int IdConclusion { get; set; }
        public int Quantity { get; set; }

        public SoldItem(int idItem, int idConclusion, int quantity)
        {
            this.IdItem = idItem;
            this.IdConclusion = idConclusion;
            this.Quantity = quantity;
        }
    }
}
