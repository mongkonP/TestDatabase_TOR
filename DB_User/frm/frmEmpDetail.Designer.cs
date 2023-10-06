namespace DB_User.frm
{
    partial class frmEmpDetail
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
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label l_NameLabel;
            System.Windows.Forms.Label cardLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label stetusLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label adminLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpDetail));
            this.dS_User = new DB_User.db.DS_User();
            this.tblEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_NameTextBox = new System.Windows.Forms.TextBox();
            this.l_NameTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.stetusTextBox = new System.Windows.Forms.TextBox();
            this.pictureTextBox = new TORServices.Forms.Forms.PictureboxOpenPath();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.tblEmpTableAdapter = new DB_User.db.DS_UserTableAdapters.tblEmpTableAdapter();
            this.tableAdapterManager = new DB_User.db.DS_UserTableAdapters.TableAdapterManager();
            f_NameLabel = new System.Windows.Forms.Label();
            l_NameLabel = new System.Windows.Forms.Label();
            cardLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            stetusLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            adminLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditDateTimePicker
            // 
            this.dateEditDateTimePicker.Location = new System.Drawing.Point(190, 666);
            // 
            // manEditTextBox
            // 
            this.manEditTextBox.Location = new System.Drawing.Point(190, 624);
            this.manEditTextBox.Visible = false;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Id_officer", true));
            this.txtID.Location = new System.Drawing.Point(180, 60);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(123, 60);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(249, 685);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(232, 685);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.Location = new System.Drawing.Point(190, 629);
            this.remarkTextBox.Size = new System.Drawing.Size(528, 152);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(346, 671);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Size = new System.Drawing.Size(1032, 90);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(882, 0);
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(958, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1032, 50);
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            f_NameLabel.Location = new System.Drawing.Point(72, 99);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(83, 24);
            f_NameLabel.TabIndex = 83;
            f_NameLabel.Text = "F Name:";
            // 
            // l_NameLabel
            // 
            l_NameLabel.AutoSize = true;
            l_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            l_NameLabel.Location = new System.Drawing.Point(538, 102);
            l_NameLabel.Name = "l_NameLabel";
            l_NameLabel.Size = new System.Drawing.Size(81, 24);
            l_NameLabel.TabIndex = 84;
            l_NameLabel.Text = "L Name:";
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            cardLabel.Location = new System.Drawing.Point(100, 135);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new System.Drawing.Size(55, 24);
            cardLabel.TabIndex = 85;
            cardLabel.Text = "Card:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            addressLabel.Location = new System.Drawing.Point(70, 186);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 86;
            addressLabel.Text = "Address:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            telLabel.Location = new System.Drawing.Point(113, 290);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(42, 24);
            telLabel.TabIndex = 87;
            telLabel.Text = "Tel:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            salaryLabel.Location = new System.Drawing.Point(95, 327);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(66, 24);
            salaryLabel.TabIndex = 88;
            salaryLabel.Text = "Salary:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            usernameLabel.Location = new System.Drawing.Point(59, 362);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(102, 24);
            usernameLabel.TabIndex = 89;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            passwordLabel.Location = new System.Drawing.Point(64, 397);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(97, 24);
            passwordLabel.TabIndex = 90;
            passwordLabel.Text = "Password:";
            // 
            // stetusLabel
            // 
            stetusLabel.AutoSize = true;
            stetusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            stetusLabel.Location = new System.Drawing.Point(95, 434);
            stetusLabel.Name = "stetusLabel";
            stetusLabel.Size = new System.Drawing.Size(66, 24);
            stetusLabel.TabIndex = 91;
            stetusLabel.Text = "Stetus:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(561, 442);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(58, 18);
            pictureLabel.TabIndex = 92;
            pictureLabel.Text = "Picture:";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Location = new System.Drawing.Point(121, 481);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(53, 18);
            adminLabel.TabIndex = 93;
            adminLabel.Text = "Admin:";
            // 
            // dS_User
            // 
            this.dS_User.DataSetName = "DS_User";
            this.dS_User.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmpBindingSource
            // 
            this.tblEmpBindingSource.DataMember = "tblEmp";
            this.tblEmpBindingSource.DataSource = this.dS_User;
            // 
            // f_NameTextBox
            // 
            this.f_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "F_Name", true));
            this.f_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.f_NameTextBox.Location = new System.Drawing.Point(180, 97);
            this.f_NameTextBox.Name = "f_NameTextBox";
            this.f_NameTextBox.Size = new System.Drawing.Size(294, 29);
            this.f_NameTextBox.TabIndex = 1;
            // 
            // l_NameTextBox
            // 
            this.l_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "L_Name", true));
            this.l_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.l_NameTextBox.Location = new System.Drawing.Point(625, 97);
            this.l_NameTextBox.Name = "l_NameTextBox";
            this.l_NameTextBox.Size = new System.Drawing.Size(379, 29);
            this.l_NameTextBox.TabIndex = 2;
            // 
            // cardTextBox
            // 
            this.cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Card", true));
            this.cardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cardTextBox.Location = new System.Drawing.Point(180, 132);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(294, 29);
            this.cardTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addressTextBox.Location = new System.Drawing.Point(180, 167);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(294, 98);
            this.addressTextBox.TabIndex = 4;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.telTextBox.Location = new System.Drawing.Point(180, 287);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(294, 29);
            this.telTextBox.TabIndex = 5;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Salary", true));
            this.salaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salaryTextBox.Location = new System.Drawing.Point(180, 322);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(294, 29);
            this.salaryTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.usernameTextBox.Location = new System.Drawing.Point(180, 357);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(294, 29);
            this.usernameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.passwordTextBox.Location = new System.Drawing.Point(180, 392);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(294, 29);
            this.passwordTextBox.TabIndex = 8;
            // 
            // stetusTextBox
            // 
            this.stetusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Stetus", true));
            this.stetusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.stetusTextBox.Location = new System.Drawing.Point(180, 431);
            this.stetusTextBox.Name = "stetusTextBox";
            this.stetusTextBox.Size = new System.Drawing.Size(294, 29);
            this.stetusTextBox.TabIndex = 9;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Picture", true));
            this.pictureTextBox.Directory = "Files\\Pic";
            this.pictureTextBox.Image = null;
            this.pictureTextBox.ImageButton = ((System.Drawing.Image)(resources.GetObject("pictureTextBox.ImageButton")));
            this.pictureTextBox.Location = new System.Drawing.Point(625, 135);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(387, 325);
            this.pictureTextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTextBox.TabIndex = 93;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblEmpBindingSource, "Admin", true));
            this.adminCheckBox.Location = new System.Drawing.Point(180, 476);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.adminCheckBox.TabIndex = 94;
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblEmpTableAdapter
            // 
            this.tblEmpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblEmpTableAdapter = this.tblEmpTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_User.db.DS_UserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmEmpDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 602);
            this.Controls.Add(adminLabel);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(stetusLabel);
            this.Controls.Add(this.stetusTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cardLabel);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(l_NameLabel);
            this.Controls.Add(this.l_NameTextBox);
            this.Controls.Add(f_NameLabel);
            this.Controls.Add(this.f_NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmEmpDetail";
            this.Text = "frmEmpDetail";
            this.Load += new System.EventHandler(this.frmEmpDetail_Load);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.remarkTextBox, 0);
            this.Controls.SetChildIndex(this.manEditTextBox, 0);
            this.Controls.SetChildIndex(this.dateEditDateTimePicker, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.f_NameTextBox, 0);
            this.Controls.SetChildIndex(f_NameLabel, 0);
            this.Controls.SetChildIndex(this.l_NameTextBox, 0);
            this.Controls.SetChildIndex(l_NameLabel, 0);
            this.Controls.SetChildIndex(this.cardTextBox, 0);
            this.Controls.SetChildIndex(cardLabel, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(addressLabel, 0);
            this.Controls.SetChildIndex(this.telTextBox, 0);
            this.Controls.SetChildIndex(telLabel, 0);
            this.Controls.SetChildIndex(this.salaryTextBox, 0);
            this.Controls.SetChildIndex(salaryLabel, 0);
            this.Controls.SetChildIndex(this.usernameTextBox, 0);
            this.Controls.SetChildIndex(usernameLabel, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(passwordLabel, 0);
            this.Controls.SetChildIndex(this.stetusTextBox, 0);
            this.Controls.SetChildIndex(stetusLabel, 0);
            this.Controls.SetChildIndex(this.pictureTextBox, 0);
            this.Controls.SetChildIndex(pictureLabel, 0);
            this.Controls.SetChildIndex(this.adminCheckBox, 0);
            this.Controls.SetChildIndex(adminLabel, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db.DS_User dS_User;
        private System.Windows.Forms.BindingSource tblEmpBindingSource;
        private System.Windows.Forms.TextBox f_NameTextBox;
        private System.Windows.Forms.TextBox l_NameTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox stetusTextBox;
        private TORServices.Forms.Forms.PictureboxOpenPath pictureTextBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private db.DS_UserTableAdapters.tblEmpTableAdapter tblEmpTableAdapter;
        private db.DS_UserTableAdapters.TableAdapterManager tableAdapterManager;
    }
}