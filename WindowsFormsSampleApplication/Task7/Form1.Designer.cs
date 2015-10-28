namespace Task7
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
            this.decreaseFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decreaseFormButton
            // 
            this.decreaseFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decreaseFormButton.Location = new System.Drawing.Point(109, 94);
            this.decreaseFormButton.Name = "decreaseFormButton";
            this.decreaseFormButton.Size = new System.Drawing.Size(200, 30);
            this.decreaseFormButton.TabIndex = 0;
            this.decreaseFormButton.Text = "Уменьшить форму";
            this.decreaseFormButton.UseVisualStyleBackColor = true;
            this.decreaseFormButton.Click += new System.EventHandler(this.decreaseFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.decreaseFormButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение размеров формы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button decreaseFormButton;
    }
}

