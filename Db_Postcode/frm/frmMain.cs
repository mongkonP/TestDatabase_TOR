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

namespace Db_Postcode.frm
{
    public partial class frmMain : frmDialogBase
    {
        public frmMain()
        {
            InitializeComponent();
            postCodeViewDataGridView.SetDefaultCellStyle();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // TODO: This line of code loads data into the 'dS_Postcode.PostCodeView' table. You can move, or remove it, as needed.
            this.postCodeViewTableAdapter.Fill(this.dS_Postcode.PostCodeView);

        }
    }
}
