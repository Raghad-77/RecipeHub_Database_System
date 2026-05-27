using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class CompanyProductsForm : Form
    {
        Form prevForm;
        int CompanyID;
        CompanyController companycontrollerObj = new CompanyController();
        public CompanyProductsForm(int ID, Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            CompanyID = ID;
            ProductListView.View = View.Details;
            ProductListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            ProductListView.Columns.Add("Description", 250, HorizontalAlignment.Left);
            LoadProducts();
        }

        private void CompanyProductsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            DataTable productsList = companycontrollerObj.getProducts(CompanyID);
            // Clear existing items
            ProductListView.Items.Clear(); 
            // Populate the ListView with data
            foreach (DataRow row in productsList.Rows) { 
                ListViewItem item = new ListViewItem(row["Name"].ToString()); 
                item.SubItems.Add(row["Description"].ToString());
                ProductListView.Items.Add(item); 
            } 
        }

        private void CompanyProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevForm.Show();
        }
    }
}
