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
    public partial class AddComment : Form
    {
        NutritionistController obj = new NutritionistController();
        NutHome prev ;
        int id;
        public AddComment()
        {
            InitializeComponent();
        }
        public AddComment(NutHome PreForm, int ID)
        {
            InitializeComponent();
            id = ID;
            prev = PreForm;
            DataTable dt2 = obj.GetRECAva();
            comboBox1.DataSource = dt2;
            comboBox1.ValueMember = "Name";
            comboBox1.DisplayMember = "Name";
            DataTable dt = obj.GetUserMessDetail(7);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            Image photo1 = Properties.Resources.Ramen;
            pictureBox1.Image = photo1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void AddComment_Load(object sender, EventArgs e)
        {

        }

        private void AddComment_FormClosed(object sender, FormClosedEventArgs e)
        {
            prev.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue != null &&
                !string.IsNullOrEmpty(CommBox.Text)
                )
            {
                int id = obj.get_RecipeID(Convert.ToString(comboBox1.Text));


                int x = obj.AddComm(CommBox.Text, 7, textBox1.Text, id);
                if (x == 1)
                {
                    MessageBox.Show("comment added successully!");
                    DataTable dt = obj.GetUserMessDetail(7);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("could not add comment!");
                }



            }
            else
            {
                MessageBox.Show("Please fill in all required fileds!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
