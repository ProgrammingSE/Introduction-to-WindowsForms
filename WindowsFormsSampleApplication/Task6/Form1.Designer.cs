﻿namespace Task6
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите натуральное число: ";
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(60, 33);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(245, 20);
            this.enterNumberTextBox.TabIndex = 1;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(60, 59);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(245, 30);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Разместить цифры по убыванию";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 94);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Упорядочить цифры числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Button sortButton;
    }
}

