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
    public partial class FilterForm : Form
    {
        Form f;
        int id;
        userController controllerObj;
        public FilterForm(Form f, int id)
        {
            this.f = f;
            this.id = id;
            InitializeComponent();
            controllerObj = new userController();

        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            comboBoxFilterType.Items.AddRange(new string[] { "Chef Name", "Nutritionist Name", "Recipe Name", "Difficulty Level", "Time Range", "Top 5 Recipes" });
            comboBoxFilterType.SelectedIndex = -1;
            comboBoxFilterOptions.Visible = false;
            comboBoxDifficultyLevel.Visible = false;
            numericUpDownMinTime.Visible = false;
            numericUpDownMaxTime.Visible = false;
            dataGridViewRecipes.Visible = false;

        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void comboBoxFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterOptions.SelectedIndex != -1)
            { buttonApplyFilters.Visible = true; }
            else { buttonApplyFilters.Visible = false; }
        }

        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilterOptions.Visible = false;
            comboBoxDifficultyLevel.Visible = false;
            numericUpDownMinTime.Visible = false;
            numericUpDownMaxTime.Visible = false;
            buttonApplyFilters.Visible = false;
            dataGridViewRecipes.Visible = false;
            difficultylbl.Visible = false;
            namelbl.Visible = false;
            maxlbl.Visible = false;
            minlbl.Visible = false;

            string selectedFilter = comboBoxFilterType.SelectedItem.ToString();

            switch (selectedFilter)
            {
                case "Chef Name":
                    comboBoxDifficultyLevel.Visible = false;
                    numericUpDownMinTime.Visible = false;
                    numericUpDownMaxTime.Visible = false;
                    difficultylbl.Visible = false;
                    namelbl.Visible = true;
                    maxlbl.Visible = false;
                    minlbl.Visible = false;

                    comboBoxFilterOptions.Visible = true;
                    DataTable chefNames = controllerObj.GetAllChefNames();
                    comboBoxFilterOptions.DataSource = chefNames;
                    comboBoxFilterOptions.DisplayMember = "Name";
                    comboBoxFilterOptions.ValueMember = "Name";
                    comboBoxFilterOptions.SelectedIndex = -1;
                    buttonApplyFilters.Visible = false;

                    break;
                case "Recipe Name":
                    maxlbl.Visible = false;
                    minlbl.Visible = false;
                    namelbl.Visible = true;
                    comboBoxDifficultyLevel.Visible = false;
                    difficultylbl.Visible = false;
                    numericUpDownMinTime.Visible = false;
                    numericUpDownMaxTime.Visible = false;

                    comboBoxFilterOptions.Visible = true;
                    DataTable recipeNames = controllerObj.GetAllRecipeNames();
                    comboBoxFilterOptions.DataSource = recipeNames;
                    comboBoxFilterOptions.DisplayMember = "Name";
                    comboBoxFilterOptions.ValueMember = "Name";
                    comboBoxFilterOptions.SelectedIndex = -1;
                    buttonApplyFilters.Visible = false;
                    break;

                case "Nutritionist Name":
                    maxlbl.Visible = false;
                    minlbl.Visible = false;
                    namelbl.Visible = true;
                    difficultylbl.Visible = false;
                    comboBoxDifficultyLevel.Visible = false;
                    numericUpDownMinTime.Visible = false;
                    numericUpDownMaxTime.Visible = false;

                    comboBoxFilterOptions.Visible = true;
                    DataTable nutritionistNames = controllerObj.GetAllNutritionistNames();
                    comboBoxFilterOptions.DataSource = nutritionistNames;
                    comboBoxFilterOptions.DisplayMember = "Name";
                    comboBoxFilterOptions.ValueMember = "Name";
                    comboBoxFilterOptions.SelectedIndex = -1;
                    buttonApplyFilters.Visible = false;

                    break;

                case "Difficulty Level":
                    maxlbl.Visible = false;
                    minlbl.Visible = false;
                    namelbl.Visible = false;
                    comboBoxFilterOptions.Visible = false;
                    numericUpDownMinTime.Visible = false;
                    numericUpDownMaxTime.Visible = false;
                    difficultylbl.Visible = true;

                    comboBoxDifficultyLevel.Visible = true;
                    comboBoxDifficultyLevel.Items.Clear();
                    comboBoxDifficultyLevel.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
                    comboBoxDifficultyLevel.SelectedIndex = -1;
                    buttonApplyFilters.Visible = false;


                    break;
                case "Time Range":
                    maxlbl.Visible = true;
                    minlbl.Visible = true;
                    namelbl.Visible = false;
                    difficultylbl.Visible = false;
                    comboBoxFilterOptions.Visible = false;
                    comboBoxDifficultyLevel.Visible = false;
                    numericUpDownMinTime.Visible = true;
                    numericUpDownMaxTime.Visible = true;
                    buttonApplyFilters.Visible = true;
                    break;
                case "Top 5 Recipes":
                    maxlbl.Visible = false;
                    minlbl.Visible = false;
                    namelbl.Visible = false;
                    difficultylbl.Visible = false;
                    comboBoxFilterOptions.Visible = false;
                    comboBoxDifficultyLevel.Visible = false;
                    numericUpDownMinTime.Visible = false;
                    numericUpDownMaxTime.Visible = false;
                    buttonApplyFilters.Visible = true;
                    break;

            }
        }

        private void difficultylbl_Click(object sender, EventArgs e)
        {

        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a filter type first.");
                return;
            }

            string selectedFilter = comboBoxFilterType.SelectedItem.ToString();
            DataTable filteredRecipes = new DataTable();
            switch (selectedFilter)
            {
                case "Chef Name":
                    if (comboBoxFilterOptions.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a name");
                    }
                    else
                    {
                        string selectedChef = comboBoxFilterOptions.SelectedValue.ToString();
                        if (!string.IsNullOrEmpty(selectedChef))
                        {
                            filteredRecipes = controllerObj.FilterRecipesByChef(selectedChef);
                            if (filteredRecipes == null)
                            {


                                MessageBox.Show("This chef doesn't have any recipes yet.");
                                dataGridViewRecipes.Visible = false;

                                return;
                            }
                        }
                    }
                    break;
                case "Nutritionist Name":
                    if (comboBoxFilterOptions.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a name");
                    }
                    else
                    {
                        string selectedNutritionist = comboBoxFilterOptions.SelectedValue.ToString();
                        if (!string.IsNullOrEmpty(selectedNutritionist))
                        {
                            filteredRecipes = controllerObj.FilterRecipesByNutritionist(selectedNutritionist);
                            if (filteredRecipes == null)
                            {
                                MessageBox.Show("This nutritionist doesn't have any recipes yet.");
                                dataGridViewRecipes.Visible = false;
                                return;
                            }
                        }
                    }
                    break;
                case "Difficulty Level":
                    if (comboBoxDifficultyLevel.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a difficulty level");

                    }
                    else
                    {
                        int selectedDifficulty = int.Parse(comboBoxDifficultyLevel.SelectedItem.ToString());
                        filteredRecipes = controllerObj.FilterRecipesByDifficulty(selectedDifficulty);
                    }
                    break;
                case "Time Range":
                    if (numericUpDownMinTime.Value == 0 && numericUpDownMaxTime.Value == 0)
                    {
                        MessageBox.Show("Please enter both minimum and maximum time values.");
                        return;
                    }
                    int minTime = (int)numericUpDownMinTime.Value;
                    int maxTime = (int)numericUpDownMaxTime.Value;
                    if (minTime > maxTime)
                    {
                        MessageBox.Show("Minimum time cannot be greater than maximum time.");
                        return;
                    }
                    filteredRecipes = controllerObj.FilterRecipesByTimeRange(minTime, maxTime);
                    break;
                case "Recipe Name":
                    if (comboBoxFilterOptions.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a name");
                    }
                    else
                    {
                        string recipeName = comboBoxFilterOptions.SelectedValue.ToString();
                        if (!string.IsNullOrEmpty(recipeName))
                        {
                            {
                                int recipeID = controllerObj.GetRecipeIDByName(recipeName) - 1;
                                Form Newform = new RecipeView(this, this.id, recipeID);
                                Newform.Show();
                                this.Hide();
                                return;
                            }
                        }
                    }
                    break;
                case "Top 5 Recipes":
                    filteredRecipes = controllerObj.GetTop5Recipes();
                    break;
            }


            if (filteredRecipes != null)
            {
                dataGridViewRecipes.DataSource = filteredRecipes;
                dataGridViewRecipes.Visible = true;


                if (dataGridViewRecipes.Columns.Contains("ChefID")) { dataGridViewRecipes.Columns["ChefID"].Visible = false; }
                if (dataGridViewRecipes.Columns.Contains("CompanyID")) { dataGridViewRecipes.Columns["CompanyID"].Visible = false; }
                if (dataGridViewRecipes.Columns.Contains("NutritionistID")) { dataGridViewRecipes.Columns["NutritionistID"].Visible = false; }
                if (dataGridViewRecipes.Columns.Contains("RecipeID")) { dataGridViewRecipes.Columns["RecipeID"].Visible = false; }

                dataGridViewRecipes.Refresh();

            }
            else { MessageBox.Show("No recipes found."); }
        }
        private void comboBoxDifficultyLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDifficultyLevel.SelectedIndex != -1)
            { buttonApplyFilters.Visible = true; }
            else { buttonApplyFilters.Visible = false; }
        }

        private void minlbl_Click(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maxlbl_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaxTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMinTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
