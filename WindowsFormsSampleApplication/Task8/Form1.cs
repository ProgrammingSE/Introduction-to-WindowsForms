using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            // Получить текст, отображаемый на кнопке можно так:
            //label1.Text = Convert.ToString(sender);
            // получить текст, отображаемый на кнопке можно так:            	 
            // label1.Text = ((Button)sender).Text;
            var Кнопка = (Button)sender;
            buttonInfoLabel.Text = "";
            buttonInfoLabel.Text = "Нажата кнопка " + Кнопка.Text; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Кнопка = new Button();
            // Задаем свойства кнопки:
            Кнопка.Visible = true;
            // Ширина и высота кнопки:
            Кнопка.Size = new Size(150, 30);
            // Расположение кнопки в системе координат формы:
            Кнопка.Location = new Point(70, 80);
            Кнопка.Text = "Новая кнопка";
            // Добавление кнопки в коллекцию элементов управления
            this.Controls.Add(Кнопка);
            // Связываем событие Click с процедурой обработки этого события:
            Кнопка.Click += new EventHandler(controlButton_Click);
        }
    }
}
