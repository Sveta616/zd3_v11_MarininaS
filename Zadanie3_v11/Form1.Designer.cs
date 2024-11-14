
namespace Zadanie3_v11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProbegNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CapacitylNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DistanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.AiroplaneList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddObject = new System.Windows.Forms.Button();
            this.RemoveObjectByNum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PynktText = new System.Windows.Forms.TextBox();
            this.NumText = new System.Windows.Forms.TextBox();
            this.NumRemove = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MarkText = new System.Windows.Forms.TextBox();
            this.Seats = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.PassangerList = new System.Windows.Forms.ListBox();
            this.AddPass = new System.Windows.Forms.Button();
            this.PNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.FindPass = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.NumFind = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DelInd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DelIndex = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemoveByCapacity = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProbegNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacitylNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Самолёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пробег";
            // 
            // ProbegNumeric
            // 
            this.ProbegNumeric.DecimalPlaces = 1;
            this.ProbegNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ProbegNumeric.Location = new System.Drawing.Point(15, 69);
            this.ProbegNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.ProbegNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProbegNumeric.Name = "ProbegNumeric";
            this.ProbegNumeric.Size = new System.Drawing.Size(129, 20);
            this.ProbegNumeric.TabIndex = 2;
            this.ProbegNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вместимость";
            // 
            // CapacitylNumeric
            // 
            this.CapacitylNumeric.Location = new System.Drawing.Point(15, 131);
            this.CapacitylNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CapacitylNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CapacitylNumeric.Name = "CapacitylNumeric";
            this.CapacitylNumeric.Size = new System.Drawing.Size(129, 20);
            this.CapacitylNumeric.TabIndex = 4;
            this.CapacitylNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(240, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Расход на км";
            // 
            // DistanceNumeric
            // 
            this.DistanceNumeric.DecimalPlaces = 1;
            this.DistanceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DistanceNumeric.Location = new System.Drawing.Point(227, 69);
            this.DistanceNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.DistanceNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DistanceNumeric.Name = "DistanceNumeric";
            this.DistanceNumeric.Size = new System.Drawing.Size(137, 20);
            this.DistanceNumeric.TabIndex = 6;
            this.DistanceNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AiroplaneList
            // 
            this.AiroplaneList.FormattingEnabled = true;
            this.AiroplaneList.Location = new System.Drawing.Point(12, 210);
            this.AiroplaneList.Name = "AiroplaneList";
            this.AiroplaneList.Size = new System.Drawing.Size(859, 147);
            this.AiroplaneList.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1202, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Срок эксплуатации";
            // 
            // AddObject
            // 
            this.AddObject.BackColor = System.Drawing.Color.Orchid;
            this.AddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddObject.Location = new System.Drawing.Point(123, 168);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(133, 36);
            this.AddObject.TabIndex = 10;
            this.AddObject.Text = "Добавить новый объект самолёта";
            this.AddObject.UseVisualStyleBackColor = false;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // RemoveObjectByNum
            // 
            this.RemoveObjectByNum.BackColor = System.Drawing.Color.Orchid;
            this.RemoveObjectByNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveObjectByNum.Location = new System.Drawing.Point(63, 70);
            this.RemoveObjectByNum.Name = "RemoveObjectByNum";
            this.RemoveObjectByNum.Size = new System.Drawing.Size(90, 24);
            this.RemoveObjectByNum.TabIndex = 11;
            this.RemoveObjectByNum.Text = "Удалить";
            this.RemoveObjectByNum.UseVisualStyleBackColor = false;
            this.RemoveObjectByNum.Click += new System.EventHandler(this.RemoveObjectByNum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(231, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пункт назначения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(389, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Главный пилот (номер)";
            // 
            // PynktText
            // 
            this.PynktText.Location = new System.Drawing.Point(227, 128);
            this.PynktText.Name = "PynktText";
            this.PynktText.Size = new System.Drawing.Size(140, 20);
            this.PynktText.TabIndex = 18;
            // 
            // NumText
            // 
            this.NumText.Location = new System.Drawing.Point(406, 67);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(140, 20);
            this.NumText.TabIndex = 19;
            // 
            // NumRemove
            // 
            this.NumRemove.Location = new System.Drawing.Point(46, 45);
            this.NumRemove.Name = "NumRemove";
            this.NumRemove.Size = new System.Drawing.Size(138, 20);
            this.NumRemove.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.NumRemove);
            this.panel1.Controls.Add(this.RemoveObjectByNum);
            this.panel1.Location = new System.Drawing.Point(419, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 104);
            this.panel1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Удаление объекта самолёта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Введите номер главного пилота";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(930, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(421, 39);
            this.label11.TabIndex = 25;
            this.label11.Text = "Пассажирский самолёт";
            // 
            // ClassText
            // 
            this.ClassText.Location = new System.Drawing.Point(947, 95);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(149, 20);
            this.ClassText.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(944, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Класс обслуживания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(954, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Марка самолёта";
            // 
            // MarkText
            // 
            this.MarkText.Location = new System.Drawing.Point(947, 157);
            this.MarkText.Name = "MarkText";
            this.MarkText.Size = new System.Drawing.Size(149, 20);
            this.MarkText.TabIndex = 29;
            // 
            // Seats
            // 
            this.Seats.Location = new System.Drawing.Point(1199, 95);
            this.Seats.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Seats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(143, 20);
            this.Seats.TabIndex = 32;
            this.Seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1210, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Кол-во сидений";
            // 
            // PassangerList
            // 
            this.PassangerList.FormattingEnabled = true;
            this.PassangerList.Location = new System.Drawing.Point(15, 405);
            this.PassangerList.Name = "PassangerList";
            this.PassangerList.Size = new System.Drawing.Size(1421, 225);
            this.PassangerList.TabIndex = 33;
            // 
            // AddPass
            // 
            this.AddPass.BackColor = System.Drawing.Color.Orchid;
            this.AddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPass.Location = new System.Drawing.Point(1061, 198);
            this.AddPass.Name = "AddPass";
            this.AddPass.Size = new System.Drawing.Size(174, 42);
            this.AddPass.TabIndex = 34;
            this.AddPass.Text = "Добавить новый объект пассажирского самолёта";
            this.AddPass.UseVisualStyleBackColor = false;
            this.AddPass.Click += new System.EventHandler(this.AddPass_Click);
            // 
            // PNumeric
            // 
            this.PNumeric.DecimalPlaces = 1;
            this.PNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PNumeric.Location = new System.Drawing.Point(1205, 157);
            this.PNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.PNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PNumeric.Name = "PNumeric";
            this.PNumeric.Size = new System.Drawing.Size(137, 20);
            this.PNumeric.TabIndex = 35;
            this.PNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.FindPass);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.NumFind);
            this.panel2.Location = new System.Drawing.Point(1032, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 151);
            this.panel2.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Поиск пассажирского самолёта";
            // 
            // FindPass
            // 
            this.FindPass.BackColor = System.Drawing.Color.Orchid;
            this.FindPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPass.Location = new System.Drawing.Point(80, 108);
            this.FindPass.Name = "FindPass";
            this.FindPass.Size = new System.Drawing.Size(80, 35);
            this.FindPass.TabIndex = 26;
            this.FindPass.Text = "Поиск";
            this.FindPass.UseVisualStyleBackColor = false;
            this.FindPass.Click += new System.EventHandler(this.FindPass_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Введите номер главного пилота";
            // 
            // NumFind
            // 
            this.NumFind.Location = new System.Drawing.Point(36, 73);
            this.NumFind.Name = "NumFind";
            this.NumFind.Size = new System.Drawing.Size(168, 20);
            this.NumFind.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Plum;
            this.panel3.Controls.Add(this.DelInd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DelIndex);
            this.panel3.Location = new System.Drawing.Point(662, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 104);
            this.panel3.TabIndex = 37;
            // 
            // DelInd
            // 
            this.DelInd.BackColor = System.Drawing.Color.Orchid;
            this.DelInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelInd.Location = new System.Drawing.Point(72, 71);
            this.DelInd.Name = "DelInd";
            this.DelInd.Size = new System.Drawing.Size(102, 23);
            this.DelInd.TabIndex = 26;
            this.DelInd.Text = "Удалить ";
            this.DelInd.UseVisualStyleBackColor = false;
            this.DelInd.Click += new System.EventHandler(this.DelInd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Удаление объекта самолёта \r\nпо индексу";
            // 
            // DelIndex
            // 
            this.DelIndex.Location = new System.Drawing.Point(33, 45);
            this.DelIndex.Name = "DelIndex";
            this.DelIndex.Size = new System.Drawing.Size(183, 20);
            this.DelIndex.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 20);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Plum;
            this.panel4.Controls.Add(this.RemoveByCapacity);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Location = new System.Drawing.Point(567, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 86);
            this.panel4.TabIndex = 26;
            // 
            // RemoveByCapacity
            // 
            this.RemoveByCapacity.BackColor = System.Drawing.Color.Orchid;
            this.RemoveByCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveByCapacity.Location = new System.Drawing.Point(58, 61);
            this.RemoveByCapacity.Name = "RemoveByCapacity";
            this.RemoveByCapacity.Size = new System.Drawing.Size(102, 23);
            this.RemoveByCapacity.TabIndex = 38;
            this.RemoveByCapacity.Text = "Удалить ";
            this.RemoveByCapacity.UseVisualStyleBackColor = false;
            this.RemoveByCapacity.Click += new System.EventHandler(this.RemoveByCapacity_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 30);
            this.label17.TabIndex = 25;
            this.label17.Text = "Удаление объекта самолёта \r\nпо вместимости";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1536, 657);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PNumeric);
            this.Controls.Add(this.AddPass);
            this.Controls.Add(this.PassangerList);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MarkText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.PynktText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AiroplaneList);
            this.Controls.Add(this.DistanceNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CapacitylNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProbegNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProbegNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacitylNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ProbegNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CapacitylNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DistanceNumeric;
        private System.Windows.Forms.ListBox AiroplaneList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button RemoveObjectByNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PynktText;
        private System.Windows.Forms.TextBox NumText;
        private System.Windows.Forms.TextBox NumRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MarkText;
        private System.Windows.Forms.NumericUpDown Seats;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox PassangerList;
        private System.Windows.Forms.Button AddPass;
        private System.Windows.Forms.NumericUpDown PNumeric;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NumFind;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button FindPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DelInd;
        private System.Windows.Forms.NumericUpDown DelIndex;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button RemoveByCapacity;
    }
}

