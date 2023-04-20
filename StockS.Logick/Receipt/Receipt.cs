namespace StockS.Logic.Receipt
{
    public class Receipt
    {
        public int Id { get; set; }
        public long Company { get; set; }
        public long User { get; set; }
        public string Date { get; set; }
        public Receipt(int id, long company, long user, string date)
        {
            this.Id = id;
            this.Company = company;
            this.User = user;
            this.Date = date;
        }
    }
}
