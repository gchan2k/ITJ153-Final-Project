using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
        public Student GetStudent(String adminNumber)
        {
            Student student = new Student();
            return student.GetStudent(adminNumber);
        }
        public List<Student> GetAllStudents()
        {
            Student student = new Student();
            return student.GetAllStudents();
        }

        public int InsertStudent(String adminNumber, String name, String gender, DateTime dob, String address, Student.Nationality citizenship, String mobile, String email, String imageURL, out String error)
        {
            Student student = new Student();

            student.AdminNumber = adminNumber;
            student.Name = name;
            student.Gender = gender;
            student.DateOfBirth = dob;
            student.Address = address;
            student.CitizenShip = citizenship;
            student.MobileNumber = mobile;
            student.SchoolEmail = email;
            student.ImageURL = imageURL;

            int result = student.Insert(out error);
            return result;
        }

        public int DeleteStudent(String adminNumber)
        {
            Student student = new Student();

            int result = student.Delete(adminNumber);
            return result;
        }
    }
}
