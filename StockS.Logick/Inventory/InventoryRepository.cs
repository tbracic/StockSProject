using System;
using System.Collections.Generic;
using System.Data.SQLite;
using OfficeOpenXml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockS.Logic;
using StockS.Logic.Items;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace StockS.Logic.Inventory
{
    public class InventoryRepository
    {
        public List<Inventory> GetAllInventories()
        {
            var list = new List<Inventory>();
            string sql = "SELECT * FROM [Inventory]";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            SQLiteDataReader reader = instance.GetData(sql);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string date = reader.GetString(1);
                long user = reader.GetInt32(2);
                Inventory inventory = new Inventory(id, date, user);
                list.Add(inventory);
            }
            reader.Close();
            instance.Close();
            return list;
        }
        public void CreateInventory(Inventory inventory)
        {

            string sql = $"INSERT INTO [Inventory] VALUES('{inventory.IdInventory}','{inventory.date}', '{inventory.User}');";
            AppDatabase instance = new AppDatabase();
            instance.Open();
            instance.InsertData(sql);
            instance.Close();
        }
        public void AddQuantityHistory(QuantityHistory history)
        {
            AppDatabase appDatabase = new AppDatabase();
            appDatabase.Open();
            string sql = $"INSERT INTO [QuantityHistory] VALUES('{history.IdItem}','{history.IdInventory}','{history.Quantity}');";
            appDatabase.InsertData(sql);
            appDatabase.Close();
        }
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
        public void CreateXLSInventory(string documentPath,int inventoryID) 
        {

        }
        public void CreateXLSList(string documentPath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var p = new ExcelPackage())
            {
                var ws = p.Workbook.Worksheets.Add("Lista");
                int i = 1;
                ItemRepositroy repo = new ItemRepositroy();
                List<string> names= repo.GetAllItemNames();
                foreach(string name in names)
                {
                    ws.Cells[i, 1].Value = name;
                    i++;
                }
                p.SaveAs(new FileInfo(AppContext.BaseDirectory + "lista.xlsx"));
            }
        }
        public void CreatePDFList(string documentPath)
        {
            WriteOffListpdf lista = new WriteOffListpdf();
            lista.generateListPdf(documentPath);
        }

        public void CreateNewInventory(Inventory inventory, List<QuantityHistory> items)
        {
            CreateInventory(inventory);
            ItemRepositroy repo = new ItemRepositroy();
            foreach(QuantityHistory item in items)
            {
                int old = repo.GetItemQuantity(item.IdItem);
                repo.ChangeQuanitity(item.IdItem, item.Quantity);
                item.Quantity = old;
                AddQuantityHistory(item);
                
            }
            CreatePDFInventory(AppContext.BaseDirectory + "Inventory" + inventory.IdInventory, inventory.IdInventory);
            Process.Start("explorer.exe", AppContext.BaseDirectory + "Inventory" + inventory.IdInventory + ".pdf");
        }
    }
}
