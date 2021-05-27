namespace Employee
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
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxListEmpl = new System.Windows.Forms.GroupBox();
            this.listBoxListEmpl = new System.Windows.Forms.ListBox();
            this.groupBoxListEmpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 29);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(13, 77);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "Зарплата";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(8, 122);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Должность";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(31, 170);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "Город";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(74, 29);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(74, 74);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 5;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Программист",
            "Менеджер",
            "Администратор",
            "Директор"});
            this.comboBoxPosition.Location = new System.Drawing.Point(74, 122);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 6;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Ростов-на-Дону",
            "Москва",
            "Воронеж",
            "Казань",
            "Санкт-Петербург"});
            this.comboBoxCity.Location = new System.Drawing.Point(74, 167);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 33);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(120, 231);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxListEmpl
            // 
            this.groupBoxListEmpl.Controls.Add(this.listBoxListEmpl);
            this.groupBoxListEmpl.Location = new System.Drawing.Point(223, 12);
            this.groupBoxListEmpl.Name = "groupBoxListEmpl";
            this.groupBoxListEmpl.Size = new System.Drawing.Size(238, 288);
            this.groupBoxListEmpl.TabIndex = 10;
            this.groupBoxListEmpl.TabStop = false;
            this.groupBoxListEmpl.Text = "Список соттрудников";
            // 
            // listBoxListEmpl
            // 
            this.listBoxListEmpl.FormattingEnabled = true;
            this.listBoxListEmpl.Items.AddRange(new object[] {
            "Воронина\t",
            "Соколов",
            ""});
            this.listBoxListEmpl.Location = new System.Drawing.Point(16, 28);
            this.listBoxListEmpl.Name = "listBoxListEmpl";
            this.listBoxListEmpl.Size = new System.Drawing.Size(205, 238);
            this.listBoxListEmpl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 352);
            this.Controls.Add(this.groupBoxListEmpl);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxListEmpl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxListEmpl;
        private System.Windows.Forms.ListBox listBoxListEmpl;
    }
}

