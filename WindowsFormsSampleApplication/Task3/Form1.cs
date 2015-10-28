using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class PellaSequenceForm : Form
    {
        public PellaSequenceForm()
        {
            InitializeComponent();
        }

        int old = 1;    // Предыдущий элемент ряда
        int last = 0;   // Последний член ряда

        // Для того, чтобы в лейбле текст был читабельным
        const string PELLA_NUMBER = "Член ряда Пелла: ";

        // Обработчик клика на кнопку, генерирующую следующий член ряда
        private void generateNextNumBtn_Click(object sender, EventArgs e)
        {
            // Проверка переполнения
            bool isCrowded = old > int.MaxValue - last * 2;

            if (isCrowded)
            {
                // Если произошло переполнение -> вывод сообщения об ошибке
                MessageBox.Show("Переполнение \n Начинаем ряд сначала!");
                last = 0;
                old = 1;
            }

            // Рассчет текущего члена ряда
            int currentNumber = old + 2 * last; 
            old = last; last = currentNumber;

            // Вывод члена в лейбл
            numShowerLabel.Text = PELLA_NUMBER + currentNumber.ToString();
        }
    }
}
