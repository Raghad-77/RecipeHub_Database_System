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
    public partial class Users1 : Form
    {
        userController controllerObj;
        int id;
        public Users1(int id)
        {
            InitializeComponent();
            this.id = id;
            controllerObj = new userController();

        }



        private void Users1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // f.Show();

        }

        private void Users1_Load(object sender, EventArgs e)
        {
            Titlelabel.Text = "Hello! " + controllerObj.SelectNames(id);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Visible = true;
                List<string> cookingList = controllerObj.ShowToCookList(this.id);
                if (cookingList.Count > 0)
                {
                    string displayText = string.Join(Environment.NewLine, cookingList);
                    listBox1.Items.Clear();
                    foreach (string recipe in cookingList)
                    {
                        listBox1.Items.Add(recipe);
                    }
                    deleteTOCOOKbtn.Visible = true;
                }
                else { tocooklabel.Visible = true; }
            }
            if (checkBox1.Checked == false)
            {
                listBox1.Visible = false;
                tocooklabel.Visible = false;
                deleteTOCOOKbtn.Visible = false;


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox2.Visible = true;
                List<string> triedList = controllerObj.ShowTriedList(this.id);
                if (triedList.Count > 0)
                {
                    string displayText = string.Join(Environment.NewLine, triedList);
                    listBox2.Items.Clear();
                    foreach (string recipe in triedList)
                    {
                        listBox2.Items.Add(recipe);
                    }

                    deletetriedbutton.Visible = true;

                }
                else { triedlabel.Visible = true; }
            }
            if (checkBox2.Checked == false)
            {
                listBox2.Visible = false;
                triedlabel.Visible = false;
                deletetriedbutton.Visible = false;

            }

        }

        private void triedlabel_Click(object sender, EventArgs e)
        {

        }

        private void tocooklabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteTOCOOKbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedRecipe = listBox1.SelectedItem.ToString();
                int result = controllerObj.deleteTocook(selectedRecipe, this.id);
                if (result == 0)
                {
                    MessageBox.Show("Error: The item was not deleted.");
                }
                else
                {
                    MessageBox.Show("Successfully deleted.");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else { MessageBox.Show("Please select an item to delete."); }
        }
        private void deletetriedbutton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string selectedRecipe = listBox2.SelectedItem.ToString();
                int result = controllerObj.deletetried(selectedRecipe, this.id);
                if (result == 0)
                {
                    MessageBox.Show("Error: The item was not deleted.");
                }
                else
                {
                    MessageBox.Show("Successfully deleted.");
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            else { MessageBox.Show("Please select an item to delete."); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            favcheck.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            shoppingCB.Checked = false;

            Form Newform = new RecipeView(this, this.id, 0);
            Newform.Show();
            this.Hide();
        }

        private void Titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void favcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (favcheck.Checked == true)
            {
                listBox3.Visible = true;
                List<string> favlist = controllerObj.ShowFavList(this.id);
                if (favlist.Count > 0)
                {

                    string displayText = string.Join(Environment.NewLine, favlist);
                    listBox3.Items.Clear();
                    foreach (string recipe in favlist)
                    {
                        listBox3.Items.Add(recipe);
                    }

                    delfavbtn.Visible = true;

                }
                else
                {
                    delfavbtn.Visible = false;
                    favlabel.Visible = true;
                }
            }
            if (favcheck.Checked == false)
            {
                listBox3.Visible = false;
                favlabel.Visible = false;
                delfavbtn.Visible = false;

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delfavbtn_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                string selectedRecipe = listBox3.SelectedItem.ToString();
                int result = controllerObj.deletefav(selectedRecipe, this.id);
                if (result == 0)
                {
                    MessageBox.Show("Error: The item was not deleted.");
                }
                else
                {
                    MessageBox.Show("Successfully deleted.");
                    listBox3.Items.Remove(listBox3.SelectedItem);
                }
            }
            else { MessageBox.Show("Please select an item to delete."); }
        }

        private void shoppingCB_CheckedChanged(object sender, EventArgs e)
        {
            if (shoppingCB.Checked == true)
            {
                listBox4.Visible = true;
                List<string> shoppinglist = controllerObj.showshoppinglist(this.id);
                if (shoppinglist.Count > 0)
                {
                    string displayText = string.Join(Environment.NewLine, shoppinglist);
                    listBox4.Items.Clear();
                    foreach (string recipe in shoppinglist)
                    {
                        listBox4.Items.Add(recipe);
                    }
                    delshopping.Visible = true;
                    buttonGenerate.Visible = true;

                }
                else
                {
                    delshopping.Visible = false;
                    shoppinglbl.Visible = true;
                    buttonGenerate.Visible = false;
                }
            }
            if (shoppingCB.Checked == false)
            {
                listBox4.Visible = false;
                shoppinglbl.Visible = false;
                delshopping.Visible = false;
                buttonGenerate.Visible = false;

            }
        }

        private void delshopping_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                string selectedRecipe = listBox4.SelectedItem.ToString();
                int result = controllerObj.deleteshopping(selectedRecipe, this.id);
                if (result == 0)
                {
                    MessageBox.Show("Error: The item was not deleted.");
                }
                else
                {
                    MessageBox.Show("Successfully deleted.");
                    listBox4.Items.Remove(listBox4.SelectedItem);
                }
            }
            else { MessageBox.Show("Please select an item to delete."); }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                string selectedRecipe = listBox4.SelectedItem.ToString();
                int recipeID = controllerObj.GetRecipeIDByName(selectedRecipe);
                if (recipeID == -1)
                {
                    MessageBox.Show("Ingredients will be determined soon!", "Info");
                    return;
                }
                List<string> ingredients = controllerObj.GetIngredientsForRecipe(recipeID);
                if (ingredients != null && ingredients.Count > 0)
                {
                    string detailedList = "Shopping List for " + selectedRecipe + ":\n" + string.Join("\n", ingredients);
                    MessageBox.Show(detailedList, "Detailed Shopping List");
                }
                else { MessageBox.Show("Ingredients will be determined soon!", "Info"); }

            }
            else { MessageBox.Show("Please select a recipe to generate its shopping list."); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            favcheck.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            shoppingCB.Checked = false;
            Form Newform = new FilterForm(this, this.id);
            Newform.Show();
            this.Hide();
        }

        private void favlabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shoppinglbl_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
