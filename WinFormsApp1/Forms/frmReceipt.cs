using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockS.Logic;
using StockS.Logic.Items;
using StockS.Logic.Receipt;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace StockS.API.Forms
{
    public partial class frmReceipt : Form
    {
        ItemRepositroy repositroy;
        ReceiptRepository repo1;
        User current;
        public frmReceipt(User user)
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            repo1 = new ReceiptRepository();
            List<Item> items = repositroy.GetAllItems();
            List<string> names = new List<string>();
            foreach (Item item in items)
            {
                names.Add(item.Name);
            }
            dgvItem.DataSource = names;
            current = user;
            List<Company> companies = repositroy.GetAllCompanies();
            List<string> list2 = new List<string>();
            foreach (Company company in companies)
            {
                list2.Add(company.Name);
            }
            cBoxCompany.DataSource = list2;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try {
                DataGridViewRow selected = dgvBoughtItems.Rows[0];
                string itemSelected = selected.Cells[0].Value.ToString();
                repositroy = new ItemRepositroy();
                List<Item> items = repositroy.GetAllItems();
                int idItem = 0;

                string comp = cBoxCompany.SelectedItem.ToString();
                List<Company> companies = repositroy.GetAllCompanies();
                long companyID = 0;
                foreach (Company company in companies)
                {
                    if (company.Name == comp) companyID = company.OIB;
                }
                int no = repo1.GetAllReceipts().Count() + 1;
                long userOIB = current.OIB;
                DateTime now = DateTime.Now;
                repo1.AddReceipt(no, companyID, userOIB, now);
                float quantity = 0;
                foreach (DataGridViewRow row in dgvBoughtItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (Item item in items)
                        {
                            // tu izbacuje compile error
                            if (item.Name == row.Cells[0].Value.ToString()) { idItem = item.IdItem; quantity = item.Quantity; };

                        }
                        repo1.AddBoughtItem(idItem, no, int.Parse(row.Cells[1].Value.ToString()), float.Parse(row.Cells[2].Value.ToString()), quantity);
                    }
                }
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string filename = "Receipt" + DateTime.Now.DayOfYear;
                repo1 = new ReceiptRepository();
                repo1.CreatePDFReceipt(filename, 2);
                Process.Start("explorer.exe", filename + ".pdf");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
