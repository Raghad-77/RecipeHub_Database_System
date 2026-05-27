using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class NutInfoAdded : Form
    {
        NutHome prev;
        NutritionistController obj = new NutritionistController();
        int id;

        public NutInfoAdded()
        {
            InitializeComponent();



        }
        public NutInfoAdded(NutHome prev, int ID)
        {
            InitializeComponent();
            id = ID;
            this.prev = prev;
            DataTable dt = obj.GetIngAva();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Name";
            comboBox1.DisplayMember = "Name";

            DataTable dt2 = obj.GetRECAva();
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "Name";
            comboBox2.DisplayMember = "Name";
            Image photo = Properties.Resources.Ramen2;
            pictureBox1.Image = photo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Image photo1 = Properties.Resources.Ramen;
            pictureBox2.Image = photo1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


        }
        private void NutInfoAdded_Load(object sender, EventArgs e)
        {

        }

        private void NutInfoAdded_FormClosed(object sender, FormClosedEventArgs e)
        {
            prev.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (
                !string.IsNullOrEmpty(NutInfoAddedbox.Text) &&
                comboBox1.SelectedValue != null
                )
            {
                int x = obj.UpdateIngInfo(Convert.ToString(comboBox1.SelectedValue), NutInfoAddedbox.Text);
                if (x != 0)
                {
                    MessageBox.Show("updated successfully!");
                }
                else
                { MessageBox.Show("could not update nutritional information!"); }

            }
            else
            {
                MessageBox.Show("please enter all boxes correctly!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Calorie;
            bool CheckCalorie = int.TryParse(textBox1.Text, out Calorie);

            if (!string.IsNullOrEmpty(NameIngbox.Text) &&
                !string.IsNullOrEmpty(NutInfoAddedbox.Text)
                && !string.IsNullOrEmpty(textBox1.Text)
                && CheckCalorie
                )
            {
                int x = obj.AdsIngInfo(NameIngbox.Text, Convert.ToInt32(textBox1.Text), NutInfoAddedbox.Text);
                if (x != 0)
                {
                    MessageBox.Show("ingredient added successfully!");
                }
                else
                {
                    MessageBox.Show("ingredient could not be added successfully!");

                }
            }
            else
            {
                MessageBox.Show("please enter all boxes correctly!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox2.SelectedValue != null &&
                !string.IsNullOrEmpty(InfoRecipeBox.Text)
                )
            {

                int x = obj.UpdateIngInfoRecipe(Convert.ToString(comboBox2.SelectedValue), InfoRecipeBox.Text);
                if (x != -1)
                {
                    MessageBox.Show("updated successfully!");
                }
                else
                { MessageBox.Show("could not update nutritional information!"); }

            }
            else
            {
                MessageBox.Show("please enter all boxes correctly!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
