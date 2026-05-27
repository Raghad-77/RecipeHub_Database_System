using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DBapplication
{
    public class ChefController
    {
        DBManager dbMan;
        public ChefController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public bool checkEmail(string email)
        {
            int ret = (int)dbMan.ExecuteScalar($"Select Count(email) from Chef where email = '{email}';");
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
        public bool AddChef(string fname, string lname, string email, string password, string bio, bool ISApproved, int FollowersCount)
        {
            string EncryptedPassword = EncryptPassword(password);
            int ret = dbMan.ExecuteNonQuery($"Insert into Chef (FirstName, LastName, Email, Password, Bio, ISApproved,FollowersCount) Values ('{fname}', '{lname}','{email}','{EncryptedPassword}','{bio}',0, {0});");
            return ret != 0;
        }
        public string getName(int id)
        {
            return (string)dbMan.ExecuteScalar($"SELECT COALESCE(FirstName, '') + ' ' + COALESCE(LastName, '') AS FullName FROM Chef WHERE ChefID = {id}");
        }
        public DataTable GetRecipes(int id)
        {
            return dbMan.ExecuteReader($@"select Name,Description,Steps,Difficulty_Level,NutritionalInfo,Cooking_Time,Image 
                                          From Recipe where ChefID={id};");
        }

        public DataTable showcollection(int ID)
        {
            string query = $"SELECT DISTINCT CollectionName AS Name FROM Collection WHERE ChefID={ID}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetCollectionRecipes(int id, string Name)
        {
            return dbMan.ExecuteReader($@"select Name,Description,Steps,Difficulty_Level,NutritionalInfo,Cooking_Time,Image 
                                          From Recipe,Collection where ChefID={id} AND CollectionName='{Name}';");
        }

        public DataTable GetRECAva()
        {
            string Query = " SELECT Name FROM Recipe  ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetUserMessDetail(int ChefID)
        {
            string query = $@"Select MessageID, Content, MessageType From Message Where ChefID ={ChefID};";
            return dbMan.ExecuteReader(query);
        }
        public int AddComm(string content, int id, string Type, int recipeID)
        {
            string query = $@"INSERT INTO Message (Content,MessageType, ChefID, RecipeID)
                 VALUES ('{content}', '{Type}' ,{id}, {recipeID});";

            return dbMan.ExecuteNonQuery(query);
        }
        public int get_RecipeID(string name)
        {
            string query = $"SELECT RecipeID FROM Recipe WHERE Name = '{name}'";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["RecipeID"]) : 0;

        }
        public int Get_FollowerCount(int id)
        {
            string query = $@"Select Count(UserID) From Follow_Chef WHERE {id} = ChefID; ";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int Get_likeCount(int id)
        {
            string query = $@"Select Count(UserID) From Likes WHERE {id} = RecipeID; ";
            return (int)dbMan.ExecuteScalar(query);
        }

       
    }
}


