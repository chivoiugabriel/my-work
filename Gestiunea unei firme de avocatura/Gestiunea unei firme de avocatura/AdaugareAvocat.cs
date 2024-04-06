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
    public partial class AdaugareAvocat : Form
    {
        SqlConnection conn;
        public AdaugareAvocat()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String insertSql = "INSERT INTO Avocati (Nume,Adresa, Telefon, Id_barou, Id_specializare) VALUES ('";
            insertSql +=textBox2.Text + "', '" +textBox3.Text;
            insertSql += "', '" + textBox4.Text + "', '" + Convert.ToInt32(barouComboBox.SelectedValue) + "', '" +Convert.ToInt32(specializari_ComboBox.SelectedValue)+"')";

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
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Focus();
        }

        private void barouBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.barouBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_de_baze_DataSet);

        }

        private void barouBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.barouBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_de_baze_DataSet);

        }

        private void AdaugareAvocat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Specializari_' table. You can move, or remove it, as needed.
            this.specializari_TableAdapter.Fill(this.data_de_baze_DataSet.Specializari_);
            // TODO: This line of code loads data into the 'data_de_baze_DataSet.Barou' table. You can move, or remove it, as needed.
            this.barouTableAdapter.Fill(this.data_de_baze_DataSet.Barou);

        }
    }
}

