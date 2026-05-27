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
    public partial class NutritionistPendingList : Form
    {
        AdminInitialWindow AdminWindow;
        int AdminID;
        UserAdminController admincontrollerObj = new UserAdminController();
        int PendingNutritionistsCount;

        public NutritionistPendingList(AdminInitialWindow AdminWindow, int id)
        {
            InitializeComponent();
            this.AdminWindow = AdminWindow;
            AdminID = id;
            
        }

        private void PendingNutritionistsList_Load(object sender, EventArgs e)
        {
            PendingNutritionistsCount = admincontrollerObj.GetPendingNutritionistsCount();
            PendingNutritionistsLabel.Text = $"Pending Nutritionists: {PendingNutritionistsCount}";
            LoadNutritionists();
        }

        private void NutritionistPendingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminWindow.Show();
        }

        public void LoadNutritionists()
        {
            DataTable NutritionistsTable = admincontrollerObj.GetPendingNutritionistsDetails();

            if (NutritionistsTable != null && NutritionistsTable.Rows.Count > 0)
            {
                NoNutritionistsLabel.Visible = false;

                // Clear any existing controls in the FlowLayoutPanel
                flowLayoutPanelNutritionists.Controls.Clear();

                foreach (DataRow row in NutritionistsTable.Rows)
                {
                    string nutritionistDetails = $"Name: {row["fullname"]}\nEmail: {row["Email"]}\n";

                    // Create a panel to hold the details and the button
                    Panel panel = new Panel();
                    panel.Width = 700;
                    panel.Height = 80;
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    // Add the nutritionist details label
                    Label detailsLabel = new Label()
                    {
                        Text = nutritionistDetails,
                        AutoSize = true,
                        Font = new Font("Anaktoria", 12, FontStyle.Regular)
                    };
                    panel.Controls.Add(detailsLabel);

                    // Add the approve button
                    Button approveButton = new Button();
                    approveButton.Text = "Approve";
                    approveButton.Font = new Font("Anaktoria", 12, FontStyle.Regular);
                    approveButton.Tag = row["NutritionistID"];
                    approveButton.Click += ApproveButton_Click;
                    approveButton.Location = new Point(400, 20);
                    approveButton.Height = 30;
                    panel.Controls.Add(approveButton);

                    // Add the panel to the FlowLayoutPanel
                    flowLayoutPanelNutritionists.Controls.Add(panel);
                }
            }
            else
            {
                NoNutritionistsLabel.Visible = true;
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            Button approveButton = sender as Button;
            int nutritionistID = (int)approveButton.Tag;

            // Approve the nutritionist (e.g., update the database)
            admincontrollerObj.ApproveNutritionist(nutritionistID);
            admincontrollerObj.UpdateAdminID(nutritionistID, AdminID,"Nutritionist");
            this.Refresh();
        }

        
    }
}
