﻿namespace ProgressBar
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
            this.progressBarTemp.Location = new System.Drawing.Point(64, 80);
            this.progressBarTemp.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarTemp.Name = "progressBarTemp";
            this.progressBarTemp.Size = new System.Drawing.Size(488, 28);
            this.progressBarTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTemp.TabIndex = 0;
            this.progressBarTemp.Value = 10;
            // 
            // buttonProgress
            // 
            this.buttonProgress.Location = new System.Drawing.Point(64, 198);
            this.buttonProgress.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(149, 62);
            this.buttonProgress.TabIndex = 1;
            this.buttonProgress.Text = "Старт";
            this.buttonProgress.UseVisualStyleBackColor = true;
            this.buttonProgress.Click += new System.EventHandler(this.buttonProgress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Location = new System.Drawing.Point(129, 153);
            this.labelVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(37, 17);
            this.labelVal.TabIndex = 3;
            this.labelVal.Text = "Step";
            this.labelVal.Click += new System.EventHandler(this.labelVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 321);
            this.Controls.Add(this.labelVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.progressBarTemp);
            this.Margin = new System.Windows.Forms.Padding(4);
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
