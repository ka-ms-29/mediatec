using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatec.dal;
using mediatec.model;
using mediatec.view;

namespace mediatec.controller
{
    /// <summary>
    /// Contrôleur de FrmAbsence
    /// </summary>
    public class FrmAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur motif
        /// </summary>
        private readonly MotifAccess motifAccess;
        public FrmAbsenceController()
        {
            motifAccess = new MotifAccess();
        }
        

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
        /// <summary>
        /// Récupère et retourne les infos des absence
        /// </summary>
        /// <returns>liste des absence</returns>
        public List<Absence> GetLesAbsence()
        {
            return absenceAccess.GetLesAbsence();
        }

    }   
}
