namespace DB_User.frm
{
    partial class frmEmpAll
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
            System.Windows.Forms.Label id_officerLabel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpAll));
            this.dS_User = new DB_User.db.DS_User();
            this.tblEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpTableAdapter = new DB_User.db.DS_UserTableAdapters.tblEmpTableAdapter();
            this.tableAdapterManager = new DB_User.db.DS_UserTableAdapters.TableAdapterManager();
            this.tblEmpBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblEmpBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblEmpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureTextBox = new TORServices.Forms.Forms.PictureboxOpenPath();
            this.stetusTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.l_NameTextBox = new System.Windows.Forms.TextBox();
            this.f_NameTextBox = new System.Windows.Forms.TextBox();
            this.id_officerTextBox = new System.Windows.Forms.TextBox();
            id_officerLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingNavigator)).BeginInit();
            this.tblEmpBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_officerLabel
            // 
            id_officerLabel.AutoSize = true;
            id_officerLabel.Location = new System.Drawing.Point(30, 32);
            id_officerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_officerLabel.Name = "id_officerLabel";
            id_officerLabel.Size = new System.Drawing.Size(75, 20);
            id_officerLabel.TabIndex = 0;
            id_officerLabel.Text = "Id officer:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Location = new System.Drawing.Point(36, 72);
            f_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(69, 20);
            f_NameLabel.TabIndex = 2;
            f_NameLabel.Text = "F Name:";
            // 
            // l_NameLabel
            // 
            l_NameLabel.AutoSize = true;
            l_NameLabel.Location = new System.Drawing.Point(36, 112);
            l_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            l_NameLabel.Name = "l_NameLabel";
            l_NameLabel.Size = new System.Drawing.Size(68, 20);
            l_NameLabel.TabIndex = 4;
            l_NameLabel.Text = "L Name:";
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Location = new System.Drawing.Point(58, 152);
            cardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new System.Drawing.Size(47, 20);
            cardLabel.TabIndex = 6;
            cardLabel.Text = "Card:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(34, 192);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(69, 329);
            telLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(34, 20);
            telLabel.TabIndex = 10;
            telLabel.Text = "Tel:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(48, 369);
            salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(57, 20);
            salaryLabel.TabIndex = 12;
            salaryLabel.Text = "Salary:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 409);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 20);
            usernameLabel.TabIndex = 14;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(22, 449);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // stetusLabel
            // 
            stetusLabel.AutoSize = true;
            stetusLabel.Location = new System.Drawing.Point(46, 489);
            stetusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stetusLabel.Name = "stetusLabel";
            stetusLabel.Size = new System.Drawing.Size(60, 20);
            stetusLabel.TabIndex = 18;
            stetusLabel.Text = "Stetus:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(742, 500);
            pictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(62, 20);
            pictureLabel.TabIndex = 20;
            pictureLabel.Text = "Picture:";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Location = new System.Drawing.Point(48, 532);
            adminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(58, 20);
            adminLabel.TabIndex = 22;
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
            // tblEmpBindingNavigator
            // 
            this.tblEmpBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblEmpBindingNavigator.BindingSource = this.tblEmpBindingSource;
            this.tblEmpBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblEmpBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblEmpBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblEmpBindingNavigatorSaveItem});
            this.tblEmpBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblEmpBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblEmpBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblEmpBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblEmpBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblEmpBindingNavigator.Name = "tblEmpBindingNavigator";
            this.tblEmpBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tblEmpBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblEmpBindingNavigator.Size = new System.Drawing.Size(1404, 25);
            this.tblEmpBindingNavigator.TabIndex = 0;
            this.tblEmpBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblEmpBindingNavigatorSaveItem
            // 
            this.tblEmpBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblEmpBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblEmpBindingNavigatorSaveItem.Image")));
            this.tblEmpBindingNavigatorSaveItem.Name = "tblEmpBindingNavigatorSaveItem";
            this.tblEmpBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblEmpBindingNavigatorSaveItem.Text = "Save Data";
            this.tblEmpBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblEmpBindingNavigatorSaveItem_Click);
            // 
            // tblEmpDataGridView
            // 
            this.tblEmpDataGridView.AutoGenerateColumns = false;
            this.tblEmpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.tblEmpDataGridView.DataSource = this.tblEmpBindingSource;
            this.tblEmpDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmpDataGridView.Location = new System.Drawing.Point(0, 602);
            this.tblEmpDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblEmpDataGridView.Name = "tblEmpDataGridView";
            this.tblEmpDataGridView.Size = new System.Drawing.Size(1404, 375);
            this.tblEmpDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_officer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_officer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "F_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "F_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "L_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "L_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Card";
            this.dataGridViewTextBoxColumn4.HeaderText = "Card";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn8.HeaderText = "Username";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn9.HeaderText = "Password";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Stetus";
            this.dataGridViewTextBoxColumn10.HeaderText = "Stetus";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Picture";
            this.dataGridViewTextBoxColumn11.HeaderText = "Picture";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Admin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(adminLabel);
            this.panel1.Controls.Add(this.adminCheckBox);
            this.panel1.Controls.Add(pictureLabel);
            this.panel1.Controls.Add(this.pictureTextBox);
            this.panel1.Controls.Add(stetusLabel);
            this.panel1.Controls.Add(this.stetusTextBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(usernameLabel);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(salaryLabel);
            this.panel1.Controls.Add(this.salaryTextBox);
            this.panel1.Controls.Add(telLabel);
            this.panel1.Controls.Add(this.telTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(cardLabel);
            this.panel1.Controls.Add(this.cardTextBox);
            this.panel1.Controls.Add(l_NameLabel);
            this.panel1.Controls.Add(this.l_NameTextBox);
            this.panel1.Controls.Add(f_NameLabel);
            this.panel1.Controls.Add(this.f_NameTextBox);
            this.panel1.Controls.Add(id_officerLabel);
            this.panel1.Controls.Add(this.id_officerTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 577);
            this.panel1.TabIndex = 2;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblEmpBindingSource, "Admin", true));
            this.adminCheckBox.Location = new System.Drawing.Point(116, 525);
            this.adminCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(156, 37);
            this.adminCheckBox.TabIndex = 23;
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Picture", true));
            this.pictureTextBox.Image = null;
            this.pictureTextBox.ImageButton = ((System.Drawing.Image)(resources.GetObject("pictureTextBox.ImageButton")));
            this.pictureTextBox.Location = new System.Drawing.Point(816, 5);
            this.pictureTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(570, 515);
            this.pictureTextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTextBox.SubDirectory = null;
            this.pictureTextBox.TabIndex = 21;
            this.pictureTextBox.Load += new System.EventHandler(this.pictureTextBox_Load);
            // 
            // stetusTextBox
            // 
            this.stetusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Stetus", true));
            this.stetusTextBox.Location = new System.Drawing.Point(116, 485);
            this.stetusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stetusTextBox.Name = "stetusTextBox";
            this.stetusTextBox.Size = new System.Drawing.Size(436, 26);
            this.stetusTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(116, 445);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(436, 26);
            this.passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(116, 405);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(436, 26);
            this.usernameTextBox.TabIndex = 15;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(116, 365);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(436, 26);
            this.salaryTextBox.TabIndex = 13;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(116, 325);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(436, 26);
            this.telTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(116, 188);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(436, 126);
            this.addressTextBox.TabIndex = 9;
            // 
            // cardTextBox
            // 
            this.cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Card", true));
            this.cardTextBox.Location = new System.Drawing.Point(116, 148);
            this.cardTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(436, 26);
            this.cardTextBox.TabIndex = 7;
            // 
            // l_NameTextBox
            // 
            this.l_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "L_Name", true));
            this.l_NameTextBox.Location = new System.Drawing.Point(116, 108);
            this.l_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.l_NameTextBox.Name = "l_NameTextBox";
            this.l_NameTextBox.Size = new System.Drawing.Size(436, 26);
            this.l_NameTextBox.TabIndex = 5;
            // 
            // f_NameTextBox
            // 
            this.f_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "F_Name", true));
            this.f_NameTextBox.Location = new System.Drawing.Point(116, 68);
            this.f_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.f_NameTextBox.Name = "f_NameTextBox";
            this.f_NameTextBox.Size = new System.Drawing.Size(436, 26);
            this.f_NameTextBox.TabIndex = 3;
            // 
            // id_officerTextBox
            // 
            this.id_officerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpBindingSource, "Id_officer", true));
            this.id_officerTextBox.Location = new System.Drawing.Point(116, 28);
            this.id_officerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_officerTextBox.Name = "id_officerTextBox";
            this.id_officerTextBox.Size = new System.Drawing.Size(148, 26);
            this.id_officerTextBox.TabIndex = 1;
            // 
            // frmEmpAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 977);
            this.Controls.Add(this.tblEmpDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblEmpBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmEmpAll";
            this.Text = "frmEmpAll";
            this.Load += new System.EventHandler(this.frmEmpAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingNavigator)).EndInit();
            this.tblEmpBindingNavigator.ResumeLayout(false);
            this.tblEmpBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db.DS_User dS_User;
        private System.Windows.Forms.BindingSource tblEmpBindingSource;
        private db.DS_UserTableAdapters.tblEmpTableAdapter tblEmpTableAdapter;
        private db.DS_UserTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblEmpBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblEmpBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblEmpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private TORServices.Forms.Forms.PictureboxOpenPath pictureTextBox;
        private System.Windows.Forms.TextBox stetusTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox l_NameTextBox;
        private System.Windows.Forms.TextBox f_NameTextBox;
        private System.Windows.Forms.TextBox id_officerTextBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
    }
}