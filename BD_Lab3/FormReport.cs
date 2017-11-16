using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BD_Lab3
{
    public partial class FormReport : Form
    {
        public FormReport(Form frmParent)
        {
            InitializeComponent();
        }

       public  BindingSource bspp,bss; //просто не хочу подключать сюда датасет и биндинг сурсы с него, 
        //поэтому просто передаю биндинги из основной формы сюда
       double[,] masd;
       double vsmaxkon = 0, vspodza = 0, vskolspec = 0; // максимальный конкрус, всего подан заявлений, всего специальностей
       int lastpos;

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.view_FAKTableAdapter.Fill(this.bD_Lab2DataSet.View_FAK); //представление для получения списка факультетов

            buttonCreateOtch.Text = "Создать";
            //reportViewerOdin.Enabled = false;
            this.reportViewerOdin.RefreshReport();

            /*
             * Структура отчета:
             *  Факультет 
             *   0--Количество специальностей
             *   1----Количество поданых заявлений
             *   2------Максимальный конкурс
             *   
             * В массиве сразу будут только последние три колонки
             * 
             */
            masd = new double[view_FAKBindingSource.Count,3]; // double потому что будем считать конкурс = чел/место. Длина массива зависит от количества факультетов
        }

        private void buttonCreateOtch_Click(object sender, EventArgs e)
        {
            //потому что не хочу писать кучу ифов, да и решил вспомнить как работает try-catch
            try
            {
                //проверяем вводимые данные
                if ((comboBoxFrmOb.Text == "") || (TextMaxKon.Text == "") || Convert.ToInt32(TextMaxKon.Text) <0) throw new ArgumentNullException();
                //Формируем таблицу на основе введенных данных
                lastpos = bspp.Position;
                bspp.MoveFirst();
                
                DataRow newR;
                
                vsmaxkon = 0; 
                vspodza = 0; 
                vskolspec = 0;
                
                int n = 0;
                double y = 0;
                for (int i = 0; i < view_FAKBindingSource.Count - 1; i++)
                {
                    masd[i, 0] = 0;
                    masd[i, 1] = 0;
                    masd[i, 2] = 0;
                }
                view_FAKBindingSource.MoveFirst();
                //если в базе уже есть данные, то удаляем их:
                if (bD_Lab2DataSet.Otchet.Count != 0)
                {
                    bD_Lab2DataSet.Otchet.Clear();
                }
                // Формируем таблицу с данными для составления отчета
                while (view_FAKBindingSource.Count != n)
                {
                    bspp.Filter = "Факультет = '" + ((DataRowView)view_FAKBindingSource.Current).Row[0].ToString() + "' AND Форма_обучения = '"+comboBoxFrmOb.Text+"'"; //делаем подсчеты по факультетам и форме обучения

                    newR = bD_Lab2DataSet.Otchet.NewRow();
                    newR["Num"] = n + 1;
                    newR["Факультет"] = ((DataRowView)view_FAKBindingSource.Current).Row[0].ToString();
                    newR["Кол_спец"] = 0;
                    newR["Кол_под"] = 0;
                    newR["Макс_кон"] = 0;
                    
                    bspp.MoveFirst();
                    for (int i = 0;  i < bspp.Count; i++)
			        {
                        y = Math.Round((Convert.ToDouble(((DataRowView)bspp.Current).Row["Подано_заявлений"].ToString()) / Convert.ToDouble(((DataRowView)bspp.Current).Row["Кол_мест"].ToString())), 2);
                        if (y < Convert.ToInt32(TextMaxKon.Text)) //конкурс менее заданного
                        {
                            if (y > Convert.ToInt32(newR["Макс_кон"]))
                                newR["Макс_кон"] = y;
                            newR["Кол_спец"] = Convert.ToInt32(newR["Кол_спец"]) + 1;
                            newR["Кол_под"] = Convert.ToInt32(newR["Кол_под"]) + Convert.ToInt32(((DataRowView)bspp.Current).Row["Подано_заявлений"].ToString());
                            //формируем данные для подведения итога
                            if (y > vsmaxkon)
                                vsmaxkon = y;
                        }
                        
                        bspp.MoveNext();
			        }
                    vskolspec += Convert.ToInt32(newR["Кол_спец"]);
                    vspodza += Convert.ToInt32(newR["Кол_под"]);
                    bD_Lab2DataSet.Otchet.Rows.Add(newR);
                    //переходим на следующий факультет
                    view_FAKBindingSource.MoveNext();
                    n++;
                }
                //передаем форму обучения в отчет
                ReportParameter p1 = new ReportParameter("ReportParameterFrmObych", comboBoxFrmOb.Text);
                ReportParameter p2 = new ReportParameter("ReportParameterVsegoKolSpec", vskolspec.ToString());
                ReportParameter p3 = new ReportParameter("ReportParameterVsegoKolPod", vspodza.ToString());
                ReportParameter p4= new ReportParameter("ReportParameterMaxKon", vsmaxkon.ToString());
                reportViewerOdin.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p1, p2, p3, p4 });

                //немного изменений пользовательского интерфейса для удобства пользования

                buttonCreateOtch.Text = "Изменить";
                //this.reportViewerOdin.Enabled = true;
                this.reportViewerOdin.RefreshReport();
                
                bspp.Filter = "";
                bspp.Position = lastpos;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(this,"Проверьте введенные данные","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch 
            {
                MessageBox.Show(this,"Неизвестная ошибка","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextMaxKon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void comboBoxFrmOb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
/*while (bspp.Count != n)
              {
                  if (((DataRowView)bspp.Current).Row["Форма_обучения"].ToString() != comboBoxFrmOb.Text)
                  {
                      bspp.MoveNext();
                      n++;
                      continue;
                  }//Сразу переходим на следующий круг, ибо нефиг хуйней страдать, да кучу кода разводить

                  view_FAKBindingSource.MoveFirst();
                  for (int i = 0; i < view_FAKBindingSource.Count - 1; i++)
                  {
                      //какое-то сложное условие, но мне похуй
                      if (((DataRowView)bspp.Current).Row["Факультет"].ToString() == ((DataRowView)view_FAKBindingSource.Current).Row["FAK"].ToString())
                      {
                          masd[i, 0]++; //кол-во специальностей увеличиваем на 1
                          masd[i, 1] += Convert.ToInt32(((DataRowView)bspp.Current).Row["Подано_заявлений"].ToString());//Суммируем кол-во поданых заявлений
                          y = (Convert.ToDouble(((DataRowView)bspp.Current).Row["Подано_заявлений"].ToString()) / Convert.ToDouble(((DataRowView)bspp.Current).Row["Кол_мест"].ToString()));
                          if (y > masd[i, 2])
                              masd[i, 2] = y;
                          break; //прерываем цикл
                      }
                      else
                          view_FAKBindingSource.MoveNext();
                  }
                  bspp.MoveNext();
                  n++;
              }
              */
