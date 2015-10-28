using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size s = this.ClientSize;   // Размеры клиентской области

            // Размещение кнопки в клиентской области формы:
            decreaseFormButton.Location =
                new Point(s.Width / 2 - decreaseFormButton.Width / 2,
                s.Height / 2 - decreaseFormButton.Height / 2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        bool isGrowing = false;  // true – рост, false - уменьшение формы    

        private void decreaseFormButton_Click(object sender, EventArgs e)
        {
            int w = this.Size.Width;    // ширина формы
            int h = this.Size.Height;   // высота формы

            this.Location = new Point((this.MaximumSize.Width - w) / 2 + 20,
            (this.MaximumSize.Height - h) / 2 + 20); // новое положение формы

            if (!isGrowing)
                if (w > this.MinimumSize.Width || h > this.MinimumSize.Height)
                { 
                    this.Size = new Size(w / 3 * 2, h / 3 * 2); 
                    return; 
                }
                else
                { 
                    isGrowing = true; 
                    decreaseFormButton.Text = "Увеличить форму"; 
                }

            if (w < this.MaximumSize.Width || h < this.MaximumSize.Height)
            { 
                this.Size = new Size(w / 2 * 3, h / 2 * 3); 
                return; 
            }
            else
            {
                isGrowing = false; 
                decreaseFormButton.Text = "Уменьшить форму";
                this.Size = new Size(w / 3 * 2, h / 3 * 2);
                return;
            }
        }
    }
}
