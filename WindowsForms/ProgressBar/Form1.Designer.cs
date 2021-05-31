namespace ProgressBar
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
            this.progressBarTemp = new System.Windows.Forms.ProgressBar();
            this.buttonProgress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarTemp
            // 
            this.progressBarTemp.Location = new System.Drawing.Point(48, 65);
            this.progressBarTemp.Name = "progressBarTemp";
            this.progressBarTemp.Size = new System.Drawing.Size(366, 23);
            this.progressBarTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTemp.TabIndex = 0;
            this.progressBarTemp.Value = 10;
            // 
            // buttonProgress
            // 
            this.buttonProgress.Location = new System.Drawing.Point(48, 161);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(112, 50);
            this.buttonProgress.TabIndex = 1;
            this.buttonProgress.Text = "Старт";
            this.buttonProgress.UseVisualStyleBackColor = true;
            this.buttonProgress.Click += new System.EventHandler(this.buttonProgress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Location = new System.Drawing.Point(97, 124);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(29, 13);
            this.labelVal.TabIndex = 3;
            this.labelVal.Text = "Step";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.labelVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.progressBarTemp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarTemp;
        private System.Windows.Forms.Button buttonProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVal;
    }
}

