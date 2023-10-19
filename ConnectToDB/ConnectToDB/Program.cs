using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection.PortableExecutable;

namespace ConnectToDB
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Delete data
            //Employee.DeleteData("EM16330");
            //Add Data
            Employee em = new Employee("0000000", "Serena", "Williams", 20000);
            em.InsertData();
            //Retrieve data  
            foreach (Employee emp in Employee.RetriveData())
            {
                Console.WriteLine(emp.ToString());
            }
            Console.Read();
        }


    

        

        


    }
}