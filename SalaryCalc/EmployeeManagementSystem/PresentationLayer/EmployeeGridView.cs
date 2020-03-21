using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagementSystem.BusinessLayer;
using EmployeeManagementSystem.DataAccessLayer;

namespace EmployeeManagementSystem.PresentationLayer
{
    public delegate void EMployeeGridViewVisible();
    public partial class EmployeeGridView : MetroFramework.Forms.MetroForm
    {
        
        private Connection con { get; set; }
        private DataSet Ds { get; set; }

        private ManagerVisible MV { get; set; }
        private int TempID { get; set; }

        public EmployeeGridView(ManagerVisible mv)
        {
            InitializeComponent();
            MV = mv;

            DisplayGrid();
        }

        private void BtnManageSalary_Click(object sender, EventArgs e)
        {
            var FormVisibility = new EmployeeGridView(this.Visibility);
            var mngsal = new ManageSalary(LblID.Text,Visibility);
            mngsal.Visible = true;
            this.Visible = false;
        }

        private void Visibility()
        {
            this.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MV();
        }

        private void EmployeeGridView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MV();
        }


        private void TxtSearch_Click(object sender, EventArgs e)
        {

            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select Employee.EmpID,Employee.Name,Employee.Email,Employee.JoiningDate,Employee.ContactNo, Employee.Address, Details.DefaultSalary, Details.totalBonus, Details.OvertimeCount from Employee, Details where Employee.EmpID = Details.EmpID and Employee.Name='"+this.TxtSearch.Text+"'", con);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvAll.Rows.Add();
                dgvAll.Rows[n].Cells[0].Value = item[0].ToString();
                // dgvAll.Rows[n].Cells[1].Value = item["EmpID"].ToString();
                dgvAll.Rows[n].Cells[1].Value = item["Name"].ToString();
                dgvAll.Rows[n].Cells[2].Value = item["Email"].ToString();
                dgvAll.Rows[n].Cells[3].Value = item["JoiningDate"].ToString();
                dgvAll.Rows[n].Cells[4].Value = item["ContactNo"].ToString();
                dgvAll.Rows[n].Cells[5].Value = item["Address"].ToString();
                dgvAll.Rows[n].Cells[6].Value = item["DefaultSalary"].ToString();
                dgvAll.Rows[n].Cells[7].Value = item["totalBonus"].ToString();
                dgvAll.Rows[n].Cells[8].Value = item["OvertimeCount"].ToString();
            }

            
        }

        public void DisplayGrid()
        {
            dgvAll.Rows.Clear();

            var con = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            SqlDataAdapter sql = new SqlDataAdapter("select Employee.EmpID,Employee.Name,Employee.Email,Employee.JoiningDate,Employee.ContactNo, Employee.Address, Details.DefaultSalary, Details.totalBonus, Details.OvertimeCount from Employee, Details where Employee.EmpID = Details.EmpID", con);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvAll.Rows.Add();
                dgvAll.Rows[n].Cells[0].Value = item[0].ToString();
               // dgvAll.Rows[n].Cells[1].Value = item["EmpID"].ToString();
                dgvAll.Rows[n].Cells[1].Value = item["Name"].ToString();
                dgvAll.Rows[n].Cells[2].Value = item["Email"].ToString();
                dgvAll.Rows[n].Cells[3].Value = item["JoiningDate"].ToString();
                dgvAll.Rows[n].Cells[4].Value = item["ContactNo"].ToString();
                dgvAll.Rows[n].Cells[5].Value = item["Address"].ToString();
                dgvAll.Rows[n].Cells[6].Value = item["DefaultSalary"].ToString();
                dgvAll.Rows[n].Cells[7].Value = item["totalBonus"].ToString();
                dgvAll.Rows[n].Cells[8].Value = item["OvertimeCount"].ToString();
            }
        }

        private void dgvAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string temp;
            temp =this.dgvAll.CurrentRow.Cells[0].Value.ToString();
            this.TempID = int.Parse(temp);



            this.LblID.Text = dgvAll.CurrentRow.Cells[0].Value.ToString();
            this.TxtName.Text = dgvAll.CurrentRow.Cells[1].Value.ToString();
            this.TxtEmail.Text = dgvAll.CurrentRow.Cells[2].Value.ToString();
            this.TxtContact.Text = dgvAll.CurrentRow.Cells[4].Value.ToString();
            this.TxtAddress.Text = dgvAll.CurrentRow.Cells[5].Value.ToString();
            this.TxtSalary.Text = dgvAll.CurrentRow.Cells[6].Value.ToString();


            PanelSal.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var emprep = new EmployeeRepository();
            emprep.Delete(TempID);

            DisplayGrid();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayGrid();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "" && TxtEmail.Text != "" && TxtContact.Text != "" && this.TxtSalary.Text != ""&& this.TxtAddress.Text != "")
            {
                var emprep = new EmployeeRepository();
                emprep.Update(int.Parse(this.LblID.Text), TxtName.Text, TxtEmail.Text, TxtContact.Text, decimal.Parse(this.TxtSalary.Text), this.TxtAddress.Text);

                DisplayGrid();
            }
            else
                {
                MessageBox.Show("Select From The Table to Update.");
            }
        }

        private void EmployeeGridView_Load(object sender, EventArgs e)
        {
            PanelSal.Visible = false;
        }
    }
}
