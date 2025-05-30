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
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsences()
        {
            InitializeComponent();
            RemplirListeMotif();
            RemplirListeAbsence();
            
        }
        /// <summary>
        /// Affiche les motif
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// Affiche les absence
        /// </summary>
        private void RemplirListeAbsence()
        {
            List<Absence> lesAbsence = controller.GetLesAbsence();
            bdgAbsence.DataSource = lesAbsence;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
