using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Klas
{
    public class Klasa3
    {
        private Form3 form3;
        public Klasa3()
        {
            form3 = new Form3();
            form3.Load += Form3_Load;
        }
        public void ShowForm()
        {
            form3.Show(); // Użyj ShowDialog() zamiast ShowForm()
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Tutaj możesz dodać logikę dla Form2 po załadowaniu
        }

        
    }
}
