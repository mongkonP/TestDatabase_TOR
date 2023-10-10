using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms.Ext.Datagridviews;

namespace ChemAtom.frm
{
    public partial class frmElementTable : Form
    {
        public frmElementTable()
        {
            InitializeComponent();
            tblElementsDataGridView.SetDefaultCellStyle();
        }

        private void tblElementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblElementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbElement);

        }

        private void frmElementTable_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // TODO: This line of code loads data into the 'dbElement.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dbElement.tblElements);

        }
    }
}
