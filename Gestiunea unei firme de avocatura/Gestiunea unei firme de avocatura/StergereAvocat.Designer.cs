namespace Gestiunea_unei_firme_de_avocatura
{
    partial class StergereAvocat
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
            this.data_de_baze_DataSet = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSet();
            this.avocatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avocatiTableAdapter = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter();
            this.tableAdapterManager = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager();
            this.avocatiDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stergere = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // data_de_baze_DataSet
            // 
            this.data_de_baze_DataSet.DataSetName = "Data_de_baze_DataSet";
            this.data_de_baze_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avocatiBindingSource
            // 
            this.avocatiBindingSource.DataMember = "Avocati";
            this.avocatiBindingSource.DataSource = this.data_de_baze_DataSet;
            // 
            // avocatiTableAdapter
            // 
            this.avocatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvocatiTableAdapter = this.avocatiTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarouTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Etape_procesTableAdapter = null;
            this.tableAdapterManager.ProcesTableAdapter = null;
            this.tableAdapterManager.Specializari_TableAdapter = null;
            this.tableAdapterManager.Status_procesTableAdapter = null;
            this.tableAdapterManager.Tip_clientTableAdapter = null;
            this.tableAdapterManager.Tip_procesTableAdapter = null;
            this.tableAdapterManager.TribunalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // avocatiDataGridView
            // 
            this.avocatiDataGridView.AutoGenerateColumns = false;
            this.avocatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avocatiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Stergere});
            this.avocatiDataGridView.DataSource = this.avocatiBindingSource;
            this.avocatiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avocatiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.avocatiDataGridView.Name = "avocatiDataGridView";
            this.avocatiDataGridView.Size = new System.Drawing.Size(800, 450);
            this.avocatiDataGridView.TabIndex = 1;
            this.avocatiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avocatiDataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Nume";
            this.dataGridViewImageColumn1.HeaderText = "Nume";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Telefon";
            this.dataGridViewImageColumn2.HeaderText = "Telefon";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_barou";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_barou";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_specializare";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_specializare";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Stergere
            // 
            this.Stergere.HeaderText = "Stergere";
            this.Stergere.Name = "Stergere";
            // 
            // StergereAvocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avocatiDataGridView);
            this.Name = "StergereAvocat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StergereAvocat";
            this.Load += new System.EventHandler(this.StergereAvocat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avocatiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Data_de_baze_DataSet data_de_baze_DataSet;
        private System.Windows.Forms.BindingSource avocatiBindingSource;
        private Data_de_baze_DataSetTableAdapters.AvocatiTableAdapter avocatiTableAdapter;
        private Data_de_baze_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView avocatiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Stergere;
    }
}