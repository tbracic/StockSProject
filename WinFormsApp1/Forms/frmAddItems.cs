using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using StockS.Logic;
using StockS.Logic.Items;

namespace StockS.API.Forms
{
    public partial class frmAddItems : Form
    {
        ItemRepositroy repositroy;
        public frmAddItems(int id)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
            cBoxUnits.DataSource = Enum.GetValues(typeof(Units));
            repositroy = new ItemRepositroy();
            List<Company> list = repositroy.GetAllCompanies();
            string[] company0= new string[list.Count];
            int i = 0;
            foreach (Company company in list)
            {
                company0[i] = company.Name;
            }
            cBoxCompany.DataSource = company0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtID.Text);
            string name = txtName.Text;
            float price = float.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            int units = cBoxUnits.SelectedIndex;
            string companyName = cBoxCompany.SelectedItem.ToString();
            long companyID = 0;
            try 
            {
                List<Company> list = repositroy.GetAllCompanies();
                foreach (Company company in list)
                {
                    if (company.Name == companyName)
                    {
                        companyID = company.OIB;
                    }
                }
                repositroy.AddNewItem(code, name, price, quantity, units, companyID);
                Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
                Close(); 
            }
            
            
        }
    }
}
