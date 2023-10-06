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
using TORServices.Forms.FormsDatabase;

namespace DB_Student.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tblStudentDataGridView.SetDefaultCellStyle();
            CenterToScreen();
        }

        private void tblStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.dS.tblStudent);

        }
    }
}
