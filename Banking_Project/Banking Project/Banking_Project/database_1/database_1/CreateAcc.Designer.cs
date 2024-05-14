namespace database_1
{
    partial class CreateAcc
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

           private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAcc));
            this.text_balance = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.text_number = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.text_ssn = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // text_balance
            // 
            this.text_balance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_balance.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_balance.Location = new System.Drawing.Point(534, 170);
            this.text_balance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_balance.Name = "text_balance";
            this.text_balance.Size = new System.Drawing.Size(159, 28);
            this.text_balance.TabIndex = 21;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.SystemColors.Control;
            this.balance.Location = new System.Drawing.Point(156, 170);
            this.balance.Margin = new System.Windows.Forms.Padding(2);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(103, 32);
            this.balance.TabIndex = 17;
            this.balance.Text = "balance";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.Control;
            this.type.Location = new System.Drawing.Point(188, 108);
            this.type.Margin = new System.Windows.Forms.Padding(2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(70, 32);
            this.type.TabIndex = 13;
            this.type.Text = "Type";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(304, 291);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 58);
            this.button7.TabIndex = 37;
            this.button7.Text = "Create Account";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // text_number
            // 
            this.text_number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_number.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_number.Location = new System.Drawing.Point(534, 48);
            this.text_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(159, 28);
            this.text_number.TabIndex = 39;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.Control;
            this.number.Location = new System.Drawing.Point(152, 48);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(108, 32);
            this.number.TabIndex = 38;
            this.number.Text = "Number";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_ssn
            // 
            this.text_ssn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_ssn.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ssn.Location = new System.Drawing.Point(534, 231);
            this.text_ssn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_ssn.Name = "text_ssn";
            this.text_ssn.Size = new System.Drawing.Size(159, 28);
            this.text_ssn.TabIndex = 41;
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.BackColor = System.Drawing.Color.Transparent;
            this.SSN.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN.ForeColor = System.Drawing.SystemColors.Control;
            this.SSN.Location = new System.Drawing.Point(195, 231);
            this.SSN.Margin = new System.Windows.Forms.Padding(2);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(61, 32);
            this.SSN.TabIndex = 40;
            this.SSN.Text = "SSN";
            this.SSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Saving",
            "Checking",
            "Money Market",
            "CD"});
            this.listBox1.Location = new System.Drawing.Point(534, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 25);
            this.listBox1.TabIndex = 42;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 390);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.text_ssn);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.text_balance);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateAcc";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox text_balance;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox text_ssn;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.ListBox listBox1;
    }
}