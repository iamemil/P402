namespace UserFormApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.nameSurnameInput = new System.Windows.Forms.TextBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.mobileNumberInput = new System.Windows.Forms.TextBox();
            this.DtBirthday = new System.Windows.Forms.DateTimePicker();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.nameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerUser = new System.Windows.Forms.Button();
            this.LblRegisterOutput = new System.Windows.Forms.Label();
            this.TxtSearchInput = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblRegisterOutput);
            this.tabPage1.Controls.Add(this.registerUser);
            this.tabPage1.Controls.Add(this.LblBirthday);
            this.tabPage1.Controls.Add(this.DtBirthday);
            this.tabPage1.Controls.Add(this.LblMobileNumber);
            this.tabPage1.Controls.Add(this.mobileNumberInput);
            this.tabPage1.Controls.Add(this.LblNameSurname);
            this.tabPage1.Controls.Add(this.nameSurnameInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yeni İstifadəçi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LblSearch);
            this.tabPage2.Controls.Add(this.TxtSearchInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Axtar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSurname,
            this.birthDate,
            this.mobileNumber});
            this.dgwUsers.Location = new System.Drawing.Point(285, 34);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.Size = new System.Drawing.Size(673, 411);
            this.dgwUsers.TabIndex = 5;
            // 
            // nameSurnameInput
            // 
            this.nameSurnameInput.Location = new System.Drawing.Point(6, 34);
            this.nameSurnameInput.Name = "nameSurnameInput";
            this.nameSurnameInput.Size = new System.Drawing.Size(247, 20);
            this.nameSurnameInput.TabIndex = 0;
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(3, 18);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(53, 13);
            this.LblNameSurname.TabIndex = 1;
            this.LblNameSurname.Text = "Ad Soyad";
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Location = new System.Drawing.Point(3, 136);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(82, 13);
            this.LblMobileNumber.TabIndex = 3;
            this.LblMobileNumber.Text = "Telefon nömrəsi";
            // 
            // mobileNumberInput
            // 
            this.mobileNumberInput.Location = new System.Drawing.Point(6, 152);
            this.mobileNumberInput.Name = "mobileNumberInput";
            this.mobileNumberInput.Size = new System.Drawing.Size(247, 20);
            this.mobileNumberInput.TabIndex = 2;
            // 
            // DtBirthday
            // 
            this.DtBirthday.CustomFormat = "dd.MM.yyyy";
            this.DtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtBirthday.Location = new System.Drawing.Point(6, 92);
            this.DtBirthday.Name = "DtBirthday";
            this.DtBirthday.Size = new System.Drawing.Size(247, 20);
            this.DtBirthday.TabIndex = 1;
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.Location = new System.Drawing.Point(3, 76);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(65, 13);
            this.LblBirthday.TabIndex = 5;
            this.LblBirthday.Text = "Doğum tarixi";
            // 
            // nameSurname
            // 
            this.nameSurname.HeaderText = "Ad Soyad";
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Doğum tarixi";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // mobileNumber
            // 
            this.mobileNumber.HeaderText = "Telefon nömrəsi";
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.ReadOnly = true;
            // 
            // registerUser
            // 
            this.registerUser.Location = new System.Drawing.Point(6, 197);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(247, 23);
            this.registerUser.TabIndex = 3;
            this.registerUser.Text = "Əlavə et";
            this.registerUser.UseVisualStyleBackColor = true;
            this.registerUser.Click += new System.EventHandler(this.registerUser_Click);
            // 
            // LblRegisterOutput
            // 
            this.LblRegisterOutput.AutoSize = true;
            this.LblRegisterOutput.Location = new System.Drawing.Point(6, 235);
            this.LblRegisterOutput.Name = "LblRegisterOutput";
            this.LblRegisterOutput.Size = new System.Drawing.Size(0, 13);
            this.LblRegisterOutput.TabIndex = 7;
            // 
            // TxtSearchInput
            // 
            this.TxtSearchInput.Location = new System.Drawing.Point(7, 34);
            this.TxtSearchInput.Name = "TxtSearchInput";
            this.TxtSearchInput.Size = new System.Drawing.Size(246, 20);
            this.TxtSearchInput.TabIndex = 0;
            this.TxtSearchInput.TextChanged += new System.EventHandler(this.TxtSearchInput_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(6, 18);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(122, 13);
            this.LblSearch.TabIndex = 1;
            this.LblSearch.Text = "Axtaracağınız sözü yazın";
            this.LblSearch.TextChanged += new System.EventHandler(this.TxtSearchInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 461);
            this.Controls.Add(this.dgwUsers);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Label LblBirthday;
        private System.Windows.Forms.DateTimePicker DtBirthday;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.TextBox mobileNumberInput;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.TextBox nameSurnameInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber;
        private System.Windows.Forms.Button registerUser;
        private System.Windows.Forms.Label LblRegisterOutput;
        private System.Windows.Forms.TextBox TxtSearchInput;
        private System.Windows.Forms.Label LblSearch;
    }
}

