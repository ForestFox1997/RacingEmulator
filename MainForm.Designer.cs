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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelPunctureProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSpeed)).BeginInit();
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
            this.lbVehicles.Size = new System.Drawing.Size(206, 264);
            this.lbVehicles.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbVehicleTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudWheelPunctureProbability);
            this.groupBox1.Controls.Add(this.nudVehicleSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbVehicleColors);
            this.groupBox1.Controls.Add(this.btnAddVehicle);
            this.groupBox1.Location = new System.Drawing.Point(25, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 283);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вероятность прокола шин";
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
            1,
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
            this.btnAddVehicle.Location = new System.Drawing.Point(36, 218);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(135, 29);
            this.btnAddVehicle.TabIndex = 5;
            this.btnAddVehicle.Text = "Добавить ТС";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnRemoveVehicle
            // 
            this.btnRemoveVehicle.Location = new System.Drawing.Point(61, 307);
            this.btnRemoveVehicle.Name = "btnRemoveVehicle";
            this.btnRemoveVehicle.Size = new System.Drawing.Size(135, 29);
            this.btnRemoveVehicle.TabIndex = 6;
            this.btnRemoveVehicle.Text = "Удалить ТС";
            this.btnRemoveVehicle.UseVisualStyleBackColor = true;
            this.btnRemoveVehicle.Click += new System.EventHandler(this.btnRemoveVehicle_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(497, 130);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(135, 29);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "поїхали";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 336);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Для вывода результатов!\r\n\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 696);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveVehicle);
            this.Controls.Add(this.lbVehicles);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelPunctureProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSpeed)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

