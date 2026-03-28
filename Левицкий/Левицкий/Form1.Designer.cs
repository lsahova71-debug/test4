
using System;

namespace Левицкий
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button9 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxOldest = new System.Windows.Forms.TextBox();
            this.textBoxNewest = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.ToggleCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxWordInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bntSnite = new System.Windows.Forms.Button();
            this.btnOtmentit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.textBoxDates = new System.Windows.Forms.TextBox();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar5);
            this.groupBox5.Controls.Add(this.monthCalendar1);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBoxOldest);
            this.groupBox5.Controls.Add(this.textBoxNewest);
            this.groupBox5.Location = new System.Drawing.Point(1051, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 459);
            this.groupBox5.TabIndex = 113;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Даты";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(6, 19);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(282, 36);
            this.progressBar5.TabIndex = 105;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 193);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 104;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(290, 23);
            this.button9.TabIndex = 103;
            this.button9.Text = "Посчитать и отметить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 102;
            this.label19.Text = "Новейшие даты";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 101;
            this.label18.Text = "Старейшие даты";
            // 
            // textBoxOldest
            // 
            this.textBoxOldest.Location = new System.Drawing.Point(6, 77);
            this.textBoxOldest.Name = "textBoxOldest";
            this.textBoxOldest.Size = new System.Drawing.Size(290, 20);
            this.textBoxOldest.TabIndex = 100;
            // 
            // textBoxNewest
            // 
            this.textBoxNewest.Location = new System.Drawing.Point(6, 116);
            this.textBoxNewest.Name = "textBoxNewest";
            this.textBoxNewest.Size = new System.Drawing.Size(290, 20);
            this.textBoxNewest.TabIndex = 99;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar4);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxAvg);
            this.groupBox4.Controls.Add(this.textBoxMin);
            this.groupBox4.Controls.Add(this.textBoxMax);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(723, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 467);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Числа";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(0, 19);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(282, 36);
            this.progressBar4.TabIndex = 108;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(-1, 275);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 37);
            this.button8.TabIndex = 107;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 247);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(290, 20);
            this.textBox9.TabIndex = 106;
            this.textBox9.Text = "Информация по словам";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-4, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 105;
            this.label16.Text = "Название файла";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-1, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 23);
            this.button7.TabIndex = 104;
            this.button7.Text = "Посчитать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 13);
            this.label15.TabIndex = 103;
            this.label15.Text = "Среднее арифмеетические всех чисел";
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Location = new System.Drawing.Point(3, 175);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.Size = new System.Drawing.Size(290, 20);
            this.textBoxAvg.TabIndex = 102;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(6, 132);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(286, 20);
            this.textBoxMin.TabIndex = 101;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(2, 83);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(290, 20);
            this.textBoxMax.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "Минимальное из чисел";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Максимальное из чисел";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.ToggleCheckBoxes);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.textBoxWordInfo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.bntSnite);
            this.groupBox3.Controls.Add(this.btnOtmentit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(376, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 453);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Слова";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(0, 19);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(282, 36);
            this.progressBar3.TabIndex = 104;
            // 
            // ToggleCheckBoxes
            // 
            this.ToggleCheckBoxes.FormattingEnabled = true;
            this.ToggleCheckBoxes.Items.AddRange(new object[] {
            "а",
            "б                ",
            "в",
            "г",
            "д",
            "е",
            "ж",
            "з",
            "и",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ч",
            "ш",
            "щ",
            "ъ",
            "ы",
            "ь",
            "э",
            "ю",
            "я",
            "а",
            "б                ",
            "в",
            "г",
            "д",
            "е",
            "ж",
            "з",
            "и",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ч",
            "ш",
            "щ",
            "ъ",
            "ы",
            "ь",
            "э",
            "ю",
            "я"});
            this.ToggleCheckBoxes.Location = new System.Drawing.Point(429, 94);
            this.ToggleCheckBoxes.MultiColumn = true;
            this.ToggleCheckBoxes.Name = "ToggleCheckBoxes";
            this.ToggleCheckBoxes.Size = new System.Drawing.Size(290, 244);
            this.ToggleCheckBoxes.TabIndex = 47;
            this.ToggleCheckBoxes.SelectedIndexChanged += new System.EventHandler(this.ToggleCheckBoxes_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(305, 23);
            this.button6.TabIndex = 102;
            this.button6.Text = "Посчитать и сохранить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBoxWordInfo
            // 
            this.textBoxWordInfo.Location = new System.Drawing.Point(0, 377);
            this.textBoxWordInfo.Name = "textBoxWordInfo";
            this.textBoxWordInfo.Size = new System.Drawing.Size(305, 20);
            this.textBoxWordInfo.TabIndex = 101;
            this.textBoxWordInfo.Text = "Информация по словам";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Название файла";
            // 
            // bntSnite
            // 
            this.bntSnite.Location = new System.Drawing.Point(161, 323);
            this.bntSnite.Name = "bntSnite";
            this.bntSnite.Size = new System.Drawing.Size(144, 23);
            this.bntSnite.TabIndex = 99;
            this.bntSnite.Text = "Снять все";
            this.bntSnite.UseVisualStyleBackColor = true;
            // 
            // btnOtmentit
            // 
            this.btnOtmentit.Location = new System.Drawing.Point(0, 323);
            this.btnOtmentit.Name = "btnOtmentit";
            this.btnOtmentit.Size = new System.Drawing.Size(147, 23);
            this.btnOtmentit.TabIndex = 98;
            this.btnOtmentit.Text = "Отметить все";
            this.btnOtmentit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Какие буква считаем?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Controls.Add(this.comboBoxWork);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(-1, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 109);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Часть 2";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(0, 68);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(107, 33);
            this.buttonStart.TabIndex = 71;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Location = new System.Drawing.Point(0, 41);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(345, 21);
            this.comboBoxWork.TabIndex = 70;
            this.comboBoxWork.SelectedIndexChanged += new System.EventHandler(this.comboBoxWork_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "С чем работаем";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.textBoxNumbers);
            this.groupBox1.Controls.Add(this.textBoxDates);
            this.groupBox1.Controls.Add(this.textBoxWords);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonCount);
            this.groupBox1.Location = new System.Drawing.Point(-1, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 247);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Часть 1";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(9, 199);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(345, 23);
            this.progressBar2.TabIndex = 71;
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(56, 107);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(290, 20);
            this.textBoxNumbers.TabIndex = 70;
            // 
            // textBoxDates
            // 
            this.textBoxDates.Location = new System.Drawing.Point(56, 156);
            this.textBoxDates.Name = "textBoxDates";
            this.textBoxDates.Size = new System.Drawing.Size(290, 20);
            this.textBoxDates.TabIndex = 69;
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(56, 61);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(290, 20);
            this.textBoxWords.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Дат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Чисел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Слов";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(1, 25);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 23);
            this.buttonCount.TabIndex = 64;
            this.buttonCount.Text = "Посчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 108;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(3, 110);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 107;
            this.buttonBrowse.Text = "Обзор...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(-1, 84);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(290, 20);
            this.textBoxPath.TabIndex = 106;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 35);
            this.progressBar1.TabIndex = 105;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Путь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Общий прогресс";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "а",
            "б                ",
            "в",
            "г",
            "д",
            "е",
            "ж",
            "з",
            "и",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ч",
            "ш",
            "щ",
            "ъ",
            "ы",
            "ь",
            "э",
            "ю",
            "я"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 84);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(282, 229);
            this.checkedListBox1.TabIndex = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 678);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxOldest;
        private System.Windows.Forms.TextBox textBoxNewest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.CheckedListBox ToggleCheckBoxes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxWordInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bntSnite;
        private System.Windows.Forms.Button btnOtmentit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.TextBox textBoxDates;
        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

