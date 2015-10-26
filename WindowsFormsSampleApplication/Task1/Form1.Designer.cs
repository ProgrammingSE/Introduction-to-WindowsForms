namespace Task1
{
    partial class buttonHiderForm
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
            this.upperButton = new System.Windows.Forms.Button();
            this.lowerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperButton
            // 
            this.upperButton.Location = new System.Drawing.Point(12, 30);
            this.upperButton.Name = "upperButton";
            this.upperButton.Size = new System.Drawing.Size(260, 89);
            this.upperButton.TabIndex = 0;
            this.upperButton.Text = "Нажми!";
            this.upperButton.UseVisualStyleBackColor = true;
            this.upperButton.Click += new System.EventHandler(this.upperButton_Click);
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(12, 145);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(260, 104);
            this.lowerButton.TabIndex = 1;
            this.lowerButton.Text = "Нажми!";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // buttonHiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.upperButton);
            this.Name = "buttonHiderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Где кнопки?";
            this.Load += new System.EventHandler(this.buttonHiderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upperButton;
        private System.Windows.Forms.Button lowerButton;
    }
}

