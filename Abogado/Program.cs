using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Abogado
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Lo primero que lee el programa
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_de_sesion());
        }
    }
}
