
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _connectionString = @"Data Source=SPICE-AND-WOLF\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string Email)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(Email))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string queryString = @"Insert Into SignUps (FirstName, LastName, Email) Values
                                        (@FirstName, @LastName, @Email)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@Email", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@Email"].Value = Email;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                    return View("Success");
            }

        }

        public ActionResult Admin()
        {
            string queryString = @"Select Id, FirstName, LastName, Email, SocialSecurityNumber From SignUps";

            List<Newsletter_Sign_Up> signups = new List<Newsletter_Sign_Up>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new Newsletter_Sign_Up();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.Email = reader["Email"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                    signups.Add(signup);
                }
            }

            var signupVMs = new List<SignupVM>();
            foreach (var signup in signups)
            {
                var signupVm = new SignupVM();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.Email = signup.Email;
                signupVMs.Add(signupVm);

            }

            return View(signupVMs);
        }
    }
}