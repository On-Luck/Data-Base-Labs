namespace BD_Lab3
{
    partial class FormDobPlanPriema
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
            this.bD_Lab2DataSet = new BD_Lab3.BD_Lab2DataSet();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager();
            this.план_приемаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.план_приемаTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.План_приемаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomSpec_Combobox = new System.Windows.Forms.ComboBox();
            this.Kol_vo_text = new System.Windows.Forms.TextBox();
            this.Podano_text = new System.Windows.Forms.TextBox();
            this.DobPlan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FormaObychCombobox = new System.Windows.Forms.ComboBox();
            this.FacultetCombobox = new System.Windows.Forms.ComboBox();
            this.NazvSpecCombobox = new System.Windows.Forms.ComboBox();
            this.viewFAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_FAKTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.View_FAKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.план_приемаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFAKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_Lab2DataSet
            // 
            this.bD_Lab2DataSet.DataSetName = "BD_Lab2DataSet";
            this.bD_Lab2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            // 
            // план_приемаBindingSource
            // 
            this.план_приемаBindingSource.DataMember = "План_приема";
            this.план_приемаBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // план_приемаTableAdapter
            // 
            this.план_приемаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер специальности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Факультет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Форма обучения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во мест";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Подано заявлений";
            // 
            // NomSpec_Combobox
            // 
            this.NomSpec_Combobox.DataSource = this.специальностиBindingSource;
            this.NomSpec_Combobox.DisplayMember = "Номер_специальности";
            this.NomSpec_Combobox.FormattingEnabled = true;
            this.NomSpec_Combobox.Location = new System.Drawing.Point(149, 35);
            this.NomSpec_Combobox.Name = "NomSpec_Combobox";
            this.NomSpec_Combobox.Size = new System.Drawing.Size(290, 21);
            this.NomSpec_Combobox.TabIndex = 6;
            this.NomSpec_Combobox.ValueMember = "ID_специальности";
            this.NomSpec_Combobox.SelectedIndexChanged += new System.EventHandler(this.NomSpec_Combobox_SelectedIndexChanged);
            // 
            // Kol_vo_text
            // 
            this.Kol_vo_text.Location = new System.Drawing.Point(149, 113);
            this.Kol_vo_text.Name = "Kol_vo_text";
            this.Kol_vo_text.Size = new System.Drawing.Size(290, 20);
            this.Kol_vo_text.TabIndex = 8;
            this.Kol_vo_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kol_vo_text_KeyPress);
            // 
            // Podano_text
            // 
            this.Podano_text.Location = new System.Drawing.Point(149, 139);
            this.Podano_text.Name = "Podano_text";
            this.Podano_text.Size = new System.Drawing.Size(290, 20);
            this.Podano_text.TabIndex = 9;
            this.Podano_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Podano_text_KeyPress);
            // 
            // DobPlan
            // 
            this.DobPlan.Location = new System.Drawing.Point(364, 165);
            this.DobPlan.Name = "DobPlan";
            this.DobPlan.Size = new System.Drawing.Size(75, 23);
            this.DobPlan.TabIndex = 10;
            this.DobPlan.Text = "Добавить";
            this.DobPlan.UseVisualStyleBackColor = true;
            this.DobPlan.Click += new System.EventHandler(this.DobPlan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Название специальности";
            // 
            // FormaObychCombobox
            // 
            this.FormaObychCombobox.FormattingEnabled = true;
            this.FormaObychCombobox.Items.AddRange(new object[] {
            "Очная",
            "Заочная"});
            this.FormaObychCombobox.Location = new System.Drawing.Point(149, 87);
            this.FormaObychCombobox.Name = "FormaObychCombobox";
            this.FormaObychCombobox.Size = new System.Drawing.Size(290, 21);
            this.FormaObychCombobox.TabIndex = 13;
            // 
            // FacultetCombobox
            // 
            this.FacultetCombobox.DataSource = this.viewFAKBindingSource;
            this.FacultetCombobox.DisplayMember = "FAK";
            this.FacultetCombobox.FormattingEnabled = true;
            this.FacultetCombobox.Location = new System.Drawing.Point(149, 61);
            this.FacultetCombobox.Name = "FacultetCombobox";
            this.FacultetCombobox.Size = new System.Drawing.Size(290, 21);
            this.FacultetCombobox.TabIndex = 14;
            this.FacultetCombobox.ValueMember = "FAK";
            // 
            // NazvSpecCombobox
            // 
            this.NazvSpecCombobox.DataSource = this.специальностиBindingSource;
            this.NazvSpecCombobox.DisplayMember = "Название_специальности";
            this.NazvSpecCombobox.FormattingEnabled = true;
            this.NazvSpecCombobox.Location = new System.Drawing.Point(149, 8);
            this.NazvSpecCombobox.Name = "NazvSpecCombobox";
            this.NazvSpecCombobox.Size = new System.Drawing.Size(290, 21);
            this.NazvSpecCombobox.TabIndex = 15;
            this.NazvSpecCombobox.ValueMember = "Название_специальности";
            // 
            // viewFAKBindingSource
            // 
            this.viewFAKBindingSource.DataMember = "View_FAK";
            this.viewFAKBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // view_FAKTableAdapter
            // 
            this.view_FAKTableAdapter.ClearBeforeFill = true;
            // 
            // FormDobPlanPriema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 193);
            this.Controls.Add(this.NazvSpecCombobox);
            this.Controls.Add(this.FacultetCombobox);
            this.Controls.Add(this.FormaObychCombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DobPlan);
            this.Controls.Add(this.Podano_text);
            this.Controls.Add(this.Kol_vo_text);
            this.Controls.Add(this.NomSpec_Combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDobPlanPriema";
            this.Text = "Добавление записи в таблицу План приема";
            this.Load += new System.EventHandler(this.FormDobPlanPriema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.план_приемаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFAKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_Lab2DataSet bD_Lab2DataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private BD_Lab2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource план_приемаBindingSource;
        private BD_Lab2DataSetTableAdapters.План_приемаTableAdapter план_приемаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NomSpec_Combobox;
        private System.Windows.Forms.TextBox Kol_vo_text;
        private System.Windows.Forms.TextBox Podano_text;
        private System.Windows.Forms.Button DobPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FormaObychCombobox;
        private System.Windows.Forms.ComboBox FacultetCombobox;
        private System.Windows.Forms.ComboBox NazvSpecCombobox;
        private System.Windows.Forms.BindingSource viewFAKBindingSource;
        private BD_Lab2DataSetTableAdapters.View_FAKTableAdapter view_FAKTableAdapter;
    }
}