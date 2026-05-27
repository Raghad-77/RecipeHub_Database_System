using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class DietPlan : Form

    {
        NutHome Prev;
        NutritionistController obj = new NutritionistController();
        int validID;
        int ValidDiff;
        int ValidTime;
        int ID;
        public DietPlan(NutHome PrevForm, int id)
        {
            InitializeComponent();
            Prev = PrevForm;
            ID = id;

        }
        public DietPlan()
        {
            InitializeComponent();
        }

        private void DietPlan_Load(object sender, EventArgs e)
        {

        }

        private void DietPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Prev.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DiffBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRecipeButt_Click(object sender, EventArgs e)
        {

            bool Check_validDiff = int.TryParse(DiffBox.Text, out ValidDiff);
            bool Check_ValidTime = int.TryParse(CookingTimeBox.Text, out ValidTime);
            if (!string.IsNullOrEmpty(NameRecipe.Text) &&
                !string.IsNullOrEmpty(Des.Text) &&
                !string.IsNullOrEmpty(Stepss.Text) &&
                !string.IsNullOrEmpty(DiffBox.Text) &&
                !string.IsNullOrEmpty(NutInfoBox.Text) &&
                !string.IsNullOrEmpty(CookingTimeBox.Text))
            {
                if (Check_validDiff && Check_ValidTime)
                {
                    //validID = Convert.ToInt32(IDNumBox.Text);
                    if (obj.Check_ID(validID))
                    {
                        int x = obj.AddRecipe(NameRecipe.Text, Des.Text, Stepss.Text, ValidDiff, NutInfoBox.Text, ValidTime, ID);
                        if (x == 0)
                        {
                            MessageBox.Show("Error could not insert Recipe!");
                        }
                        else
                        {
                            MessageBox.Show(" RecipeInserted successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid ID");
                    }

                }
                else
                {
                    MessageBox.Show("Please Fill in all required fileds!");
                }
            }


            else
            {
                MessageBox.Show("Please fill in all the boxes related to adding recipes!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ;

            if (
               !string.IsNullOrEmpty(Des.Text) &&
               !string.IsNullOrEmpty(DPbox.Text) &&
               !string.IsNullOrEmpty(GoalBox.Text)

              )
            {

                int x = obj.AddDP(DPbox.Text, Des.Text, GoalBox.Text, ID);
                if (x == 0)
                {
                    MessageBox.Show("Diet Plan not added successfully!");
                }
                else
                {
                    MessageBox.Show("Diet Plan added successfully!");
                }



            }
            else
            {
                MessageBox.Show("Please Fill in all required fileds!");
            }
        }

        private void DPbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GoalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CookingTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CookTime_Click(object sender, EventArgs e)
        {

        }

        private void NutInfo_Click(object sender, EventArgs e)
        {

        }

        private void Stepss_TextChanged(object sender, EventArgs e)
        {

        }

        private void Steps_Click(object sender, EventArgs e)
        {

        }

        private void Des_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decription_Click(object sender, EventArgs e)
        {

        }

        private void NameRecipe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
