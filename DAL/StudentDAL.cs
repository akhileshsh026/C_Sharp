using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL
    {
        public int insert(string FileName, string Lastname, int age)
        {
            
            SqlConnection constring = new SqlConnection("Server=12.76.87.192;DataBase=Student;user=sa;Password=Akhilesh@123");

        }
    }
}
