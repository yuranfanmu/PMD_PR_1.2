using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ЗАДАНИЕ:
 * 1. Разместите в окне четыре кнопки (Button). Сделайте на кнопках следующие надписи:
«красный», «зеленый», «синий», «желтый». Создайте четыре обработчика события
нажатия на данные кнопки, которые будут менять цвет формы в соответствии с текстом
на кнопках.
 */

namespace PMD_PR_1._2
{
    public partial class Form1 : Form
    {
        Button[] btns;
        Color[] colors = { Color.Red , Color.Green, Color.Blue, Color.Yellow };
        String[] btnText = { "Красный", "Зеленый", "Синий", "Желтый" };
        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            btns = new Button[4];
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = new Button();
                btns[i].Size = new Size(270, 30);
                btns[i].Text = btnText[i];
                btns[i].Location = new Point(10, 10 + i * 40);
                btns[i].Click += btnClickEvent;
                this.Controls.Add(btns[i]);
            }
        }

        private void btnClickEvent(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "Красный":
                    this.BackColor = colors[0];
                    return;
                case "Зеленый":
                    this.BackColor = colors[1];
                    return;
                case "Синий":
                    this.BackColor = colors[2];
                    return;
                case "Желтый":
                    this.BackColor = colors[3];
                    return;
                default:
                    return;
            }
        }


    }
}
