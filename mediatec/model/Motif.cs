using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatec.model
{
    /// <summary>
    /// classe correspandant a la table motif
    /// </summary>
    public class Motif
    {
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
        ///<summary>
        /// Définit l'information à afficher (juste la libelle)
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
