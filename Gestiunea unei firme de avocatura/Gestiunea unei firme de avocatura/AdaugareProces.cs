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
    public partial class AdaugareProces : Form
    {
        SqlConnection conn;
        public AdaugareProces()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String insertSql = "INSERT INTO Proces (Id_client, Id_avocat,Id_tribunal, Nr_dosar,Pret, Decizie, Tip_proces) VALUES (";
            insertSql +=Convert.ToInt32(textBox1.Text)+","+ Convert.ToInt32(textBox2.Text) +","+ Convert.ToInt32(tribunalComboBox.SelectedValue)  + ", '" + textBox4.Text + "', "+Convert.ToDouble(textBox6.Text) + ", '"+textBox7.Text + "', " +Convert.ToInt32(tip_procesComboBox.SelectedValue)+ ")";

            //MessageBox.Show(insertSql);

            if (conn == null)
                conn = new SqlConnection(Properties.Settings.Default.dbConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(insertSql, conn);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Adaugare cu succes !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Eroare la adaugarea in tabela !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clear();
        }
        private void Clear()
        {
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox4.Focus();
        }

        private void tip_procesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tip_procesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_de_baze_DataSet);

        }

        private void AdaugareProces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Tribunal' table. You can move, or remove it, as needed.
            this.tribunalTableAdapter.Fill(this.data_de_baze_DataSet.Tribunal);
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Tip_proces' table. You can move, or remove it, as needed.
            this.tip_procesTableAdapter.Fill(this.data_de_baze_DataSet.Tip_proces);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
