namespace BD_Lab3
{
    partial class Sprav_spec
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиекафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Lab2DataSet = new BD_Lab3.BD_Lab2DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpravIzm = new System.Windows.Forms.Button();
            this.SpravDob = new System.Windows.Forms.Button();
            this.специальностиTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDспециальностиDataGridViewTextBoxColumn,
            this.номерспециальностиDataGridViewTextBoxColumn,
            this.названиеспециальностиDataGridViewTextBoxColumn,
            this.названиекафедрыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.специальностиBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(602, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDспециальностиDataGridViewTextBoxColumn
            // 
            this.iDспециальностиDataGridViewTextBoxColumn.DataPropertyName = "ID_специальности";
            this.iDспециальностиDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDспециальностиDataGridViewTextBoxColumn.Name = "iDспециальностиDataGridViewTextBoxColumn";
            this.iDспециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDспециальностиDataGridViewTextBoxColumn.Width = 35;
            // 
            // номерспециальностиDataGridViewTextBoxColumn
            // 
            this.номерспециальностиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.номерспециальностиDataGridViewTextBoxColumn.DataPropertyName = "Номер_специальности";
            this.номерспециальностиDataGridViewTextBoxColumn.HeaderText = "Номер специальности";
            this.номерспециальностиDataGridViewTextBoxColumn.Name = "номерспециальностиDataGridViewTextBoxColumn";
            this.номерспециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерспециальностиDataGridViewTextBoxColumn.Width = 133;
            // 
            // названиеспециальностиDataGridViewTextBoxColumn
            // 
            this.названиеспециальностиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.названиеспециальностиDataGridViewTextBoxColumn.DataPropertyName = "Название_специальности";
            this.названиеспециальностиDataGridViewTextBoxColumn.HeaderText = "Название специальности";
            this.названиеспециальностиDataGridViewTextBoxColumn.Name = "названиеспециальностиDataGridViewTextBoxColumn";
            this.названиеспециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеспециальностиDataGridViewTextBoxColumn.Width = 148;
            // 
            // названиекафедрыDataGridViewTextBoxColumn
            // 
            this.названиекафедрыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.названиекафедрыDataGridViewTextBoxColumn.DataPropertyName = "Название_кафедры";
            this.названиекафедрыDataGridViewTextBoxColumn.HeaderText = "Название кафедры";
            this.названиекафедрыDataGridViewTextBoxColumn.Name = "названиекафедрыDataGridViewTextBoxColumn";
            this.названиекафедрыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиекафедрыDataGridViewTextBoxColumn.Width = 120;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // bD_Lab2DataSet
            // 
            this.bD_Lab2DataSet.DataSetName = "BD_Lab2DataSet";
            this.bD_Lab2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpravIzm);
            this.panel1.Controls.Add(this.SpravDob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 31);
            this.panel1.TabIndex = 1;
            // 
            // SpravIzm
            // 
            this.SpravIzm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpravIzm.Location = new System.Drawing.Point(334, 3);
            this.SpravIzm.Name = "SpravIzm";
            this.SpravIzm.Size = new System.Drawing.Size(147, 23);
            this.SpravIzm.TabIndex = 1;
            this.SpravIzm.Text = "Изменить запись";
            this.SpravIzm.UseVisualStyleBackColor = true;
            this.SpravIzm.Click += new System.EventHandler(this.SpravIzm_Click);
            // 
            // SpravDob
            // 
            this.SpravDob.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpravDob.Location = new System.Drawing.Point(115, 3);
            this.SpravDob.Name = "SpravDob";
            this.SpravDob.Size = new System.Drawing.Size(147, 23);
            this.SpravDob.TabIndex = 0;
            this.SpravDob.Text = "Добавить запись";
            this.SpravDob.UseVisualStyleBackColor = true;
            this.SpravDob.Click += new System.EventHandler(this.SpravDob_Click);
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // Sprav_spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Sprav_spec";
            this.Text = "Справочник специальностей";
            this.Load += new System.EventHandler(this.Sprav_spec_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_Lab2DataSet bD_Lab2DataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SpravIzm;
        private System.Windows.Forms.Button SpravDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиекафедрыDataGridViewTextBoxColumn;
    }
}