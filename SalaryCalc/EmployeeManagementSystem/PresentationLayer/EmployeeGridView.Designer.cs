namespace EmployeeManagementSystem.PresentationLayer
{
    partial class EmployeeGridView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnUpdate = new MetroFramework.Controls.MetroPanel();
            this.dgvAll = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSearch = new MetroFramework.Controls.MetroLabel();
            this.LblID = new MetroFramework.Controls.MetroLabel();
            this.BtnManageSalary = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LblContact = new MetroFramework.Controls.MetroLabel();
            this.LblEmail = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtContact = new MetroFramework.Controls.MetroTextBox();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.BtnBack = new MetroFramework.Controls.MetroButton();
            this.BtnRefresh = new MetroFramework.Controls.MetroButton();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.employeeManagementSystemDataSet1 = new EmployeeManagementSystem.EmployeeManagementSystemDataSet1();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeManagementSystem.EmployeeManagementSystemDataSet1TableAdapters.EmployeeTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblSalary = new MetroFramework.Controls.MetroLabel();
            this.TxtSalary = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PanelSal = new MetroFramework.Controls.MetroPanel();
            this.BtnUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.PanelSal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Controls.Add(this.PanelSal);
            this.BtnUpdate.Controls.Add(this.metroButton1);
            this.BtnUpdate.Controls.Add(this.LblSalary);
            this.BtnUpdate.Controls.Add(this.TxtSalary);
            this.BtnUpdate.Controls.Add(this.metroLabel1);
            this.BtnUpdate.Controls.Add(this.dgvAll);
            this.BtnUpdate.Controls.Add(this.LblSearch);
            this.BtnUpdate.Controls.Add(this.LblID);
            this.BtnUpdate.Controls.Add(this.BtnDelete);
            this.BtnUpdate.Controls.Add(this.metroLabel5);
            this.BtnUpdate.Controls.Add(this.LblContact);
            this.BtnUpdate.Controls.Add(this.LblEmail);
            this.BtnUpdate.Controls.Add(this.LblName);
            this.BtnUpdate.Controls.Add(this.TxtEmail);
            this.BtnUpdate.Controls.Add(this.TxtContact);
            this.BtnUpdate.Controls.Add(this.TxtAddress);
            this.BtnUpdate.Controls.Add(this.TxtName);
            this.BtnUpdate.Controls.Add(this.BtnBack);
            this.BtnUpdate.Controls.Add(this.BtnRefresh);
            this.BtnUpdate.Controls.Add(this.TxtSearch);
            this.BtnUpdate.HorizontalScrollbarBarColor = true;
            this.BtnUpdate.HorizontalScrollbarHighlightOnWheel = false;
            this.BtnUpdate.HorizontalScrollbarSize = 10;
            this.BtnUpdate.Location = new System.Drawing.Point(23, 63);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(917, 511);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.VerticalScrollbarBarColor = true;
            this.BtnUpdate.VerticalScrollbarHighlightOnWheel = false;
            this.BtnUpdate.VerticalScrollbarSize = 10;
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.AllowUserToResizeRows = false;
            this.dgvAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAll.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAll.EnableHeadersVisualStyles = false;
            this.dgvAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAll.Location = new System.Drawing.Point(36, 282);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.Size = new System.Drawing.Size(828, 182);
            this.dgvAll.TabIndex = 25;
            this.dgvAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ContactNo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "joiningDate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "DefaultSalary";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "TotalBonus";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "OvertimeCount";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(621, 253);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(106, 19);
            this.LblSearch.TabIndex = 24;
            this.LblSearch.Text = "Search By Name";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblID.Location = new System.Drawing.Point(66, 17);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(30, 25);
            this.LblID.TabIndex = 23;
            this.LblID.Text = "ID";
            // 
            // BtnManageSalary
            // 
            this.BtnManageSalary.Location = new System.Drawing.Point(29, 4);
            this.BtnManageSalary.Name = "BtnManageSalary";
            this.BtnManageSalary.Size = new System.Drawing.Size(168, 81);
            this.BtnManageSalary.TabIndex = 22;
            this.BtnManageSalary.Text = "Manage Salary";
            this.BtnManageSalary.UseSelectable = true;
            this.BtnManageSalary.Click += new System.EventHandler(this.BtnManageSalary_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(36, 253);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(127, 104);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Address";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Location = new System.Drawing.Point(108, 75);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(79, 19);
            this.LblContact.TabIndex = 16;
            this.LblContact.Text = "Contact No.";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(142, 42);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(41, 19);
            this.LblEmail.TabIndex = 15;
            this.LblEmail.Text = "Email";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(138, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 19);
            this.LblName.TabIndex = 14;
            this.LblName.Text = "Name";
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(193, 42);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(75, 23);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContact
            // 
            // 
            // 
            // 
            this.TxtContact.CustomButton.Image = null;
            this.TxtContact.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtContact.CustomButton.Name = "";
            this.TxtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContact.CustomButton.TabIndex = 1;
            this.TxtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContact.CustomButton.UseSelectable = true;
            this.TxtContact.CustomButton.Visible = false;
            this.TxtContact.Lines = new string[0];
            this.TxtContact.Location = new System.Drawing.Point(193, 71);
            this.TxtContact.MaxLength = 32767;
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.PasswordChar = '\0';
            this.TxtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContact.SelectedText = "";
            this.TxtContact.SelectionLength = 0;
            this.TxtContact.SelectionStart = 0;
            this.TxtContact.ShortcutsEnabled = true;
            this.TxtContact.Size = new System.Drawing.Size(75, 23);
            this.TxtContact.TabIndex = 10;
            this.TxtContact.UseSelectable = true;
            this.TxtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAddress
            // 
            // 
            // 
            // 
            this.TxtAddress.CustomButton.Image = null;
            this.TxtAddress.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtAddress.CustomButton.Name = "";
            this.TxtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddress.CustomButton.TabIndex = 1;
            this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddress.CustomButton.UseSelectable = true;
            this.TxtAddress.CustomButton.Visible = false;
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(193, 100);
            this.TxtAddress.MaxLength = 32767;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.SelectionLength = 0;
            this.TxtAddress.SelectionStart = 0;
            this.TxtAddress.ShortcutsEnabled = true;
            this.TxtAddress.Size = new System.Drawing.Size(75, 23);
            this.TxtAddress.TabIndex = 8;
            this.TxtAddress.UseSelectable = true;
            this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(193, 13);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(75, 23);
            this.TxtName.TabIndex = 7;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 480);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseSelectable = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(193, 480);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseSelectable = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(769, 253);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.ShortcutsEnabled = true;
            this.TxtSearch.Size = new System.Drawing.Size(95, 23);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // employeeManagementSystemDataSet1
            // 
            this.employeeManagementSystemDataSet1.DataSetName = "EmployeeManagementSystemDataSet1";
            this.employeeManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeManagementSystemDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "ID:";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(390, 13);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(45, 19);
            this.LblSalary.TabIndex = 28;
            this.LblSalary.Text = "Salary";
            // 
            // TxtSalary
            // 
            // 
            // 
            // 
            this.TxtSalary.CustomButton.Image = null;
            this.TxtSalary.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtSalary.CustomButton.Name = "";
            this.TxtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSalary.CustomButton.TabIndex = 1;
            this.TxtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSalary.CustomButton.UseSelectable = true;
            this.TxtSalary.CustomButton.Visible = false;
            this.TxtSalary.Lines = new string[0];
            this.TxtSalary.Location = new System.Drawing.Point(441, 13);
            this.TxtSalary.MaxLength = 32767;
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.PasswordChar = '\0';
            this.TxtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSalary.SelectedText = "";
            this.TxtSalary.SelectionLength = 0;
            this.TxtSalary.SelectionStart = 0;
            this.TxtSalary.ShortcutsEnabled = true;
            this.TxtSalary.Size = new System.Drawing.Size(75, 23);
            this.TxtSalary.TabIndex = 27;
            this.TxtSalary.UseSelectable = true;
            this.TxtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(390, 104);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 67);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Update";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PanelSal
            // 
            this.PanelSal.Controls.Add(this.BtnManageSalary);
            this.PanelSal.HorizontalScrollbarBarColor = true;
            this.PanelSal.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSal.HorizontalScrollbarSize = 10;
            this.PanelSal.Location = new System.Drawing.Point(685, 13);
            this.PanelSal.Name = "PanelSal";
            this.PanelSal.Size = new System.Drawing.Size(200, 100);
            this.PanelSal.TabIndex = 30;
            this.PanelSal.VerticalScrollbarBarColor = true;
            this.PanelSal.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSal.VerticalScrollbarSize = 10;
            // 
            // EmployeeGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 595);
            this.Controls.Add(this.BtnUpdate);
            this.Name = "EmployeeGridView";
            this.Resizable = false;
            this.Text = "EmployeeGridView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeGridView_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeGridView_Load);
            this.BtnUpdate.ResumeLayout(false);
            this.BtnUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.PanelSal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BtnUpdate;
        private MetroFramework.Controls.MetroButton BtnManageSalary;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel LblContact;
        private MetroFramework.Controls.MetroLabel LblEmail;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtContact;
        private MetroFramework.Controls.MetroTextBox TxtAddress;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroButton BtnBack;
        private MetroFramework.Controls.MetroButton BtnRefresh;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroLabel LblID;
        private MetroFramework.Controls.MetroLabel LblSearch;
        private EmployeeManagementSystemDataSet1 employeeManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeManagementSystemDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MetroFramework.Controls.MetroGrid dgvAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private MetroFramework.Controls.MetroLabel LblSalary;
        private MetroFramework.Controls.MetroTextBox TxtSalary;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel PanelSal;
    }
}