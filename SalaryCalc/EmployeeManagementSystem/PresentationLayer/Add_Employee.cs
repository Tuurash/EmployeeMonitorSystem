using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.BusinessLayer;
using EmployeeManagementSystem.DataAccessLayer;

namespace EmployeeManagementSystem.PresentationLayer
{
    
    public partial class Add_Employee : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private ManagerVisible MV { get; set; }

        public Add_Employee(ManagerVisible man)
        {
            InitializeComponent();
            this.con = new Connection();
            this.MV = man;
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

        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            MV();
        }

        private void BtnHire_Click(object sender, EventArgs e)
        {
            if (this.TxtName.Text != "" && this.TxtEmail.Text != "" && this.TxtContact.Text != "" && this.TxtDate.Text != "" && this.TxtSalary.Text != "" && this.TxtAddress.Text != "")
            {
                var Emprep = new EmployeeRepository();
                Emprep.Insert(this.TxtName.Text, this.TxtEmail.Text, this.TxtContact.Text, this.TxtDate.Text, decimal.Parse(this.TxtSalary.Text), this.TxtAddress.Text);
                clear();
            }
            else { MessageBox.Show("Fillup Mendatory Sections With Correct Format."); }
        }

        public void clear()
        {
            this.TxtName.Text = this.TxtEmail.Text = this.TxtContact.Text = this.TxtDate.Text = this.TxtSalary.Text = this.TxtAddress.Text = "";
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var empgrid = new EmployeeGridView(Visibility);
            empgrid.Visible = true;
             
            this.Close();
        }
    }
}
