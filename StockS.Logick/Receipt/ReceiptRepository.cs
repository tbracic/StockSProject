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

        public void AddBoughtItem(int item,int receipt,int quantity, float price,float oldQuantity)
        {

            string sql = $"INSERT INTO [BoughtItem] VALUES ('{item}','{receipt}','{quantity}','{price}');";
            AppDatabase instance = new AppDatabase();
            string sql2 = $"UPDATE [Item] SET [Quantity]='{quantity+oldQuantity}' WHERE [ItemID]='{item}';";
            instance.Open();
            instance.InsertData(sql);
            instance.InsertData(sql2);
            instance.Close();
            
        }
        public void AddReceipt(int no, long companyID, long userOIB, DateTime now)
        {
            string sql = $"INSERT INTO [Receipt] VALUES('{no}','{companyID}','{userOIB}','{now}');";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            instance.InsertData(sql);
            instance.Close();
            }
        public List<BoughtItem> GetBoughtItems(int receiptID)
        {
            List<BoughtItem > result = new List<BoughtItem>();
            BoughtItem item = null;
            string sql = $"SELECT * FROM [BoughtItem] WHERE [Receipt] = '{receiptID}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                int itemid = reader.GetInt32(0);
                int quantity = reader.GetInt32(2);
                float price = reader.GetFloat(3);
                item = new BoughtItem(itemid, receiptID, quantity, price);
                result.Add(item);
            }
            reader.Close();
            instance.Close();
            return result;
        }
        public Receipt GetReceipt(int id)
        {
            Receipt result = new Receipt(id,0,0,null);
            string sql = $"SELECT * FROM [Receipt] WHERE [ReceiptID] = '{id}';";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                result.Id = reader.GetInt32(0);
                result.Company = reader.GetInt64(1);
                result.User = reader.GetInt64(2);
                result.Date = reader.GetString(3);
            }
            reader.Close();
            instance.Close();
            return result;
        }
        public List<Receipt> GetAllReceipts()
        {
            List<Receipt> list = new List<Receipt>();
            Receipt receipt;
            AppDatabase instance = new AppDatabase();
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
        public void CreatePDFReceipt(string path,int idReceipt)
        {
            ReceiptPDF pdftool = new ReceiptPDF();

            pdftool.GenrateReceiptPDF(path,GetReceipt(idReceipt),GetBoughtItems(idReceipt));
        }
    }
}
