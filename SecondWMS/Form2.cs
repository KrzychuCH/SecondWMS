﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondWMS
{
    public partial class Form2 : Form
    {
   
       
        public Form2()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this; // Ustaw formularz nadrzędny dla Form3 na bieżący Form2
            this.Hide();
            form3.Show();
      

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
    }
}
