namespace Arithmetic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.labelstep = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.v4 = new System.Windows.Forms.Label();
            this.picMult = new System.Windows.Forms.PictureBox();
            this.s1 = new System.Windows.Forms.Label();
            this.picDiv = new System.Windows.Forms.PictureBox();
            this.s2 = new System.Windows.Forms.Label();
            this.rBDiv = new System.Windows.Forms.RadioButton();
            this.s3 = new System.Windows.Forms.Label();
            this.rBMult = new System.Windows.Forms.RadioButton();
            this.s4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.s5 = new System.Windows.Forms.Label();
            this.s7 = new System.Windows.Forms.Label();
            this.s6 = new System.Windows.Forms.Label();
            this.s8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Визуализация аппаратной реализации операций умножения и деления чисел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 110;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(163, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(529, 421);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(405, 421);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(649, 421);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.labelstep);
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.v1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.v2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.v3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.v4);
            this.panel1.Controls.Add(this.picMult);
            this.panel1.Controls.Add(this.s1);
            this.panel1.Controls.Add(this.picDiv);
            this.panel1.Controls.Add(this.s2);
            this.panel1.Controls.Add(this.rBDiv);
            this.panel1.Controls.Add(this.s3);
            this.panel1.Controls.Add(this.rBMult);
            this.panel1.Controls.Add(this.s4);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.s5);
            this.panel1.Controls.Add(this.s7);
            this.panel1.Controls.Add(this.s6);
            this.panel1.Controls.Add(this.s8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(-4, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 298);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Далее...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.White;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1.Location = new System.Drawing.Point(653, 15);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(16, 15);
            this.p1.TabIndex = 9;
            this.p1.Text = "0";
            this.p1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(123, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.Color.White;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2.Location = new System.Drawing.Point(675, 15);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(16, 15);
            this.p2.TabIndex = 10;
            this.p2.Text = "0";
            this.p2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(123, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.BackColor = System.Drawing.Color.White;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p3.Location = new System.Drawing.Point(697, 15);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(16, 15);
            this.p3.TabIndex = 11;
            this.p3.Text = "0";
            this.p3.Visible = false;
            // 
            // labelstep
            // 
            this.labelstep.AutoSize = true;
            this.labelstep.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelstep.Location = new System.Drawing.Point(24, 49);
            this.labelstep.Name = "labelstep";
            this.labelstep.Size = new System.Drawing.Size(172, 13);
            this.labelstep.TabIndex = 70;
            this.labelstep.Text = "1. Заполнение регистров";
            this.labelstep.Visible = false;
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.BackColor = System.Drawing.Color.White;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p4.Location = new System.Drawing.Point(719, 15);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(16, 15);
            this.p4.TabIndex = 12;
            this.p4.Text = "0";
            this.p4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(345, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.BackColor = System.Drawing.Color.White;
            this.v1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v1.Location = new System.Drawing.Point(653, 40);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(16, 15);
            this.v1.TabIndex = 13;
            this.v1.Text = "0";
            this.v1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(345, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.BackColor = System.Drawing.Color.White;
            this.v2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v2.Location = new System.Drawing.Point(675, 40);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(16, 15);
            this.v2.TabIndex = 14;
            this.v2.Text = "0";
            this.v2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(345, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.BackColor = System.Drawing.Color.White;
            this.v3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v3.Location = new System.Drawing.Point(697, 40);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(16, 15);
            this.v3.TabIndex = 15;
            this.v3.Text = "0";
            this.v3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(345, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "";
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // v4
            // 
            this.v4.AutoSize = true;
            this.v4.BackColor = System.Drawing.Color.White;
            this.v4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v4.Location = new System.Drawing.Point(719, 40);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(16, 15);
            this.v4.TabIndex = 16;
            this.v4.Text = "0";
            this.v4.Visible = false;
            // 
            // picMult
            // 
            this.picMult.Image = ((System.Drawing.Image)(resources.GetObject("picMult.Image")));
            this.picMult.Location = new System.Drawing.Point(42, 85);
            this.picMult.Name = "picMult";
            this.picMult.Size = new System.Drawing.Size(297, 196);
            this.picMult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMult.TabIndex = 4;
            this.picMult.TabStop = false;
            this.picMult.Visible = false;
            //this.picMult.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.BackColor = System.Drawing.Color.White;
            this.s1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s1.Location = new System.Drawing.Point(653, 66);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(16, 15);
            this.s1.TabIndex = 17;
            this.s1.Text = "0";
            this.s1.Visible = false;
            // 
            // picDiv
            // 
            this.picDiv.Image = ((System.Drawing.Image)(resources.GetObject("picDiv.Image")));
            this.picDiv.Location = new System.Drawing.Point(451, 85);
            this.picDiv.Name = "picDiv";
            this.picDiv.Size = new System.Drawing.Size(329, 196);
            this.picDiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDiv.TabIndex = 3;
            this.picDiv.TabStop = false;
            this.picDiv.Visible = false;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.BackColor = System.Drawing.Color.White;
            this.s2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s2.Location = new System.Drawing.Point(668, 66);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(16, 15);
            this.s2.TabIndex = 18;
            this.s2.Text = "0";
            this.s2.Visible = false;
            // 
            // rBDiv
            // 
            this.rBDiv.AutoSize = true;
            this.rBDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBDiv.Location = new System.Drawing.Point(450, 62);
            this.rBDiv.Name = "rBDiv";
            this.rBDiv.Size = new System.Drawing.Size(164, 20);
            this.rBDiv.TabIndex = 92;
            this.rBDiv.TabStop = true;
            this.rBDiv.Text = "Реализация деления";
            this.rBDiv.UseVisualStyleBackColor = true;
            this.rBDiv.CheckedChanged += new System.EventHandler(this.rBDiv_CheckedChanged);
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.BackColor = System.Drawing.Color.White;
            this.s3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s3.Location = new System.Drawing.Point(690, 66);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(16, 15);
            this.s3.TabIndex = 19;
            this.s3.Text = "0";
            this.s3.Visible = false;
            // 
            // rBMult
            // 
            this.rBMult.AutoSize = true;
            this.rBMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBMult.Location = new System.Drawing.Point(42, 62);
            this.rBMult.Name = "rBMult";
            this.rBMult.Size = new System.Drawing.Size(182, 20);
            this.rBMult.TabIndex = 90;
            this.rBMult.TabStop = true;
            this.rBMult.Text = "Реализация умножения";
            this.rBMult.UseVisualStyleBackColor = true;
            this.rBMult.CheckedChanged += new System.EventHandler(this.rBMult_CheckedChanged);
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.BackColor = System.Drawing.Color.White;
            this.s4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s4.Location = new System.Drawing.Point(707, 66);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(16, 15);
            this.s4.TabIndex = 20;
            this.s4.Text = "0";
            this.s4.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(258, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(296, 16);
            this.label.TabIndex = 200;
            this.label.Text = "Выберите арифметическую операцию";
            // 
            // s5
            // 
            this.s5.AutoSize = true;
            this.s5.BackColor = System.Drawing.Color.White;
            this.s5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s5.Location = new System.Drawing.Point(719, 66);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(16, 15);
            this.s5.TabIndex = 21;
            this.s5.Text = "0";
            this.s5.Visible = false;
            // 
            // s7
            // 
            this.s7.AutoSize = true;
            this.s7.BackColor = System.Drawing.Color.White;
            this.s7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s7.Location = new System.Drawing.Point(763, 66);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(16, 15);
            this.s7.TabIndex = 23;
            this.s7.Text = "0";
            this.s7.Visible = false;
            // 
            // s6
            // 
            this.s6.AutoSize = true;
            this.s6.BackColor = System.Drawing.Color.White;
            this.s6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s6.Location = new System.Drawing.Point(741, 66);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(16, 15);
            this.s6.TabIndex = 22;
            this.s6.Text = "0";
            this.s6.Visible = false;
            // 
            // s8
            // 
            this.s8.AutoSize = true;
            this.s8.BackColor = System.Drawing.Color.White;
            this.s8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s8.Location = new System.Drawing.Point(785, 69);
            this.s8.Name = "s8";
            this.s8.Size = new System.Drawing.Size(16, 15);
            this.s8.TabIndex = 24;
            this.s8.Text = "0";
            this.s8.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer12
            // 
            this.timer12.Tick += new System.EventHandler(this.timer12_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аппаратная реализация арифметических операций";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBDiv;
        private System.Windows.Forms.RadioButton rBMult;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox picMult;
        private System.Windows.Forms.PictureBox picDiv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelstep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label v1;
        private System.Windows.Forms.Label v2;
        private System.Windows.Forms.Label v3;
        private System.Windows.Forms.Label v4;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label s4;
        private System.Windows.Forms.Label s5;
        private System.Windows.Forms.Label s7;
        private System.Windows.Forms.Label s6;
        private System.Windows.Forms.Label s8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
    }
}

