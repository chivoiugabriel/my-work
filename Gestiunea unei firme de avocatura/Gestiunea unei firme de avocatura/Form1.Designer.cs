namespace Gestiunea_unei_firme_de_avocatura
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avocatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avocatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avocatToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data_de_baze_DataSet1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSet();
            this.avocatiTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter();
            this.clientTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.ClientTableAdapter();
            this.procesTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.ProcesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avocatToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.procesToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adaugareToolStripMenuItem.Text = "Adaugare ";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // avocatToolStripMenuItem
            // 
            this.avocatToolStripMenuItem.Name = "avocatToolStripMenuItem";
            this.avocatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avocatToolStripMenuItem.Text = "Avocat";
            this.avocatToolStripMenuItem.Click += new System.EventHandler(this.avocatToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // procesToolStripMenuItem
            // 
            this.procesToolStripMenuItem.Name = "procesToolStripMenuItem";
            this.procesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procesToolStripMenuItem.Text = "Proces";
            this.procesToolStripMenuItem.Click += new System.EventHandler(this.procesToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avocatToolStripMenuItem1,
            this.clientToolStripMenuItem1,
            this.procesToolStripMenuItem1});
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.modificareToolStripMenuItem.Text = "Modificare ";
            // 
            // avocatToolStripMenuItem1
            // 
            this.avocatToolStripMenuItem1.Name = "avocatToolStripMenuItem1";
            this.avocatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.avocatToolStripMenuItem1.Text = "Avocat";
            this.avocatToolStripMenuItem1.Click += new System.EventHandler(this.avocatToolStripMenuItem1_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // procesToolStripMenuItem1
            // 
            this.procesToolStripMenuItem1.Name = "procesToolStripMenuItem1";
            this.procesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.procesToolStripMenuItem1.Text = "Proces";
            this.procesToolStripMenuItem1.Click += new System.EventHandler(this.procesToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avocatToolStripMenuItem2,
            this.clientToolStripMenuItem2,
            this.procesToolStripMenuItem2});
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.stergereToolStripMenuItem.Text = "Stergere ";
            // 
            // avocatToolStripMenuItem2
            // 
            this.avocatToolStripMenuItem2.Name = "avocatToolStripMenuItem2";
            this.avocatToolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.avocatToolStripMenuItem2.Text = "Avocat";
            this.avocatToolStripMenuItem2.Click += new System.EventHandler(this.avocatToolStripMenuItem2_Click);
            // 
            // clientToolStripMenuItem2
            // 
            this.clientToolStripMenuItem2.Name = "clientToolStripMenuItem2";
            this.clientToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem2.Text = "Client";
            this.clientToolStripMenuItem2.Click += new System.EventHandler(this.clientToolStripMenuItem2_Click);
            // 
            // procesToolStripMenuItem2
            // 
            this.procesToolStripMenuItem2.Name = "procesToolStripMenuItem2";
            this.procesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.procesToolStripMenuItem2.Text = "Proces";
            this.procesToolStripMenuItem2.Click += new System.EventHandler(this.procesToolStripMenuItem2_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.iesireToolStripMenuItem.Text = "Iesire ";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // data_de_baze_DataSet1
            // 
            this.data_de_baze_DataSet1.DataSetName = "Data_de_baze_DataSet";
            this.data_de_baze_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avocatiTableAdapter1
            // 
            this.avocatiTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // procesTableAdapter1
            // 
            this.procesTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Gestiunea_unei_firme_de_avocatura.Properties.Resources.logo_final_large;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avocatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avocatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avocatToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem procesToolStripMenuItem2;
        private Data_de_baze_DataSet data_de_baze_DataSet1;
        private Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter avocatiTableAdapter1;
        private Data_de_baze_DataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private Data_de_baze_DataSetTableAdapters.ProcesTableAdapter procesTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

