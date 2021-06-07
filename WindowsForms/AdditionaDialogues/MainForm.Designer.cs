namespace AdditionaDialogues
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxGoods = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.buttonAdd);
            this.panel.Controls.Add(this.buttonDel);
            this.panel.Controls.Add(this.buttonEdit);
            this.panel.Controls.Add(this.buttonClear);
            this.panel.Controls.Add(this.listBoxGoods);
            this.panel.Location = new System.Drawing.Point(0, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(483, 559);
            this.panel.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(0, 459);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(483, 26);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDel.Location = new System.Drawing.Point(0, 485);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(483, 23);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEdit.Location = new System.Drawing.Point(0, 508);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(483, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(0, 531);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(483, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxGoods
            // 
            this.listBoxGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGoods.FormattingEnabled = true;
            this.listBoxGoods.ItemHeight = 21;
            this.listBoxGoods.Location = new System.Drawing.Point(0, 0);
            this.listBoxGoods.Name = "listBoxGoods";
            this.listBoxGoods.Size = new System.Drawing.Size(483, 466);
            this.listBoxGoods.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.panel);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог товаров";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxGoods;
    }
}

