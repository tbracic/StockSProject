using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace StockS.Logic.Items
{
    public class ItemRepositroy
    {

        public List<Item> GetAllItems()
        {
            Item item = new Item(0, null, 0, 0, 0, 0);
            List<Item> items = new List<Item>();
            string sql = "Select * from Item;";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string name = dataReader.GetString(1);
                float price = dataReader.GetFloat(2);
                int quantity = dataReader.GetInt32(3);
                int units = dataReader.GetInt32(4);
                var company = (long)(dataReader.GetInt64(5));
                item = new Item(id, name, price, quantity, (Units)units, company);
                items.Add(item);
            }
            dataReader.Close();
            instance.Close();
            return items;
        }
        public List<Company> GetAllCompanies()
        {
            Company company = new Company(0, null, null, null, null);
            List<Company> companies = new List<Company>();
            string sql = "Select * from Company;";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                long id = dataReader.GetInt64(0);
                string name = dataReader.GetString(1);
                string adress = dataReader.GetString(2);
                string telephon = dataReader.GetString(3);
                string email = dataReader.GetString(4);
                company = new Company(id, name, adress, telephon, email);
                companies.Add(company);
            }
            dataReader.Close();
            instance.Close();
            return companies;
        }
        public List<string> GetAllItemNames()
        {
            List<Item> items =GetAllItems();
            List<string> result = new List<string>();
            foreach (Item item in items) { result.Add(item.Name); }
            return result;
        }

        public int GetItemID(string name)
        {
            int id = 0;
            string sql = $"SELECT [ItemID] FROM [Item] WHERE [Name] = '{name}';"; 
            AppDatabase instance=new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while(reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        public string GetItemName(int id) {
            string result = null;
            string sql = $"SELECT [Name] FROM [Item] WHERE [ItemID] = '{id}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            return result;
        }
        public string AddNewCompany(long oib, string name, string adress, string telephone, string email)
        {
            AppDatabase instance = new AppDatabase();
            string sql = $"INSERT into [Company] VALUES ('{oib}','{name}','{adress}','{telephone}','{email}');";
            instance.Open();
            string msg = instance.InsertData(sql);
            instance.Close();
            return msg;
        }

        public string AddNewItem(int code, string name, float price, int quantity,int units, long company)
        {
            string msg = "";
            AppDatabase instance = new AppDatabase();
            string sql = $"INSERT into [Item] VALUES ('{code}','{name}','{price}','{quantity}','{units}','{company}');";
            instance.Open();
            msg = instance.InsertData(sql);
            instance.Close();
            return msg;
        }

        public string ChangePrice(int id, float price1,float price2)
        {
            string msg = "";
            DateTime date = DateTime.Now;
            string sql1 = $"INSERT INTO [PriceHistory] VALUES (null,'{date}','{price1}','{id}');";
            string sql2 = $"UPDATE [Item] SET [Price] = '{price2}' WHERE [ItemID]='{id}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            msg += instance.InsertData(sql1) + "  ";
            msg += instance.InsertData(sql2);
            instance.Close();
            return msg;
        }

        public int GetItemQuantity(int item)
        {
            int result =-1;
            string sql = $"SELECT [Quantity] FROM [Item] WHERE [ItemID] = '{item}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }
            return result;
        }

        public string ChangeQuanitity(int id, int quantity)
        {
            string msg = "";
            string sql = $"UPDATE [Item] SET [Quantity] = '{quantity}' WHERE [ItemID]='{id}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            msg += instance.InsertData(sql);
            instance.Close();
            return msg;
        }
    }
}