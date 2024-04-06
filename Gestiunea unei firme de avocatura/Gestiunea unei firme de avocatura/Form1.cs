using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiunea_unei_firme_de_avocatura
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void avocatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareAvocat adFrm = new AdaugareAvocat();
            adFrm.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareClient adFrm = new AdaugareClient();
            adFrm.ShowDialog();
        }

        private void procesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareProces adFrm = new AdaugareProces();
            adFrm.ShowDialog();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avocatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificareAvocat modFrm = new ModificareAvocat();
            modFrm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void avocatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StergereAvocat modFrm = new StergereAvocat();
            modFrm.ShowDialog();
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificareClient stergFrm = new ModificareClient();
            stergFrm.ShowDialog();
        }

        private void procesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificareProces modFrm = new ModificareProces();
            modFrm.ShowDialog();
        }

        private void clientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StergereClient stergFrm = new StergereClient();
            stergFrm.ShowDialog();
        }

        private void procesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StergereProces stergFrm = new StergereProces();
            stergFrm.ShowDialog();
        }
    }
}
