namespace Gestiunea_unei_firme_de_avocatura
{
    partial class AdaugareAvocat
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.data_de_baze_DataSet = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSet();
            this.barouBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barouTableAdapter = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.BarouTableAdapter();
            this.tableAdapterManager = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager();
            this.specializari_TableAdapter = new Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.Specializari_TableAdapter();
            this.barouComboBox = new System.Windows.Forms.ComboBox();
            this.specializari_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializari_ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barouBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializari_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barou";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specializare";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(15, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_de_baze_DataSet
            // 
            this.data_de_baze_DataSet.DataSetName = "Data_de_baze_DataSet";
            this.data_de_baze_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barouBindingSource
            // 
            this.barouBindingSource.DataMember = "Barou";
            this.barouBindingSource.DataSource = this.data_de_baze_DataSet;
            // 
            // barouTableAdapter
            // 
            this.barouTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvocatiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarouTableAdapter = this.barouTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Etape_procesTableAdapter = null;
            this.tableAdapterManager.ProcesTableAdapter = null;
            this.tableAdapterManager.Specializari_TableAdapter = this.specializari_TableAdapter;
            this.tableAdapterManager.Status_procesTableAdapter = null;
            this.tableAdapterManager.Tip_clientTableAdapter = null;
            this.tableAdapterManager.Tip_procesTableAdapter = null;
            this.tableAdapterManager.TribunalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestiunea_unei_firme_de_avocatura.Data_de_baze_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // specializari_TableAdapter
            // 
            this.specializari_TableAdapter.ClearBeforeFill = true;
            // 
            // barouComboBox
            // 
            this.barouComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.barouBindingSource, "Nume", true));
            this.barouComboBox.DataSource = this.barouBindingSource;
            this.barouComboBox.DisplayMember = "Nume";
            this.barouComboBox.FormattingEnabled = true;
            this.barouComboBox.Location = new System.Drawing.Point(82, 90);
            this.barouComboBox.Name = "barouComboBox";
            this.barouComboBox.Size = new System.Drawing.Size(300, 21);
            this.barouComboBox.TabIndex = 13;
            this.barouComboBox.ValueMember = "Id";
            // 
            // specializari_BindingSource
            // 
            this.specializari_BindingSource.DataMember = "Specializari ";
            this.specializari_BindingSource.DataSource = this.data_de_baze_DataSet;
            // 
            // specializari_ComboBox
            // 
            this.specializari_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.specializari_BindingSource, "Denumire ", true));
            this.specializari_ComboBox.DataSource = this.specializari_BindingSource;
            this.specializari_ComboBox.DisplayMember = "Denumire ";
            this.specializari_ComboBox.FormattingEnabled = true;
            this.specializari_ComboBox.Location = new System.Drawing.Point(82, 115);
            this.specializari_ComboBox.Name = "specializari_ComboBox";
            this.specializari_ComboBox.Size = new System.Drawing.Size(300, 21);
            this.specializari_ComboBox.TabIndex = 13;
            this.specializari_ComboBox.ValueMember = "Id";
            // 
            // AdaugareAvocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(603, 202);
            this.Controls.Add(this.specializari_ComboBox);
            this.Controls.Add(this.barouComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "AdaugareAvocat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugareAvocat";
            this.Load += new System.EventHandler(this.AdaugareAvocat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_de_baze_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barouBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializari_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Data_de_baze_DataSet data_de_baze_DataSet;
        private System.Windows.Forms.BindingSource barouBindingSource;
        private Data_de_baze_DataSetTableAdapters.BarouTableAdapter barouTableAdapter;
        private Data_de_baze_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox barouComboBox;
        private Data_de_baze_DataSetTableAdapters.Specializari_TableAdapter specializari_TableAdapter;
        private System.Windows.Forms.BindingSource specializari_BindingSource;
        private System.Windows.Forms.ComboBox specializari_ComboBox;
    }
}