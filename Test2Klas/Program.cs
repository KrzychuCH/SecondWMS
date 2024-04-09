using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Klas
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Klasa1 klasa1 = new Klasa1();
            klasa1.ShowForm();

            //Application.Run();

           Klasa2 klasa2 = new Klasa2();
             klasa2.ShowFormModal();

            Klasa3 klasa3 = new Klasa3();
            klasa3.ShowFormModal();

            // Wywołaj ShowForm() dopiero po zamknięciu Form2

        }
    }
}
