using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матричная_игра
{
    public partial class FormMatrix : Form
    {
        double a11, a12, a13, a21, a22, a23, a31, a32, a33; //Элементы матрицы

        double v1, v2;
        double a, b, c; //alpha, betta, gamma
        double a1, a2, a3;  //a, b, c

        
        public FormMatrix()
        {
            InitializeComponent();
        }

        double[] mas;
        public void Mas(int number)
        {
            mas = new double[dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                mas[i] = double.Parse(dataGridView1[number, i].Value.ToString());
            }
        }
        public void Row()
        {
            for (int i = 2; i <= numericUpDown1.Value; i++)
            {
                if (dataGridView1[1, i - 1].Value == "A")
                {
                    a = (double)dataGridView1[3, i - 2].Value + a11;
                    b = (double)dataGridView1[4, i - 2].Value + a12;
                    c = (double)dataGridView1[5, i - 2].Value + a13;

                    double[] minM = { a, b, c };
                    double min = minM.Min();
                    double maxq = minM.Max();


                    if (min == a)
                    {
                        dataGridView1.Rows[i - 1].Cells[3].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "α";
                        v2 = min / i;
                    }
                    else if (min == b)
                    {
                        dataGridView1.Rows[i - 1].Cells[4].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "β";
                        v2 = min / i;
                    }
                    else
                    {
                        dataGridView1.Rows[i - 1].Cells[5].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "γ";
                        v2 = min / i;
                    }

                    if (dataGridView1[2, i - 1].Value == "α")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a11;
                        a2 = (double)dataGridView1[7, i - 2].Value + a21;
                        a3 = (double)dataGridView1[8, i - 2].Value + a31;
                        
                        double[] minMM = { a1, a2, a3 };
                        double minn = minMM.Min();

                        double maxx = minMM.Max();
                        v1 = maxx / i;

                        if (maxx == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (maxx == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "β")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a12;
                        a2 = (double)dataGridView1[7, i - 2].Value + a22;
                        a3 = (double)dataGridView1[8, i - 2].Value + a32;
                        
                        double[] minMM = { a1, a2, a3 };
                        double minn = minMM.Min();
                        
                        double maxx = minMM.Max();
                        v1 = maxx / i;

                        if (maxx == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (maxx == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "γ")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a13;
                        a2 = (double)dataGridView1[7, i - 2].Value + a23;
                        a3 = (double)dataGridView1[8, i - 2].Value + a33;

                        double[] minMM = { a1, a2, a3 };
                        double minn = minMM.Min();

                        double maxx = minMM.Max();
                        v1 = maxx / i;

                        if (maxx == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (maxx == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                }
                else if (dataGridView1[1, i - 1].Value == "B")
                {
                    a = (double)dataGridView1[3, i - 2].Value + a21;
                    b = (double)dataGridView1[4, i - 2].Value + a22;
                    c = (double)dataGridView1[5, i - 2].Value + a23;

                    double[] minM = { a, b, c };
                    double min = minM.Min();
                    double maxq = minM.Max();


                    if (min == a)
                    {
                        dataGridView1.Rows[i - 1].Cells[3].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "α";
                        v2 = min / i;
                    }
                    else if (min == b)
                    {
                        dataGridView1.Rows[i - 1].Cells[4].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "β";
                        v2 = min / i;
                    }
                    else
                    {
                        dataGridView1.Rows[i - 1].Cells[5].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "γ";
                        v2 = min / i;
                    }

                    if (dataGridView1[2, i - 1].Value == "α")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a11;
                        a2 = (double)dataGridView1[7, i - 2].Value + a21;
                        a3 = (double)dataGridView1[8, i - 2].Value + a31;
                        
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "β")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a12;
                        a2 = (double)dataGridView1[7, i - 2].Value + a22;
                        a3 = (double)dataGridView1[8, i - 2].Value + a32;
                        
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "γ")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a13;
                        a2 = (double)dataGridView1[7, i - 2].Value + a23;
                        a3 = (double)dataGridView1[8, i - 2].Value + a33;
                       
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                }
                else if (dataGridView1[1, i - 1].Value == "C")
                {
                    a = (double)dataGridView1[3, i - 2].Value + a31;
                    b = (double)dataGridView1[4, i - 2].Value + a32;
                    c = (double)dataGridView1[5, i - 2].Value + a33;

                    double[] minM = { a, b, c };
                    double min = minM.Min();
                    double maxq = minM.Max();

                    if (min == a)
                    {
                        dataGridView1.Rows[i - 1].Cells[3].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "α";
                        v2 = min / i;
                    }
                    else if (min == b)
                    {
                        dataGridView1.Rows[i - 1].Cells[4].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "β";
                        v2 = min / i;
                    }
                    else
                    {
                        dataGridView1.Rows[i - 1].Cells[5].Style.BackColor = Color.Yellow;
                        dataGridView1[2, i - 1].Value = "γ";
                        v2 = min / i;
                    }

                    if (dataGridView1[2, i - 1].Value == "α")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a11;
                        a2 = (double)dataGridView1[7, i - 2].Value + a21;
                        a3 = (double)dataGridView1[8, i - 2].Value + a31;
                        
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "β")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a12;
                        a2 = (double)dataGridView1[7, i - 2].Value + a22;
                        a3 = (double)dataGridView1[8, i - 2].Value + a32;
                        
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                    else if (dataGridView1[2, i - 1].Value == "γ")
                    {
                        a1 = (double)dataGridView1[6, i - 2].Value + a13;
                        a2 = (double)dataGridView1[7, i - 2].Value + a23;
                        a3 = (double)dataGridView1[8, i - 2].Value + a33;
                        
                        double[] maxM = { a1, a2, a3 };
                        double max = maxM.Max();
                        v1 = max / i;

                        if (max == a1)
                        {
                            dataGridView1.Rows[i - 1].Cells[6].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "A");
                        }
                        else if (max == a2)
                        {
                            dataGridView1.Rows[i - 1].Cells[7].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "B");
                        }
                        else
                        {
                            dataGridView1.Rows[i - 1].Cells[8].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(i + 1, "C");
                        }

                        dataGridView1[3, i - 1].Value = a;
                        dataGridView1[4, i - 1].Value = b;
                        dataGridView1[5, i - 1].Value = c;
                        dataGridView1[6, i - 1].Value = a1;
                        dataGridView1[7, i - 1].Value = a2;
                        dataGridView1[8, i - 1].Value = a3;
                        dataGridView1[9, i - 1].Value = v1;
                        dataGridView1[10, i - 1].Value = v2;
                    }
                }
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            labelAnswer.Text = "";
            labelHigh.Text = "Верхняя цена игры = ";
            labelLow.Text = "Нижняя цена игры = ";
            labelA.Text = "";
            labelB.Text = "";
            labelC.Text = "";
            labelAlpha.Text = "";
            labelBetta.Text = "";
            labelGamma.Text = "";

            a11 = Convert.ToDouble(textBox11.Text);
            a12 = Convert.ToDouble(textBox12.Text);
            a13 = Convert.ToDouble(textBox13.Text);
            a21 = Convert.ToDouble(textBox21.Text);
            a22 = Convert.ToDouble(textBox22.Text);
            a23 = Convert.ToDouble(textBox23.Text);
            a31 = Convert.ToDouble(textBox31.Text);
            a32 = Convert.ToDouble(textBox32.Text);
            a33 = Convert.ToDouble(textBox33.Text);

            //Значение нижней цены игры
            double[] firstRow = { a11, a12, a13 };
            double minFirstRow = firstRow.Min();
            double maxFirstRow = firstRow.Max();

            double[] secondRow = { a21, a22, a23 };
            double minSecondRow = secondRow.Min();
            double maxSecondRow = secondRow.Max();

            double[] thirdRow = { a31, a32, a33 };
            double minThirdRow = thirdRow.Min();
            double maxThirdRow = thirdRow.Max();

            double[] maxminMass = { minFirstRow, minSecondRow, minThirdRow };
            double maxmin = maxminMass.Max();

            labelLow.Text += Convert.ToString(maxmin);

            //Значение верхней цены игры
            double[] firstColumn = { a11, a21, a31 };
            double maxFirstColumn = firstColumn.Max();
            double minFirstColumn = firstColumn.Min();

            double[] secondColumn = { a12, a22, a32 };
            double maxSecondColumn = secondColumn.Max();
            double minSecondColumnn = secondColumn.Min();

            double[] thirdColumn = { a13, a23, a33 };
            double maxThirdColumn = thirdColumn.Max();
            double minThirdColumn = thirdColumn.Min();

            double[] minmaxMass = { maxFirstColumn, maxSecondColumn, maxThirdColumn };
            double minmax = minmaxMass.Min();
            double minSecondColumn = secondRow.Min();

            labelHigh.Text += Convert.ToString(minmax);

            //Седловая точка
            if (maxmin == minmax)
            {
                labelPoint.Text = "Седловая точка есть";
            }
            else
            {
                labelPoint.Text = "Седловой точки нет";
            }

            //Итерации
            int iteration = (int)numericUpDown1.Value;


            //Создание столбцов
            dataGridView1.ColumnCount = 11;

            dataGridView1.Columns[0].Name = "№";
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightGreen;

            dataGridView1.Columns[1].Name = "1 игрок";
            dataGridView1.Columns[2].Name = "2 игрок";

            dataGridView1.Columns[3].Name = "α";
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.Columns[4].Name = "β";
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.Columns[5].Name = "γ";
            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.Columns[6].Name = "А";
            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightSlateGray;

            dataGridView1.Columns[7].Name = "В";
            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightSlateGray;

            dataGridView1.Columns[8].Name = "С";
            dataGridView1.Columns[8].DefaultCellStyle.BackColor = Color.LightSlateGray;

            dataGridView1.Columns[9].Name = "V(1)";
            dataGridView1.Columns[10].Name = "V(2)";

            double aa = 0;
            double bb = 0;
            double cc = 0;

            //Заполнение первой итерации
            if (maxmin == minFirstRow)
            {
                if (a11 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "А", "α", firstRow[0], firstRow[1], firstRow[2], a11, a21, a31, maxFirstColumn, minFirstRow);
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Yellow;
                    aa++;
                    if (maxFirstColumn == a11)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxFirstColumn == a21)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else if (a12 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "А", "β", firstRow[0], firstRow[1], firstRow[2], a12, a22, a32, maxSecondColumn, minFirstRow);
                    dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Yellow;
                    aa++;
                    if (maxSecondColumn == a12)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxSecondColumn == a22)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else
                {
                    dataGridView1.Rows.Add(1, "А", "γ", firstRow[0], firstRow[1], firstRow[2], a13, a23, a33, maxThirdColumn, minFirstRow);
                    dataGridView1.Rows[0].Cells[5].Style.BackColor = Color.Yellow;
                    aa++;
                    if (maxThirdColumn == a13)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxThirdColumn == a23)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
            }
            else if (maxmin == minSecondRow)
            {
                if (a21 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "В", "α", secondRow[0], secondRow[1], secondRow[2], a11, a21, a31, maxFirstColumn, minSecondRow);
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Yellow;
                    bb++;
                    if (maxFirstColumn == a11)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxFirstColumn == a21)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else if (a22 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "В", "β", secondRow[0], secondRow[1], secondRow[2], a12, a22, a32, maxSecondColumn, minSecondRow);
                    dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Yellow;
                    bb++;
                    if (maxSecondColumn == a12)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxSecondColumn == a22)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else
                {
                    dataGridView1.Rows.Add(1, "B", "γ", secondRow[0], secondRow[1], secondRow[2], a13, a23, a33, maxThirdColumn, minSecondRow);
                    dataGridView1.Rows[0].Cells[5].Style.BackColor = Color.Yellow;
                    bb++;
                    if (maxThirdColumn == a13)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxThirdColumn == a23)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B"); 
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
            }
            else
            {
                if (a31 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "C", "α", thirdRow[0], thirdRow[1], thirdRow[2], a11, a21, a31, maxFirstColumn, minThirdRow);
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Yellow;
                    cc++;
                    if (maxFirstColumn == a11)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxFirstColumn == a21)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else if (a32 == maxmin)
                {
                    dataGridView1.Rows.Add(1, "C", "β", thirdRow[0], thirdRow[1], thirdRow[2], a12, a22, a32, maxSecondColumn, minThirdRow);
                    dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Yellow;
                    cc++;
                    if (maxSecondColumn == a12)
                    { 
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxSecondColumn == a22)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
                else
                {
                    dataGridView1.Rows.Add(1, "C", "γ", thirdRow[0], thirdRow[1], thirdRow[2], a13, a23, a33, maxThirdColumn, minThirdRow);
                    dataGridView1.Rows[0].Cells[5].Style.BackColor = Color.Yellow;
                    cc++;
                    if (maxThirdColumn == a13)
                    {
                        dataGridView1.Rows[0].Cells[6].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "A");
                        Row();
                    }
                    else if (maxThirdColumn == a23)
                    {
                        dataGridView1.Rows[0].Cells[7].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "B");
                        Row();
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[8].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows.Add(2, "C");
                        Row();
                    }
                }
            
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

            //Минимальное и максимальное V1 и V2
            Mas(9);
            double masV1 = mas.Min();

            Mas(10);
            double masV2 = mas.Max();

            dataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", masV1, masV2);
            dataGridView1.Rows[iteration].DefaultCellStyle.BackColor = Color.DeepPink;

            //Количество стратегий
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("A"))
                    aa++;
                else if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("B"))
                    bb++;
                else if(dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("C"))
                    cc++;
            }
            aa /= iteration;
            bb /= iteration;
            cc /= iteration;
            labelA.Text = "A = " + Math.Round(aa, 3);
            labelB.Text = "B = " + Math.Round(bb, 3);
            labelC.Text = "C = " + Math.Round(cc, 3);

            double alpha = 0;
            double betta = 0;
            double gamma = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("α"))
                    alpha++;
                else if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("β"))
                    betta++;
                else if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("γ"))
                    gamma++;
            }
            alpha /= iteration;
            betta /= iteration;
            gamma /= iteration;
            labelAlpha.Text = "α = " + Math.Round(alpha, 3);
            labelBetta.Text = "β = " + Math.Round(betta, 3);
            labelGamma.Text = "γ = " + Math.Round(gamma, 3);

            labelAnswer.Text += Math.Round(masV2, 3) + " < V < " + Math.Round(masV1, 3) + "\r\n" + "P = (" + Math.Round(aa, 3) + "; " + Math.Round(bb, 3) + "; " + Math.Round(cc, 3) + ")" + "\r\n" + "Q = ( " + Math.Round(alpha, 3) + "; " + Math.Round(betta, 3) + "; " + Math.Round(gamma, 3) + ")";
        }
    }
    }

