using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            // Скрываем кнопку отображения отредактированного варианта
            showModifiedListButton.Visible = false;
        }

        string[] linesToShow = { "cat", "dog", "skate", "fog", "frog", "water" };

        private void showInitialListButton_Click(object sender, EventArgs e)
        {
            linesTextBox.Lines = linesToShow;
            showModifiedListButton.Visible = true;
        }

        private void showModifiedListButton_Click(object sender, EventArgs e)
        {
            string result = String.Join(" ", linesTextBox.Lines);
            MessageBox.Show("Результат изменений:\n" + result);
        }
    }
}
