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
    public partial class PendingChefsList : Form
    {
        AdminInitialWindow AdminWindow;
        int AdminID;
        UserAdminController admincontrollerObj = new UserAdminController();
        int PendingChefsCount;
        public PendingChefsList(AdminInitialWindow AdminWindow, int id)
        {
            InitializeComponent();
            this.AdminWindow = AdminWindow;
            AdminID= id;
        }

        private void PendingChefsList_Load(object sender, EventArgs e)
        {
            PendingChefsCount = admincontrollerObj.GetPendingChefsCount();
            PendingChefsLabel.Text = $"Pending Chefs: {PendingChefsCount}";
            LoadChefs();
        }
        private void PendingChefsList_FormClosed(object sender, EventArgs e)
        {
            AdminWindow.Show();
        }
        public void LoadChefs()
        {
            DataTable ChefsTable = admincontrollerObj.GetPendingChefsDetails();
            if (ChefsTable != null && ChefsTable.Rows.Count > 0)
            {
                NoChefsLabel.Visible = false;
                // Clear any existing controls in the FlowLayoutPanel
                flowLayoutPanelChefs.Controls.Clear();

                foreach (DataRow row in ChefsTable.Rows)
                {
                    string chefDetails = $"Name: {row["fullname"]}\nEmail: {row["Email"]}\n";

                    // Create a panel to hold the details and the button
                    Panel panel = new Panel();
                    panel.Width = 700;
                    panel.Height = 80;
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    // Add the chef details label
                    Label detailsLabel = new Label()
                    {
                        Text = chefDetails,
                        AutoSize = true,
                        Font = new Font("Anaktoria", 12, FontStyle.Regular)
                    };
                    panel.Controls.Add(detailsLabel);

                    // Add the approve button
                    Button approveButton = new Button();
                    approveButton.Text = "Approve";
                    approveButton.Font = new Font("Anaktoria", 12, FontStyle.Regular);
                    approveButton.Tag = row["ChefID"];
                    approveButton.Click += ApproveButton_Click;
                    approveButton.Location = new Point(400, 20);
                    approveButton.Height = 30;
                    panel.Controls.Add(approveButton);

                    // Add the panel to the FlowLayoutPanel
                    flowLayoutPanelChefs.Controls.Add(panel);
                }
            }
            else
            {
                NoChefsLabel.Visible = true;
            }
        }
        private void ApproveButton_Click(object sender, EventArgs e)
        {
            Button approveButton = sender as Button;
            int chefID = (int)approveButton.Tag;

            // Approve the chef (e.g., update the database)
            admincontrollerObj.ApproveChef(chefID);
            admincontrollerObj.UpdateAdminID(chefID, AdminID, "Chef");
            this.Refresh();
        }

    }
}
