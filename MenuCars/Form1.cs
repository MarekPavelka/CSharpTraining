﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            listBox1.Items.Add("yolo");
            listBox1.Items.Add("yulo");
            listBox1.Items.Add("klo");
        }

        private void Button2_Click(object sender, EventArgs e)
        {


        }
    }
}
