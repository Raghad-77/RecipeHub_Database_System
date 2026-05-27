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
    public partial class Calories : Form
    {
        NutritionistController obj = new NutritionistController();
        NutHome prevform;
        int id;
        //Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        public Calories()
        {
            InitializeComponent();
        }
        public Calories(NutHome prev, int ID)
        {
            InitializeComponent();
            id = ID;
            this.prevform = prev;
            Image Photo1 = Properties.Resources.Ramen2;
            pictureBox1.Image = Photo1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Image photo2 = Properties.Resources.Ramen;
            pictureBox2.Image = photo2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            // this.BackColor = backgroundColor;
            DataTable dt = obj.GetIngAva();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Name";
            comboBox1.DisplayMember = "NAme";


        }
        private void Calories_Load(object sender, EventArgs e)
        {

        }

        private void Calories_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter all fileds!");
            }
            else
            {
                int cal = obj.Get_Calories(Convert.ToString(comboBox1.SelectedValue));
                string dis = Convert.ToString(cal * Convert.ToInt32(textBox1.Text));
                DisplayLabel.Text = dis;
            }

        }
    }
}
