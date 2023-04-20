namespace StockS.Logic.WriteOff
{
    public class WriteOff
    {
        public int IdWriteOff { get; set; }
        public int Item { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public long User { get; set; }
        public WriteOff(int idWriteOff, int item, int quantity, string description, long user)
        {
            this.IdWriteOff = idWriteOff;
            this.Item = item;
            this.Quantity = quantity;
            this.Description = description;
            this.User = user;
        }
    }
}
