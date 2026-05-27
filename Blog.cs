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
    public partial class Blog : Form
    {
        int ID;
        NutritionistController obj = new NutritionistController();
        NutHome Prev;
        public Blog()
        {
            InitializeComponent();
        }
        public Blog(NutHome PrevForm, int ID)
        {
            
            InitializeComponent();
            this.ID = ID;
            Prev = PrevForm;
            Image photo = Properties.Resources.Ramen2;
            pictureBox1.Image = photo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Image photo1 = Properties.Resources.Chef_scribbles;
            pictureBox2.Image = photo1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateentered;
            bool Check_date = DateTime.TryParse(textBox3.Text, out dateentered);
            if (Check_date && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                if (obj.AddBlog(textBox1.Text, textBox2.Text, 7))
                {
                    MessageBox.Show("Blog added!");
                }
                else
                {
                    MessageBox.Show("could not add blog!");
                }
            }
            else
            {
                MessageBox.Show("enter all fileds!");
            }
        }

        private void Blog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Prev.Show();
        }
    }
}
