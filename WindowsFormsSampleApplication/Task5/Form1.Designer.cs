namespace Task5
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
            this.showInitialListButton = new System.Windows.Forms.Button();
            this.linesTextBox = new System.Windows.Forms.TextBox();
            this.showModifiedListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showInitialListButton
            // 
            this.showInitialListButton.Location = new System.Drawing.Point(12, 12);
            this.showInitialListButton.Name = "showInitialListButton";
            this.showInitialListButton.Size = new System.Drawing.Size(260, 62);
            this.showInitialListButton.TabIndex = 0;
            this.showInitialListButton.Text = "Вывести исходный список";
            this.showInitialListButton.UseVisualStyleBackColor = true;
            this.showInitialListButton.Click += new System.EventHandler(this.showInitialListButton_Click);
            // 
            // linesTextBox
            // 
            this.linesTextBox.Location = new System.Drawing.Point(12, 80);
            this.linesTextBox.Multiline = true;
            this.linesTextBox.Name = "linesTextBox";
            this.linesTextBox.Size = new System.Drawing.Size(260, 101);
            this.linesTextBox.TabIndex = 1;
            // 
            // showModifiedListButton
            // 
            this.showModifiedListButton.Location = new System.Drawing.Point(12, 187);
            this.showModifiedListButton.Name = "showModifiedListButton";
            this.showModifiedListButton.Size = new System.Drawing.Size(260, 62);
            this.showModifiedListButton.TabIndex = 2;
            this.showModifiedListButton.Text = "Показать измененный список";
            this.showModifiedListButton.UseVisualStyleBackColor = true;
            this.showModifiedListButton.Click += new System.EventHandler(this.showModifiedListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showModifiedListButton);
            this.Controls.Add(this.linesTextBox);
            this.Controls.Add(this.showInitialListButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showInitialListButton;
        private System.Windows.Forms.TextBox linesTextBox;
        private System.Windows.Forms.Button showModifiedListButton;
    }
}

