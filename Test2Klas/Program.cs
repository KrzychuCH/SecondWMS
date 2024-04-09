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
            Klasa2 klasa2 = new Klasa2();
            Klasa3 klasa3 = new Klasa3();

          //  Application.Run();

            // Klasa1 klasa1 = new Klasa1();
            //klasa1.ShowForm();


            //   Klasa2 klasa2 = new Klasa2();
            //     klasa2.ShowForm();

            //  Klasa3 klasa3 = new Klasa3();
            //   klasa3.ShowForm();

            // 
            Application.Run();
        }
    }
}
