namespace Lesson5
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonData = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelCurrentDataArrival = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentDataDeparture = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberofdays = new System.Windows.Forms.Label();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.monthCalendarBirthday = new System.Windows.Forms.MonthCalendar();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(117, 57);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(138, 42);
            this.buttonData.TabIndex = 1;
            this.buttonData.Text = "Выбрать дату";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(95, 146);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(72, 13);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Дата заезда";
            // 
            // labelCurrentDataArrival
            // 
            this.labelCurrentDataArrival.AutoSize = true;
            this.labelCurrentDataArrival.Location = new System.Drawing.Point(194, 146);
            this.labelCurrentDataArrival.Name = "labelCurrentDataArrival";
            this.labelCurrentDataArrival.Size = new System.Drawing.Size(61, 13);
            this.labelCurrentDataArrival.TabIndex = 3;
            this.labelCurrentDataArrival.Text = "24.05.2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата выезда";
            // 
            // labelCurrentDataDeparture
            // 
            this.labelCurrentDataDeparture.AutoSize = true;
            this.labelCurrentDataDeparture.Location = new System.Drawing.Point(194, 218);
            this.labelCurrentDataDeparture.Name = "labelCurrentDataDeparture";
            this.labelCurrentDataDeparture.Size = new System.Drawing.Size(61, 13);
            this.labelCurrentDataDeparture.TabIndex = 5;
            this.labelCurrentDataDeparture.Text = "24.05.2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество дней:";
            // 
            // labelNumberofdays
            // 
            this.labelNumberofdays.AutoSize = true;
            this.labelNumberofdays.Location = new System.Drawing.Point(194, 275);
            this.labelNumberofdays.Name = "labelNumberofdays";
            this.labelNumberofdays.Size = new System.Drawing.Size(13, 13);
            this.labelNumberofdays.TabIndex = 7;
            this.labelNumberofdays.Text = "0";
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.Location = new System.Drawing.Point(82, 234);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDepart.TabIndex = 8;
            this.dateTimePickerDepart.ValueChanged += new System.EventHandler(this.dateTimePickerDepart_ValueChanged);
            // 
            // monthCalendarBirthday
            // 
            this.monthCalendarBirthday.Location = new System.Drawing.Point(218, 352);
            this.monthCalendarBirthday.Name = "monthCalendarBirthday";
            this.monthCalendarBirthday.TabIndex = 9;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(106, 352);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(100, 20);
            this.textBoxBirthday.TabIndex = 10;
            this.textBoxBirthday.Text = " ";
            this.textBoxBirthday.TextChanged += new System.EventHandler(this.textBoxBirthday_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата рождения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 586);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.monthCalendarBirthday);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Controls.Add(this.labelNumberofdays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentDataDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentDataArrival);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средство для выбора даты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelCurrentDataArrival;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentDataDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumberofdays;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.MonthCalendar monthCalendarBirthday;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Label label3;
    }
}

