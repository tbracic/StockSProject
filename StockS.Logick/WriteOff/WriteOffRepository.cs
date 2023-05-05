using StockS.Logic.Items;
using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockS.Logic.WriteOff
{
    public class WriteOffRepository
        
    {
        private ItemRepositroy repository;
        public void AddWriteOff(WriteOff document)
        {
            repository = new ItemRepositroy();
            int item = repository.GetItemQuantity(document.Item);
            repository.ChangeQuanitity(document.Item, document.Quantity);
            string sql = $"INSERT INTO [WriteOff] VALUES ('{document.IdWriteOff}','{document.Item}','{item}','{document.Description}','{document.User}');";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            instance.InsertData(sql);
            instance.Close();
           
        }

        public List<WriteOff> GetAllWriteOffs()
        {
            List<WriteOff> list = new List<WriteOff>();
            WriteOff writeOff = null;
            string sql = "Select * from [WriteOff] ";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader dataReader = instance.GetData(sql);
            while (dataReader.Read())
            {
                int idWriteoff = dataReader.GetInt32(0);
                int item = dataReader.GetInt32(1);
                int quantity = dataReader.GetInt32(2);
                string description = dataReader.GetString(3);
                long user = dataReader.GetInt64(4);
                writeOff = new WriteOff(idWriteoff, item,quantity,description,user);
                list.Add(writeOff);
            }
            dataReader.Close();
            instance.Close();
            return list;
        }
    }
}
