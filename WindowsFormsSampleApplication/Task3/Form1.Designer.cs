namespace Task3
{
    partial class PellaSequenceForm
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
            this.numShowerLabel = new System.Windows.Forms.Label();
            this.generateNextNumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numShowerLabel
            // 
            this.numShowerLabel.AutoSize = true;
            this.numShowerLabel.Location = new System.Drawing.Point(12, 9);
            this.numShowerLabel.Name = "numShowerLabel";
            this.numShowerLabel.Size = new System.Drawing.Size(151, 13);
            this.numShowerLabel.TabIndex = 0;
            this.numShowerLabel.Text = "Члены ряда Пелла будут тут";
            // 
            // generateNextNumBtn
            // 
            this.generateNextNumBtn.Location = new System.Drawing.Point(198, 3);
            this.generateNextNumBtn.Name = "generateNextNumBtn";
            this.generateNextNumBtn.Size = new System.Drawing.Size(128, 52);
            this.generateNextNumBtn.TabIndex = 1;
            this.generateNextNumBtn.Text = "Следующий член ряда";
            this.generateNextNumBtn.UseVisualStyleBackColor = true;
            this.generateNextNumBtn.Click += new System.EventHandler(this.generateNextNumBtn_Click);
            // 
            // PellaSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 67);
            this.Controls.Add(this.generateNextNumBtn);
            this.Controls.Add(this.numShowerLabel);
            this.Name = "PellaSequenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вывод членов ряда Пелла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numShowerLabel;
        private System.Windows.Forms.Button generateNextNumBtn;
    }
}

