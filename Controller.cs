using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public bool checkPassword(string email, string password, string UserType)
        {
            string EncryptedPassword = EncryptPassword(password);
            // apply password encryption and store in CorrectedPassword
            string CorrectPassword = (string)dbMan.ExecuteScalar($"Select password from {UserType} where email = '{email}';");
            return CorrectPassword == EncryptedPassword;
        }
        public bool checkEmail(string email, string Usertype)
        {
            int ret = (int)dbMan.ExecuteScalar($"Select Count(Email) from {Usertype} where Email = '{email}';");
            return ret > 0 ? true : false;
        }
        public bool isAdmin(string email)
        {
            bool isAdmin = (bool)dbMan.ExecuteScalar($"select Admin from users where email = '{email}';");
            return isAdmin;
        }
        public bool IsValidEmail(string email)
        { // Define the regular expression pattern for a valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // Use Regex to match the input email with the pattern
            return Regex.IsMatch(email, pattern);
        }
        public int GetID(string email, string userType)
        {
            if (userType == "Users")
            { return (int)dbMan.ExecuteScalar($"Select UserID From {userType} Where email = '{email}';"); }

            return (int)dbMan.ExecuteScalar($"Select {userType}ID From {userType} Where email = '{email}';");
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
        public byte[] UploadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // sets initial directory
                openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.jpeg;*.png) | *.bmp;*.jpg;*.jpeg;*.png";// sets the file types to be shown when searching
                openFileDialog.RestoreDirectory = true;// yraga3 el directory zy makant

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] img_Bytes = File.ReadAllBytes(filePath);
                    return img_Bytes;
                }
                return null;
            }
        }
        public int AddRecipe(string name, string description, string steps, int difficulty_level, string nutritionalInfo, byte[] image, int cooking_time, string usertype, int ID)
        {
            string query = $@"INSERT INTO Recipe (Name, Description, Steps, Difficulty_Level,Cooking_Time, NutritionalInfo, Image, {usertype}ID)
                                    Values (@name,@description,@steps,@difficulty,@cookingTime,@nutritionalInfo,@image,@id);";
            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@description", description },
                { "@steps", steps },
                { "@difficulty", difficulty_level },
                { "@nutritionalInfo", nutritionalInfo },
                { "@cookingTime", cooking_time },
                { "@image", image },
                { "@id", ID }
            };
            return dbMan.ExecuteNonQuery(query, parameters);
        }
        public int AddRecipeWithCollab(string name, string description, string steps, int difficulty_level, string nutritionalInfo, byte[] image, int cooking_time,string usertype, int colaber_id, string collabed_with_email, string collabed_with_usertype)
        {
            int collabed_with_id = (int)dbMan.ExecuteScalar($"Select {collabed_with_usertype}ID from {collabed_with_usertype} Where Email = {collabed_with_email};");
            string query = $@"INSERT INTO Recipe (Name, Description, Steps, Difficulty_Level,Cooking_Time, NutritionalInfo, Image, {usertype}ID, {collabed_with_usertype}ID)
                                    Values (@name,@description,@steps,@difficulty,@cookingTime,@nutritionalInfo,@image,@id1,@id2);";
            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@description", description },
                { "@steps", steps },
                { "@difficulty", difficulty_level },
                { "@nutritionalInfo", nutritionalInfo },
                { "@cookingTime", cooking_time },
                { "@image", image },
                { "@id1", colaber_id },
                { "@id2", collabed_with_id },
            };
            if (collabed_with_usertype == "Company")
            {
                dbMan.ExecuteNonQuery($"INSERT INTO Collabs (ChefID,CompanyID,Date,Description) Values ({colaber_id},{collabed_with_id},'2024-12-28','{description}');");
            }
            else
            {
                dbMan.ExecuteNonQuery($"INSERT INTO Collabs (CompanyID,ChefID,Date,Description) Values ({colaber_id},{collabed_with_id},'2024-12-28','{description}');");
                MessageBox.Show("Collab with chef added successfuly!");
            }
            return dbMan.ExecuteNonQuery(query, parameters);
        }
        public int UpdateRecipe(string name, string description, string steps, int difficulty_level, string nutritionalInfo, byte[] image, int cooking_time, int ID)
        { 
            string query = $@"UPDATE Recipe SET Name=@name, Description=@description, Steps=@steps, Difficulty_Level=@difficulty,Cooking_Time = @cookingTime, NutritionalInfo=@nutritionalInfo, Image=@image
                                    Where RecipeID= @id;";
            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@description", description },
                { "@steps", steps },
                { "@difficulty", difficulty_level },
                { "@nutritionalInfo", nutritionalInfo },
                { "@cookingTime", cooking_time },
                { "@image", image },
                { "@id", ID }
            };
            return dbMan.ExecuteNonQuery(query, parameters);
        }
        public int AddCollab(int colaber_id, string collabed_with_email,string description, string collabed_with_usertype)
        {
            int collabed_with_id = (int)dbMan.ExecuteScalar($"Select {collabed_with_usertype}ID from {collabed_with_usertype} Where Email = {collabed_with_email};");
            if (collabed_with_usertype=="Company")
            return dbMan.ExecuteNonQuery($"INSERT INTO Collabs (ChefID,CompanyID,Date,Description) Values ({colaber_id},{collabed_with_id},'2024-12-28','{description}');");
            return dbMan.ExecuteNonQuery($"INSERT INTO Collabs (CompanyID,ChefID,Date,Description) Values ({colaber_id},{collabed_with_id},'2024-12-28','{description}');");
        }
    }
}

