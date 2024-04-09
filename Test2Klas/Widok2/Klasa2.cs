using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Klas
{
    
    public class Klasa2
    {
        private Form2 form2;
        public Klasa2()
        {
            form2 = new Form2();
            form2.ButtonClicked += Form2_ButtonClicked;
        }
        private void Form2_ButtonClicked(object sender, EventArgs e)
        {
            // Po kliknięciu przycisku w formularzu Form1, otwórz kolejny formularz
            Klasa3 klasa3 = new Klasa3();
            klasa3.ShowForm();
        }
    
      
      /*  private void Form2_Load(object sender, EventArgs e)
        {
            // Tutaj możesz dodać logikę dla Form2 po załadowaniu
        }*/
        public void ShowForm()
        {
            form2.ShowDialog();
        }




    }
    
}
