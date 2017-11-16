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
    public partial class FormIzmSpravSpec : Form
    {
        int CurrentIDSpec = 0;
        string CurrentNomerSpec, CurrentNazvSpec;

        public FormIzmSpravSpec(Form ParentForm, int acur, string bcur, string ccur, string dcur)
        {
            InitializeComponent();
            CurrentIDSpec = acur;
            NewNomerSpec.Text = CurrentNomerSpec = bcur;
            NewNazvSpec.Text = CurrentNazvSpec = ccur;
            //NewNazvKaf.Text = dcur;
            KafcomboBox.Text = dcur;
        }

        private void FormIzmSpravSpec_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet1.View_Кафедры". При необходимости она может быть перемещена или удалена.
            this.view_КафедрыTableAdapter.Fill(this.bD_Lab2DataSet1.View_Кафедры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);

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

            foreach (string str in ast.Distinct())
            {
                if (str != "")
                    KafcomboBox.Items.Add(str); // добавляем данные без повторений
            }
            KafcomboBox.Sorted = true; //сортируем данные по алфавиту*/
            
        }

        private void IzmSpravSpec_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool finding = false;
            if (NewNomerSpec.Text != "" && NewNazvSpec.Text != "" ) //&& NewNazvKaf.Text != "")
            {
                специальностиBindingSource.Position = 0;
                
                while (специальностиBindingSource.Count != n)
                {   //Если текущая строка в биндингсурсе имеет ID отличный от того, по которому мы хотим изменить данные, и если номер специальности в текущей строке биндингсурса равен введенному номеру специальности, то редактирование запретить (так как такой номер специальности уже существует). Аналогично с названием специальности. 
                    if ((Convert.ToInt32(((DataRowView)специальностиBindingSource.Current).Row["ID_специальности"].ToString()) != CurrentIDSpec && ((DataRowView)специальностиBindingSource.Current).Row["Номер_специальности"].ToString() == NewNomerSpec.Text) || (Convert.ToInt32(((DataRowView)специальностиBindingSource.Current).Row["ID_специальности"].ToString()) != CurrentIDSpec && ((DataRowView)специальностиBindingSource.Current).Row["Название_специальности"].ToString() == NewNazvSpec.Text))
                    {
                        finding = true;
                        break;
                    }
                    специальностиBindingSource.MoveNext();
                    n++;
                }
            }
            else MessageBox.Show("Недопустимо оставлять поля пустыми", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!finding)
            {
                специальностиTableAdapter.UpdateQuery(NewNomerSpec.Text, NewNazvSpec.Text, KafcomboBox.Text, CurrentIDSpec);
                MessageBox.Show("Изменения внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Специальность с таким названием или номером уже существует.\nПроверьте введенные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
