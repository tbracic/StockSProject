using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;
using StockS.Logic.Conclusion;

namespace StockS.Logic.User
{

    public class UserRepository
    {
        public string GetPasswordCrypted(string password) { return password; }
        string patha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.db");
        public List<User> GetAllUsers()
        {
            User user;
            string sql = "SELECT * FROM [User];";
            List<User> users = new List<User>();
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader= instance.GetData(sql);
            while (dataReader.Read())
            {
                long oib = dataReader.GetInt64(0);
                string name = dataReader.GetString(1);
                string surname = dataReader.GetString(2);
                string adress = dataReader.GetString(3);
                string telephone = dataReader.GetString(4);
                string email = dataReader.GetString(5);
                int role = dataReader.GetInt32(6);
                string password = dataReader.GetString(7);
                string username = dataReader.GetString(8);
                user = new User(oib, name, surname, adress, telephone, email, role, password, username);
                users.Add(user);
            }
            dataReader.Close();
            instance.Close();
            return users;

        }
        public User GetUserOIB (long oib)
        {
            User user = null;
            string sql = $"SELECT * FROM [User] WHERE [OIB] = '{oib}'";
            List<User> users = new List<User>();
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                
                string name = dataReader.GetString(1);
                string surname = dataReader.GetString(2);
                string adress = dataReader.GetString(3);
                string telephone = dataReader.GetString(4);
                string email = dataReader.GetString(5);
                int role = dataReader.GetInt32(6);
                string password = dataReader.GetString(7);
                string username = dataReader.GetString(8);

                user = new User(oib, name, surname, adress, telephone, email, role, password, username);
                users.Add(user);
            }
            dataReader.Close();
            instance.Close();
            return user;
        }
        public User GetUser(string username)
        {
            User user =null;
            string sql = $"SELECT * FROM [User] WHERE [Login] = '{username}'";
            List<User> users = new List<User>();
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                long oib = dataReader.GetInt64(0);
                string name = dataReader.GetString(1);
                string surname = dataReader.GetString(2);
                string adress = dataReader.GetString(3);
                string telephone = dataReader.GetString(4);
                string email = dataReader.GetString(5);
                int role = dataReader.GetInt32(6);
                string password = dataReader.GetString(7);
                
                user = new User(oib, name, surname, adress, telephone, email, role, password,username);
                users.Add(user);
            }
            dataReader.Close();
            instance.Close();
            return user;

        }
        public string CheckIfDatabaseExist()
        {
            if (!File.Exists(patha)) { return "Database doesnt exist in courrent context"; }
            return "";
        }
        public object GetUserLogin(string username, string pass)
        {
            string msg = CheckIfDatabaseExist();
            if (!string.IsNullOrEmpty(msg)) { return msg; }
            else
            {
                User user = new User(0, null,null, null, null, null,0,null,username);
                  user = GetUser(username);
                if (user == null) { return "User doesnt exist."; }
                else
                {
                    // password moras jos
                    string pass1 = GetPasswordCrypted(pass);
                    string pass2 = user.Password;
                    if (pass1 == pass2) { return user; }
                    else 
                    {
                        return "Password doesnt match the OIB. 2: " + pass1 + "  1:  " + pass2 + "   oib: " + user.Password + "  path   " + patha + " " ; 
                    }
                }
            }
        }
        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            Role role = null;
            string sql = "Select * from Role ";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                int idRole = dataReader.GetInt32(0);
                string title = dataReader.GetString(1);
                role = new Role(idRole, title);
                roles.Add(role);
            }
            dataReader.Close();
            instance.Close();
            return roles;
        }
        public Role GetRole(int id)
        {
            Role role = null;
            string sql = "Select * from Role where RoleID = " + id;
            List<Role> roles = new List<Role>();
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                int idRole = dataReader.GetInt32(0);
                string title = dataReader.GetString(1);
                role = new Role(idRole,title);
                roles.Add(role);
            }
            dataReader.Close();
            instance.Close();
            return role;
        }
        public string GetRoleTitle(int id) {
            Role role = GetRole(id);
            if(role == null) { return "Greska."; }
            else { return role.Title.ToString(); }
        }

        public void AddUser(long oib,string name,string surr ,string adress,string mail,string telephone,int role,string pass0)
        {
            AppDatabase instance = new AppDatabase();
            string pass = GetPasswordCrypted(pass0);
            string sql = $"INSERT INTO [User] VALUES ('{oib}','{name}','{surr}','{adress}','{mail}','{telephone}','{role}','{pass}');";
            instance.Open();
            instance.InsertData(sql);
            instance.Close();

        }

        public void AddRole(int id, string title)
        {
            AppDatabase instance = new AppDatabase();
            string sql = $"INSERT INTO [Role] VALUES ('{id}','{title}');";
            instance.Open();
            instance.InsertData(sql);
            instance.Close();

        }

        public List<Shift> GetAllShifts()
        {
            Shift shift;
            List<Shift> list = new List<Shift>();
            string sql = "SELECT* FROM [Shift]";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string start = reader.GetString(1);
                string end = reader.GetString(2);
                shift = new Shift(id, start, end);
                list.Add(shift);
            }
            reader.Close();
            instance.Close();
            return list;
        }

        public void AddShift(int id, string start, string end)
        {
            AppDatabase instance = new AppDatabase();
            string sql = $"INSERT INTO [Shift] VALUES ('{id}','{start}','{end}');";
            instance.Open();
            instance.InsertData(sql);
            instance.Close();
        }
    }

}
