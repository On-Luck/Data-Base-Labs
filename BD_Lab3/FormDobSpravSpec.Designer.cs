namespace BD_Lab3
{
    partial class FormDobSpravSpec
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
            this.DobSprSpec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DobNomerSpec = new System.Windows.Forms.TextBox();
            this.DobNazvSpec = new System.Windows.Forms.TextBox();
            this.bD_Lab2DataSet = new BD_Lab3.BD_Lab2DataSet();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager();
            this.KafcomboBox = new System.Windows.Forms.ComboBox();
            this.специальностиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewКафедрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_КафедрыTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.View_КафедрыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewКафедрыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DobSprSpec
            // 
            this.DobSprSpec.Location = new System.Drawing.Point(332, 93);
            this.DobSprSpec.Name = "DobSprSpec";
            this.DobSprSpec.Size = new System.Drawing.Size(75, 23);
            this.DobSprSpec.TabIndex = 0;
            this.DobSprSpec.Text = "Добавить";
            this.DobSprSpec.UseVisualStyleBackColor = true;
            this.DobSprSpec.Click += new System.EventHandler(this.DobSprSpec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер специальности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название специальности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название кафедры";
            // 
            // DobNomerSpec
            // 
            this.DobNomerSpec.Location = new System.Drawing.Point(163, 6);
            this.DobNomerSpec.Name = "DobNomerSpec";
            this.DobNomerSpec.Size = new System.Drawing.Size(244, 20);
            this.DobNomerSpec.TabIndex = 4;
            // 
            // DobNazvSpec
            // 
            this.DobNazvSpec.Location = new System.Drawing.Point(163, 32);
            this.DobNazvSpec.Name = "DobNazvSpec";
            this.DobNazvSpec.Size = new System.Drawing.Size(244, 20);
            this.DobNazvSpec.TabIndex = 5;
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
            // KafcomboBox
            // 
            this.KafcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KafcomboBox.DataSource = this.viewКафедрыBindingSource;
            this.KafcomboBox.DisplayMember = "name";
            this.KafcomboBox.FormattingEnabled = true;
            this.KafcomboBox.Location = new System.Drawing.Point(163, 58);
            this.KafcomboBox.Name = "KafcomboBox";
            this.KafcomboBox.Size = new System.Drawing.Size(244, 21);
            this.KafcomboBox.TabIndex = 7;
            this.KafcomboBox.ValueMember = "name";
            // 
            // специальностиBindingSource1
            // 
            this.специальностиBindingSource1.DataMember = "Специальности";
            this.специальностиBindingSource1.DataSource = this.bD_Lab2DataSet;
            // 
            // viewКафедрыBindingSource
            // 
            this.viewКафедрыBindingSource.DataMember = "View_Кафедры";
            this.viewКафедрыBindingSource.DataSource = this.bD_Lab2DataSet;
            // 
            // view_КафедрыTableAdapter
            // 
            this.view_КафедрыTableAdapter.ClearBeforeFill = true;
            // 
            // FormDobSpravSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 123);
            this.Controls.Add(this.KafcomboBox);
            this.Controls.Add(this.DobNazvSpec);
            this.Controls.Add(this.DobNomerSpec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DobSprSpec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDobSpravSpec";
            this.Text = "Добавление записей в справочник специальностей";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDobSpravSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewКафедрыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DobSprSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DobNomerSpec;
        private System.Windows.Forms.TextBox DobNazvSpec;
        private BD_Lab2DataSet bD_Lab2DataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private BD_Lab2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox KafcomboBox;
        private System.Windows.Forms.BindingSource специальностиBindingSource1;
        private System.Windows.Forms.BindingSource viewКафедрыBindingSource;
        private BD_Lab2DataSetTableAdapters.View_КафедрыTableAdapter view_КафедрыTableAdapter;
    }
}