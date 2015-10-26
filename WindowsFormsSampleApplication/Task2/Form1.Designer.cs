namespace Task2
{
    partial class meltedStringForm
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
            this.components = new System.ComponentModel.Container();
            this.stringContainerLabel = new System.Windows.Forms.Label();
            this.catTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stringContainerLabel
            // 
            this.stringContainerLabel.AutoSize = true;
            this.stringContainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringContainerLabel.Location = new System.Drawing.Point(12, 9);
            this.stringContainerLabel.Name = "stringContainerLabel";
            this.stringContainerLabel.Size = new System.Drawing.Size(407, 63);
            this.stringContainerLabel.TabIndex = 0;
            this.stringContainerLabel.Text = "Чеширский кот";
            // 
            // catTimer
            // 
            this.catTimer.Tick += new System.EventHandler(this.catTimer_Tick);
            // 
            // meltedStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 87);
            this.Controls.Add(this.stringContainerLabel);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Name = "meltedStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Растаявшая надпись";
            this.Load += new System.EventHandler(this.meltedStringForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringContainerLabel;
        private System.Windows.Forms.Timer catTimer;
    }
}

