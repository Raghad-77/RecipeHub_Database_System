using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DBapplication
{
    public class CompanyController
    {
        DBManager dbMan;
        public CompanyController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public bool checkEmail(string email)
        {
            int ret = (int)dbMan.ExecuteScalar($"Select Count(email) from Company where email = '{email}';");
            return ret > 0 ? true : false;
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
        public bool AddCompany(string name,string email, string password, string bio)
        {
            string EncryptedPassword = EncryptPassword(password);
            int ret = dbMan.ExecuteNonQuery($"Insert into Company (Name, Email, Password, Bio, ISApproved) Values ('{name}','{email}','{EncryptedPassword}','{bio}',0);");
            return ret != 0;
        }
        public string getName(int id)
        {
            return (string) dbMan.ExecuteScalar($"Select Name from Company where CompanyID={id};");
        }
        public DataTable GetRecipes(int id)
        {
            return dbMan.ExecuteReader($@"select Name,Description,Steps,Difficulty_Level,NutritionalInfo,Cooking_Time,Image,RecipeID 
                                          From Recipe where CompanyID={id};");
        }
        public DataTable getProducts(int id)
        {
            return dbMan.ExecuteReader($"Select Name,Description From Product where CompanyID={id};");
        }
    }
}
