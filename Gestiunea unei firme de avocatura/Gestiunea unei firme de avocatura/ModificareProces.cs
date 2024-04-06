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
    public partial class ModificareProces : Form
    {
        SqlConnection conn;
        public ModificareProces()
        {
            InitializeComponent();
        }

        private void ModificareProces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Proces' table. You can move, or remove it, as needed.
            this.procesTableAdapter.Fill(this.data_de_baze_DataSet.Proces);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String updateQuery = "UPDATE Proces SET ";
            updateQuery += "[Pret] = @pret, [Decizie] = @decizie, [Tip_proces]= @tip_proc, [Nr_dosar]=@nr_dos";
            updateQuery += "WHERE Id = @Id";

            int id = Convert.ToInt32(procesDataGridView.CurrentRow.Cells["Id"].Value);

            if (conn == null)
                conn = new SqlConnection(Properties.Settings.Default.dbConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@pret", textBox2.Text);
            cmd.Parameters.AddWithValue("@decizie", textBox3.Text);
            cmd.Parameters.AddWithValue("@tip_proc", textBox4.Text);
            cmd.Parameters.AddWithValue("@nr_dos", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Modificarea s-a realizat cu succes !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procesTableAdapter.Fill(data_de_baze_DataSet.Proces);
            }
            else
                MessageBox.Show("Eroare la modificarea datelor !", "Eroare !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

