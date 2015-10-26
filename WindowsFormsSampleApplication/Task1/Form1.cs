using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class buttonHiderForm : Form
    {
        public buttonHiderForm()
        {
            InitializeComponent();
        }

        // Обработчик клика на верхнюю кнопку
        private void upperButton_Click(object sender, EventArgs e)
        {
            lowerButton.Visible = true;     // Спрятанную кнопку показываем
            upperButton.Visible = false;    // Кликнутую кнопку скрываем
        }

        // Обработчик клика на нижнюю кнопку
        private void lowerButton_Click(object sender, EventArgs e)
        {
            upperButton.Visible = true;     // Спрятанную кнопку показываем
            lowerButton.Visible = false;    // Кликнутую кнопку скрывает
        }

        // Обработчик Load
        private void buttonHiderForm_Load(object sender, EventArgs e)
        {
            lowerButton.Visible = false;    // Скрываем одну из кнопок
        }
    }
}
