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
    public delegate void LoginVisible();
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private DataSet Ds { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TxtUserID.Text == "101" && TxtPassword.Text == "123")
            {
                LoginVisible LoginFromVisibility = new LoginVisible(this.Visibility);
                Manager man = new Manager(LoginFromVisibility);
                man.Visible = true;
                this.Visible = false;
            }else
            {
                MessageBox.Show("ID or Password Error!");
            }
        }

        private void Visibility()
        {
            this.Visible = true;
            this.TxtUserID.Text = "";
            this.TxtPassword.Text = "";
        }
    }
}
