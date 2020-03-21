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
    public delegate void ManagerVisible();
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        private Connection con { get; set; }
        private DataSet Ds { get; set; }
        private LoginVisible LV { get; set; }

        public Manager(LoginVisible lv)
        {
            InitializeComponent();
            LV = lv;

        }

        private void BtnNwEmp_Click(object sender, EventArgs e)
        {
            var FormVisibilty = new ManagerVisible(this.Visibility);
            var ne = new Add_Employee(FormVisibilty);
            ne.Visible = true;
            this.Visible = false;
        }

        private void Visibility()
        {
            this.Visible = true;
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            LV();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            LV();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var FormVisibilty = new ManagerVisible(this.Visibility);
            var empgrid = new EmployeeGridView(FormVisibilty);
            empgrid.Visible = true;
            this.Visible = false;
        }
    }
}
