namespace StockS.Logic.Conclusion
{
    public class Shift
    {
        public int IdShift { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public Shift(int idShift, string start, string end)
        {
            this.IdShift = idShift;
            this.Start = start;
            this.End = end;
        }
    }
}
