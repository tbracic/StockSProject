namespace StockS.Logic.Items
{
    public enum Units
    {
        Komad,
        Gram,
        Litra
    }

    public class Item
    {
        public int IdItem { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Units Unit { get; set; }
        public long Company { get; set; }

        public Item(int id,string name, float price, int quantity, Units units,long company)
        {
            this.IdItem = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Unit = units;
            this.Company = company;
        }
    }
}
