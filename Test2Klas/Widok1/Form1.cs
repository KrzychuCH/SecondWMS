using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Klas
{
    public partial class Form1 : Form
    {
        public event EventHandler ButtonClicked;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Po kliknięciu przycisku, wywołaj zdarzenie ButtonClicked
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Klasa2 klasa2 = new Klasa2();
            klasa2.ShowForm();
        }*/
      
    }
}
