using StockS.Logic.Items;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockS.Logic.Conclusion
{
    public class ConclusionRepositroy
    {
        string patha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.db");
        ItemRepositroy repositroy = new();
        public List<Shift> GetAllShifts()
        {
            List<Shift> result = new List<Shift>();
            string sql = "SELECT * FROM [Shift];";
            Shift shift = null;
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                int shiftID = reader.GetInt32(0);
                string start = reader.GetString(1);
                string end = reader.GetString(2);
                shift = new Shift(shiftID, start, end);
                result.Add(shift);
            }
            reader.Close();
            instance.Close();
            return result;
        }
        public List<int> GetShiftID()
        {
            List<Shift> shifts = GetAllShifts();
            List<int> result = new List<int>();
            foreach(Shift shift in shifts)
            {
                result.Add(shift.IdShift);
            }
            return result;
        }
        public List<Conclusion> GetAllConclusions()
        {
            List<Conclusion> result = new List<Conclusion>();
            Conclusion conclusion = null;
            string sql = "SELECT * From [Conclusion];";
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                int conclusionID = reader.GetInt32(0);
                string date = reader.GetString(1);
                int shift = reader.GetInt32(2);
                long user = reader.GetInt64(3);
                conclusion = new Conclusion(conclusionID, date,shift, user);
                result.Add(conclusion);
            }
            reader.Close();
            instance.Close();
            return result;
        }
        public int GetNewConclusionID()
        {
            int result = GetAllConclusions().Count;
            return result + 1;
        }

        public string CreateNewConclusion(string date,int shift,long user)
        {
            string msg = "";
            int id = GetNewConclusionID();
            string sql = $"INSERT INTO [Conclusion] VALUES ('{id}','{date}','{shift}','{user}');";
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            msg += instance.InsertData(sql);
            instance.Close();
            return msg;
        }
        public string CreateNewSoldItem(int itemID,int quantity)
        {
            string msg = "";
            int conclusion = GetNewConclusionID()-1;
            int oldquantity = repositroy.GetItemQuantity(itemID);
            _= repositroy.ChangeQuanitity(itemID, oldquantity-quantity);
            string sql = $"INSERT INTO [SoldItem] VALUES ('{itemID}','{conclusion}','{quantity}') ; " ;
            AppDatabase instance = new AppDatabase(patha);
            instance.Open();
            msg = instance.InsertData(sql);
            instance.Close();
            return msg;
        }
    }
}
