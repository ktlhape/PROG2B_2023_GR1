using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB
{
    public class Employee
    {
        static string strCon = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        public  string EmpNo { get; set; }
        public  string Firstname { get; set; }
        public  string Lastname { get; set; }
        public  decimal Salary { get; set; }

        public Employee(string empNo, string firstname, string lastname, decimal salary)
        {
            EmpNo = empNo;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
        }

        public void InsertData()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = strCon;
                con.Open();
                //2. Create a command

                    string strInsert = $"INSERT INTO tblEmployee VALUES('{EmpNo}','{Firstname}','{Lastname}',{Salary})";
                    SqlCommand cmdInsert = new SqlCommand(strInsert, con);
                    //3. Execute the command
                    cmdInsert.ExecuteNonQuery();
            }
        }
       public static void DeleteData(string emNo)
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmdDelete = new($"DELETE FROM tblEmployee WHERE EmployeeNo = '{emNo}'", con);
            con.Open();
            cmdDelete.ExecuteNonQuery();
            con.Close();
        }

        public static List<Employee> RetriveData()
        {
            List<Employee> employees = new();
            //1. Create connection
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                //2.
                string strSelect = "SELECT * FROM tblEmployee";
                SqlCommand cmdSelect = new(strSelect, con);
                //3.
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new((string)reader["EmployeeNo"], (string)reader[1], reader.GetString(2), (decimal)reader["Salary"]));
                    }
                }
            }

            return employees;
        }

        public static DataTable GetData()
        {
            //Declare Datatbale and Datarow
            SqlConnection con = new SqlConnection(strCon);
            DataTable myTable = new DataTable();
            DataRow myRow;
            string strSelect = "SELECT * FROM tblEmployee";
            //Option 1
            //SqlCommand cmdSelect = new SqlCommand(strSelect,con);
            //SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            //Option 2
            SqlDataAdapter myAdapter = new SqlDataAdapter(strSelect, con);

            con.Open();
            //Fill the table using the adapter
            myAdapter.Fill(myTable);
            if (myTable.Rows.Count > 0)
            {
                return myTable;
                //for (int i = 0; i < myTable.Rows.Count; i++)
                //{
                //    myRow = myTable.Rows[i];
                //    string emNo = (string)myRow[0];
                //    string firstname = (string)myRow[1];
                //    string lastname = (string)myRow["Lastname"];
                //    decimal salary = (decimal)myRow["Salary"];
                //    Console.WriteLine($"[{emNo}]\t\t{firstname}\t\t{lastname}\t\t{salary.ToString("C2")}");
                //}

            }

            con.Close();

            return null;

        }

        public override string? ToString()
        {
            return $"[{EmpNo}]\t\t{Firstname}\t\t{Lastname}\t\t{Salary.ToString("C2")}";
        }
    }
}
