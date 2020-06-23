using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {

        string strNumBin1;
        string strNumBin2;
        int step = 0;
        int a, b;

        string x, y;
        int del_end = 0;

        string b_pr = "";
        string b_dop = "";
        int digit = 1;
        string res = "---";
        string ost = "";

        List<Control> k1 = new List<Control>();
        List<Control> k2 = new List<Control>();
        List<Control> scp = new List<Control>();

        int h = 1, subh = 1;
        int p = 0;

        
        /////////////////////////////////////////////
        
        //функция перевода в двоичную систему
        static public string ToBinary(string s)
        {
            string t="";
            int a = Convert.ToInt16(s);
            while (a > 0)
            {
                t = (a % 2).ToString() + t;
                a /= 2;
            }
          return t;
        }

        /////////////////////////////////////////////

        //функция перевода в десятичную систему
        static string ToDec(string a)
        {
            int sum = 0;
            int st2 = 1;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int c = Convert.ToInt16(a[i].ToString());
                sum += st2 * c;
                st2 *= 2;
            }
            return sum.ToString();
        }


        /////////////////////////////////////////////

        //функция преобразования в дополнительный код
        static string ToDop(string s)
        {
            string dop_code = "";
            //построение обратного кода путём инвертирования разрядов модуля числа
            for (int i = 0; i < 4; i++)
                if (s[i] == '1')
                    dop_code += "0";
                else
                    dop_code += "1";

            //построение дополнительного кода путём прибавления 1 к обратному коду
            if (dop_code[3] == '0')
            {
                dop_code = dop_code.Remove(3);
                dop_code = dop_code.Insert(3, "1");
            }
            else
            {
                int ind = 3;
                bool p = true;
                do
                {
                    if (dop_code[ind] == '0')
                    {
                        dop_code = dop_code.Remove(ind, 1);
                        dop_code = dop_code.Insert(ind, "1");
                        p = false;
                    }
                    else
                    {
                        dop_code = dop_code.Remove(ind, 1);
                        dop_code = dop_code.Insert(ind, "0");
                    }
                    ind--;
                } while (p && ind >= 0);
            }
            return dop_code;
        }

    //////////////////////////////////////////////////////////
    
        public Form1()
        {
            InitializeComponent();

            k1.Add(p1);
            k1.Add(p2);
            k1.Add(p3);
            k1.Add(p4);

            k2.Add(v1);
            k2.Add(v2);
            k2.Add(v3);
            k2.Add(v4);

            scp.Add(s1);
            scp.Add(s2);
            scp.Add(s3);
            scp.Add(s4);
            scp.Add(s5);
            scp.Add(s6);
            scp.Add(s7);
            scp.Add(s8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "программа предназначена для демонстрации пошагового выполнения работы алгоритмов";
            label3.Text = "на положительных целых числах, представимых в четырёхразрядной сетке";
        }

      
        private void rBMult_CheckedChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
            picDiv.Visible = false;
            picMult.Visible = true;
        }

        private void rBDiv_CheckedChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;
            picDiv.Visible = true;
            picMult.Visible = false;
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            step++;
            if (step == 1)
            {
                label.Location= new Point(195, 15);
                label.Text = "Введите два целых числа для выполнения операции";
                buttonBack.Enabled = true;
                picMult.Visible = false;
                picDiv.Visible = false;
                rBDiv.Visible = false;
                rBMult.Visible = false;

                label4.Visible = true;
                label5.Visible = true;
                if (rBMult.Checked)
                {
                    label4.Location = new Point(345, 85);
                    label5.Location = new Point(345, 145);
                    label4.Text = "Множимое";
                    label5.Text = "Множитель";
                }
                else
                {
                    label4.Location = new Point(345, 85);
                    label5.Location = new Point(345, 145);
                    label4.Text = "Делимое";
                    label5.Text = "Делитель";
                }

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox1.Focus();

            }
            else
                if (step == 2)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Необходимо ввести оба числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    step--;
                }
                else
                {
                    a = Convert.ToInt16(textBox1.Text);
                    b = Convert.ToInt16(textBox2.Text);

                    //умножение

                    if (rBMult.Checked)
                        if (a < 1 || a > 15 || b < 1 || b > 15)
                        {
                            MessageBox.Show("Оба числа должны быть в диапазоне от 1 до 15" + "\n" + "для отображения в 4-х разрядной сетке", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            step--;
                        }
                        else
                        {
                            buttonNext.Text = "Work...";
                            buttonNext.Enabled = false;

                            labelstep.Text = "1.Заполнение регистров";

                            label.Location = new Point(208, 15);
                            label.Text = "Умножение чисел "+a.ToString() +" и "  + b.ToString() + " алгоритмом левого сдвига";//!!!
                            strNumBin1 = ToBinary(textBox1.Text);
                            strNumBin2 = ToBinary(textBox2.Text);
                            
                            textBox1.Clear();       textBox2.Clear();
                            textBox1.Visible=false; textBox2.Visible = false;

                            labelstep.Visible = true;
                            label4.Location = new Point(24, 79);
                            label5.Location = new Point(24, 123);

                            p1.Visible = true;
                            p2.Visible = true;
                            p3.Visible = true;
                            p4.Visible = true;
                            
                            p1.Location = new Point(30, 95);
                            p2.Location = new Point(47, 95);
                            p3.Location = new Point(64, 95);
                            p4.Location = new Point(81, 95);

                            v1.Visible = true;
                            v2.Visible = true;
                            v3.Visible = true;
                            v4.Visible = true;

                            v1.Location = new Point(30, 142);
                            v2.Location = new Point(47, 142);
                            v3.Location = new Point(64, 142);
                            v4.Location = new Point(81, 142);

                            s1.Visible = true; s5.Visible = true;
                            s2.Visible = true; s6.Visible = true;
                            s3.Visible = true; s7.Visible = true;
                            s4.Visible = true; s8.Visible = true;

                            
                            s1.Location = new Point(30, 194);
                            s2.Location = new Point(47, 194);
                            s3.Location = new Point(64, 194);
                            s4.Location = new Point(81, 194);
                            s5.Location = new Point(98, 194);
                            s6.Location = new Point(115, 194);
                            s7.Location = new Point(132, 194);
                            s8.Location = new Point(149, 194);

                            label8.Location = new Point(24, 175);
                            label8.Visible = true;
                            label8.Text = "Сумма Частичных Произведений";

                            button1.Visible = true;


                            x = strNumBin1;
                            if (strNumBin1.Length < 4)
                                for (int i = 1; i <= 4 - strNumBin1.Length; i++)
                                    x = string.Concat("0", x);

                            y = strNumBin2;
                            if (strNumBin2.Length < 4)
                                for (int i = 1; i <= 4 - strNumBin2.Length; i++)
                                    y = string.Concat("0", y);


                            for (int i = 0; i < k1.Count; i++)
                            {
                                k1[i].Text = x[i].ToString();
                                k1[i].BackColor = Color.FromArgb(255, 255, 255);
                            }

                            for (int i = 0; i < k2.Count; i++)
                            {
                                k2[i].Text = y[i].ToString();
                                k2[i].BackColor = Color.FromArgb(255, 255, 255);
                            }

                            for (int i = 0; i < scp.Count; i++)
                            {
                                scp[i].Text = "0";
                                scp[i].BackColor = Color.FromArgb(255, 255, 255);
                            }
                        }


                    //деление
                    if (rBDiv.Checked)
                        if (a < 16 || a > 31)
                        {
                            MessageBox.Show("Делимое должно быть в диапазоне от 16 до 31", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            step--;
                        }
                        else
                            if (b < 1 || b > 7)
                        {
                            MessageBox.Show("Делитель должен быть в диапазоне от 1 до 7", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            step--;
                        }
                        else
                        {
                            buttonNext.Text = "Work...";
                            buttonNext.Enabled = false;

                            label.Location = new Point(150, 15);
                            label.Text = "Целочисленное деление числа " + a.ToString() + " на " + b.ToString() + " с восстановлением остатка";
                            strNumBin1 = ToBinary(textBox1.Text);
                            b_pr = ToBinary(textBox2.Text);


                            textBox1.Clear(); textBox2.Clear();
                            textBox1.Visible = false; textBox2.Visible = false;
                            label4.Visible = false; label5.Visible = false;


                            labelstep.Visible = true;
                            labelstep.Text = "В Частичный Остаток  записано делимое";
                            label4.Location = new Point(24, 160);
                            label4.Text = "Делитель";
                            

                            p1.Location = new Point(30, 177);
                            p2.Location = new Point(47, 177);
                            p3.Location = new Point(64, 177);
                            p4.Location = new Point(81, 177);

                            
                            s1.Visible = true; s5.Visible = true;
                            s2.Visible = true; s6.Visible = true;
                            s3.Visible = true; s7.Visible = true;
                            s4.Visible = true; s8.Visible = true;


                            s1.Location = new Point(30, 105);
                            s2.Location = new Point(47, 105);
                            s3.Location = new Point(64, 105);
                            s4.Location = new Point(81, 105);
                            s5.Location = new Point(98, 105);
                            s6.Location = new Point(115, 105);
                            s7.Location = new Point(132, 105);
                            s8.Location = new Point(149, 105);

                            label8.Visible = true;
                            label8.Location = new Point(24, 89);
                            label8.Text = "Частичный Остаток";

                            button1.Visible = true;

                            y = b_pr;
                            if (b_pr.Length < 4)
                                for (int i = 1; i <= 4 - b_pr.Length; i++)
                                    y = string.Concat("0", y);
                            b_pr = y;

                            
                            for (int i = 0; i < scp.Count; i++)
                            {
                                if (i < 3)
                                    scp[i].Text = "0";
                                else
                                    scp[i].Text = strNumBin1[i - 3].ToString();
                                scp[i].BackColor = Color.FromArgb(255, 255, 255);
                            }

                            b_dop = ToDop(b_pr);

                            for (int i = 0; i < b_dop.Length; i++)
                            {
                                k1[i].Text = b_dop[i].ToString();
                                k1[i].BackColor = Color.FromArgb(255, 255, 255);
                            }
                        }
                }
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            label.Location=new Point(258, 15);
            label.Text = "Выберите арифметическую операцию";
            rBDiv.Visible = true;
            rBMult.Visible = true;

            buttonBack.Enabled = false;
            if (rBMult.Checked)
                picMult.Visible = true;
            else
                if (rBDiv.Checked)
                   picDiv.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

            step = 0;

            buttonNext.Text = "Next";
            buttonNext.Enabled = true;

            p1.Visible = false; v1.Visible = false;
            p2.Visible = false; v2.Visible = false;
            p3.Visible = false; v3.Visible = false;
            p4.Visible = false; v4.Visible = false;
            
            s1.Visible = false; s5.Visible = false;
            s2.Visible = false; s6.Visible = false;
            s3.Visible = false; s7.Visible = false;
            s4.Visible = false; s8.Visible = false;

            label8.Visible = false;
            button1.Visible = false;

            labelstep.Visible = false;
            labelstep.ForeColor = Color.FromArgb(0, 0, 0, 0);

            label6.Visible = false;
            label7.Visible = false;

            del_end = 0;
            textBox1.Clear();
            textBox2.Clear();
            step = 0;
            h = 1;
            subh = 1;
            p = 0;
        }


        int znak = 0, indco, indk;

        private void button1_Click_1(object sender, EventArgs e)
        {
            ////////////////////////////////У М Н О Ж Е Н И Е ////////////////////////////////////

            if (rBMult.Checked)
            {
                if (h < 5)
                {

                    for (int i = 0; i < k2.Count; i++)
                        k2[i].BackColor = Color.FromArgb(255, 255, 255);


                    for (int i = 0; i < scp.Count; i++)
                    {
                        scp[i].BackColor = Color.FromArgb(255, 255, 255);
                    }



                    label6.Visible = true;
                    label7.Visible = true;
                    label7.Location = new Point(123, 69);

                    labelstep.Text = "шаг " + h.ToString();
                    switch (subh)
                    {

                        case 1:
                            {
                                //.1 Сдвиг влево СЧП
                                label6.Text = "Сдвиг влево СЧП";
                                label6.ForeColor = Color.FromArgb(29, 180, 65);
                                label7.Text = h.ToString() + ".1 Сдвиг на один разряд влево СЧП";
                                index = 0;
                                timer1.Enabled = true;
                            }
                            break;

                        case 2:
                            //.2 Если множитель начинается с 1, то сложить СЧП с множимым
                            {
                                label6.Text = "Сложение множимого с СЧП";
                                label6.ForeColor = Color.FromArgb(200, 11, 5, 235);
                                label7.Text = h.ToString() + ".2 Старший разряд множителя 1, складываем множимое с СЧП";
                                indk1 = k1.Count - 1;
                                indscp = scp.Count - 1;
                                p = 0;
                                timer2.Enabled = true;
                            }
                            break;

                        case 3:
                            //.3 Сдвиг влево множителя
                            label6.Text = "Сдвиг влево множителя";
                            label6.ForeColor = Color.FromArgb(29, 180, 65);
                            if (k2[0].Text == "0")
                                label7.Text = h.ToString() + ".3 Старший бит множителя 0, поэтому сразу сдвигаем на один разряд влево множителя";
                            else
                                label7.Text = h.ToString() + ".3 Cдвиг на один разряд влево множителя";
                            index = 0;
                            timer3.Enabled = true;
                            break;
                    }

                    subh++;
                    if (subh == 2 && k2[0].Text == "0") subh = 3;
                    if (subh == 4)
                    {
                        subh = 1;
                        h++;
                    }
                }
                else
                //Результат умножения
                {
                    string res = "";
                    for (int i = 0; i < scp.Count; i++)
                    {
                        scp[i].BackColor = Color.FromArgb(255, 255, 255);
                        res += scp[i].Text;
                    }

                    for (int i = 0; i < k2.Count; i++)
                        k2[i].BackColor = Color.FromArgb(255, 255, 255);
                    label6.Visible = false;
                    label7.Visible = false;
                    labelstep.ForeColor = Color.FromArgb(255, 0, 0);
                    labelstep.Text = "Результат умножения равен " + res + " (2) = " + ToDec(res);
                    button1.Enabled = false;
                }
            }

            ////////////////////////////////Д Е Л Е Н И Е////////////////////////////////////

            else
                if (rBDiv.Checked)
            {
                if (h < 5)
                {

                    for (int i = 0; i < k1.Count; i++)
                        k1[i].BackColor = Color.FromArgb(255, 255, 255);


                    for (int i = 0; i < scp.Count; i++)
                    {
                        scp[i].BackColor = Color.FromArgb(255, 255, 255);
                    }



                    label6.Visible = true;
                    label7.Visible = true;
                    label7.Location = new Point(123, 69);

                    labelstep.Text = "шаг " + h.ToString();
                    switch (subh)
                    {

                        case 1:
                            {
                                //.1 Сдвиг влево ЧО
                                label6.Text = "Сдвиг влево Частичного Остатка";
                                label6.ForeColor = Color.FromArgb(29, 180, 65);
                                label7.Text = h.ToString() + ".1 ЧО удваивается сдвигом на один разряд влево";
                                index = 0;
                                timer11.Enabled = true;
                            }
                            break;

                        case 2:
                            //.2 если в старшем бите 1 — сложение ЧО с делителем, иначе — вычитние делителя путём сложения с его дополнительным кодом из ЧО
                            {
                                if (h == 1)
                                {
                                    label6.Text = "Вычитание делителя";
                                    label7.Text = h.ToString() + ".2 Из сдвинутого Частичного Остатка вычитается делитель";
                                }
                                else
                                {
                                    if (znak == 0)
                                    {
                                        label6.Text = "Вычитание делителя";
                                        label7.Text = h.ToString() + ".2 Остаток положителен, поэтому из Частичного Остатка вычитается делитель";
                                    }
                                    else
                                    {
                                        label6.Text = "Прибавление делителя";
                                        label7.Text = h.ToString() + ".2 Остаток отрицателен, поэтому к Частичному Остатку прибавляется делитель";
                                    }

                                }
                                label6.ForeColor = Color.FromArgb(200, 11, 5, 235);
                                indk = k1.Count - 1;
                                indco = 3;
                                p = 0;
                                timer12.Enabled = true;
                            }
                            break;

                        case 3:
                            //.3 Анализ знакового разряда
                            label4.Visible = false;
                            p1.Visible = false;
                            p2.Visible = false;
                            p3.Visible = false;
                            p4.Visible = false;
                            scp[0].BackColor = Color.FromArgb(255, 174, 201);
                            if (h == 1)
                            {
                                if (scp[0].Text == "1")
                                    label6.Text = "Переполнения нет, деление возможно";
                                label7.Visible = false;

                            }
                            else
                            {
                                int cifra;
                                if (znak == 0)
                                    if (scp[0].Text == "1")
                                    {
                                        label6.Text = "Результат вычитания отрицательный, " + digit.ToString() + "-цифра частного равна 0";
                                        cifra = 0;
                                    }
                                    else
                                    {
                                        label6.Text = "Результат вычитания отрицательный, " + digit.ToString() + "-цифра частного равна 1";
                                        cifra = 1;
                                    }
                                else
                                   if (scp[0].Text == "1")
                                {
                                    label6.Text = "Результат сложения отрицательный, " + digit.ToString() + "-цифра частного равна 0";
                                    cifra = 0;
                                }
                                else
                                {
                                    label6.Text = "Результат сложения отрицательный, " + digit.ToString() + "-цифра частного равна 1";
                                    cifra = 1;
                                }
                                label6.ForeColor = Color.FromArgb(29, 180, 65);
                                res = res.Remove(h - 2, 1);
                                res = res.Insert(h - 2, cifra.ToString());
                                label7.Text = h.ToString() + ".3 Результат деления на данном шаге равен " + res;
                                digit++;
                            }
                            znak = Convert.ToInt16(scp[0].Text);
                            break;
                    }

                    subh++;
                    if (subh == 4)
                    {
                        subh = 1;
                        h++;
                    }
                }
                else
                //Результат деления
                {
                    for (int i = 0; i < scp.Count; i++)
                    {
                        scp[i].BackColor = Color.FromArgb(255, 255, 255);
                    }

                    for (int i = 0; i < k1.Count; i++)
                        k1[i].BackColor = Color.FromArgb(255, 255, 255);
                    label6.Visible = false;
                    label7.Visible = false;
                    labelstep.ForeColor = Color.FromArgb(255, 0, 0);
                    labelstep.Text = "Результат деления равен " + res + " (2) = " + ToDec(res);
                    button1.Enabled = false;

                    //восстанавливаем остаток
                    string ost = "";
                    if (scp[0].Text == "1")
                    {

                        label6.ForeColor = Color.FromArgb(200, 11, 5, 235);
                        indk = k1.Count - 1;
                        indco = 3;
                        p = 0;
                        del_end = 1;
                        timer12.Enabled = true;
                    }
                    else
                    {

                        for (int i = 0; i < 4; i++)
                            ost += scp[i].Text;

                        label7.Location = new Point(24, 69);
                        label7.Text = "остаток от деления равен " + ost + "(2) = " + ToDec(ost);
                        label7.Visible = true;
                    }
                }

            }
        }


        int index;
        int indk1, indscp;

        ////////////////Таймеры умножения////////////////
        
        //сдвиг влево СЧП
        private void timer1_Tick(object sender, EventArgs e)
        {
            //отключаем на время кнопку Далее...
            button1.Enabled = false;
            //осуществляем сдвиг влево
            if (index < scp.Count - 1)
            {
                scp[index].Text = scp[index + 1].Text;
                scp[index].BackColor = Color.FromArgb(16, 224, 89);
            }
            else
            {
                //завершаем сдвиг, выключаем таймер, включаем кнопку Далее...
                scp[index].Text = "0";
                scp[index].BackColor = Color.FromArgb(16, 224, 89);
                timer1.Enabled = false;
                button1.Enabled = true;
            }
            index++;
        }

        //реализация поразрядного сложения СЧП с множимым
        private void timer2_Tick(object sender, EventArgs e)
        {
            //отключаем на время кнопку Далее...
            button1.Enabled = false;

            //реализуем поразрядное сложение (с учётом перехода разрядов p)
            if (indk1 >= 0)
            {
                if (k1[indk1--].Text == "0")
                {
                    if (p != 0)
                    {
                        if (scp[indscp].Text == "0")
                        {
                            scp[indscp].Text = "1";
                            p = 0;
                        }
                        else
                        {
                            scp[indscp].Text = "0";
                            p = 1;
                        }
                    }
                    scp[indscp--].BackColor = Color.FromArgb(110, 11, 5, 235);
                }
                else
                {
                    if (scp[indscp].Text == "0")
                        if (p == 0)
                            scp[indscp].Text = "1";
                        else
                            scp[indscp].Text = "0";
                    else
                    {
                        if (p == 0)
                        {
                            scp[indscp].Text = "0";
                            p = 1;
                        }
                        else
                            scp[indscp].Text = "1";
                    }
                    scp[indscp--].BackColor = Color.FromArgb(110, 11, 5, 235);
                }
            }
            else
              if (p==1 && indscp >= 0)
                 {
                        if (scp[indscp].Text == "0")
                        {
                            scp[indscp].Text = "1";
                            p = 0;
                        }
                        else
                        {
                            scp[indscp].Text = "0";
                            p = 1;
                        }
                  scp[indscp--].BackColor = Color.FromArgb(110, 11, 5, 235);
                }
            else
            {
                //завершаем: выключаем таймер, включаем кнопку Далее...
                timer2.Enabled = false;
                button1.Enabled = true;
            }
        }

        //сдвиг влево множителя
        private void timer3_Tick(object sender, EventArgs e)
        {
            //отключаем на время кнопку Далее...
            button1.Enabled = false;

            //осуществляем сдвиг влево
            if (index < k2.Count - 1)
            {
                k2[index].Text = k2[index + 1].Text;
                k2[index].BackColor = Color.FromArgb(16, 224, 89);
            }
            else
            {
                //завершаем сдвиг, выключаем таймер, включаем кнопку Далее...
                k2[index].Text = "0";
                k2[index].BackColor = Color.FromArgb(16, 224, 89);
                timer3.Enabled = false;
                button1.Enabled = true;
            }
            index++;
        }

        ////////////////Таймеры деления////////////////

        //сдвиг влево ЧО
        private void timer11_Tick(object sender, EventArgs e)
        {
            //отключаем на время кнопку Далее...
            button1.Enabled = false;

            //осуществляем сдвиг влево
            if (index < scp.Count - 1)
            {
                scp[index].Text = scp[index + 1].Text;
                scp[index].BackColor = Color.FromArgb(16, 224, 89);
            }
            else
            {
                //завершаем сдвиг, выключаем таймер, включаем кнопку Далее...
                scp[index].Text = "0";
                scp[index].BackColor = Color.FromArgb(16, 224, 89);
                timer11.Enabled = false;
                button1.Enabled = true;
            }
            index++;
        }

        //сложение/вычитание ЧО с делителем
        private void timer12_Tick(object sender, EventArgs e)
        {
            //для вычитания делителя задействуем дополнительный код
            if (znak == 0)
            {
                for (int i = 0; i < b_dop.Length; i++)
                {
                    k1[i].Text = b_dop[i].ToString();
                    k1[i].BackColor = Color.FromArgb(255, 255, 255);
                }
            }
            else
                //для сложения с делителем используем прямой код
                for (int i = 0; i < k1.Count; i++)
                {
                    k1[i].Text = b_pr[i].ToString();
                    k1[i].BackColor = Color.FromArgb(255, 255, 255);
                }

            //отображаем делитель в нужном представлении
            label4.Visible = true;
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;

            //отключаем на время кнопку Далее...
            button1.Enabled = false;

            //производим поразрядное сложение с учётом переноса разряда (p)
            if (indk >= 0)
            {
                if (k1[indk--].Text == "0")
                {
                    if (p != 0)
                    {
                        if (scp[indco].Text == "0")
                        {
                            scp[indco].Text = "1";
                            p = 0;
                        }
                        else
                        {
                            scp[indco].Text = "0";
                            p = 1;
                        }
                    }
                    scp[indco--].BackColor = Color.FromArgb(110, 11, 5, 235);
                }
                else
                {
                    if (scp[indco].Text == "0")
                        if (p == 0)
                            scp[indco].Text = "1";
                        else
                            scp[indco].Text = "0";
                    else
                    {
                        if (p == 0)
                        {
                            scp[indco].Text = "0";
                            p = 1;
                        }
                        else
                            scp[indco].Text = "1";
                    }
                    scp[indco--].BackColor = Color.FromArgb(110, 11, 5, 235);
                }
            }
            else
            {
                //завершаем работу таймера
                timer12.Enabled = false;
                if (del_end == 0)
                    button1.Enabled = true;
                else
                {
                    //на последнем шаге восстанавливаем остаток ...
                    button1.Enabled = false;
                    label4.Visible = false;
                    p1.Visible = false;
                    p2.Visible = false;
                    p3.Visible = false;
                    p4.Visible = false;
                    for (int i = 0; i < 4; i++)
                        ost += scp[i].Text;

                    // ... и выводим его под результатом деления
                    label7.Text = "остаток от деления равен " + ost + "(2) = " + ToDec(ost);
                    label7.Visible = true;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; 

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
