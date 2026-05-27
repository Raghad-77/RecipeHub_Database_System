using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{

    public partial class ReportsForm : Form
    {
        UserAdminController admincontrolobj = new UserAdminController();

        public ReportsForm()
        {
            InitializeComponent();
            int UserCount = admincontrolobj.Total_UsersCount();
            int ChefCount = admincontrolobj.Total_ChefsCount();
            int NutCount = admincontrolobj.Total_CompaniesCount();
            int CompCount = admincontrolobj.Total_NutritionistsCount();
            int recipeCount = admincontrolobj.TotalRecipes();
            label1.Text = $"There are {UserCount} Users, {ChefCount} Chefs,{NutCount} Nutritionists, {CompCount} Companies.";
            label2.Text = $"There are {recipeCount} Recipes!";
            double AVGRateing = admincontrolobj.getAVGRating();
            label3.Text = $"Average Rating is {AVGRateing}.";
            dataGridView1.DataSource = admincontrolobj.RecipesSorted();
            dataGridView2.DataSource = admincontrolobj.TotalRecipesForChefs();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
