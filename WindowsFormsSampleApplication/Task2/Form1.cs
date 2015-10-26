using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class meltedStringForm : Form
    {
        public meltedStringForm()
        {
            InitializeComponent();
        }
        // Шаг измерения прозрачности изображения формы
        double timerStep;    

        // Обработчик тика
        private void catTimer_Tick(object sender, EventArgs e)
        {
            if (timerStep > 0)
            {
                // Временное значение 
                string temp = stringContainerLabel.Text;
                if (temp.Length > 0)
                    stringContainerLabel.Text = temp.Substring(0, temp.Length - 1);
                else
                {
                    if (this.Opacity > 0)
                        this.Opacity = this.Opacity - timerStep;
                    else
                    {
                        stringContainerLabel.Text = "Кот уже ушел!";
                        timerStep = -timerStep;
                    }
                }
            }
            else    // Здесь шаг отрицательный
                this.Opacity = this.Opacity - timerStep;

        }

        // Обработчик события Load для формы
        private void meltedStringForm_Load(object sender, EventArgs e)
        {
            timerStep = 0.1;
            catTimer.Enabled = true;    // Запуск таймера
        }
    }
}
