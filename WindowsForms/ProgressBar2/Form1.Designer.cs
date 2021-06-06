namespace ProgressBar2
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
            this.textBoxCatalog = new System.Windows.Forms.TextBox();
            this.labelVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.progressBarTemp = new System.Windows.Forms.ProgressBar();
            this.textBoxCatalogCopy = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBoxCopy = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCatalog
            // 
            this.textBoxCatalog.Location = new System.Drawing.Point(81, 44);
            this.textBoxCatalog.Name = "textBoxCatalog";
            this.textBoxCatalog.Size = new System.Drawing.Size(153, 20);
            this.textBoxCatalog.TabIndex = 0;
            this.textBoxCatalog.Text = "E:\\";
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Location = new System.Drawing.Point(141, 330);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(29, 13);
            this.labelVal.TabIndex = 7;
            this.labelVal.Text = "Step";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Value";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(258, 169);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(52, 35);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = ">>";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // progressBarTemp
            // 
            this.progressBarTemp.Location = new System.Drawing.Point(107, 360);
            this.progressBarTemp.Name = "progressBarTemp";
            this.progressBarTemp.Size = new System.Drawing.Size(366, 23);
            this.progressBarTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTemp.TabIndex = 4;
            this.progressBarTemp.Value = 10;
            // 
            // textBoxCatalogCopy
            // 
            this.textBoxCatalogCopy.Location = new System.Drawing.Point(329, 44);
            this.textBoxCatalogCopy.Name = "textBoxCatalogCopy";
            this.textBoxCatalogCopy.Size = new System.Drawing.Size(153, 20);
            this.textBoxCatalogCopy.TabIndex = 8;
            this.textBoxCatalogCopy.Text = "C:\\Users";
            this.textBoxCatalogCopy.TextChanged += new System.EventHandler(this.textBoxCatalogCopy_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(81, 91);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(153, 212);
            this.listBox.TabIndex = 9;
            // 
            // listBoxCopy
            // 
            this.listBoxCopy.FormattingEnabled = true;
            this.listBoxCopy.HorizontalScrollbar = true;
            this.listBoxCopy.Location = new System.Drawing.Point(329, 91);
            this.listBoxCopy.Name = "listBoxCopy";
            this.listBoxCopy.Size = new System.Drawing.Size(153, 212);
            this.listBoxCopy.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBoxCopy);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxCatalogCopy);
            this.Controls.Add(this.labelVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.progressBarTemp);
            this.Controls.Add(this.textBoxCatalog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCatalog;
        private System.Windows.Forms.Label labelVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ProgressBar progressBarTemp;
        private System.Windows.Forms.TextBox textBoxCatalogCopy;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBoxCopy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

