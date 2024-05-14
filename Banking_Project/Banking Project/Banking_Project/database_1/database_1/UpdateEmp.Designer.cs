
namespace database_1
{
    partial class UpdateEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmp));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_password_up = new System.Windows.Forms.Label();
            this.text_email_up = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.text_name_up = new System.Windows.Forms.TextBox();
            this.text_phone_up = new System.Windows.Forms.TextBox();
            this.text_address_up = new System.Windows.Forms.TextBox();
            this.text_id_up = new System.Windows.Forms.TextBox();
            this.Password_up = new System.Windows.Forms.Label();
            this.Customer_name_up = new System.Windows.Forms.Label();
            this.Phone_up = new System.Windows.Forms.Label();
            this.Address_up = new System.Windows.Forms.Label();
            this.Email_up = new System.Windows.Forms.Label();
            this.SSN_up = new System.Windows.Forms.Label();
            this.bankingDataSet = new database_1.BankingDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new database_1.BankingDataSetTableAdapters.EmployeeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(689, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 60);
            this.button2.TabIndex = 46;
            this.button2.Text = "LOAD EMPLOYEES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter the emplyee\'s ID:";
            // 
            // text_password_up
            // 
            this.text_password_up.AutoSize = true;
            this.text_password_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.text_password_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password_up.Location = new System.Drawing.Point(221, 355);
            this.text_password_up.Name = "text_password_up";
            this.text_password_up.Padding = new System.Windows.Forms.Padding(1);
            this.text_password_up.Size = new System.Drawing.Size(161, 27);
            this.text_password_up.TabIndex = 44;
            this.text_password_up.Text = "Can\'t edit this field";
            this.text_password_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_email_up
            // 
            this.text_email_up.AutoSize = true;
            this.text_email_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.text_email_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email_up.Location = new System.Drawing.Point(221, 308);
            this.text_email_up.Name = "text_email_up";
            this.text_email_up.Padding = new System.Windows.Forms.Padding(1);
            this.text_email_up.Size = new System.Drawing.Size(161, 27);
            this.text_email_up.TabIndex = 43;
            this.text_email_up.Text = "Can\'t edit this field";
            this.text_email_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_update.FlatAppearance.BorderSize = 2;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_update.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.Location = new System.Drawing.Point(120, 455);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(167, 59);
            this.button_update.TabIndex = 41;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // text_name_up
            // 
            this.text_name_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_name_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name_up.Location = new System.Drawing.Point(213, 147);
            this.text_name_up.Name = "text_name_up";
            this.text_name_up.Size = new System.Drawing.Size(181, 30);
            this.text_name_up.TabIndex = 40;
            // 
            // text_phone_up
            // 
            this.text_phone_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_phone_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone_up.Location = new System.Drawing.Point(213, 200);
            this.text_phone_up.Name = "text_phone_up";
            this.text_phone_up.Size = new System.Drawing.Size(181, 30);
            this.text_phone_up.TabIndex = 39;
            // 
            // text_address_up
            // 
            this.text_address_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_address_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_address_up.Location = new System.Drawing.Point(213, 253);
            this.text_address_up.Name = "text_address_up";
            this.text_address_up.Size = new System.Drawing.Size(181, 30);
            this.text_address_up.TabIndex = 38;
            // 
            // text_id_up
            // 
            this.text_id_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_id_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_up.Location = new System.Drawing.Point(213, 91);
            this.text_id_up.Name = "text_id_up";
            this.text_id_up.Size = new System.Drawing.Size(181, 30);
            this.text_id_up.TabIndex = 37;
            // 
            // Password_up
            // 
            this.Password_up.AutoSize = true;
            this.Password_up.BackColor = System.Drawing.Color.Transparent;
            this.Password_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Password_up.Location = new System.Drawing.Point(9, 355);
            this.Password_up.Margin = new System.Windows.Forms.Padding(2);
            this.Password_up.Name = "Password_up";
            this.Password_up.Size = new System.Drawing.Size(177, 23);
            this.Password_up.TabIndex = 36;
            this.Password_up.Text = "Employee password";
            this.Password_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_name_up
            // 
            this.Customer_name_up.AutoSize = true;
            this.Customer_name_up.BackColor = System.Drawing.Color.Transparent;
            this.Customer_name_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_name_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Customer_name_up.Location = new System.Drawing.Point(45, 147);
            this.Customer_name_up.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_name_up.Name = "Customer_name_up";
            this.Customer_name_up.Size = new System.Drawing.Size(141, 20);
            this.Customer_name_up.TabIndex = 35;
            this.Customer_name_up.Text = "Employee name";
            this.Customer_name_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone_up
            // 
            this.Phone_up.AutoSize = true;
            this.Phone_up.BackColor = System.Drawing.Color.Transparent;
            this.Phone_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Phone_up.Location = new System.Drawing.Point(34, 200);
            this.Phone_up.Margin = new System.Windows.Forms.Padding(2);
            this.Phone_up.Name = "Phone_up";
            this.Phone_up.Size = new System.Drawing.Size(152, 23);
            this.Phone_up.TabIndex = 34;
            this.Phone_up.Text = "Employee phone";
            this.Phone_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Address_up
            // 
            this.Address_up.AutoSize = true;
            this.Address_up.BackColor = System.Drawing.Color.Transparent;
            this.Address_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Address_up.Location = new System.Drawing.Point(23, 253);
            this.Address_up.Margin = new System.Windows.Forms.Padding(2);
            this.Address_up.Name = "Address_up";
            this.Address_up.Size = new System.Drawing.Size(163, 23);
            this.Address_up.TabIndex = 33;
            this.Address_up.Text = "Employee address";
            this.Address_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email_up
            // 
            this.Email_up.AutoSize = true;
            this.Email_up.BackColor = System.Drawing.Color.Transparent;
            this.Email_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Email_up.Location = new System.Drawing.Point(42, 308);
            this.Email_up.Margin = new System.Windows.Forms.Padding(2);
            this.Email_up.Name = "Email_up";
            this.Email_up.Size = new System.Drawing.Size(144, 23);
            this.Email_up.TabIndex = 32;
            this.Email_up.Text = "Employee Email";
            this.Email_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSN_up
            // 
            this.SSN_up.AutoSize = true;
            this.SSN_up.BackColor = System.Drawing.Color.Transparent;
            this.SSN_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN_up.ForeColor = System.Drawing.SystemColors.Control;
            this.SSN_up.Location = new System.Drawing.Point(69, 92);
            this.SSN_up.Margin = new System.Windows.Forms.Padding(2);
            this.SSN_up.Name = "SSN_up";
            this.SSN_up.Size = new System.Drawing.Size(117, 23);
            this.SSN_up.TabIndex = 31;
            this.SSN_up.Text = "Employee ID";
            this.SSN_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankingDataSet
            // 
            this.bankingDataSet.DataSetName = "BankingDataSet";
            this.bankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bankingDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(45, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Branch number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 407);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(161, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "Can\'t edit this field";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.bankingDataSet;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.bankingDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.branchNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(444, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 339);
            this.dataGridView1.TabIndex = 49;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchNumberDataGridViewTextBoxColumn
            // 
            this.branchNumberDataGridViewTextBoxColumn.DataPropertyName = "Branch_Number";
            this.branchNumberDataGridViewTextBoxColumn.HeaderText = "Branch_Number";
            this.branchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchNumberDataGridViewTextBoxColumn.Name = "branchNumberDataGridViewTextBoxColumn";
            this.branchNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.bankingDataSet;
            // 
            // UpdateEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_password_up);
            this.Controls.Add(this.text_email_up);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.text_name_up);
            this.Controls.Add(this.text_phone_up);
            this.Controls.Add(this.text_address_up);
            this.Controls.Add(this.text_id_up);
            this.Controls.Add(this.Password_up);
            this.Controls.Add(this.Customer_name_up);
            this.Controls.Add(this.Phone_up);
            this.Controls.Add(this.Address_up);
            this.Controls.Add(this.Email_up);
            this.Controls.Add(this.SSN_up);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateEmp";
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.UpdateEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text_password_up;
        private System.Windows.Forms.Label text_email_up;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox text_name_up;
        private System.Windows.Forms.TextBox text_phone_up;
        private System.Windows.Forms.TextBox text_address_up;
        private System.Windows.Forms.TextBox text_id_up;
        private System.Windows.Forms.Label Password_up;
        private System.Windows.Forms.Label Customer_name_up;
        private System.Windows.Forms.Label Phone_up;
        private System.Windows.Forms.Label Address_up;
        private System.Windows.Forms.Label Email_up;
        private System.Windows.Forms.Label SSN_up;
        private BankingDataSet bankingDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BankingDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
    }
}