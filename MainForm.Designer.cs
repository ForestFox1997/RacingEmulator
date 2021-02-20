namespace TestTask
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbVehicles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVehicleTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWheelPunctureProbability = new System.Windows.Forms.NumericUpDown();
            this.nudVehicleSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVehicleColors = new System.Windows.Forms.ComboBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnRemoveVehicle = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbRacingStats = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxTimeToChangeWheel = new System.Windows.Forms.NumericUpDown();
            this.nudMinTimeToChangeWheel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSimulationSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVehiclesStats = new System.Windows.Forms.TextBox();
            this.nudPeopleCount = new System.Windows.Forms.NumericUpDown();
            this.nudCargoWeight = new System.Windows.Forms.NumericUpDown();
            this.cbSidecarAvailability = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelPunctureProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTimeToChangeWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTimeToChangeWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulationSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeopleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargoWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Транспортные средства";
            // 
            // lbVehicles
            // 
            this.lbVehicles.FormattingEnabled = true;
            this.lbVehicles.Location = new System.Drawing.Point(25, 29);
            this.lbVehicles.Name = "lbVehicles";
            this.lbVehicles.Size = new System.Drawing.Size(315, 264);
            this.lbVehicles.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbVehicleTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudWheelPunctureProbability);
            this.groupBox1.Controls.Add(this.nudVehicleSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbVehicleColors);
            this.groupBox1.Controls.Add(this.btnAddVehicle);
            this.groupBox1.Controls.Add(this.nudCargoWeight);
            this.groupBox1.Controls.Add(this.cbSidecarAvailability);
            this.groupBox1.Controls.Add(this.nudPeopleCount);
            this.groupBox1.Location = new System.Drawing.Point(25, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить транспортное средство";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тип ТС";
            // 
            // cbVehicleTypes
            // 
            this.cbVehicleTypes.FormattingEnabled = true;
            this.cbVehicleTypes.Items.AddRange(new object[] {
            "Грузовик",
            "Легковое авто",
            "Мотоцикл"});
            this.cbVehicleTypes.Location = new System.Drawing.Point(19, 36);
            this.cbVehicleTypes.Name = "cbVehicleTypes";
            this.cbVehicleTypes.Size = new System.Drawing.Size(130, 21);
            this.cbVehicleTypes.TabIndex = 12;
            this.cbVehicleTypes.SelectedValueChanged += new System.EventHandler(this.cbVehicleTypes_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Коэффициент удачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Скорость";
            // 
            // nudWheelPunctureProbability
            // 
            this.nudWheelPunctureProbability.DecimalPlaces = 2;
            this.nudWheelPunctureProbability.Increment = new decimal(new int[] {
            50,
            0,
            0,
            196608});
            this.nudWheelPunctureProbability.Location = new System.Drawing.Point(19, 178);
            this.nudWheelPunctureProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWheelPunctureProbability.Name = "nudWheelPunctureProbability";
            this.nudWheelPunctureProbability.Size = new System.Drawing.Size(130, 20);
            this.nudWheelPunctureProbability.TabIndex = 9;
            this.nudWheelPunctureProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nudVehicleSpeed
            // 
            this.nudVehicleSpeed.Location = new System.Drawing.Point(19, 125);
            this.nudVehicleSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVehicleSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVehicleSpeed.Name = "nudVehicleSpeed";
            this.nudVehicleSpeed.Size = new System.Drawing.Size(130, 20);
            this.nudVehicleSpeed.TabIndex = 8;
            this.nudVehicleSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цвет";
            // 
            // cbVehicleColors
            // 
            this.cbVehicleColors.FormattingEnabled = true;
            this.cbVehicleColors.Location = new System.Drawing.Point(19, 79);
            this.cbVehicleColors.Name = "cbVehicleColors";
            this.cbVehicleColors.Size = new System.Drawing.Size(130, 21);
            this.cbVehicleColors.TabIndex = 6;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(36, 269);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(135, 29);
            this.btnAddVehicle.TabIndex = 5;
            this.btnAddVehicle.Text = "Добавить ТС";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnRemoveVehicle
            // 
            this.btnRemoveVehicle.Location = new System.Drawing.Point(61, 310);
            this.btnRemoveVehicle.Name = "btnRemoveVehicle";
            this.btnRemoveVehicle.Size = new System.Drawing.Size(135, 29);
            this.btnRemoveVehicle.TabIndex = 6;
            this.btnRemoveVehicle.Text = "Удалить ТС";
            this.btnRemoveVehicle.UseVisualStyleBackColor = true;
            this.btnRemoveVehicle.Click += new System.EventHandler(this.btnRemoveVehicle_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(766, 576);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(135, 29);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Начать гонку!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbRacingStats
            // 
            this.tbRacingStats.Location = new System.Drawing.Point(859, 627);
            this.tbRacingStats.Multiline = true;
            this.tbRacingStats.Name = "tbRacingStats";
            this.tbRacingStats.ReadOnly = true;
            this.tbRacingStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRacingStats.Size = new System.Drawing.Size(476, 254);
            this.tbRacingStats.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(377, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(958, 545);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSimulationSpeed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudMaxTimeToChangeWheel);
            this.groupBox2.Controls.Add(this.nudMinTimeToChangeWheel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudDistance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(25, 685);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 212);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры моделирования";
            // 
            // nudMaxTimeToChangeWheel
            // 
            this.nudMaxTimeToChangeWheel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxTimeToChangeWheel.Location = new System.Drawing.Point(98, 112);
            this.nudMaxTimeToChangeWheel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxTimeToChangeWheel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxTimeToChangeWheel.Name = "nudMaxTimeToChangeWheel";
            this.nudMaxTimeToChangeWheel.Size = new System.Drawing.Size(73, 20);
            this.nudMaxTimeToChangeWheel.TabIndex = 14;
            this.nudMaxTimeToChangeWheel.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMaxTimeToChangeWheel.ValueChanged += new System.EventHandler(this.TimeToChangeWheel_ValueChanged);
            // 
            // nudMinTimeToChangeWheel
            // 
            this.nudMinTimeToChangeWheel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinTimeToChangeWheel.Location = new System.Drawing.Point(16, 112);
            this.nudMinTimeToChangeWheel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinTimeToChangeWheel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinTimeToChangeWheel.Name = "nudMinTimeToChangeWheel";
            this.nudMinTimeToChangeWheel.Size = new System.Drawing.Size(73, 20);
            this.nudMinTimeToChangeWheel.TabIndex = 13;
            this.nudMinTimeToChangeWheel.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudMinTimeToChangeWheel.ValueChanged += new System.EventHandler(this.TimeToChangeWheel_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Минимальное и максимальное \r\nколичество едениц времени, \r\nкоторое уйдет на замену" +
    " колеса\r\n";
            // 
            // nudDistance
            // 
            this.nudDistance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDistance.Location = new System.Drawing.Point(16, 36);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDistance.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(120, 20);
            this.nudDistance.TabIndex = 12;
            this.nudDistance.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDistance.ValueChanged += new System.EventHandler(this.nudDistance_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дистанция круга";
            // 
            // nudSimulationSpeed
            // 
            this.nudSimulationSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSimulationSpeed.Location = new System.Drawing.Point(16, 173);
            this.nudSimulationSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSimulationSpeed.Name = "nudSimulationSpeed";
            this.nudSimulationSpeed.Size = new System.Drawing.Size(120, 20);
            this.nudSimulationSpeed.TabIndex = 16;
            this.nudSimulationSpeed.ValueChanged += new System.EventHandler(this.nudSimulationSpeed_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Коэффициент замедления \r\nскорости моделирования, %";
            // 
            // tbVehiclesStats
            // 
            this.tbVehiclesStats.Location = new System.Drawing.Point(377, 627);
            this.tbVehiclesStats.Multiline = true;
            this.tbVehiclesStats.Name = "tbVehiclesStats";
            this.tbVehiclesStats.ReadOnly = true;
            this.tbVehiclesStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVehiclesStats.Size = new System.Drawing.Size(476, 254);
            this.tbVehiclesStats.TabIndex = 11;
            // 
            // nudPeopleCount
            // 
            this.nudPeopleCount.Location = new System.Drawing.Point(19, 230);
            this.nudPeopleCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPeopleCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeopleCount.Name = "nudPeopleCount";
            this.nudPeopleCount.Size = new System.Drawing.Size(130, 20);
            this.nudPeopleCount.TabIndex = 12;
            this.nudPeopleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCargoWeight
            // 
            this.nudCargoWeight.Location = new System.Drawing.Point(19, 230);
            this.nudCargoWeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCargoWeight.Name = "nudCargoWeight";
            this.nudCargoWeight.Size = new System.Drawing.Size(130, 20);
            this.nudCargoWeight.TabIndex = 13;
            this.nudCargoWeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbSidecarAvailability
            // 
            this.cbSidecarAvailability.AutoSize = true;
            this.cbSidecarAvailability.Location = new System.Drawing.Point(40, 231);
            this.cbSidecarAvailability.Name = "cbSidecarAvailability";
            this.cbSidecarAvailability.Size = new System.Drawing.Size(114, 17);
            this.cbSidecarAvailability.TabIndex = 14;
            this.cbSidecarAvailability.Text = "Наличие коляски";
            this.cbSidecarAvailability.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дополнительный параметр";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 909);
            this.Controls.Add(this.tbVehiclesStats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbRacingStats);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveVehicle);
            this.Controls.Add(this.lbVehicles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Симулятор гонок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelPunctureProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTimeToChangeWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTimeToChangeWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulationSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeopleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargoWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWheelPunctureProbability;
        private System.Windows.Forms.NumericUpDown nudVehicleSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVehicleColors;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnRemoveVehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVehicleTypes;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbRacingStats;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.NumericUpDown nudMaxTimeToChangeWheel;
        private System.Windows.Forms.NumericUpDown nudMinTimeToChangeWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSimulationSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVehiclesStats;
        private System.Windows.Forms.CheckBox cbSidecarAvailability;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPeopleCount;
        private System.Windows.Forms.NumericUpDown nudCargoWeight;
    }
}

