using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toyota_beta
{
    public partial class addCar : Form
    {
        public int f;           
        public bool flagEdit = false;

        public addCar()
        {
            InitializeComponent();
        }

        private void addCar_Load(object sender, EventArgs e)
        {
            label0.Text += " " + Form1.listM[f].Model;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int yb = 0, r = 0, tp = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text))  
            {
                MessageBox.Show("Назва комплектації має бути введена");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text != "" && !int.TryParse(textBox2.Text, out yb))
            {
                MessageBox.Show("Рік випуску має бути числом");
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))  
            {
                MessageBox.Show("Тип коробки має бути введений");
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))  
            {
                MessageBox.Show("Тип приводу має бути введений");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text != "" && !int.TryParse(textBox5.Text, out r))
            {
                MessageBox.Show("Кількість кінських сил має бути числом");
                textBox5.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))  
            {
                MessageBox.Show("Тип двигуна має бути введений");
                textBox6.Focus();
                return;
            }
            if (textBox7.Text != "" && !int.TryParse(textBox7.Text, out tp))
            {
                MessageBox.Show("Ціна має бути числом");
                textBox7.Focus();
                return;
            }

            Form1.listM[f].Cars.Add(new Cars(textBox1.Text, yb,
                                           textBox3.Text, textBox4.Text, textBox5.Text, r, tp ));
            flagEdit = true;

            if (MessageBox.Show("Комплектація " + textBox1.Text +
                        " додана. \n\nДодати іншу комплектацію?.",
                        "Додати або вийти?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                Close();

            textBox1.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
