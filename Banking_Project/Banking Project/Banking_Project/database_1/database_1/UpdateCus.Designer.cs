
namespace database_1
{
    partial class UpdateCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCus));
            this.button_update = new System.Windows.Forms.Button();
            this.text_name_up = new System.Windows.Forms.TextBox();
            this.text_phone_up = new System.Windows.Forms.TextBox();
            this.text_address_up = new System.Windows.Forms.TextBox();
            this.text_ssn_up = new System.Windows.Forms.TextBox();
            this.Password_up = new System.Windows.Forms.Label();
            this.Customer_name_up = new System.Windows.Forms.Label();
            this.Phone_up = new System.Windows.Forms.Label();
            this.Address_up = new System.Windows.Forms.Label();
            this.Email_up = new System.Windows.Forms.Label();
            this.SSN_up = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankingDataSet = new database_1.BankingDataSet();
            this.customerTableAdapter = new database_1.BankingDataSetTableAdapters.CustomerTableAdapter();
            this.text_email_up = new System.Windows.Forms.Label();
            this.text_password_up = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.button_update.Location = new System.Drawing.Point(110, 390);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(167, 59);
            this.button_update.TabIndex = 25;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // text_name_up
            // 
            this.text_name_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_name_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name_up.Location = new System.Drawing.Point(219, 125);
            this.text_name_up.Name = "text_name_up";
            this.text_name_up.Size = new System.Drawing.Size(181, 30);
            this.text_name_up.TabIndex = 24;
            // 
            // text_phone_up
            // 
            this.text_phone_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_phone_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone_up.Location = new System.Drawing.Point(219, 178);
            this.text_phone_up.Name = "text_phone_up";
            this.text_phone_up.Size = new System.Drawing.Size(181, 30);
            this.text_phone_up.TabIndex = 23;
            // 
            // text_address_up
            // 
            this.text_address_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_address_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_address_up.Location = new System.Drawing.Point(219, 231);
            this.text_address_up.Name = "text_address_up";
            this.text_address_up.Size = new System.Drawing.Size(181, 30);
            this.text_address_up.TabIndex = 20;
            // 
            // text_ssn_up
            // 
            this.text_ssn_up.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_ssn_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ssn_up.Location = new System.Drawing.Point(219, 69);
            this.text_ssn_up.Name = "text_ssn_up";
            this.text_ssn_up.Size = new System.Drawing.Size(181, 30);
            this.text_ssn_up.TabIndex = 19;
            // 
            // Password_up
            // 
            this.Password_up.AutoSize = true;
            this.Password_up.BackColor = System.Drawing.Color.Transparent;
            this.Password_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Password_up.Location = new System.Drawing.Point(4, 337);
            this.Password_up.Margin = new System.Windows.Forms.Padding(2);
            this.Password_up.Name = "Password_up";
            this.Password_up.Size = new System.Drawing.Size(177, 23);
            this.Password_up.TabIndex = 18;
            this.Password_up.Text = "Customer password";
            this.Password_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_name_up
            // 
            this.Customer_name_up.AutoSize = true;
            this.Customer_name_up.BackColor = System.Drawing.Color.Transparent;
            this.Customer_name_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_name_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Customer_name_up.Location = new System.Drawing.Point(36, 125);
            this.Customer_name_up.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_name_up.Name = "Customer_name_up";
            this.Customer_name_up.Size = new System.Drawing.Size(145, 23);
            this.Customer_name_up.TabIndex = 17;
            this.Customer_name_up.Text = "Customer name";
            this.Customer_name_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone_up
            // 
            this.Phone_up.AutoSize = true;
            this.Phone_up.BackColor = System.Drawing.Color.Transparent;
            this.Phone_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Phone_up.Location = new System.Drawing.Point(29, 178);
            this.Phone_up.Margin = new System.Windows.Forms.Padding(2);
            this.Phone_up.Name = "Phone_up";
            this.Phone_up.Size = new System.Drawing.Size(152, 23);
            this.Phone_up.TabIndex = 16;
            this.Phone_up.Text = "Customer phone";
            this.Phone_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Address_up
            // 
            this.Address_up.AutoSize = true;
            this.Address_up.BackColor = System.Drawing.Color.Transparent;
            this.Address_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Address_up.Location = new System.Drawing.Point(18, 231);
            this.Address_up.Margin = new System.Windows.Forms.Padding(2);
            this.Address_up.Name = "Address_up";
            this.Address_up.Size = new System.Drawing.Size(163, 23);
            this.Address_up.TabIndex = 15;
            this.Address_up.Text = "Customer address";
            this.Address_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email_up
            // 
            this.Email_up.AutoSize = true;
            this.Email_up.BackColor = System.Drawing.Color.Transparent;
            this.Email_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_up.ForeColor = System.Drawing.SystemColors.Control;
            this.Email_up.Location = new System.Drawing.Point(37, 284);
            this.Email_up.Margin = new System.Windows.Forms.Padding(2);
            this.Email_up.Name = "Email_up";
            this.Email_up.Size = new System.Drawing.Size(144, 23);
            this.Email_up.TabIndex = 14;
            this.Email_up.Text = "Customer Email";
            this.Email_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSN_up
            // 
            this.SSN_up.AutoSize = true;
            this.SSN_up.BackColor = System.Drawing.Color.Transparent;
            this.SSN_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN_up.ForeColor = System.Drawing.SystemColors.Control;
            this.SSN_up.Location = new System.Drawing.Point(49, 69);
            this.SSN_up.Margin = new System.Windows.Forms.Padding(2);
            this.SSN_up.Name = "SSN_up";
            this.SSN_up.Size = new System.Drawing.Size(132, 23);
            this.SSN_up.TabIndex = 13;
            this.SSN_up.Text = "Customer SSN";
            this.SSN_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusSSNDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cusphoneDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(440, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 339);
            this.dataGridView1.TabIndex = 26;
            // 
            // cusSSNDataGridViewTextBoxColumn
            // 
            this.cusSSNDataGridViewTextBoxColumn.DataPropertyName = "Cus_SSN";
            this.cusSSNDataGridViewTextBoxColumn.HeaderText = "Cus_SSN";
            this.cusSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusSSNDataGridViewTextBoxColumn.Name = "cusSSNDataGridViewTextBoxColumn";
            this.cusSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusphoneDataGridViewTextBoxColumn
            // 
            this.cusphoneDataGridViewTextBoxColumn.DataPropertyName = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.HeaderText = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusphoneDataGridViewTextBoxColumn.Name = "cusphoneDataGridViewTextBoxColumn";
            this.cusphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            this.cusaddressDataGridViewTextBoxColumn.Width = 125;
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
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bankingDataSetBindingSource;
            // 
            // bankingDataSetBindingSource
            // 
            this.bankingDataSetBindingSource.DataSource = this.bankingDataSet;
            this.bankingDataSetBindingSource.Position = 0;
            // 
            // bankingDataSet
            // 
            this.bankingDataSet.DataSetName = "BankingDataSet";
            this.bankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // text_email_up
            // 
            this.text_email_up.AutoSize = true;
            this.text_email_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.text_email_up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.text_email_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email_up.Location = new System.Drawing.Point(228, 284);
            this.text_email_up.Name = "text_email_up";
            this.text_email_up.Padding = new System.Windows.Forms.Padding(1);
            this.text_email_up.Size = new System.Drawing.Size(163, 29);
            this.text_email_up.TabIndex = 27;
            this.text_email_up.Text = "Can\'t edit this field";
            this.text_email_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_password_up
            // 
            this.text_password_up.AutoSize = true;
            this.text_password_up.BackColor = System.Drawing.Color.LightGray;
            this.text_password_up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.text_password_up.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password_up.Location = new System.Drawing.Point(228, 337);
            this.text_password_up.Name = "text_password_up";
            this.text_password_up.Padding = new System.Windows.Forms.Padding(1);
            this.text_password_up.Size = new System.Drawing.Size(163, 29);
            this.text_password_up.TabIndex = 28;
            this.text_password_up.Text = "Can\'t edit this field";
            this.text_password_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Enter the cutsomer\'s SSN:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(689, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 60);
            this.button1.TabIndex = 30;
            this.button1.Text = "LOAD CUSTOMERS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1243, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_password_up);
            this.Controls.Add(this.text_email_up);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.text_name_up);
            this.Controls.Add(this.text_phone_up);
            this.Controls.Add(this.text_address_up);
            this.Controls.Add(this.text_ssn_up);
            this.Controls.Add(this.Password_up);
            this.Controls.Add(this.Customer_name_up);
            this.Controls.Add(this.Phone_up);
            this.Controls.Add(this.Address_up);
            this.Controls.Add(this.Email_up);
            this.Controls.Add(this.SSN_up);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCus";
            this.Text = "Update Customer ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox text_name_up;
        private System.Windows.Forms.TextBox text_phone_up;
        private System.Windows.Forms.TextBox text_address_up;
        private System.Windows.Forms.TextBox text_ssn_up;
        private System.Windows.Forms.Label Password_up;
        private System.Windows.Forms.Label Customer_name_up;
        private System.Windows.Forms.Label Phone_up;
        private System.Windows.Forms.Label Address_up;
        private System.Windows.Forms.Label Email_up;
        private System.Windows.Forms.Label SSN_up;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bankingDataSetBindingSource;
        private BankingDataSet bankingDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BankingDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label text_email_up;
        private System.Windows.Forms.Label text_password_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}