using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using EmployeeManagementSystem.DataAccessLayer;

namespace EmployeeManagementSystem.BusinessLayer
{
    class EmployeeRepository
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }

        private int Id { get; set; }
        private string Name { get; set; }
        private string ContactNo { get; set; }
        private string JoiningDate { get; set; }
        private decimal Salary { get; set;}
        private int Workhour { get; set; }
        private string Address { get; set; }
        

        public EmployeeRepository()
        {
            this.con = new Connection();
        }

        public DataSet Display(string sql = "select * from Employee;")
        {
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public DataSet SearchUser(string name)
        {
            string sql = "select * from Employee where EmpID = '" + name + "';";
            this.Ds = this.con.ExecuteQuery(sql);
            return this.Ds;
        }

        public void Delete(int id)
        {
            string sql = "delete from Employee where EmpID="+id+"";
            string sql1 = "delete from Details where EmpID=" + id + "";

            try
            {
                this.con.ExecuteUpdateQuery(sql);
                this.con.ExecuteQuery(sql1);
                MessageBox.Show("Deletation Done.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        public void Insert(string name, string email, string contactNo, string joiningDate, decimal salary, string address)
        {


            string sql = @"insert into Employee
                values ('" + name + "','" + email + "', '" + contactNo + @"'
                , '" + joiningDate + "','" + address + "');";

            string sql1 = @"insert into Details values (" + salary + "," + 0 + "," + 0 + "," + 0 + "," + 0 + " );";
            try
            {
                this.con.ExecuteUpdateQuery(sql);
                this.con.ExecuteQuery(sql1);
                MessageBox.Show("Insertion Done.");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);

            }
        }
            




        


        public void Update(int id,string name, string email, string contactNo, decimal salary, string address)
        {

                string sql = @"Update Employee
                set Name='" + name + "',Email='" + email + "',ContactNo= '" + contactNo + @"'
                ,Address='" + address + "' where EmpID="+id+";";
                
                string sql1 = @"Update Details
                set DefaultSalary="+salary+" where EmpID=" + id + ";";
            try
                {
                    this.con.ExecuteUpdateQuery(sql);
                    this.con.ExecuteUpdateQuery(sql1);
                MessageBox.Show("Update Successfull.");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            




        }

       
    }
}
