using StockS.Logic.Conclusion;
using StockS.Logic.Items;
using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockS.API.Forms
{
    public partial class frmConclusion : Form
    {
        User current;
        ConclusionRepositroy repository;
        ItemRepositroy itemRepositroy;
        public frmConclusion(User user)
        {
            InitializeComponent();
            current = user;
            repository = new ConclusionRepositroy();
            itemRepositroy = new ItemRepositroy();
            cBoxShift.DataSource = repository.GetShiftID();
            colItem.DataSource = itemRepositroy.GetAllItemNames();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            long user = current.OIB;
            string date = dTPdate.Value.ToString();
            int shift = int.Parse(cBoxShift.SelectedItem.ToString());
            repository = new ConclusionRepositroy();
            itemRepositroy = new ItemRepositroy();
            try {
                repository.CreateNewConclusion(date, shift, user);
                string msg = "Good";

                foreach (DataGridViewRow row in dgvSoldItems.Rows)
                {
                    if (!row.IsNewRow) { repository.CreateNewSoldItem(itemRepositroy.GetItemID(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString())); }
                    else
                        break;
                }
                MessageBox.Show(msg);
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
