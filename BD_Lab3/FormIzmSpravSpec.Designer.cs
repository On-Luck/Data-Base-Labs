namespace BD_Lab3
{
    partial class FormIzmSpravSpec
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewNomerSpec = new System.Windows.Forms.TextBox();
            this.NewNazvSpec = new System.Windows.Forms.TextBox();
            this.IzmSpravSpec = new System.Windows.Forms.Button();
            this.KafcomboBox = new System.Windows.Forms.ComboBox();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Lab2DataSet = new BD_Lab3.BD_Lab2DataSet();
            this.специальностиTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager();
            this.bD_Lab2DataSet1 = new BD_Lab3.BD_Lab2DataSet();
            this.viewКафедрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_КафедрыTableAdapter = new BD_Lab3.BD_Lab2DataSetTableAdapters.View_КафедрыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewКафедрыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер специальности";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название специальности";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название кафедры";
            // 
            // NewNomerSpec
            // 
            this.NewNomerSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNomerSpec.Location = new System.Drawing.Point(159, 21);
            this.NewNomerSpec.Name = "NewNomerSpec";
            this.NewNomerSpec.Size = new System.Drawing.Size(252, 20);
            this.NewNomerSpec.TabIndex = 3;
            // 
            // NewNazvSpec
            // 
            this.NewNazvSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNazvSpec.Location = new System.Drawing.Point(159, 47);
            this.NewNazvSpec.Name = "NewNazvSpec";
            this.NewNazvSpec.Size = new System.Drawing.Size(252, 20);
            this.NewNazvSpec.TabIndex = 4;
            // 
            // IzmSpravSpec
            // 
            this.IzmSpravSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IzmSpravSpec.Location = new System.Drawing.Point(302, 99);
            this.IzmSpravSpec.Name = "IzmSpravSpec";
            this.IzmSpravSpec.Size = new System.Drawing.Size(109, 23);
            this.IzmSpravSpec.TabIndex = 6;
            this.IzmSpravSpec.Text = "Изменить запись";
            this.IzmSpravSpec.UseVisualStyleBackColor = true;
            this.IzmSpravSpec.Click += new System.EventHandler(this.IzmSpravSpec_Click);
            // 
            // KafcomboBox
            // 
            this.KafcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KafcomboBox.DataSource = this.viewКафедрыBindingSource;
            this.KafcomboBox.DisplayMember = "name";
            this.KafcomboBox.FormattingEnabled = true;
            this.KafcomboBox.Location = new System.Drawing.Point(159, 73);
            this.KafcomboBox.Name = "KafcomboBox";
            this.KafcomboBox.Size = new System.Drawing.Size(252, 21);
            this.KafcomboBox.TabIndex = 8;
            this.KafcomboBox.ValueMember = "name";
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
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BD_Lab3.BD_Lab2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            // 
            // bD_Lab2DataSet1
            // 
            this.bD_Lab2DataSet1.DataSetName = "BD_Lab2DataSet";
            this.bD_Lab2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewКафедрыBindingSource
            // 
            this.viewКафедрыBindingSource.DataMember = "View_Кафедры";
            this.viewКафедрыBindingSource.DataSource = this.bD_Lab2DataSet1;
            // 
            // view_КафедрыTableAdapter
            // 
            this.view_КафедрыTableAdapter.ClearBeforeFill = true;
            // 
            // FormIzmSpravSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 140);
            this.Controls.Add(this.KafcomboBox);
            this.Controls.Add(this.IzmSpravSpec);
            this.Controls.Add(this.NewNazvSpec);
            this.Controls.Add(this.NewNomerSpec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIzmSpravSpec";
            this.Text = "Изменение записи в справочнике специальностей";
            this.Load += new System.EventHandler(this.FormIzmSpravSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Lab2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewКафедрыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewNomerSpec;
        private System.Windows.Forms.TextBox NewNazvSpec;
        private System.Windows.Forms.Button IzmSpravSpec;
        private BD_Lab2DataSet bD_Lab2DataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private BD_Lab2DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private BD_Lab2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox KafcomboBox;
        private BD_Lab2DataSet bD_Lab2DataSet1;
        private System.Windows.Forms.BindingSource viewКафедрыBindingSource;
        private BD_Lab2DataSetTableAdapters.View_КафедрыTableAdapter view_КафедрыTableAdapter;
    }
}