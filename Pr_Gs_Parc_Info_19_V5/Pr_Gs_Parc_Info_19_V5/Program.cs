using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Gs_Parc_Info_19_V5
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Principal mdiForm = new Frm_Principal();
            mdiForm.Show();
            Frm_connexion loginForm = new Frm_connexion();
            // Affiche la fenêtre de connexion en modal
            loginForm.ShowDialog();
            Application.Run(mdiForm);
        }
    }
}
