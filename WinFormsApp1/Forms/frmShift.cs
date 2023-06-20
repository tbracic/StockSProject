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

namespace StockS.API.Forms
{
    public partial class frmShift : Form
    {
        UserRepository repository;
        public frmShift()
        {
            InitializeComponent();
            repository = new UserRepository();
            lblNo.Text = repository.GetAllShifts().Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblNo.Text) + 1;
            string start =txtStart.Text;
            string end = txtEnd.Text;
            repository = new UserRepository();
            try {
                repository.AddShift(id, start, end);
                MessageBox.Show("");
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
