using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatec.model
{
    public class Absence
    {
        /// <summary>
        /// les probriétés corespandant aux champs da la table BDD
        /// </summary>
        public Personnel personnel { get; set; }
        public DateTime dateDebut {  get; set; }
        public DateTime dateFin {  get; set; }
        public Motif motif {  get; set; }

        /// <summary>
        /// constructeur da la classe, valorisation des propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            this.personnel = personnel;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.motif = motif;
        }
    }
}
