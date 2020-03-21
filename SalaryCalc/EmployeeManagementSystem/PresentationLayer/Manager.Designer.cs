namespace EmployeeManagementSystem.PresentationLayer
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnNwEmp = new MetroFramework.Controls.MetroButton();
            this.BtnLogout = new MetroFramework.Controls.MetroButton();
            this.BtnMngEmp = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnNwEmp);
            this.metroPanel1.Controls.Add(this.BtnLogout);
            this.metroPanel1.Controls.Add(this.BtnMngEmp);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(278, 349);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnNwEmp
            // 
            this.BtnNwEmp.Location = new System.Drawing.Point(37, 165);
            this.BtnNwEmp.Name = "BtnNwEmp";
            this.BtnNwEmp.Size = new System.Drawing.Size(204, 81);
            this.BtnNwEmp.TabIndex = 6;
            this.BtnNwEmp.Text = "New Employee";
            this.BtnNwEmp.UseSelectable = true;
            this.BtnNwEmp.Click += new System.EventHandler(this.BtnNwEmp_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(187, 272);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(88, 45);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseSelectable = true;
            this.BtnLogout.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // BtnMngEmp
            // 
            this.BtnMngEmp.Location = new System.Drawing.Point(37, 77);
            this.BtnMngEmp.Name = "BtnMngEmp";
            this.BtnMngEmp.Size = new System.Drawing.Size(204, 82);
            this.BtnMngEmp.TabIndex = 4;
            this.BtnMngEmp.Text = "Manage Employee";
            this.BtnMngEmp.UseSelectable = true;
            this.BtnMngEmp.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 438);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Manager";
            this.Resizable = false;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnLogout;
        private MetroFramework.Controls.MetroButton BtnMngEmp;
        private MetroFramework.Controls.MetroButton BtnNwEmp;
    }
}