using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockS.Logic.Receipt
{
    public class ReceiptRepository
    {
        string patha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.db");
        public string AddBoughtItem(int item,int receipt,int quantity, float price)
        {

            string sql = $"INSERT INTO [BoughtItem] VALUES ('{item}','{receipt}','{quantity}','{price}');";
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            string msg = instance.InsertData(sql);
            instance.Close();
            return msg;
        }
        public string AddReceipt(int no, long companyID, long userOIB, DateTime now)
        {
            string sql = $"INSERT INTO [Receipt] VALUES('{no}','{companyID}','{userOIB}','{now}')";
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            string msg = instance.InsertData(sql);
            instance.Close();
            return msg;
        }

        public List<Receipt> GetAllReceipts()
        {
            List<Receipt> list = new List<Receipt>();
            Receipt receipt;
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            string sql = "SELECT * FROM [Receipt];";
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                long company = dataReader.GetInt64(1);
                long user = dataReader.GetInt64(2);
                string date = dataReader.GetString(3);
                receipt = new Receipt(id, company, user, date);
                list.Add(receipt);
            }
            dataReader.Close();
            instance.Close();
            return list;
        }
    }
}
