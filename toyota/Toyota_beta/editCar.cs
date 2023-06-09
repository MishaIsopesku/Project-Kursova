﻿using System;
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
    public partial class editCar : Form
    {
        public int f, s;
        public bool flagEdit = false;

        public editCar()
        {
            InitializeComponent();
        }

        private void editCar_Load(object sender, EventArgs e)
        {
            label0.Text += " " + Form1.listM[f].Model;

            Cars cars = Form1.listM[f].Cars[s];

            textBox1.Text = cars.Model;
            textBox2.Text = cars.Year.ToString();
            textBox3.Text = cars.Transmission;
            textBox4.Text = cars.Drive;
            textBox5.Text = cars.Hp.ToString();
            textBox6.Text = cars.Engine;
            textBox7.Text = cars.Price.ToString();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
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
            Cars cars = Form1.listM[f].Cars[s];
            cars.Model = textBox1.Text;
            cars.Year = yb;
            cars.Transmission = textBox3.Text;
            cars.Drive = textBox4.Text;
            cars.Hp = r;
            cars.Engine = textBox6.Text;
            cars.Price = tp;

            flagEdit = true;
            Close();

        }
    }
}
