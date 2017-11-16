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
    public partial class FormDobSpravSpec : Form
    {
        public FormDobSpravSpec(Form frmParent)
        {
            InitializeComponent();
        }

        private void DobSprSpec_Click(object sender, EventArgs e) // добавление записей в таблицу специальностей
        {
            
            if (DobNomerSpec.Text != "" && DobNazvSpec.Text != "")
                if ((специальностиBindingSource.Find("Номер_специальности", DobNomerSpec.Text) < 0) && (специальностиBindingSource.Find("Название_специальности", DobNazvSpec.Text) < 0))
                {
                    специальностиTableAdapter.InsertQuery(DobNomerSpec.Text, DobNazvSpec.Text, KafcomboBox.Text);
                    this.Close();
                }
                else MessageBox.Show("Специальность с таким названием или номером уже существует","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Необходимо заполнить все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void FormDobSpravSpec_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.View_Кафедры". При необходимости она может быть перемещена или удалена.
            this.view_КафедрыTableAdapter.Fill(this.bD_Lab2DataSet.View_Кафедры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
           
            //Делаем комбобокс для выбора кафедры
            /*int n = 0; //просто переменная для цикла
            string[] ast = new string[специальностиBindingSource.Count]; //массив для получения всех названий кафедр
            специальностиBindingSource.MoveFirst(); 

            while (специальностиBindingSource.Count != n)
            {
                ast[n] = ((DataRowView)специальностиBindingSource.Current).Row["Название_кафедры"].ToString();
                специальностиBindingSource.MoveNext();
                n++;
            }
            KafcomboBox.Items.Clear(); // очищаем набор данных в комбобокс

            foreach(string str in ast.Distinct())
            {
                if (str != "")
                    KafcomboBox.Items.Add(str); // добавляем данные без повторений
            }
            KafcomboBox.Sorted = true; //сортируем данные по алфавиту*/
        }


    }
}
