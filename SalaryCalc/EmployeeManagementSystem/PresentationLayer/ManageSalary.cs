using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagementSystem.BusinessLayer;
using EmployeeManagementSystem.DataAccessLayer;

namespace EmployeeManagementSystem.PresentationLayer
{
    public partial class ManageSalary : MetroFramework.Forms.MetroForm
    {
        //private Connection con { get; set; }
        //private DataSet Ds { get; set; }
        private EMployeeGridViewVisible EV { get; set; }
        public ManageSalary(string id,EMployeeGridViewVisible ev)
        {

            InitializeComponent();

            EV = ev;

            LblID.Text = id;
            
        }

        private void ManageSalary_Load(object sender, EventArgs e)
        {
            DisplaySal();
            
        }

        private void ManageSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            EV();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            EV();

            
        }

        public void DisplaySal()
        {
            var conn = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            

            string sql = "select * from Details where EmpID="+int.Parse(LblID.Text)+"";

            var cmd = new SqlCommand(sql,conn);

            conn.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            if(DR.Read())
            {
                TxtDefaultSalary.Text = (DR["DefaultSalary"].ToString());
                TxtWholeSal.Text = (DR["TotalSalary"].ToString());
                TxtOTpay.Text = (DR["totalBonus"].ToString());
                TxtOTcount.Text = (DR["OvertimeCount"].ToString());
                TxtWorkhrMonthly.Text = (DR["WorkHourMonthly"].ToString());
                

            }
            conn.Close();


        }

        public void CalculateSal()
        {
            decimal Sal = decimal.Parse(TxtDefaultSalary.Text);
            int WorkHr;

            if (int.Parse(TxtWorkhrMonthly.Text) != 0)
            {
                WorkHr = int.Parse(TxtWorkhrMonthly.Text);
            }else
            {
                MessageBox.Show("Monthly Work Hour = 0 ");
                WorkHr = int.Parse(TxtWorkhrMonthly.Text);
            }

            int DefaultWorkHr = 240;

            int OTMnthly = WorkHr - DefaultWorkHr;
            if (OTMnthly >= 0)
            {
                this.TxtOvertimeMnthly.Text = OTMnthly.ToString();
            }
            else
            {
                OTMnthly = 0;
                this.TxtOvertimeMnthly.Text = OTMnthly.ToString();
            }

            int OTcount = OTMnthly / 2;

            this.TxtOTcount.Text = OTcount.ToString();

            decimal Bonus = OTcount * 500;

            this.TxtOTpay.Text = Bonus.ToString();

            int AvrgWorkHr = WorkHr / 30;

            this.TxtDailyworkHR.Text = AvrgWorkHr.ToString();

            decimal TotalSal = Sal + Bonus;

            this.TxtWholeSal.Text = TotalSal.ToString();

            var conn = new SqlConnection(@"Data Source=DESKTOP-P1NIJ6M\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            

            string sql = "update Details set DefaultSalary = "+Sal+",TotalSalary = "+TxtWholeSal.Text+",totalBonus = "+TxtOTpay.Text+",OvertimeCount = "+TxtOTcount.Text+",WorkHourMonthly = "+TxtWorkhrMonthly.Text+" where EmpID = "+int.Parse(LblID.Text)+"; ";

            var cmd = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader DR = cmd.ExecuteReader();

            if (DR.Read())
            {
                TxtDefaultSalary.Text = (DR["DefaultSalary"].ToString());
                TxtWholeSal.Text = (DR["TotalSalary"].ToString());
                TxtOTpay.Text = (DR["totalBonus"].ToString());
                TxtOTcount.Text = (DR["OvertimeCount"].ToString());
                TxtWorkhrMonthly.Text = (DR["WorkHourMonthly"].ToString());


            }
            conn.Close();



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CalculateSal();
        }
    }
}
