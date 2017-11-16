namespace BD_Lab3
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OtchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Lab2DataSet = new BD_Lab3.BD_Lab2DataSet();
            this.view_FAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_FAKTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.View_FAKTableAdapter();
            this.tableAdapterManager = new BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager();
            this.reportViewerOdin = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxFrmOb = new System.Windows.Forms.ComboBox();
            this.buttonCreateOtch = new System.Windows.Forms.Button();
            this.TextMaxKon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OtchetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_FAKBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtchetBindingSource
            // 
            this.OtchetBindingSource.DataMember = "Otchet";
            this.OtchetBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // bD_Lab2DataSet
            // 
            this.bD_Lab2DataSet.DataSetName = "BD_Lab2DataSet";
            this.bD_Lab2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_FAKBindingSource
            // 
            this.view_FAKBindingSource.DataMember = "View_FAK";
            this.view_FAKBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // view_FAKTableAdapter
            // 
            this.view_FAKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            // 
            // reportViewerOdin
            // 
            this.reportViewerOdin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerOdin.DocumentMapWidth = 85;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.OtchetBindingSource;
            this.reportViewerOdin.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerOdin.LocalReport.ReportEmbeddedResource = "BD_Lab3.ReportOdin.rdlc";
            this.reportViewerOdin.Location = new System.Drawing.Point(3, 3);
            this.reportViewerOdin.Name = "reportViewerOdin";
            this.reportViewerOdin.Size = new System.Drawing.Size(598, 430);
            this.reportViewerOdin.TabIndex = 12;
            // 
            // comboBoxFrmOb
            // 
            this.comboBoxFrmOb.FormattingEnabled = true;
            this.comboBoxFrmOb.Items.AddRange(new object[] {
            "Очная",
            "Заочная"});
            this.comboBoxFrmOb.Location = new System.Drawing.Point(139, 37);
            this.comboBoxFrmOb.Name = "comboBoxFrmOb";
            this.comboBoxFrmOb.Size = new System.Drawing.Size(136, 21);
            this.comboBoxFrmOb.TabIndex = 11;
            // 
            // buttonCreateOtch
            // 
            this.buttonCreateOtch.Location = new System.Drawing.Point(139, 90);
            this.buttonCreateOtch.Name = "buttonCreateOtch";
            this.buttonCreateOtch.Size = new System.Drawing.Size(136, 23);
            this.buttonCreateOtch.TabIndex = 10;
            this.buttonCreateOtch.Text = "Создать";
            this.buttonCreateOtch.UseVisualStyleBackColor = true;
            this.buttonCreateOtch.Click += new System.EventHandler(this.buttonCreateOtch_Click);
            // 
            // TextMaxKon
            // 
            this.TextMaxKon.Location = new System.Drawing.Point(139, 64);
            this.TextMaxKon.Name = "TextMaxKon";
            this.TextMaxKon.Size = new System.Drawing.Size(136, 20);
            this.TextMaxKon.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Максимальный конкурс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Форма обучения";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewerOdin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 436);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextMaxKon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCreateOtch);
            this.panel1.Controls.Add(this.comboBoxFrmOb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(607, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 430);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Создать/Изменить отчет";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(720, 350);
            this.Name = "FormReport";
            this.Text = "Отчет по плану приема";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtchetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_FAKBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_Lab2DataSet bD_Lab2DataSet;
        private System.Windows.Forms.BindingSource view_FAKBindingSource;
        private BD_Lab2DataSetTableAdapters.View_FAKTableAdapter view_FAKTableAdapter;
        private BD_Lab2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource OtchetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOdin;
        private System.Windows.Forms.ComboBox comboBoxFrmOb;
        private System.Windows.Forms.Button buttonCreateOtch;
        private System.Windows.Forms.TextBox TextMaxKon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;

    }
}