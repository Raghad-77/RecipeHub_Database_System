using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace DBapplication
{
    public class NutritionistController

    {
        DBManager dbMan;
        public NutritionistController()
        {
            dbMan = new DBManager();
        }

        public int Get_FollowerCount(int id)
        {
            string query = $@"Select Count(UserID) From Follow_Nutritionist WHERE {id} = NutritionistID; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Get_Calories(string name)
        {
            string query = $@"Select Calorie From Ingredient WHERE Name = '{name}' ; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password string to a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash byte array back to a string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Convert byte to hexadecimal string
                }

                return sb.ToString();
            }
        }
        public int GetNutID(string name)
        {
            string query = $"Select NutritionistID From Nutritionist Where Email = '{name}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public bool IsValidEmail(string email)
        { // Define the regular expression pattern for a valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // Use Regex to match the input email with the pattern
            return Regex.IsMatch(email, pattern);
        }
        public int InsertNut(string Fname, string Lname, string email, string password, string bio)
        {
            string query = $"INSERT INTO Nutritionist (FirstName, LastName, Email, IsApproved ,Password, Bio) VALUES ('{Fname}', '{Lname}', '{email}', {0} ,'{password}', '{bio}')";
            return dbMan.ExecuteNonQueryyklnmkl(query);
        }
        public int getRecipesTotal(int NutId)
        {
            string query = $"Select Count(Name) From Recipe Where NutritionistID = {NutId}";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetNutName(int ID)
        {
            string query = $@"Select FirstName From Nutritionist Where NutritionistID = {ID};";
            return (string)dbMan.ExecuteScalar(query);
        }
        public bool AddBlog(string Title, string Content, int Nutid)
        {
            string query = $@"INSERT INTO BlogPost (Title, Content, NutritionistID)
                 VALUES ('{Title}', '{Content}',{Nutid}  );";
            int x = dbMan.ExecuteNonQueryyklnmkl(query);
            if (x != -1)
            {
                return true;
            }
            return false;
        }

        public bool Check_ID(int id)
        {
            //LOW MAWGOODA AW LA2 BYRAG3A TRUE

            string query = $"select NutritionistID From Nutritionist where NutritionistID = {id}; ";
            int x = dbMan.ExecuteNonQueryyklnmkl(query);
            if (x == -1)
            {
                return true;
            }
            return false;
        }
        public bool Check_ingID(int id)
        {
            string query = $"select IngredientID From Ingredient where IngredientID = {id}; ";
            int x = dbMan.ExecuteNonQueryyklnmkl(query);
            if (x == -1)
            {
                return true;
            }
            return false;
        }
        public DataTable GetUserMessDetail(int NutID)
        {
            string query = $@"Select MessageID, Content, MessageType From Message Where NutritionistID ={NutID};";
            return dbMan.ExecuteReader(query);
        }
        public int get_RecipeID(string name)
        {
            string query = $"select RecipeID From Recipe where Name = '{name}'; ";
            int x = (int)dbMan.ExecuteScalar(query);
            return x;

        }
        //executenon query makanetesh radya testa8al
        //insert new recipe 
        public int AddRecipe(string name, string des, string steps, int diff, string nutinfo, int cookintime, int nutid)
        {
            string query = $@"INSERT INTO Recipe (Name, Description, Steps, Difficulty_Level, NutritionalInfo, Cooking_Time, NutritionistID)
                 VALUES ('{name}','{des}'  ,'{steps}', {diff}, '{nutinfo}', {cookintime}, {nutid});";

            return dbMan.ExecuteNonQuery(query);

        }
        public int AddDP(string name, string des, string goal, int nutid)
        {
            string query = $@"INSERT INTO DietPlan (Name,Goal, Description, NutritionistID)
                 VALUES ('{name}','{goal}'  ,'{des}', {nutid});";

            return dbMan.ExecuteNonQuery(query);

        }
        public int AdsIngInfo(string name, int cal, string NutInfo)
        {
            string query = $@"INSERT INTO Ingredient (Name, Calorie,NutritionalInfo)
                 VALUES ('{name}',{cal},'{NutInfo}');";

            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateIngInfo(string name, string NutInfo)
        {
            string query = $@" Update Ingredient Set NutritionalInfo = '{NutInfo}' where Name = '{name}'";

            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateIngInfoRecipe(string name, string NutInfo)
        {
            string query = $@" Update Recipe Set NutritionalInfo = '{NutInfo}' where Name = '{name}'";

            return dbMan.ExecuteNonQuery(query);

        }
        public int AddComm(string content, int id, string Type, int recipeID)
        {
            string query = $@"INSERT INTO Message (Content,MessageType, NutritionistID, RecipeID)
                 VALUES ('{content}', '{Type}' ,{id}, {recipeID});";

            return dbMan.ExecuteNonQueryyklnmkl(query);
        }

        public DataTable GetIngAva()
        {
            string Query = " SELECT Name FROM Ingredient  ";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetRECAva()
        {
            string Query = " SELECT Name FROM Recipe  ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable Getrec(int id)
        {
            string Query = $@" select Name,Description,Steps,Difficulty_Level,NutritionalInfo,Cooking_Time, Image From Recipe where {id} = NutritionistID ; ";
            return dbMan.ExecuteReader(Query);
        }


    }
}
