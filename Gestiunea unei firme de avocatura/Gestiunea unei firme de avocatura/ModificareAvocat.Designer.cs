namespace Gestiunea_unei_firme_de_avocatura
{
    partial class ModificareAvocat
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.avocatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_de_baze_DataSet = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSet();
            this.datadebazeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avocatiTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter();
            this.clientTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.ClientTableAdapter();
            this.tribunalTableAdapter1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TribunalTableAdapter();
            this.tableAdapterManager = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager();
            this.data_de_baze_DataSet1 = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSet();
            this.avocatiDataGridView = new System.Windows.Forms.DataGridView();
            this.avocatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadebazeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(419, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avocatiBindingSource
            // 
            this.avocatiBindingSource.DataMember = "Avocati";
            this.avocatiBindingSource.DataSource = this.data_de_baze_DataSet;
            // 
            // data_de_baze_DataSet
            // 
            this.data_de_baze_DataSet.DataSetName = "Data_de_baze_DataSet";
            this.data_de_baze_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datadebazeDataSetBindingSource
            // 
            this.datadebazeDataSetBindingSource.DataSource = this.data_de_baze_DataSet;
            this.datadebazeDataSetBindingSource.Position = 0;
            // 
            // avocatiTableAdapter1
            // 
            this.avocatiTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // tribunalTableAdapter1
            // 
            this.tribunalTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvocatiTableAdapter = this.avocatiTableAdapter1;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarouTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter1;
            this.tableAdapterManager.Etape_procesTableAdapter = null;
            this.tableAdapterManager.ProcesTableAdapter = null;
            this.tableAdapterManager.Specializari_TableAdapter = null;
            this.tableAdapterManager.Status_procesTableAdapter = null;
            this.tableAdapterManager.Tip_clientTableAdapter = null;
            this.tableAdapterManager.Tip_procesTableAdapter = null;
            this.tableAdapterManager.TribunalTableAdapter = this.tribunalTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // data_de_baze_DataSet1
            // 
            this.data_de_baze_DataSet1.DataSetName = "Data_de_baze_DataSet";
            this.data_de_baze_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avocatiDataGridView
            // 
            this.avocatiDataGridView.AutoGenerateColumns = false;
            this.avocatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avocatiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.idbarouDataGridViewTextBoxColumn,
            this.idspecializareDataGridViewTextBoxColumn});
            this.avocatiDataGridView.DataSource = this.avocatiBindingSource1;
            this.avocatiDataGridView.Location = new System.Drawing.Point(22, 12);
            this.avocatiDataGridView.Name = "avocatiDataGridView";
            this.avocatiDataGridView.Size = new System.Drawing.Size(470, 150);
            this.avocatiDataGridView.TabIndex = 8;
            // 
            // avocatiBindingSource1
            // 
            this.avocatiBindingSource1.DataMember = "Avocati";
            this.avocatiBindingSource1.DataSource = this.data_de_baze_DataSet;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // idbarouDataGridViewTextBoxColumn
            // 
            this.idbarouDataGridViewTextBoxColumn.DataPropertyName = "Id_barou";
            this.idbarouDataGridViewTextBoxColumn.HeaderText = "Id_barou";
            this.idbarouDataGridViewTextBoxColumn.Name = "idbarouDataGridViewTextBoxColumn";
            this.idbarouDataGridViewTextBoxColumn.Visible = false;
            // 
            // idspecializareDataGridViewTextBoxColumn
            // 
            this.idspecializareDataGridViewTextBoxColumn.DataPropertyName = "Id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.HeaderText = "Id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.Name = "idspecializareDataGridViewTextBoxColumn";
            this.idspecializareDataGridViewTextBoxColumn.Visible = false;
            // 
            // ModificareAvocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(504, 290);
            this.Controls.Add(this.avocatiDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModificareAvocat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificareAvocat";
            this.Load += new System.EventHandler(this.ModificareAvocat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadebazeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data_de_baze_DataSet data_de_baze_DataSet;
        private System.Windows.Forms.BindingSource datadebazeDataSetBindingSource;
        private Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter avocatiTableAdapter1;
        private Data_de_baze_DataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private Data_de_baze_DataSetTableAdapters.TribunalTableAdapter tribunalTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource avocatiBindingSource;
        private Data_de_baze_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Data_de_baze_DataSet data_de_baze_DataSet1;
        private System.Windows.Forms.DataGridView avocatiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource avocatiBindingSource1;
    }
}