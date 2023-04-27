namespace StockS.Logic.Items
{
    public class PriceHistory
    {
        public int IdPriceHistory { get; set; }
        public DateTime date { get; set; }
        public float OldPrice { get; set; }
        public int Item { get; set; }
    }
}
