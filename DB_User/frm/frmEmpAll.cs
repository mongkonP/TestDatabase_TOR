using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms.Ext;
using TORServices.Forms.Ext.Datagridviews;

namespace DB_User.frm
{
    public partial class frmEmpAll : frmDialogBase
    {
        public frmEmpAll()
        {
            InitializeComponent();
            tblEmpDataGridView.SetDefaultCellStyle();
        }

        private void tblEmpBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblEmpBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_User);


        }
        void InsertTestData()
        {
           // tblEmpTableAdapter.Insert(1, "Admin", "Admin", null, null, null, null, "ADMIN", "ADMIN", null, null, true);
            tblEmpTableAdapter.Insert(2, "EMP 001", "EMP 001", null, null, null, null, "ADMIN01", "ADMIN", null, null, true);
            tblEmpTableAdapter.Insert(3, "EMP 002", "EMP 002", null, null, null, null, "EMP 002", "EMP 002", null, null, true);
            tblEmpTableAdapter.Insert(4, "EMP 003", "EMP 003", null, null, null, null, "EMP 003", "EMP 003", null, null, false);

        }
        private void frmEmpAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_User.tblEmp' table. You can move, or remove it, as needed.
            this.tblEmpTableAdapter.Fill(this.dS_User.tblEmp);
           /* InsertTestData();
            this.tblEmpTableAdapter.Fill(this.dS_User.tblEmp);*/
        }

        private void pictureTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
