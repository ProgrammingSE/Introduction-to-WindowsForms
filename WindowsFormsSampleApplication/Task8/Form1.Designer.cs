namespace Task8
{
    partial class Form1
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
            this.controlButton = new System.Windows.Forms.Button();
            this.buttonInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(12, 206);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(141, 43);
            this.controlButton.TabIndex = 0;
            this.controlButton.Text = "Программная кнопка";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // buttonInfoLabel
            // 
            this.buttonInfoLabel.AutoSize = true;
            this.buttonInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.buttonInfoLabel.Name = "buttonInfoLabel";
            this.buttonInfoLabel.Size = new System.Drawing.Size(126, 13);
            this.buttonInfoLabel.TabIndex = 1;
            this.buttonInfoLabel.Text = "Информация о кнопках";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonInfoLabel);
            this.Controls.Add(this.controlButton);
            this.Name = "Form1";
            this.Text = "Программная кнопка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label buttonInfoLabel;
    }
}

