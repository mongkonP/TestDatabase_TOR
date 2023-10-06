using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms.FormsDatabase;

namespace DB_User.frm
{
    public  class frmLogin:frmLoginBase
    {
        private db.DS_User dS_User;
        private System.Windows.Forms.BindingSource tblEmpBindingSource;
        private System.ComponentModel.IContainer components;
        private db.DS_UserTableAdapters.tblEmpTableAdapter tblEmpTableAdapter;
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
        private db.DS_UserTableAdapters.TableAdapterManager tableAdapterManager;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.tblEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_User = new DB_User.db.DS_User();
            this.tblEmpTableAdapter = new DB_User.db.DS_UserTableAdapters.tblEmpTableAdapter();
            this.tableAdapterManager = new DB_User.db.DS_UserTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_01
            // 
            this.pic_01.Location = new System.Drawing.Point(12, 91);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // tblEmpDataGridView
            // 
            this.tblEmpDataGridView.AllowUserToAddRows = false;
            this.tblEmpDataGridView.AllowUserToDeleteRows = false;
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
            this.tblEmpDataGridView.Location = new System.Drawing.Point(9, 490);
            this.tblEmpDataGridView.Name = "tblEmpDataGridView";
            this.tblEmpDataGridView.ReadOnly = true;
            this.tblEmpDataGridView.Size = new System.Drawing.Size(790, 98);
            this.tblEmpDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_officer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_officer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "F_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "F_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "L_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "L_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Card";
            this.dataGridViewTextBoxColumn4.HeaderText = "Card";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn8.HeaderText = "Username";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn9.HeaderText = "Password";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Stetus";
            this.dataGridViewTextBoxColumn10.HeaderText = "Stetus";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Picture";
            this.dataGridViewTextBoxColumn11.HeaderText = "Picture";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Admin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // tblEmpBindingSource
            // 
            this.tblEmpBindingSource.DataMember = "tblEmp";
            this.tblEmpBindingSource.DataSource = this.dS_User;
            // 
            // dS_User
            // 
            this.dS_User.DataSetName = "DS_User";
            this.dS_User.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(840, 438);
            this.Controls.Add(this.tblEmpDataGridView);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmLogin";
            this.ShowInTaskbar = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(this.cmdSubmit, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pic_01, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.tblEmpDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public frmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void tblEmpBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblEmpBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_User);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_User.tblEmp' table. You can move, or remove it, as needed.
            this.tblEmpTableAdapter.Fill(this.dS_User.tblEmp);

        }


      public override void CHECKLOGIN(string User, string Pass)
        {
            if (txtUserName.Text == "ADMINSYSTEM" && txtPass.Text == "ADMINSYSTEM")
            {
              new frmEmpAll().ShowDialog();
                this.Close();
            }
            else
            { 
            tblEmpTableAdapter.FillByUserPass(this.dS_User.tblEmp,User, Pass);
            if (tblEmpDataGridView.RowCount > 0)
            {
                MessageBox.Show("ยินดีต้อนรับคุณ:\n\n" + tblEmpDataGridView[1, 0].Value.ToString() + " " + tblEmpDataGridView[2, 0].Value.ToString());
                new frmEmpDetail((int)tblEmpDataGridView[0, 0].Value).ShowDialog();
                    this.Close();
          }
            else
            {
                MessageBox.Show("User name หรือ User pass ผิดพลาด" + Environment.NewLine + "กรุณาระบุใหม่อีกครั้ง");
                txtUserName.Focus();
            }
            }

        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
