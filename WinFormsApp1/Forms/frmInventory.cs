using StockS.Logic.Inventory;
using StockS.Logic.Items;
using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockS.API.Forms
{
    public partial class frmInventory : Form
    {
        User user1;
        InventoryRepository repository;
        public frmInventory(User user)
        {
            user1 = user;
            InitializeComponent();
            ItemRepositroy repo = new ItemRepositroy();
            List<string> items = repo.GetAllItemNames();
            dgvInventory.Columns.Add("name", "Name");
            dgvInventory.Columns.Add("qunatity", "Quantity");
            foreach (string item in items)
            {
                dgvInventory.Rows.Add(item, 0);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPDFAllItems_Click(object sender, EventArgs e)
        {
            repository = new InventoryRepository();
            string filename = "ItemList";
            repository.CreatePDFList(filename);
            Process.Start("explorer.exe", filename + ".pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repository = new InventoryRepository();
            string filename = "Inventory" + DateTime.Now.Year.ToString();
            repository.CreatePDFInventory(filename, 1);
            Process.Start("explorer.exe", filename + ".pdf");
        }

        private void btnAllItemsExcel_Click(object sender, EventArgs e)
        {
            repository = new InventoryRepository();
            string filename = "ItemList";
            repository.CreateXLSList(filename);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            repository = new InventoryRepository();
            ItemRepositroy repo1 = new ItemRepositroy();
            try
            {
                Inventory inventory = new Inventory(repository.GetAllInventories().Count + 1, DateTime.Now.Date.ToString(), user1.OIB);
                List<QuantityHistory> items = new List<QuantityHistory>();
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    if (row.IsNewRow)
                    {
                        break;
                    }
                    else
                    {
                        QuantityHistory item = new QuantityHistory(repo1.GetItemID(row.Cells[0].Value.ToString()), inventory.IdInventory, int.Parse(row.Cells[1].Value.ToString()));
                        items.Add(item);
                    }
                }
                repository.CreateNewInventory(inventory, items);
                MessageBox.Show("Uspijeh");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }
    }
}
