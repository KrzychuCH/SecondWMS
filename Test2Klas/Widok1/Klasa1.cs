using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Klas

{

    public class Klasa1
    {
        private Form1 form1;
        public Klasa1()
        {
            form1 = new Form1();
            form1.ButtonClicked += Form1_ButtonClicked;
        }
        public void ShowForm()
        {
            form1.ShowDialog();//Application.Run(form1);
        }
        private void Form1_ButtonClicked(object sender, EventArgs e)
        {
            // Po kliknięciu przycisku w formularzu Form1, otwórz kolejny formularz
            Klasa2 klasa2 = new Klasa2();
            klasa2.ShowForm();
        }
      /*  private void Form1_Load(object sender, EventArgs e)
        {
            // Tutaj możesz dodać logikę dla Form1 po załadowaniu
        }*/
       /* public void ShowForm()
        {
            form1.ShowDialog();//Application.Run(form1);
        }*/



    } 
}
