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
    public partial class NutSignUp : Form
    {
        NutritionistController obj = new NutritionistController();


        public NutSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = obj.IsValidEmail(textBox3.Text);
            if (check &&
                !string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text)
                )
            {
                String pass = obj.EncryptPassword(textBox4.Text);
                int x = obj.InsertNut(textBox1.Text, textBox2.Text, textBox3.Text, pass, textBox5.Text);

                if (x != 0)
                { MessageBox.Show("signed successfully"); }
                else { MessageBox.Show("can not sign in"); }

                int id = obj.GetNutID(textBox3.Text);
                NutHome f1 = new NutHome(id);
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("enter all fields");
            }

        }

        private void NutSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
