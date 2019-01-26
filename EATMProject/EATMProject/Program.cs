using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Configuration;
using System.Data;

namespace EATMProject
{
    public class CreateFileOrFolder
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }


        public static void UserLogin()
        {


            Console.Clear();
            Console.WriteLine("Hello Member! Please enter your login information.");
            Console.WriteLine();
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Members WHERE UserName = '" + username + "' PassWord = '" + password + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Login Sucess!!");
                SqlCommand cmdS = new SqlCommand("SELECT FirstName FROM Members WHERE UserName =@UserName", conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                string firstName = cmd.ExecuteScalar().ToString();
                Console.WriteLine(firstName);
                Console.ReadLine();
                conn.Close();
            }
            else
            {
                Console.WriteLine("Access Denied!!");
                conn.Close();
            }






        }

        public static void UserRegistration()
        {
            Console.Clear();
            string newFirstName = "";
            string newLastName = "";
            string newPhoneNumber = "";
            string newUserName = "";
            string newPassWord = "";

            Console.WriteLine($"Welcome new JJ Credit Union Member! Please fill out the registration form.\n");
            Console.WriteLine("First name?");
            newFirstName = Console.ReadLine();

            Console.WriteLine($"Last name?");
            newLastName = Console.ReadLine();

            Console.WriteLine($"Phone number?");
            newPhoneNumber = Console.ReadLine();

            Console.WriteLine($"User name?");
            newUserName = Console.ReadLine();

            Console.WriteLine($"Pass word?");
            newPassWord = Console.ReadLine();

            Console.WriteLine($"Thank you for completing the registration process!\nYou may login when ever you are ready.");
            Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT Members (FirstName, LastName, PhoneNumber, UserName, PassWord) Values (@newFirstName, @newLastName, @newPhoneNumber, @newUserName, @newPassWord)";
                    cmd.Parameters.Add("@newFirstName", SqlDbType.NVarChar).Value = newFirstName;
                    cmd.Parameters.Add("@newLastName", SqlDbType.NVarChar).Value = newLastName;
                    cmd.Parameters.Add("@newPhoneNumber", SqlDbType.NVarChar).Value = newPhoneNumber;
                    cmd.Parameters.Add("@newUserName", SqlDbType.NVarChar).Value = newUserName;
                    cmd.Parameters.Add("@newPassWord", SqlDbType.NVarChar).Value = newPassWord;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Rows Affected: {0}", rowsAffected);
                }
            }
            Console.ReadLine();
        }
            public static void DisplayMenu()
        {
        displayMenu:
            Console.Clear();
            string display = "0";
            Console.WriteLine($"Welcome JJ Credit Union.");
            Console.WriteLine();
            Console.WriteLine("{1}Member Login");
            Console.WriteLine("{2}New Member Registration");
            Console.WriteLine("{9}Exit.");
            Console.WriteLine();
            display = Console.ReadLine();
            Console.WriteLine();

            while (display != "9")

                if (display == "1")
                {
                    
                    UserLogin();
                    goto displayMenu;
                }
                else if (display == "2")
                {
                    UserRegistration();
                    goto displayMenu;
                }
                else if (display == "9")
                {
                    break;
                }
                else
                {
                    goto displayMenu;
                }
        }

    }
}