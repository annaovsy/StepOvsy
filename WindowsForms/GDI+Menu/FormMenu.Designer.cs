namespace GDI_Menu
{
    partial class FormMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SquareSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линияToolStripMenuItem,
            this.квадратToolStripMenuItem,
            this.toolStripMenuItem1,
            this.прямоугольникToolStripMenuItem,
            this.треугольникToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(687, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineSetupToolStripMenuItem});
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.линияToolStripMenuItem.Text = "Линия";
            // 
            // LineSetupToolStripMenuItem
            // 
            this.LineSetupToolStripMenuItem.Name = "LineSetupToolStripMenuItem";
            this.LineSetupToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.LineSetupToolStripMenuItem.Text = "Настройка";
            this.LineSetupToolStripMenuItem.Click += new System.EventHandler(this.tuningToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SquareSettingToolStripMenuItem});
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            // 
            // SquareSettingToolStripMenuItem
            // 
            this.SquareSettingToolStripMenuItem.Name = "SquareSettingToolStripMenuItem";
            this.SquareSettingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SquareSettingToolStripMenuItem.Text = "Настройка";
            this.SquareSettingToolStripMenuItem.Click += new System.EventHandler(this.SquareSettingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingRectangleToolStripMenuItem});
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            // 
            // SettingRectangleToolStripMenuItem
            // 
            this.SettingRectangleToolStripMenuItem.Name = "SettingRectangleToolStripMenuItem";
            this.SettingRectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SettingRectangleToolStripMenuItem.Text = "Настройка";
            this.SettingRectangleToolStripMenuItem.Click += new System.EventHandler(this.SettingRectangleToolStripMenuItem_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingTriangleToolStripMenuItem});
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            // 
            // SettingTriangleToolStripMenuItem
            // 
            this.SettingTriangleToolStripMenuItem.Name = "SettingTriangleToolStripMenuItem";
            this.SettingTriangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SettingTriangleToolStripMenuItem.Text = "Настройка";
            this.SettingTriangleToolStripMenuItem.Click += new System.EventHandler(this.SettingTriangleToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 554);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SquareSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingTriangleToolStripMenuItem;
    }
}

