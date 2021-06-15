namespace GDI_Menu
{
    partial class LineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цвет";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(78, 238);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(322, 45);
            this.trackBarBlue.TabIndex = 12;
            this.trackBarBlue.TickFrequency = 10;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(78, 175);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(322, 45);
            this.trackBarGreen.TabIndex = 11;
            this.trackBarGreen.TickFrequency = 10;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(78, 106);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(322, 45);
            this.trackBarRed.TabIndex = 10;
            this.trackBarRed.TickFrequency = 10;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Синий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Зеленый";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Красный";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(78, 45);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(322, 20);
            this.textBoxColor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Толщина";
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(78, 340);
            this.trackBarThickness.Maximum = 255;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(322, 45);
            this.trackBarThickness.TabIndex = 15;
            this.trackBarThickness.TickFrequency = 10;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(23, 431);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(98, 42);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(291, 431);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 42);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 513);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "LineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка линии";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}