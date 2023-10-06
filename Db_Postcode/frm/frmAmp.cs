using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TORServices.Forms.Ext;
using TORServices.Forms.FormsDatabase;

namespace Db_Postcode.frm
{
    public  class frmAmp : frmDatagrid_base

    {
        private db.DS_Postcode dS_Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn postAmphurIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postAmphurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postAmphurEngDataGridViewTextBoxColumn;
        private db.DS_PostcodeTableAdapters.PostCode_AmphurTableAdapter postCode_AmphurTableAdapter;

        private void InitializeComponent()
        {
            this.dS_Postcode = new Db_Postcode.db.DS_Postcode();
            this.postAmphurIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postAmphurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postAmphurEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCode_AmphurTableAdapter = new Db_Postcode.db.DS_PostcodeTableAdapters.PostCode_AmphurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Postcode)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "PostCode_Amphur";
            this.bindingSource.DataSource = this.dS_Postcode;
            // 
            // dS_Postcode
            // 
            this.dS_Postcode.DataSetName = "DS_Postcode";
            this.dS_Postcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postAmphurIDDataGridViewTextBoxColumn
            // 
            this.postAmphurIDDataGridViewTextBoxColumn.DataPropertyName = "Post_Amphur_ID";
            this.postAmphurIDDataGridViewTextBoxColumn.HeaderText = "Post_Amphur_ID";
            this.postAmphurIDDataGridViewTextBoxColumn.Name = "postAmphurIDDataGridViewTextBoxColumn";
            this.postAmphurIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postAmphurDataGridViewTextBoxColumn
            // 
            this.postAmphurDataGridViewTextBoxColumn.DataPropertyName = "Post_Amphur";
            this.postAmphurDataGridViewTextBoxColumn.HeaderText = "Post_Amphur";
            this.postAmphurDataGridViewTextBoxColumn.Name = "postAmphurDataGridViewTextBoxColumn";
            // 
            // postAmphurEngDataGridViewTextBoxColumn
            // 
            this.postAmphurEngDataGridViewTextBoxColumn.DataPropertyName = "Post_Amphur_Eng";
            this.postAmphurEngDataGridViewTextBoxColumn.HeaderText = "Post_Amphur_Eng";
            this.postAmphurEngDataGridViewTextBoxColumn.Name = "postAmphurEngDataGridViewTextBoxColumn";
            // 
            // postCode_AmphurTableAdapter
            // 
            this.postCode_AmphurTableAdapter.ClearBeforeFill = true;
            // 
            // frmAmp
            // 
            this.ClientSize = new System.Drawing.Size(837, 619);
            this.Name = "frmAmp";
            this.Load += new System.EventHandler(this.frmAmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Postcode)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmAmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Postcode.PostCode_Amphur' table. You can move, or remove it, as needed.
            this.postCode_AmphurTableAdapter.Fill(this.dS_Postcode.PostCode_Amphur);

        }
    }
}
