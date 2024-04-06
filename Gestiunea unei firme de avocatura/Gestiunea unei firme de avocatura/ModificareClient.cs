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
    public partial class ModificareClient : Form
    {
        SqlConnection conn;
        public ModificareClient()
        {
            InitializeComponent();
        }

        private void ModificareClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.data_de_baze_DataSet.Client);

        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sunteti sigur ca vreti sa salvati modificarile ?", "Atentie !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                String updateQuery = "UPDATE Client SET ";
                updateQuery += "[Nume]= @nume, [Adresa] = @adresa, [Telefon]= @tel";
                updateQuery += "WHERE Id = @Id";

                int id = Convert.ToInt32(clientDataGridView.CurrentRow.Cells["Id"].Value);

                if (conn == null)
                    conn = new SqlConnection(Properties.Settings.Default.dbConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@nume", textBox1.Text);
                cmd.Parameters.AddWithValue("@adresa", textBox2.Text);
                cmd.Parameters.AddWithValue("@tel", textBox3.Text);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Modificarea s-a realizat cu succes !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clientTableAdapter.Fill(data_de_baze_DataSet.Client);
                }
                else
                    MessageBox.Show("Eroare la modificarea datelor !", "Eroare !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
