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
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// objet permettant de recuperer la personnel selectionné
        /// </summary>
        private Personnel personnelSelectionne;
        /// <summary>
        /// pour conserver la date debut 
        /// </summary>
        private DateTime ancienneDateDebut;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsences(Personnel personnelSelectionne)
        {
            InitializeComponent();
            this.personnelSelectionne = personnelSelectionne;
            Init();


        }
        private void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeMotif();
            RemplirListeAbsence();
            EnCourseModifAbsence(false);
            lblPersonnelSelectionne.Text = "Absences de : " + personnelSelectionne.Nom + " " + personnelSelectionne.Prenom;
        }
        /// <summary>
        /// Affiche les motif
        /// </summary>
        private void RemplirListeMotif()
        {
            
            List<Motif> lesMotifs = controller.GetLesMotifs();
            lesMotifs.Insert(0, new Motif(0, ""));
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
            cboMotif.SelectedIndex = 0;

        }

        /// <summary>
        /// Affiche les absence
        /// </summary>
        private void RemplirListeAbsence()
        {
            List<Absence> lesAbsence = controller.GetLesAbsence(personnelSelectionne);
            bdgAbsence.DataSource = lesAbsence;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["personnel"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSupprimAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer   ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un absence
        /// </summary>
        /// <param name="absence"></param>
        private void EnCourseModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbLesAbsence.Enabled = !modif;
            if (modif)
            {
                grbAbsence.Text = "modifier un absence";
            }
            else
            {
                grbAbsence.Text = "ajouter un absence";
                dtpDebut.Value = DateTime.Today;
                dtpFin.Value = DateTime.Today;

            }
        }

        private void btnModifiAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                EnCourseModifAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.dateDebut;
                dtpFin.Value = absence.dateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.motif.Libelle);
                ancienneDateDebut = absence.dateDebut;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Checked && dtpFin.Checked && cboMotif.SelectedIndex != 0)
            {
                if (dtpDebut.Value <= dtpFin.Value)
                {


                    Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                    if (enCoursDeModifAbsence)
                    {
                        Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                        absence.dateDebut = dtpDebut.Value;
                        absence.dateFin = dtpFin.Value;
                        absence.motif = motif;
                        controller.UpdateAbsence(absence, ancienneDateDebut);
                    }
                    else
                    {
                        Absence absence = new Absence(personnelSelectionne, dtpDebut.Value, dtpFin.Value, motif);
                        controller.AddAbsence(absence);
                    }
                    RemplirListeAbsence();
                    EnCourseModifAbsence(false);
                }
                else
                {
                    MessageBox.Show("la date de début d'absence doit etre egale ou plus petit de la date fin d'absence.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }
    }
}
