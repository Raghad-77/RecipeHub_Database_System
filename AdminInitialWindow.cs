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
    public partial class AdminInitialWindow : Form
    {
        int AdminID;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        UserAdminController admincontrollerObj = new UserAdminController();
        public AdminInitialWindow(int ID)
        {
            InitializeComponent();
            AdminID = ID;

            // Initialize BG color
            this.BackColor = backgroundColor;

            // Picture boxes Background
            // Chef
            ViewChefsListPB.Image = Image.FromFile("../../Resources/Images/Chef_scribbles.png");
            ViewChefsListPB.SizeMode = PictureBoxSizeMode.Zoom;
            // Nutritionist
            ViewNutritionistsListPB.Image = Image.FromFile("../../Resources/Images/Nutritionist_scribbles.png");
            ViewNutritionistsListPB.SizeMode = PictureBoxSizeMode.Zoom;
            // Company
            ViewCompanyListPB.Image = Image.FromFile("../../Resources/Images/Company_scribbles.png");
            ViewCompanyListPB.SizeMode = PictureBoxSizeMode.StretchImage;

            // Initialize greeting label
            WelcomeLabel.Text = "Hello, " + admincontrollerObj.GetName(AdminID);



        }

        private void AdminInitialWindow_Load(object sender, EventArgs e)
        {

        }

        private void ViewChefsListPB_Click(object sender, EventArgs e)
        {
            PendingChefsList pendingChefsList = new PendingChefsList(this,AdminID);
            pendingChefsList.Show();
            this.Hide();
        }

        private void ViewNutritionistsListPB_Click(object sender, EventArgs e)
        {
            NutritionistPendingList nutritionistPendingList = new NutritionistPendingList(this, AdminID);
            nutritionistPendingList.Show();
            this.Hide();
        }

        private void ViewCompanyListPB_Click(object sender, EventArgs e)
        {
            CompanyPendingList companyPendingList = new CompanyPendingList(this, AdminID);
            companyPendingList.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nf = new ReportsForm();
            nf.Show();
            this.Hide();

        }
    }
}
