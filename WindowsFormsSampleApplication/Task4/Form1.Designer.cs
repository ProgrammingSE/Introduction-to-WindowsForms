namespace Task4
{
    partial class ListBoxForm
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
            this.linesShowerListBox = new System.Windows.Forms.ListBox();
            this.deleteChosenElementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showInitialListButton
            // 
            this.showInitialListButton.Location = new System.Drawing.Point(12, 12);
            this.showInitialListButton.Name = "showInitialListButton";
            this.showInitialListButton.Size = new System.Drawing.Size(311, 52);
            this.showInitialListButton.TabIndex = 0;
            this.showInitialListButton.Text = "Отобразить изначальный список";
            this.showInitialListButton.UseVisualStyleBackColor = true;
            this.showInitialListButton.Click += new System.EventHandler(this.showInitialListButton_Click);
            // 
            // linesShowerListBox
            // 
            this.linesShowerListBox.FormattingEnabled = true;
            this.linesShowerListBox.Location = new System.Drawing.Point(12, 70);
            this.linesShowerListBox.Name = "linesShowerListBox";
            this.linesShowerListBox.Size = new System.Drawing.Size(311, 160);
            this.linesShowerListBox.TabIndex = 1;
            // 
            // deleteChosenElementButton
            // 
            this.deleteChosenElementButton.Location = new System.Drawing.Point(12, 241);
            this.deleteChosenElementButton.Name = "deleteChosenElementButton";
            this.deleteChosenElementButton.Size = new System.Drawing.Size(311, 52);
            this.deleteChosenElementButton.TabIndex = 2;
            this.deleteChosenElementButton.Text = "Удалить выбранный элемент";
            this.deleteChosenElementButton.UseVisualStyleBackColor = true;
            this.deleteChosenElementButton.Click += new System.EventHandler(this.deleteChosenElementButton_Click);
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Controls.Add(this.deleteChosenElementButton);
            this.Controls.Add(this.linesShowerListBox);
            this.Controls.Add(this.showInitialListButton);
            this.Name = "ListBoxForm";
            this.Text = "Работаю со списком!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showInitialListButton;
        private System.Windows.Forms.ListBox linesShowerListBox;
        private System.Windows.Forms.Button deleteChosenElementButton;
    }
}

