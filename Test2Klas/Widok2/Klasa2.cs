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
            form2.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Tutaj możesz dodać logikę dla Form2 po załadowaniu
        }

        public void ShowFormModal()
        {
            form2.ShowDialog();

        } // Użyj ShowDialog() zamiast ShowForm()
    }
    }
}
