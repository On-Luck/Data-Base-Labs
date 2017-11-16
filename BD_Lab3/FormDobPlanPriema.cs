using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Lab3
{
    public partial class FormDobPlanPriema : Form
    {
        public FormDobPlanPriema(Form frmParent)
        {
            InitializeComponent();
        }

        private void специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Lab2DataSet);

        }

        private void FormDobPlanPriema_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.View_FAK". При необходимости она может быть перемещена или удалена.
            this.view_FAKTableAdapter.Fill(this.bD_Lab2DataSet.View_FAK);
            this.план_приемаTableAdapter.Fill(this.bD_Lab2DataSet.План_приема);
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
            //выводим название специальности в поле, дабы было прозе добавлять данные
            специальностиBindingSource.MoveFirst();
            специальностиBindingSource.Find("ID_специальности", NomSpec_Combobox.SelectedValue.ToString());    
        }

        private void DobPlan_Click(object sender, EventArgs e)
        {
            this.план_приемаTableAdapter.InsertQuery(FacultetCombobox.Text, FormaObychCombobox.Text, Convert.ToInt32(Kol_vo_text.Text), Convert.ToInt32(Podano_text.Text),Convert.ToInt32(NomSpec_Combobox.SelectedValue));
            this.Close();
        }

        private void NomSpec_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Kol_vo_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void Podano_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }
    }
    
}