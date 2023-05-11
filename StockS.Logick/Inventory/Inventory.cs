namespace StockS.Logic.Inventory
{
    public class Inventory
    {
        public int IdInventory { get; set; }
        public string date { get; set; }
        public long User { get; set; }

        public Inventory (int idInventory, string date, long user)
        {
            this.IdInventory = idInventory;
            this.date = date;
            this.User = user;
        }

        public Inventory()
        {
        }
    }

}
