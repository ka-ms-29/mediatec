using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatec.model
{
    public class Motif
    {
        /// <summary>
        /// les proprite de la class Motif correspandant aux champs de la table motif de BDD mediatec
        /// </summary>
        public int Idmotif { get; }
        public string Libelle { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }
        // <summary>
        /// Définit l'information à afficher (juste la libelle)
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
