namespace AdditionalForm
{
    partial class FormChild
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
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCencel
            // 
            this.buttonCencel.Location = new System.Drawing.Point(299, 118);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(161, 46);
            this.buttonCencel.TabIndex = 3;
            this.buttonCencel.Text = "Cencel";
            this.buttonCencel.UseVisualStyleBackColor = true;
            this.buttonCencel.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(59, 52);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(333, 20);
            this.textBoxMessage.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(46, 118);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(161, 46);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 245);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "FormChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дочерняя форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonOk;
    }
}