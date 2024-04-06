using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestiunea_unei_firme_de_avocatura
{
    public partial class StergereClient : Form
    {
        SqlConnection conn;
        public StergereClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_de_baze_DataSet);

        }

        private void StergereClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.data_de_baze_DataSet.Client);

        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult response = MessageBox.Show("Sunteti sigur ?", "Atentie !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(clientDataGridView.CurrentRow.Cells["Id"].Value);
                    clientTableAdapter.DeleteById(id);
                    clientTableAdapter.Fill(data_de_baze_DataSet.Client);

                }
            }
        }
    }
}
