using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Student
    {
        public enum Nationality
        {
            BD, //Bangladesh
            CA, //Canada
            CN, //China
            HK, //Hong Kong
            ID, //Indonesia
            JP, //Japan
            MY, //Malaysia
            SG, //Singapore
        }

        private readonly String CONNECTION_STRING = Properties.Settings.Default.EddieIsDebarredConnectionString;
        public String AdminNumber { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public Nationality CitizenShip { get; set; }
        public String MobileNumber { get; set; }
        public String SchoolEmail { get; set; }
        public String ImageURL { get; set; }
        public int Insert(out String error)
        {
            int result = 0;
            error = String.Empty;
            String query = "INSERT INTO Student(AdminNumber, Name, Gender, DOB, Address, Citizenship, Mobile, Email, ImageURL) values (@AdminNumber, @Name, @Gender, @DOB, @Address, @Citizenship, @Mobile, @Email, @ImageURL)";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminNumber", this.AdminNumber);
                    command.Parameters.AddWithValue("@Name", this.Name);
                    command.Parameters.AddWithValue("@Gender", this.Gender);
                    command.Parameters.AddWithValue("@DOB", this.DateOfBirth);
                    command.Parameters.AddWithValue("@Address", this.Address);
                    command.Parameters.AddWithValue("@Citizenship", this.CitizenShip.ToString());
                    command.Parameters.AddWithValue("@Mobile", this.MobileNumber);
                    command.Parameters.AddWithValue("@Email", this.SchoolEmail);
                    command.Parameters.AddWithValue("@ImageURL", this.ImageURL);

                    try
                    {
                        connection.Open();
                        result += command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (System.Exception exception)
                    {
                        error = exception.Message;
                    }
                }
            }

            return result;
        }
        public int Delete(String adminNumber)
        {
            //Delete the following and add your implementation here
            throw new NotImplementedException();
        }

        public Student GetStudent(String adminNumber)
        {
            Student student = new Student();
            String query = "SELECT * FROM Student WHERE AdminNumber = @AdminNumber";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminNumber", adminNumber);

                    connection.Open();

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            student.AdminNumber = adminNumber;
                            student.Name = dataReader["Name"].ToString();
                            student.Gender = dataReader["Gender"].ToString();
                            student.DateOfBirth = DateTime.Parse(dataReader["DOB"].ToString());
                            student.Address = dataReader["Address"].ToString();
                            switch (dataReader["CitizenShip"].ToString())
                            {
                                case "BD":
                                    student.CitizenShip = Student.Nationality.BD;
                                    break;
                                case "CA":
                                    student.CitizenShip = Student.Nationality.CA;
                                    break;
                                case "CN":
                                    student.CitizenShip = Student.Nationality.CN;
                                    break;
                                case "HK":
                                    student.CitizenShip = Student.Nationality.HK;
                                    break;
                                case "ID":
                                    student.CitizenShip = Student.Nationality.ID;
                                    break;
                                case "JP":
                                    student.CitizenShip = Student.Nationality.JP;
                                    break;
                                case "MY":
                                    student.CitizenShip = Student.Nationality.MY;
                                    break;
                                case "SG":
                                    student.CitizenShip = Student.Nationality.SG;
                                    break;
                            }

                            student.MobileNumber = dataReader["Mobile"].ToString();
                            student.SchoolEmail = dataReader["Email"].ToString();
                            student.ImageURL = dataReader["ImageURL"].ToString();
                        }

                        dataReader.Close();
                        dataReader.Dispose();
                    }

                    connection.Close();
                }
            }

            return student;
        }

        public List<Student> GetAllStudents()
        {
            //Delete the following and add your implementation here
            throw new NotImplementedException();
        }
    }
}
