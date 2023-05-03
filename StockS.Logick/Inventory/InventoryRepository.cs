using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockS.Logic;

namespace StockS.Logic.Inventory
{
    public class InventoryRepository
    {
        public Inventory GetInventory(int inventoryID)
        {
            string sql = $"SELECT * FROM [Inventory] WHERE [InventoryID] = '{inventoryID}';";
            Inventory result = new Inventory();
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read()) {
                result.IdInventory = reader.GetInt32(0);
                result.date = reader.GetString(1);
                result.User = reader.GetInt64(2);

            }
            reader.Close();
            instance.Close();
            return result;
        }
            
        public List<QuantityHistory> GetAllInventoryItems(int inventoryID)
        {
            string sql = $"SELECT * FROM [QuantityHistory] WHERE [Inventory] = '{inventoryID}';";
            AppDatabase instance = new AppDatabase();
            QuantityHistory item = new QuantityHistory(0, 0, 0);
            List<QuantityHistory> result = new List<QuantityHistory>();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while(reader.Read())
            {
                int IdItem = reader.GetInt32(0);
                int IdInventory = inventoryID;
                int Quantity = reader.GetInt32(2);
                item = new QuantityHistory(IdItem, IdInventory, Quantity);
                result.Add(item);
            }
            reader.Close();
            instance.Close();
            return result;
        }
        public void CreatePDFInventory(string documentPath,int inventoryID)
        {
            InventoryPDF pdftool = new InventoryPDF();

            pdftool.generateInventoryPDF(documentPath,GetInventory(inventoryID),GetAllInventoryItems(inventoryID));
        }
        public void CreatePDFList(string documentPath)
        {
            ItemListpdf lista = new ItemListpdf();
            lista.generateListPdf(documentPath);
        }
    }
}
