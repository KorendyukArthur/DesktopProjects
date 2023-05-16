using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRYPK
{
    public partial class DataA : Form
    {
        public DataA()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";

            ;

            label15.Text = "Колличество договоров по месяцам оформленным в этом году" + "\n";

            label1.Text = "1 месяц:" + "\n";
            List<string> idfamild1 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-01-01 01:00:00' and '2021-03-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild1.Count; i++)
            {
                label1.Text += idfamild1[i] + "\n";
            }


            label2.Text = "2 месяц:" + "\n";
            List<string> idfamild2 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-02-01 01:00:00' and '2021-02-28 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild2.Count; i++)
            {
                label2.Text += idfamild2[i] + "\n";
            }



            label3.Text = "3 месяц:" + "\n";
            List<string> idfamild3 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-03-01 01:00:00' and '2021-03-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild3.Count; i++)
            {
                label3.Text += idfamild3[i] + "\n";
            }


            label4.Text = "4 месяц:" + "\n";
            List<string> idfamild4 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-04-01 01:00:00' and '2021-04-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild4.Count; i++)
            {
                label4.Text += idfamild4[i] + "\n";
            }


            label5.Text = "5 месяц:" + "\n";
            List<string> idfamild5 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-05-01 01:00:00' and '2021-05-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild5.Count; i++)
            {
                label5.Text += idfamild5[i] + "\n";
            }


            label6.Text = "6 месяц:" + "\n";
            List<string> idfamild6 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-06-01 01:00:00' and '2021-06-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild6.Count; i++)
            {
                label6.Text += idfamild6[i] + "\n";
            }


            label7.Text = "7 месяц:" + "\n";
            List<string> idfamild7 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-07-01 01:00:00' and '2021-07-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild7.Count; i++)
            {
                label7.Text += idfamild7[i] + "\n";
            }


            label8.Text = "8 месяц:" + "\n";
            List<string> idfamild8 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-08-01 01:00:00' and '2021-08-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild8.Count; i++)
            {
                label8.Text += idfamild8[i] + "\n";
            }

            label9.Text = "9 месяц:" + "\n";
            List<string> idfamild9 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-09-01 01:00:00' and '2021-09-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild9.Count; i++)
            {
                label9.Text += idfamild9[i] + "\n";
            }


            label10.Text = "10 месяц:" + "\n";
            List<string> idfamild10 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-10-01 01:00:00' and '2021-10-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild10.Count; i++)
            {
                label10.Text += idfamild10[i] + "\n";
            }


            label11.Text = "11 месяц:" + "\n";
            List<string> idfamild11 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-11-01 01:00:00' and '2021-11-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild11.Count; i++)
            {
                label11.Text += idfamild11[i] + "\n";
            }


            label12.Text = "12 месяц:" + "\n";
            List<string> idfamild12 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-12-01 01:00:00' and '2021-12-31 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamild12.Count; i++)
            {
                label12.Text += idfamild12[i] + "\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";



            label21.Text = "Колличество договоров по кварталам оформленным в этом году" + "\n";

            label17.Text = "1 квартал:" + "\n";
            List<string> idfamil3 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-01-01 01:00:00' and '2021-03-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil3.Count; i++)
            {
                label17.Text += idfamil3[i] + "\n";
            }


            label18.Text = "2 квартал:" + "\n";
            List<string> idfamil4 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-03-01 01:00:00' and '2021-06-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil4.Count; i++)
            {
                label18.Text += idfamil4[i] + "\n";
            }

            label19.Text = "3 квартал:" + "\n";
            List<string> idfamil5 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-06-01 01:00:00' and '2021-09-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil5.Count; i++)
            {
                label19.Text += idfamil5[i] + "\n";
            }


            label20.Text = "4 квартал:" + "\n";
            List<string> idfamil6 = SQLRequests.SelectRequest(
          "Select count (КодДоговора) From Договор where ДатаОформления between '2021-09-01 01:00:00' and '2021-12-30 01:00:00'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil6.Count; i++)
            {
                label20.Text += idfamil6[i] + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";
            label30.Text = " "; label31.Text = " "; label32.Text = " ";
            label33.Text = " ";
            label22.Text = " "; label23.Text = " "; label24.Text = " ";
            label25.Text = " ";



            label26.Text = "Статистика клиентов по возрасту" + "\n";

            label30.Text = "Клиентов до 20 лет " + "\n";
            List<string> idfamil = SQLRequests.SelectRequest(
          "SELECT COUNT (ИКлиент.Имя) FROM  ИКлиент WHERE Возраст <= 20",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil.Count; i++)
            {
                label22.Text += idfamil[i] + "\n";
            }

            label31.Text = "Клиентов от 20 до 30 лет " + "\n";
            List<string> idfamil1 = SQLRequests.SelectRequest(
          "SELECT COUNT (ИКлиент.Имя) FROM  ИКлиент WHERE Возраст >= 20 and Возраст <= 30",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil1.Count; i++)
            {
                label23.Text += idfamil1[i] + "\n";
            }

            label32.Text = "Клиентов от 30 до 40 лет " + "\n";
            List<string> idfamil2 = SQLRequests.SelectRequest(
          "SELECT COUNT (ИКлиент.Имя) FROM  ИКлиент WHERE Возраст >= 30 and Возраст <= 40",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil2.Count; i++)
            {
                label24.Text += idfamil2[i] + "\n";
            }

            label33.Text = "Клиентов от 50 лет " + "\n";
            List<string> idfamil3 = SQLRequests.SelectRequest(
          "SELECT COUNT (ИКлиент.Имя) FROM  ИКлиент WHERE Возраст >= 50",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil3.Count; i++)
            {
                label25.Text += idfamil3[i] + "\n";
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";
            label17.Text = " "; label18.Text = " "; label19.Text = " "; label20.Text = " ";
            label21.Text = " "; label22.Text = " "; label23.Text = " "; label24.Text = " ";
            label25.Text = " "; label26.Text = " "; label27.Text = " "; label28.Text = " ";
            label29.Text = " "; label30.Text = " "; label31.Text = " "; label32.Text = " ";
            label33.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            button5.Visible = true;

            button1.PerformClick();
            button2.PerformClick();
            button6.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Создаём объект - экземпляр нашего приложения
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            // Создаём экземпляр рабочей книги Excel
            Microsoft.Office.Interop.Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);

            // Данные пом месяцам
            //Значения [y - строка,x - столбец]
            //workSheet.Cells[1, 2] = "Страхование жизни";
            workSheet.Cells[1, 3] = "Общее колличество заказов по месяцам закрытых";

            workSheet.Cells[2, 1] = "Колличество заказов";
            //workSheet.Cells[3, 1] = "За последний месяц";
            //workSheet.Cells[4, 1] = "За последнюю неделю";

            workSheet.Cells[2, 2] = label1.Text;
            workSheet.Cells[2, 3] = label2.Text;
            workSheet.Cells[2, 4] = label3.Text;

            workSheet.Cells[2, 5] = label4.Text;
            workSheet.Cells[2, 6] = label5.Text;
            workSheet.Cells[2, 7] = label6.Text;

            workSheet.Cells[2, 8] = label7.Text;
            workSheet.Cells[2, 9] = label8.Text;
            workSheet.Cells[2, 10] = label9.Text;
            workSheet.Cells[2, 11] = label10.Text;
            workSheet.Cells[2, 12] = label11.Text;
            workSheet.Cells[2, 12] = label12.Text;


            //Данные по кварталам

            //Значения [y - строка,x - столбец]
            workSheet.Cells[5, 1] = "Количество договоров";
            workSheet.Cells[4, 2] = "Общее колличество заказов по кварталам закрытых";

            //workSheet.Cells[2, 1] = "Колличество заказов";
            //workSheet.Cells[3, 1] = "За последний месяц";
            //workSheet.Cells[4, 1] = "За последнюю неделю";

            workSheet.Cells[5, 2] = label17.Text;
            workSheet.Cells[5, 3] = label18.Text;
            workSheet.Cells[5, 4] = label19.Text;
            workSheet.Cells[5, 5] = label20.Text;


            //workSheet.Cells[2, 5] = label4.Text;
            //workSheet.Cells[2, 6] = label5.Text;
            //workSheet.Cells[2, 7] = label6.Text;

            //workSheet.Cells[2, 8] = label7.Text;
            //workSheet.Cells[2, 9] = label8.Text;
            //workSheet.Cells[2, 10] = label9.Text;
            //workSheet.Cells[2, 11] = label10.Text;
            //workSheet.Cells[2, 12] = label11.Text;
            //workSheet.Cells[2, 12] = label12.Text;


            //Данные по заказам путевок по возрасту

            //Значения [y - строка,x - столбец]
            workSheet.Cells[8, 2] = "Клиентов до 20 лет ";
            workSheet.Cells[8, 3] = "Клиентов от 20 до 30 лет ";
            workSheet.Cells[8, 4] = "Клиентов от 30 до 40 лет ";
            workSheet.Cells[8, 5] = "Клиентов больше 50  ";


            workSheet.Cells[7, 2] = "Возраст клиентов";
            workSheet.Cells[9, 1] = "Данные по заказам";


            workSheet.Cells[9, 2] = label22.Text;
            workSheet.Cells[9, 3] = label23.Text;
            workSheet.Cells[9, 4] = label24.Text;
            workSheet.Cells[9, 5] = label25.Text;


            //workSheet.Cells[2, 5] = label4.Text;
            //workSheet.Cells[2, 6] = label5.Text;
            //workSheet.Cells[2, 7] = label6.Text;

            //workSheet.Cells[2, 8] = label7.Text;
            //workSheet.Cells[2, 9] = label8.Text;
            //workSheet.Cells[2, 10] = label9.Text;
            //workSheet.Cells[2, 11] = label10.Text;
            //workSheet.Cells[2, 12] = label11.Text;
            //workSheet.Cells[2, 12] = label12.Text;



            MessageBox.Show("Данные выгружены");

            excelApp.Visible = true;
            excelApp.UserControl = true;


            //

            //var excelcells = ObjWorkSheet.get_Range("A3", "E3");
            ////И выбираем их
            //excelcells.Select();
            ////Создаем объект Excel.Chart диаграмму по умолчанию
            //Microsoft.Office.Interop.Excel.Chart excelchart = (Microsoft.Office.Interop.Excel.Chart)ObjExcel.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            ////Выбираем диграмму - отображаем лист с диаграммой
            //excelchart.Activate();
            //excelchart.Select(Type.Missing);
            ////Изменяем тип диаграммы
            //ObjExcel.ActiveChart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnStacked;
            ////Создаем надпись - Заглавие диаграммы
            //ObjExcel.ActiveChart.HasTitle = true;
            //ObjExcel.ActiveChart.ChartTitle.Text
            //= "Пример диаграммы";
            //ObjExcel.ActiveChart.FullSeriesCollection(1).XValues = "=Лист1!$A$2:$E$2";
            ////Меняем шрифт, можно поменять и другие параметры шрифта
            //ObjExcel.ActiveChart.ChartTitle.Font.Size = 14;
            //ObjExcel.ActiveChart.ChartTitle.Font.Color = 255;
            ////Обрамление для надписи c тенями
            //ObjExcel.ActiveChart.ChartTitle.Shadow = true;
            //ObjExcel.ActiveChart.ChartTitle.Border.LineStyle
            //= Microsoft.Office.Interop.Excel.Constants.xlSolid;
            ////Даем названия осей
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Период";
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Количество";
            ////Координатная сетка - оставляем только крупную сетку
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasMajorGridlines = true;
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory,
            //    Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasMinorGridlines = false;
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasMinorGridlines = false;
            //((Microsoft.Office.Interop.Excel.Axis)ObjExcel.ActiveChart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue,
            //Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary)).HasMajorGridlines = true;
            //ObjExcel.ActiveChart.HasLegend = true;
            ////Расположение легенды
            //ObjExcel.ActiveChart.Legend.Position
            //= Microsoft.Office.Interop.Excel.XlLegendPosition.xlLegendPositionLeft;
            ////Можно изменить шрифт легенды и другие параметры
            //((Microsoft.Office.Interop.Excel.LegendEntry)ObjExcel.ActiveChart.Legend.LegendEntries(1)).Font.Size = 12;
            //Microsoft.Office.Interop.Excel.SeriesCollection seriesCollection =
            //(Microsoft.Office.Interop.Excel.SeriesCollection)ObjExcel.ActiveChart.SeriesCollection(Type.Missing);
            //Microsoft.Office.Interop.Excel.Series series = seriesCollection.Item(1);
            //series.Name = "Количество";
            //series.Name = "Период";

            ////Перемещаем диаграмму на лист 1
            //ObjExcel.ActiveChart.Location(Microsoft.Office.Interop.Excel.XlChartLocation.xlLocationAsObject, "Лист1");
            ////Получаем ссылку на лист 1
            //var excelsheets = ObjWorkBook.Worksheets;
            //ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelsheets.get_Item(1);
            ////Перемещаем диаграмму в нужное место
            //ObjWorkSheet.Shapes.Item(1).IncrementLeft(-201);
            //ObjWorkSheet.Shapes.Item(1).IncrementTop((float)20.5);
            ////Задаем размеры диаграммы
            //ObjWorkSheet.Shapes.Item(1).Height = 550;
            //ObjWorkSheet.Shapes.Item(1).Width = 500;


            //ObjExcel.Visible = true;
            //ObjExcel.UserControl = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";
            label17.Text = " "; label18.Text = " "; label19.Text = " "; label20.Text = " ";
            label21.Text = " "; label22.Text = " "; label23.Text = " "; label24.Text = " ";
            label25.Text = " "; label26.Text = " "; label27.Text = " "; label28.Text = " ";
            label29.Text = " "; label30.Text = " "; label31.Text = " "; label32.Text = " ";
            label33.Text = " ";



            label29.Text = "Статистика по оплаченным договорам" + "\n";

            int sum = 0;
            label27.Text = "Код по оплате" + "\n";
            List<string> idfamil6 = SQLRequests.SelectRequest(
          "SELECT Договор.КодПутевки FROM  Договор WHERE Оплата = 'Оплачено'",
          new string[] { }, new string[] { });
            label28.Text = "Цена по оплате" + "\n";
            label29.Text = "Сумма долга" + "\n";
            for (int i = 0; i < idfamil6.Count; i++)
            {
                label27.Text += idfamil6[i] + "\n";

                List<string> idfamil7 = SQLRequests.SelectRequest(
                "Select ЦенаПутевки From Путевки2_old join Договор on Договор.КодПутевки = Путевки2_old.КодПутевки and  Путевки2_old.КодПутевки = @v1",
               new string[] { "v1" }, new string[] { idfamil6[i] });
                label28.Text += idfamil7[0] + "\n";

                int a = Convert.ToInt32(idfamil7[0]);

                sum += a;
                label16.Text = sum + "\n";

            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";
            label17.Text = " "; label18.Text = " "; label19.Text = " "; label20.Text = " ";
            label21.Text = " "; label22.Text = " "; label23.Text = " "; label24.Text = " ";
            label25.Text = " "; label26.Text = " "; label27.Text = " "; label28.Text = " ";
            label29.Text = " "; label30.Text = " "; label31.Text = " "; label32.Text = " ";
            label33.Text = " ";



            label29.Text = "Статистика по неоплаченным договорам" + "\n";

            int sum = 0;
            label27.Text = "Код по оплате" + "\n";
            List<string> idfamil6 = SQLRequests.SelectRequest(
          "SELECT Договор.КодПутевки FROM  Договор WHERE Оплата = 'Неоплачено'",
          new string[] { }, new string[] { });
            label28.Text = "Цена по оплате" + "\n";
            label29.Text = "Сумма долга" + "\n";
            for (int i = 0; i < idfamil6.Count; i++)
            {
                label27.Text += idfamil6[i] + "\n";

                List<string> idfamil7 = SQLRequests.SelectRequest(
                "Select ЦенаПутевки From Путевки2_old join Договор on Договор.КодПутевки = Путевки2_old.КодПутевки and  Путевки2_old.КодПутевки = @v1",
               new string[] { "v1" }, new string[] { idfamil6[i] });
                label28.Text += idfamil7[0] + "\n";

                int a = Convert.ToInt32(idfamil7[0]);

                sum += a;
                label16.Text = sum + "\n";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " ";
            label13.Text = " "; label14.Text = " "; label15.Text = " "; label16.Text = " ";
            label17.Text = " "; label18.Text = " "; label19.Text = " "; label20.Text = " ";
            label21.Text = " "; label22.Text = " "; label23.Text = " "; label24.Text = " ";
            label25.Text = " "; label26.Text = " "; label27.Text = " "; label28.Text = " ";
            label29.Text = " ";

            label15.Text = "Общая сумма за все путевки " + "\n";

            int sum = 0;

            List<string> idfamil6 = SQLRequests.SelectRequest(
          "SELECT Договор.КодПутевки FROM  Договор WHERE Оплата = 'Неоплачено' or Оплата = 'Оплачено'",
          new string[] { }, new string[] { });

            for (int i = 0; i < idfamil6.Count; i++)
            {


                List<string> idfamil7 = SQLRequests.SelectRequest(
                "Select ЦенаПутевки From Путевки2_old join Договор on Договор.КодПутевки = Путевки2_old.КодПутевки and  Путевки2_old.КодПутевки = @v1",
               new string[] { "v1" }, new string[] { idfamil6[i] });


                int a = Convert.ToInt32(idfamil7[0]);

                sum += a;
                label2.Text = sum + "\n";

            }

        }

        private void DataA_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
