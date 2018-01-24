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
    public partial class Plan_priema : Form
    {
        public Plan_priema()
        {
            InitializeComponent();
        }

        string filtrstring;
        int check_box_checked = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_Lab2DataSet.План_приема". При необходимости она может быть перемещена или удалена.
            this.план_приемаTableAdapter.Fill(this.bD_Lab2DataSet.План_приема);
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e) //обновление данных в таблице
        {
            планприемаBindingSource.RemoveFilter();
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
            this.план_приемаTableAdapter.Fill(this.bD_Lab2DataSet.План_приема);
        }

        private void Search_Tochnii_Click(object sender, EventArgs e)  //точный поиск
        {
            //точный поиск по номеру записи в таблице "План_приема". Возвращает либо номер строки, 
            //либо "-1" если ничего не найдено
            bD_Lab2DataSet.CaseSensitive = false;
            
            int indx = планприемаBindingSource.Find("Номер_специальности",SearchTochnii.Text);
            if (indx >= 0)
            {
                планприемаBindingSource.Position = indx;
            }
            else 
            {
                MessageBox.Show("Информация не найдена","Поиск",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Search_Pribl_Click(object sender, EventArgs e) //приближенный поиск
        {
            планприемаBindingSource.Sort = "Факультет";   
            int indx = планприемаBindingSource.Find("Факультет", SearchPribl.Text);
            if (indx >= 0)
            {
                планприемаBindingSource.Position = indx;
            }
            else
            {
                MessageBox.Show("Информация не найдена", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_Proizvol_Click(object sender, EventArgs e) //произвольный поиск
        {            
            int n = 0;
            bool finding = false;
            планприемаBindingSource.Position = 0;
            if (SearchProizv.Text != "" || SearchProizv1.Text != "")
            {
                while (планприемаBindingSource.Count != n)
                {   //если первое поле заполнено и найдено совпадение в текущей строке
                    if (SearchProizv.Text != "" && ((DataRowView)планприемаBindingSource.Current).Row["Кол_мест"].ToString() == SearchProizv.Text)
                    {
                        //если второе поле заполнено и строка соответствует введенным данным, то прекратить поиск
                        if (SearchProizv1.Text != "" && ((DataRowView)планприемаBindingSource.Current).Row["Подано_заявлений"].ToString() == SearchProizv1.Text)
                        {
                            finding = true;
                            break;
                        }
                        else if (SearchProizv1.Text == "") //если второе поле пустое, прекратить поиск
                        {
                            finding = true;
                            break;
                        }
                    }
                    else if (SearchProizv.Text == "" && SearchProizv1.Text != "" && ((DataRowView)планприемаBindingSource.Current).Row["Подано_заявлений"].ToString() == SearchProizv1.Text)
                    {
                        finding = true;
                        break;
                    }
                    планприемаBindingSource.MoveNext();
                    n++;
                }
            }
            else MessageBox.Show("Поля оставлены пустыми! Введите данные","ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!finding)
                MessageBox.Show("Нет записей, удовлетворяющих критериям поиска", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Filtr_sbros_Click(object sender, EventArgs e) //фильтрация
        {
            планприемаBindingSource.RemoveFilter();
            filtrstring = "";
            check_box_checked = 0;

            foreach (Control gb in tableLayoutPanel3.Controls)
            {
               if (gb is GroupBox)
                foreach (Control ch in ((GroupBox)gb).Controls)
                {
                    if (ch is CheckBox)
                        if (((CheckBox)ch).Checked)
                        {
                            switch (ch.Name)
                            {
                                case "TochniiCheck":
                                    filtrstring += "Номер_специальности = '" + FiltrNomer_spec.Text + "'";
                                    check_box_checked++;
                                    break;
                                case "PriblCheck":
                                    if (check_box_checked != 0)
                                        filtrstring += "AND " + String.Format("Convert(Кол_мест, 'System.String') LIKE '{0}%' ", FiltrKol_mest.Text);
                                    else filtrstring += String.Format("Convert(Кол_мест, 'System.String') LIKE '{0}%' ", FiltrKol_mest.Text);
                                    check_box_checked++;
                                    break;
                                case "IntervCheck":
                                    if (check_box_checked != 0)
                                    {
                                        filtrstring += " AND ";
                                    }
                                    if (Filtr_Ot.Text != "")
                                    {
                                        filtrstring += String.Format("Подано_заявлений >= {0} ", Filtr_Ot.Text);
                                        if (Filtr_do.Text != "")
                                            filtrstring += String.Format("AND Подано_заявлений <= {0}", Filtr_do.Text);
                                    }
                                    else if (Filtr_do.Text != "")
                                        filtrstring += filtrstring += String.Format("Подано_заявлений <= {0}", Filtr_do.Text);
                                    break;
                                    /*if (check_box_checked !=0 && Filtr_Ot.Text !=""  && Filtr_do.Text != "")
                                        filtrstring += "AND " + String.Format("Подано_заявлений >= '{0}' and Подано_заявлений <='{1}'", Filtr_Ot.Text, Filtr_do.Text);
                                    else if (Filtr_Ot.Text != "" && Filtr_do.Text != "") 
                                        filtrstring += String.Format("Подано_заявлений >= '{0}' and Подано_заявлений <='{1}'", Filtr_Ot.Text, Filtr_do.Text);
                                    else if ()
                                    break;*/
                            }
                        }
                }
            }
            планприемаBindingSource.Filter = filtrstring;
        }

        private void Filtr_Clear_filtr_Click(object sender, EventArgs e) 
        {//очистка фильтра
            планприемаBindingSource.RemoveFilter();
            Filtr_do.Clear();
            Filtr_Ot.Clear();
            FiltrNomer_spec.Clear();
            FiltrKol_mest.Clear();
        }

        private void справочникСпециальностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sprav_spec frm2 = new Sprav_spec(this);
            frm2.ShowDialog();
        }

        private void GroupIzmen_Click(object sender, EventArgs e) //групповое изменение
        {
            планприемаBindingSource.MoveLast(); //читаем последнее значение ID и записываем его в переменную izmpo
            int izms = -1, izmpo = Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString());
            //-----------------------------
            if (GroupIzmS.Text !="")
                izms = Convert.ToInt32(GroupIzmS.Text);
            if (GroupIzmPo.Text !="")
                izmpo = Convert.ToInt32(GroupIzmPo.Text);
            //-----------------------------
                int n = 0;
                планприемаBindingSource.Position = 0;

                while (планприемаBindingSource.Count != n)
                {  
                    if (Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString()) >= izms && Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString()) <= izmpo)
                    {
                        if (ComboBoxGroupIzm.Text !="Кол-во мест")
                            ((DataRowView)планприемаBindingSource.Current).Row[ComboBoxGroupIzm.Text.Replace(' ','_')] = NewZnachGroupIzm.Text;
                        else ((DataRowView)планприемаBindingSource.Current).Row["Кол_мест"] = NewZnachGroupIzm.Text;
                    }
                    n++;
                    планприемаBindingSource.MoveNext();
                }
        }

        private void GroupDel_Click(object sender, EventArgs e) //Групповое удаление
        {
            // формируем условие для удаления
            планприемаBindingSource.MoveLast(); //читаем последнее значение ID и записываем его в переменную delpo
            int dels = -1, delpo = Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString());
            if (GroupDelS.Text != "")
                dels = Convert.ToInt32(GroupDelS.Text);
            if (GroupDelPo.Text != "")
                delpo = Convert.ToInt32(GroupDelPo.Text);
            //----------------удаляем-----------------
            int n = 0;
            планприемаBindingSource.Position = 0;

                while (планприемаBindingSource.Count != n)
                {
                    if (Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString()) >= dels && Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString()) <= delpo)
                    {
                        планприемаBindingSource.RemoveCurrent();
                        n = 0;
                        планприемаBindingSource.MovePrevious();
                    }
                    else
                    {
                        n++;
                        планприемаBindingSource.MoveNext();
                    }
                }
            
        }

        private void toolStripDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку навсегда?", "Возник вопросик", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.план_приемаTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)планприемаBindingSource.Current).Row["ID_записи"].ToString()));
                this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
                this.план_приемаTableAdapter.Fill(this.bD_Lab2DataSet.План_приема);
            }
        }

        private void toolStripAddItem_Click(object sender, EventArgs e)
        {
            FormDobPlanPriema frmdob = new FormDobPlanPriema(this);
            frmdob.ShowDialog();
            this.специальностиTableAdapter.Fill(this.bD_Lab2DataSet.Специальности);
            this.план_приемаTableAdapter.Fill(this.bD_Lab2DataSet.План_приема);
        }

        private void SearchProizv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void SearchProizv1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void Filtr_Ot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void Filtr_do_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void GroupDelS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void GroupDelPo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void отчетПоПлануПриемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frmr = new FormReport(this);
            frmr.bspp = планприемаBindingSource;
            frmr.bss = специальностиBindingSource;
            frmr.ShowDialog();
        }
    }
}
