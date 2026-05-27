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
    public partial class chating : Form
    {
        ChefController controller = new ChefController();
        int IDchef;
        HelloChefForm form;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        public chating(HelloChefForm form, int ChefID)
        {
            InitializeComponent();
            this.BackColor = backgroundColor;
            this.form = form;
            IDchef = ChefID;
            DataTable dt2 = controller.GetRECAva();
            comboBox1.DataSource = dt2;
            comboBox1.ValueMember = "Name";
            comboBox1.DisplayMember = "Name";
            DataTable dt = controller.GetUserMessDetail(ChefID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void chating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null &&
               !string.IsNullOrEmpty(textBox2.Text)
               )
            {
                int id = controller.get_RecipeID(Convert.ToString(comboBox1.Text));


                int x = controller.AddComm(textBox2.Text, IDchef, textBox1.Text, id);
                if (x == 1)
                {
                    MessageBox.Show("comment added successully!");
                    DataTable dt = controller.GetUserMessDetail(7);
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

        private void chating_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
