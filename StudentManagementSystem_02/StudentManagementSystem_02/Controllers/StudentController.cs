using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem_02.Models;

namespace StudentManagementSystem_02.Controllers
{
    public class StudentController : Controller
    {
        //Connection string to connect to my local database
        private string _connectionString = @"Data Source=SPICE-AND-WOLF\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET: Student
        public ActionResult Index()
        {
            string queryString = "Select * from Students"; //Command I want to perform upon my database
            List<Student> students = new List<Student>(); //List to append to

            using (SqlConnection connection = new SqlConnection(_connectionString)) //sets up connection using my connection string
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open(); //opens connection
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //while there is stuff to read
                {
                    Student student = new Student(); //create new student using the information that is read from my database
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FIrstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    students.Add(student);
                }
                connection.Close(); //close conenction
            }
            return View(students); //returns to page that shows the students in my database
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            string queryString = @"Insert Into Students (FirstName, LastName) Values (@FirstName, @LastName)"; //generates table using database information
            using (SqlConnection connection = new SqlConnection(_connectionString)) //pulling information from FirstName and LastName colummns and placing them into
            {                                                                       //FirstName and LastName in the new list
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar); //tells type of data being worked with
                command.Parameters.Add("@LastName", SqlDbType.VarChar);

                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery(); //populating with data not looking for data

                connection.Close();
            }

            return RedirectToAction("Index"); //returns to the index
        }

        public ActionResult Details(int id) //houses students details
        {
            string queryString = "Select * From Students where id = @id"; //string to retrieve specific data from database relating to a single student
            Student student = new Student();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
            }
            return View(student);
        }

        public ActionResult Edit(int id)
        {
            string queryString = "Select * From Students Where Id = @id";
            Student student = new Student();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            string queryString = @"Update Students set FirstName = @FirstName, LastName = @LastName where Id = @Id"; //updates database where we want with the information we choose

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(@"Id", SqlDbType.Int);
                command.Parameters.Add(@"FirstName", SqlDbType.VarChar);
                command.Parameters.Add(@"LastName", SqlDbType.VarChar);

                command.Parameters["@Id"].Value = student.Id;
                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }
    }
}