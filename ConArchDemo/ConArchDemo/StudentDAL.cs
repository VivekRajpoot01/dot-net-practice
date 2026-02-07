using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//For Ado.net
using System.Data.SqlClient;
using System.Data;

namespace ConArchDemo
{
    /// <summary>
    /// Demo Code for Connected Architecture in StudentDal Class
    /// </summary>
    public class StudentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress; Integrated Security = SSPI; Database = LPU_DB; TrustServerCertificate=true";
        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;
            //Code for connected arch below


            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Holding data via Reader
                sdr = cmd.ExecuteReader();

                DataTable myDT = new DataTable();

                myDT.Load(sdr);

                //convert table into list
                foreach(DataRow drow in myDT.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[2].ToString()

                    };

                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public Student SearchByName(string name)
        {
            List<Student> studList = null;
            return studList;
        }

        public Student SearchByRollNo(int rollNo)
        {
            List<Student> studList = null;
            return studList;
        }

    }
}
