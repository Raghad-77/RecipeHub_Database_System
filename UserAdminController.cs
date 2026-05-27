using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace DBapplication
{
    public class UserAdminController
    {
        DBManager dbMan;

        public UserAdminController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public string GetName(int id)
        {
            return (string)dbMan.ExecuteScalar($"Select firstname + ' ' + lastname as fullname from Users where UserID={id};");
        }
        public int GetPendingChefsCount()
        {
            return (int)dbMan.ExecuteScalar($"Select Count(*) From Chef Where IsApproved = 0;");
        }
        public DataTable GetPendingChefsDetails()
        {
            return dbMan.ExecuteReader("Select FirstName + ' ' + LastName as fullname, Email,ChefID From Chef Where IsApproved = 0;");
        }
        public void ApproveChef(int id)
        {
            dbMan.ExecuteNonQuery($"Update Chef Set IsApproved=1 Where ChefID={id};");
        }
        public int GetPendingNutritionistsCount()
        {
            return (int)dbMan.ExecuteScalar($"Select Count(*) From Nutritionist Where IsApproved = 0;");
        }

        public DataTable GetPendingNutritionistsDetails()
        {
            return dbMan.ExecuteReader("Select FirstName + ' ' + LastName as fullname, Email, NutritionistID From Nutritionist Where IsApproved = 0;");
        }

        public void ApproveNutritionist(int id)
        {
            dbMan.ExecuteNonQuery($"Update Nutritionist Set IsApproved=1 Where NutritionistID={id};");
        }

        public int GetPendingCompaniesCount()
        {
            return (int)dbMan.ExecuteScalar($"Select Count(*) From Company Where IsApproved = 0;");
        }

        public DataTable GetPendingCompaniesDetails()
        {
            return dbMan.ExecuteReader("Select Name, Email, CompanyID From Company Where IsApproved = 0;");
        }

        public void ApproveCompany(int id)
        {
            dbMan.ExecuteNonQuery($"Update Company Set IsApproved=1 Where CompanyID={id};");
        }

        public void UpdateAdminID(int ID, int AdminID, string userType)
        {
            dbMan.ExecuteNonQuery($"Update {userType} Set AdminID={AdminID} Where {userType}ID={ID};");
        }
        public int Total_UsersCount()
        {
            return (int)dbMan.ExecuteScalar("Select Count(*) from users;");
        }
        public int Total_ChefsCount()
        {
            return (int)dbMan.ExecuteScalar("Select Count(*) from Chef;");
        }
        public int Total_NutritionistsCount()
        {
            return (int)dbMan.ExecuteScalar("Select Count(*) from Nutritionist;");
        }
        public int Total_CompaniesCount()
        {
            return (int)dbMan.ExecuteScalar("Select Count(*) from Company;");
        }
        public int TotalRecipes()
        {
            return (int)dbMan.ExecuteScalar("Select Count(*) from Recipe;");
        }
        public DataTable RecipesSorted()
        {
            return dbMan.ExecuteReader("SELECT R.Name, COUNT(L.UserID) AS TotalLikes FROM Recipe R LEFT JOIN Likes L ON R.RecipeID = L.RecipeID GROUP BY R.Name ORDER BY TotalLikes DESC");
        }
        public DataTable TotalRecipesForChefs()
        {
            return dbMan.ExecuteReader("SELECT C.FirstName + ' ' + C.LastName AS ChefName, COUNT(R.RecipeID) AS TotalRecipes FROM Recipe R JOIN Chef C ON R.ChefID = C.ChefID GROUP BY C.FirstName, C.LastName ORDER BY TotalRecipes DESC");
        }
        public double getAVGRating()
        {
            return (double)dbMan.ExecuteScalar("SELECT AVG(Rating) AS AverageRating FROM Rating");
        }

    }
}

