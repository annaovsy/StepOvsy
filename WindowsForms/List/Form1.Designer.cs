namespace List
{
    partial class FormList
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
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxCarCopy = new System.Windows.Forms.ListBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkedListBoxName = new System.Windows.Forms.CheckedListBox();
            this.buttonDelChecked = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Items.AddRange(new object[] {
            "Audi",
            "Mersedes"});
            this.listBoxCar.Location = new System.Drawing.Point(26, 27);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCar.Size = new System.Drawing.Size(207, 186);
            this.listBoxCar.TabIndex = 0;
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(26, 246);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(207, 20);
            this.textBoxCar.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(60, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(60, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxCarCopy
            // 
            this.listBoxCarCopy.FormattingEnabled = true;
            this.listBoxCarCopy.Location = new System.Drawing.Point(269, 27);
            this.listBoxCarCopy.Name = "listBoxCarCopy";
            this.listBoxCarCopy.Size = new System.Drawing.Size(170, 186);
            this.listBoxCarCopy.TabIndex = 4;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(60, 423);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(125, 37);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkedListBoxName
            // 
            this.checkedListBoxName.CheckOnClick = true;
            this.checkedListBoxName.FormattingEnabled = true;
            this.checkedListBoxName.Items.AddRange(new object[] {
            "Маша",
            "Петя",
            "Вася",
            "Катя",
            "Вера"});
            this.checkedListBoxName.Location = new System.Drawing.Point(482, 27);
            this.checkedListBoxName.Name = "checkedListBoxName";
            this.checkedListBoxName.Size = new System.Drawing.Size(166, 184);
            this.checkedListBoxName.TabIndex = 6;
            // 
            // buttonDelChecked
            // 
            this.buttonDelChecked.Location = new System.Drawing.Point(516, 246);
            this.buttonDelChecked.Name = "buttonDelChecked";
            this.buttonDelChecked.Size = new System.Drawing.Size(101, 47);
            this.buttonDelChecked.TabIndex = 7;
            this.buttonDelChecked.Text = "Удалить";
            this.buttonDelChecked.UseVisualStyleBackColor = true;
            this.buttonDelChecked.Click += new System.EventHandler(this.buttonDelChecked_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Маша",
            "Вася",
            "Петя",
            "Катя",
            "Вера"});
            this.comboBox1.Location = new System.Drawing.Point(289, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDelChecked);
            this.Controls.Add(this.checkedListBoxName);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.listBoxCarCopy);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.listBoxCar);
            this.Name = "FormList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxCarCopy;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckedListBox checkedListBoxName;
        private System.Windows.Forms.Button buttonDelChecked;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

