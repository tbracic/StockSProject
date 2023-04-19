namespace StockS.Logic.User
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Title { get; set; }

        public Role(int id,string title)
        {
            this.IdRole = id;
            this.Title = title;
        }
    }
}
