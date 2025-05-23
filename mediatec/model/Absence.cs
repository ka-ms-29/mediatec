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
        /// les proprite de la class Absence correspandant aux champs de la table Absence de BDD mediatec
        /// </summary>
        public int IdPersonnel { get;}
        public int IdMotif { get;}
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
       

        /// <summary>
        /// la constructeur de la class et valorisation des propriétés
        /// </summary>
        public Absence(int idpersonnel, int idmotif, DateTime datedebut, DateTime datefin) 
        {
            this.IdPersonnel = idpersonnel;
            this.IdMotif = idmotif;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            
        }


    }
}
