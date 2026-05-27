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
    public partial class CompanyPendingList : Form
    {
        AdminInitialWindow AdminWindow;
        int AdminID;
        UserAdminController admincontrollerObj = new UserAdminController();
        int PendingCompaniesCount;

        public CompanyPendingList(AdminInitialWindow AdminWindow, int id)
        {
            InitializeComponent();
            this.AdminWindow = AdminWindow;
            AdminID = id;
            
        }

        private void PendingCompaniesList_Load(object sender, EventArgs e)
        {
            PendingCompaniesCount = admincontrollerObj.GetPendingCompaniesCount();
            PendingCompaniesLabel.Text = $"Pending Companies: {PendingCompaniesCount}";
            LoadCompanies();
        }

        private void CompanyPendingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminWindow.Show();
        }

        public void LoadCompanies()
        {
            DataTable CompaniesTable = admincontrollerObj.GetPendingCompaniesDetails();

            if (CompaniesTable != null && CompaniesTable.Rows.Count > 0)
            {
                NoCompaniesLabel.Visible = false;

                // Clear any existing controls in the FlowLayoutPanel
                flowLayoutPanelCompanies.Controls.Clear();

                foreach (DataRow row in CompaniesTable.Rows)
                {
                    string companyDetails = $"Name: {row["Name"]}\nEmail: {row["Email"]}\n";

                    // Create a panel to hold the details and the button
                    Panel panel = new Panel();
                    panel.Width = 700;
                    panel.Height = 80;
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    // Add the company details label
                    Label detailsLabel = new Label()
                    {
                        Text = companyDetails,
                        AutoSize = true,
                        Font = new Font("Anaktoria", 12, FontStyle.Regular)
                    };
                    panel.Controls.Add(detailsLabel);

                    // Add the approve button
                    Button approveButton = new Button();
                    approveButton.Text = "Approve";
                    approveButton.Font = new Font("Anaktoria", 12, FontStyle.Regular);
                    approveButton.Tag = row["CompanyID"];
                    approveButton.Click += ApproveButton_Click;
                    approveButton.Location = new Point(400, 20);
                    approveButton.Height = 30;
                    panel.Controls.Add(approveButton);

                    // Add the panel to the FlowLayoutPanel
                    flowLayoutPanelCompanies.Controls.Add(panel);
                }
            }
            else
            {
                NoCompaniesLabel.Visible = true;
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            Button approveButton = sender as Button;
            int companyID = (int)approveButton.Tag;

            // Approve the company (e.g., update the database)
            admincontrollerObj.ApproveCompany(companyID);
            admincontrollerObj.UpdateAdminID(companyID, AdminID,"Company");
            this.Refresh();
        }

       
    }

}
