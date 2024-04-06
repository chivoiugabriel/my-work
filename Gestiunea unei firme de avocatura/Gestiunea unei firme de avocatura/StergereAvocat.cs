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
    public partial class StergereAvocat : Form
    {
        SqlConnection conn;
        public StergereAvocat()
        {
            InitializeComponent();
        }

        private void avocatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avocatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_de_baze_DataSet);

        }

        private void StergereAvocat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Avocati' table. You can move, or remove it, as needed.
            this.avocatiTableAdapter.Fill(this.data_de_baze_DataSet.Avocati);

        }

        private void avocatiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult response = MessageBox.Show("Sunteti sigur ?", "Atentie !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(avocatiDataGridView.CurrentRow.Cells["Id"].Value);
                    avocatiTableAdapter.DeleteById(id);
                    avocatiTableAdapter.Fill(data_de_baze_DataSet.Avocati);

                }
            }
        }
    }
}
