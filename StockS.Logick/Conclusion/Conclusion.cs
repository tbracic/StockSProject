namespace StockS.Logic.Conclusion
{
    public class Conclusion
    {
        public int IdConclusion { get; set; }
        public string Date { get; set; }
        public int Shift { get; set; }
        public long User { get; set; }

        public Conclusion(int idConclusion, string date, int shift, long user)
        {
            this.IdConclusion = idConclusion;
            this.Date = date;
            this.Shift = shift;
            this.User = user;
        }
    }
}
