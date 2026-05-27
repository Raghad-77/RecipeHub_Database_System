using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;

namespace DBapplication
{
    public class userController
    {
        DBManager dbMan;
        public userController()
        {
            dbMan = new DBManager();
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

        public string SelectNames(int id)
        {
            string query = $"SELECT FirstName + ' ' + LastName AS FullName FROM Users WHERE UserID={id}";
            return (string)dbMan.ExecuteScalar(query);
        }





        public List<string> ShowToCookList(int id)
        {
            string query = $"SELECT Recipe.Name FROM Recipe, AddToList WHERE ListType='To-Cook List' AND UserID={id} AND Recipe.RecipeID=AddToList.RecipeID";
            DataTable dt = dbMan.ExecuteReader(query);
            List<string> recipeNames = new List<string>();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Name"] != null)
                    {
                        recipeNames.Add(row["Name"].ToString());
                    }
                }
            }

            return recipeNames;
        }


        public List<string> ShowTriedList(int id)
        {
            string query = $"SELECT Recipe.Name FROM Recipe, AddToList WHERE ListType='Tried List' AND UserID={id} AND Recipe.RecipeID=AddToList.RecipeID";

            DataTable dt = dbMan.ExecuteReader(query);
            List<string> recipeNames = new List<string>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    recipeNames.Add(row["Name"].ToString());
                }
            }
            return recipeNames;

        }

        public List<string> ShowFavList(int id)
        {
            string query = $"SELECT Recipe.Name FROM Recipe, AddToList WHERE ListType='Favorite List' AND UserID={id} AND Recipe.RecipeID=AddToList.RecipeID";

            DataTable dt = dbMan.ExecuteReader(query);
            List<string> recipeNames = new List<string>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    recipeNames.Add(row["Name"].ToString());
                }
            }
            return recipeNames;

        }

        public List<string> showshoppinglist(int id)
        {
            string query = $"SELECT Recipe.Name FROM Recipe, AddToList WHERE ListType='Shopping List' AND UserID={id} AND Recipe.RecipeID=AddToList.RecipeID";

            DataTable dt = dbMan.ExecuteReader(query);
            List<string> recipeNames = new List<string>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    recipeNames.Add(row["Name"].ToString());
                }
            }
            return recipeNames;

        }

        public int deleteTocook(string Rname, int id)
        {
            string query = $"DELETE FROM AddToList WHERE ListType='To-Cook List' and  UserID={id} AND RecipeID IN ( SELECT RecipeID FROM Recipe WHERE Recipe.Name ='{Rname}')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int deletetried(string Rname, int id)
        {
            string query = $"DELETE FROM AddToList WHERE ListType='Tried List' and  UserID={id} AND RecipeID IN ( SELECT RecipeID FROM Recipe WHERE Recipe.Name ='{Rname}')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int deletefav(string Rname, int id)
        {
            string query = $"DELETE FROM AddToList WHERE ListType='Favorite List' and  UserID={id} AND RecipeID IN ( SELECT RecipeID FROM Recipe WHERE Recipe.Name ='{Rname}')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteshopping(string Rname, int id)
        {
            string query = $"DELETE FROM AddToList WHERE ListType='Shopping List' and  UserID={id} AND RecipeID IN ( SELECT RecipeID FROM Recipe WHERE Recipe.Name ='{Rname}')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int GetRecipeIDByName(string recipeName)
        {
            string query = $"SELECT RecipeID FROM Recipe WHERE Name = '{recipeName}'";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["RecipeID"]) : -1;
        }
        public List<string> GetIngredientsForRecipe(int recipeID)
        {
            string query = $" SELECT I.Name FROM Ingredient I, RecipeIngredients RI WHERE RI.RecipeID = {recipeID} AND RI.IngredientID = I.IngredientID";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null || dt.Rows.Count == 0) { return new List<string>(); }
            return dt.AsEnumerable().Select(row => row["Name"].ToString()).ToList();
        }
        public DataTable ShowAllRecipes()
        {
            string query = "Select RecipeID,Name,Description,Steps,Difficulty_Level,NutritionalInfo,Cooking_Time,ChefID,NutritionistID, CompanyID FROM Recipe";
            return dbMan.ExecuteReader(query);
        }
        public int InserRating(int uid, int Rid, double rate)
        {
            string query = $"Insert into Rating (UserID,RecipeID,Rating) values({uid},{Rid},{rate})";
            return dbMan.ExecuteNonQuery(query);

        }

        public int insertTried(string type, int uid, int Rid)
        {
            string query = $"Insert into AddToList values('Tried List','{uid}','{Rid}')";

            return dbMan.ExecuteNonQuery(query);

        }

        public int insertfav(string type, int uid, int Rid)
        {
            string query = $"Insert into AddToList values('Favorite List','{uid}','{Rid}')";

            return dbMan.ExecuteNonQuery(query);

        }

        public int insertTocook(string type, int uid, int Rid)
        {
            string query = $"Insert into AddToList values('To-Cook List','{uid}','{Rid}')";

            return dbMan.ExecuteNonQuery(query);

        }

        public int AddToShoppingList(string type, int uid, int Rid)
        {
            string query = $"Insert into AddToList values('Shopping List','{uid}','{Rid}')";

            return dbMan.ExecuteNonQuery(query);

        }

        public bool isRecipeInshopping(int uid, int Rid)
        {
            string query = $"SELECT COUNT(*) FROM AddToList WHERE ListType='Shopping List' AND UserID={uid} AND RecipeID={Rid}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        public bool isRecipeInTocook(int uid, int Rid)
        {
            string query = $"SELECT COUNT(*) FROM AddToList WHERE ListType='To-Cook List' AND UserID={uid} AND RecipeID={Rid}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        public bool isRecipeInfav(int uid, int Rid)
        {
            string query = $"SELECT COUNT(*) FROM AddToList WHERE ListType='Favorite List' AND UserID={uid} AND RecipeID={Rid}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

        public bool isRecipeInTriedList(int uid, int Rid)
        {
            string query = $"SELECT COUNT(*) FROM AddToList WHERE ListType='Tried List' AND UserID={uid} AND RecipeID={Rid}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        public int updateRating(int uid, int Rid, double rate)
        {
            string query = $"UPDATE Rating SET Rating = {rate} WHERE UserID = {uid} AND RecipeID = {Rid}";
            return dbMan.ExecuteNonQuery(query);
        }


        public int insertmessage(string content, string type, int uid, int Rid)
        {
            string query = $"INSERT INTO Message (Content, MessageType, UserID, RecipeID) VALUES ('{content}','{type}','{uid}','{Rid}')";

            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable Selecttype()
        {
            string query = $"SELECT Distinct MessageType from Message";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetRecipeAuthor(int recipeID)
        {
            string query = $" SELECT CASE WHEN R.ChefID IS NOT NULL THEN 'Chef ' + C.FirstName + ' ' + C.LastName WHEN R.NutritionistID IS NOT NULL THEN 'Nutritionist ' + N.FirstName + ' ' + N.LastName WHEN R.CompanyID IS NOT NULL THEN 'Company ' + Co.Name ELSE 'Unknown' END AS Author FROM Recipe R LEFT JOIN Chef C ON R.ChefID = C.ChefID LEFT JOIN Nutritionist N ON R.NutritionistID = N.NutritionistID LEFT JOIN Company Co ON R.CompanyID = Co.CompanyID WHERE R.RecipeID = {recipeID}";
            return dbMan.ExecuteReader(query);
        }

        public int FollowChef(int userID, int chefID)
        {
            string insertQuery = $"INSERT INTO Follow_Chef (UserID, ChefID) VALUES ({userID}, {chefID})";
            string updateQuery = $"UPDATE Chef SET FollowersCount = FollowersCount + 1 WHERE ChefID = {chefID}";
            dbMan.ExecuteNonQuery(updateQuery);
            return dbMan.ExecuteNonQuery(insertQuery);
        }

        public int FollowNutritionist(int userID, int nutritionistID)
        {
            string insertQuery = $"INSERT INTO Follow_Nutritionist (UserID, NutritionistID) VALUES ({userID}, {nutritionistID})";
            string updateQuery = $"UPDATE Nutritionist SET FollowersCount = FollowersCount + 1 WHERE NutritionistID = {nutritionistID}";
            dbMan.ExecuteNonQuery(updateQuery);
            return dbMan.ExecuteNonQuery(insertQuery);
        }

        public bool isFollowingChef(int userID, int chefID)
        {
            string query = $"SELECT COUNT(*) FROM Follow_Chef WHERE UserID = {userID} AND ChefID = {chefID}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        public bool isFollowingNutritionist(int userID, int nutritionistID)
        {
            string query = $"SELECT COUNT(*) FROM Follow_Nutritionist WHERE UserID = {userID} AND NutritionistID = {nutritionistID}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }

        public bool IsRecipeLikedByUser(int userID, int recipeID)
        {
            string query = $"SELECT COUNT(*) FROM Likes WHERE UserID = {userID} AND RecipeID = {recipeID}";
            DataTable dt = dbMan.ExecuteReader(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0;
        }
        public int LikeRecipe(int userID, int recipeID)
        {
            string query = $"INSERT INTO Likes (UserID, RecipeID) VALUES ({userID}, {recipeID})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UnlikeRecipe(int userID, int recipeID)
        {
            string query = $"DELETE FROM Likes WHERE UserID = {userID} AND RecipeID = {recipeID}";
            return dbMan.ExecuteNonQuery(query);
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///second form functions///

        public DataTable GetAllChefNames()
        {
            string query = "SELECT DISTINCT FirstName + ' ' + LastName as Name FROM Chef";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllNutritionistNames()
        {
            string query = "SELECT DISTINCT FirstName + ' ' + LastName as Name FROM Nutritionist";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllRecipeNames()
        {
            string query = "SELECT Name FROM Recipe";
            return dbMan.ExecuteReader(query);

        }

        public DataTable FilterRecipesByChef(string chefName)
        {
            string query = $" SELECT R.*, C.FirstName + ' ' + C.LastName AS ChefName FROM Recipe R INNER JOIN Chef C ON R.ChefID = C.ChefID WHERE C.FirstName + ' ' + C.LastName = '{chefName}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable FilterRecipesByNutritionist(string nutritionistName)
        {
            string query = $" SELECT R.*, N.FirstName + ' ' + N.LastName AS NutritionistName FROM Recipe R INNER JOIN Nutritionist N ON R.NutritionistID = N.NutritionistID WHERE N.FirstName + ' ' + N.LastName = '{nutritionistName}'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable FilterRecipesByDifficulty(int difficulty)
        {
            string query = $" SELECT R.*, COALESCE(C.FirstName + ' ' + C.LastName, N.FirstName + ' ' + N.LastName, Co.Name) AS AuthorName FROM Recipe R LEFT JOIN Chef C ON R.ChefID = C.ChefID LEFT JOIN Nutritionist N ON R.NutritionistID = N.NutritionistID LEFT JOIN Company Co ON R.CompanyID = Co.CompanyID WHERE R.Difficulty_Level = {difficulty}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable FilterRecipesByTimeRange(int minTime, int maxTime)
        {
            string query = $" SELECT R.*, COALESCE(C.FirstName + ' ' + C.LastName, N.FirstName + ' ' + N.LastName, Co.Name) AS AuthorName FROM Recipe R LEFT JOIN Chef C ON R.ChefID = C.ChefID LEFT JOIN Nutritionist N ON R.NutritionistID = N.NutritionistID LEFT JOIN Company Co ON R.CompanyID = Co.CompanyID WHERE R.Cooking_Time BETWEEN {minTime} AND {maxTime}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTop5Recipes()
        {
            string query = " SELECT TOP 5 R.RecipeID, R.Name, R.Description, R.Steps, R.Image,R.Difficulty_Level, R.NutritionalInfo, R.Cooking_Time, COALESCE(C.FirstName + ' ' + C.LastName, N.FirstName + ' ' + N.LastName, Co.Name) AS AuthorName, COUNT(L.UserID) AS TotalLikes FROM Recipe R LEFT JOIN Likes L ON R.RecipeID = L.RecipeID LEFT JOIN Chef C ON R.ChefID = C.ChefID LEFT JOIN Nutritionist N ON R.NutritionistID = N.NutritionistID LEFT JOIN Company Co ON R.CompanyID = Co.CompanyID GROUP BY R.RecipeID, R.Name, R.Description, R.Steps, R.Image,R.Difficulty_Level, R.NutritionalInfo, R.Cooking_Time, R.ChefID, R.NutritionistID, R.CompanyID, C.FirstName, C.LastName, N.FirstName, N.LastName, Co.Name ORDER BY TotalLikes DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetRecipeDetailsById(int recipeId)
        {
            string query = $"SELECT * FROM Recipe WHERE RecipeID = {recipeId}";
            return dbMan.ExecuteReader(query);
        }

        /// //////////////////////////////////
        ///// signup///////
        public bool checkEmail(string email)
        {
            int ret = (int)dbMan.ExecuteScalar($"Select Count(Email) from Users where Email = '{email}';");
            return ret > 0 ? true : false;
        }

        public bool AddUser(string fname, string LNAME, string email, string password)
        {
            string EncryptedPassword = EncryptPassword(password);
            int ret = dbMan.ExecuteNonQuery($"Insert into Users (FirstName, LastName, Email, Password, Admin) Values ('{fname}','{LNAME}','{email}','{EncryptedPassword}',0);");
            return ret != 0;
        }

        public int GetUserID(string email, string userType)
        {
            if (userType == "Users")
                return (int)dbMan.ExecuteScalar($"Select UserID From {userType} Where email = '{email}';");

            return (int)dbMan.ExecuteScalar($"Select {userType}ID From {userType} Where email = '{email}';");
        }







        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }




    }
}


