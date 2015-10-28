using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        // Массив-образец цифр сделаем статическим:
        static string sample = "0123456789";
        static char[] temp = sample.ToCharArray();
       
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (enterNumberTextBox.Text.IndexOfAny(temp) == -1)
            {
                // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Не введены цифры!");
                enterNumberTextBox.Focus();   // установить фокус ввода
                return;
            }
            string number = enterNumberTextBox.Text;
            number.Trim();                             // убираем пробелы 
            int t = 0;	                               // вспомогательная переменная
            foreach (char ch in number)
                t = Math.Min(sample.IndexOf(ch), t);
            if (t == -1)
            {
                // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Это не натуральное число!");
                enterNumberTextBox.Focus();   // установить фокус ввода
                return;
            }
            char[] arNumb = number.ToCharArray();	        // массив из строки
            Array.Sort(arNumb);		                        // сортировка по возрастанию
            Array.Reverse(arNumb);			                // реверсирование
            enterNumberTextBox.Text = new string(arNumb);	// из массива в строку

        }
    }
}
