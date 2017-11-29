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
    public partial class Sprav_spec : Form
    {
        public Sprav_spec(Form frm1)
        {
            InitializeComponent();
        }

        string IDSpec, NazvSpec, NomerSpec, NazvKaf;
        private void Sprav_spec_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
        }

        private void SpravDob_Click(object sender, EventArgs e)
        {
            FormDobSpravSpec frm3 = new FormDobSpravSpec(this);
            frm3.ShowDialog();
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
        }

        private void SpravIzm_Click(object sender, EventArgs e)
        {
            IDSpec = ((DataRowView)специальностиBindingSource.Current).Row["ID_специальности"].ToString();
            NomerSpec = ((DataRowView)специальностиBindingSource.Current).Row["Номер_специальности"].ToString();
            NazvSpec = ((DataRowView)специальностиBindingSource.Current).Row["Название_специальности"].ToString();
            NazvKaf = ((DataRowView)специальностиBindingSource.Current).Row["Название_кафедры"].ToString();

            FormIzmSpravSpec fr4 = new FormIzmSpravSpec(this, Convert.ToInt32(IDSpec), NomerSpec, NazvSpec, NazvKaf);
            fr4.ShowDialog();
            
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);

        }
    }
}
