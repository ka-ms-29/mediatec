using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatec.view;


namespace mediatec
{
    /// <summary>
    /// Application MediaTec : Atelier 2
    /// </summary>
    internal class NamespaceDoc
    {

    }
    internal static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.FrmAuthentification());
        }
    }
}
