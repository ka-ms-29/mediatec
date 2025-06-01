using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatec.controller;
using mediatec.model;

namespace mediatec.view
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;
        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        public void Init()
        {
            controller = new FrmAuthentificationController();
        }
        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConnect_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;

            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmMediaTec frm = new FrmMediaTec();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas responsable", "Alerte");
                }
            }
        }
    }
}
