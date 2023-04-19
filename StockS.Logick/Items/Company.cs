namespace StockS.Logic.Items
{
    public class Company
    {
        public long OIB { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Company (long id, string name, string adress, string telephone, string email)
        {
            this.OIB = id;
            this.Name = name;
            this.Adress = adress;
            this.Telephone = telephone;
            this.Email = email;
        }
    }
}
