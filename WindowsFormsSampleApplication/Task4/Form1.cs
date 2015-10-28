using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();

            // Задаем свойства формы
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Работаю со списком!";

            // Устанавливаем изначальные свойства элементов
            linesShowerListBox.Visible = false;
            deleteChosenElementButton.Visible = false;
        }

        // Поля объекта Form1
        string[] linesToShow = { "один", "два", "три", "четыре", "пять", "шесть" };
        string[] newLines = null;

        private void showInitialListButton_Click(object sender, EventArgs e)
        {
            // Показываем исходный список
            linesShowerListBox.Visible = true;
            linesShowerListBox.Items.Clear();               // Очищаем поле
            linesShowerListBox.Items.AddRange(linesToShow); // Помещаем строки
            newLines = linesToShow;                         // Запоминаем список
            deleteChosenElementButton.Visible = true;       // Отображаем кнопку удаления
        }

        private void deleteChosenElementButton_Click(object sender, EventArgs e)
        {
            // Удаляем выбранный элемент
            int n = linesShowerListBox.SelectedIndex;	// Номер выделенной строки
            
            // Если все плохо
            if (n == -1)
            {   // Выделенная строка отсутствует
                // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Список пуст или \nнет выделенного элемента!");
                return;
            }
		
            // Если все нормально
            // Весь нижний код можно заменить одной строчкой:
            // Разберитесь в том, как она работает! MSDN - в помощь
            // linesShowerListBox.Items.RemoveAt(n); 
            // Все это работает благодаря тому, что
            // linesShowerListBox.Items - коллекция
            string[] tempLines = new string[newLines.Length - 1];
            for (int k = 0, i = 0; i < newLines.Length; i++)
                if (i != n) tempLines[k++] = newLines[i];
            newLines = tempLines;
            linesShowerListBox.Items.Clear(); // очистить список
            linesShowerListBox.Items.AddRange(newLines);  // поместить строки в список
        }
    }
}
