namespace StockS.Logic.User
{
    public class User
    {
        public long OIB { get; set; }
        public string Name { get; set;}
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public User(long id, string name, string surname, string adress, string telephone, string mail, int role, string pass,string username)
        {
            this.OIB = id;
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
            this.Telephone = telephone;
            this.Email = mail;
            this.Role = role;
            this.Password = pass;
            this.Username = username;
        }
    }
}
