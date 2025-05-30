using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using mediatec.model;

namespace mediatec.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absence
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        // <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Absence> GetLesAbsence()
        {
            List<Absence> lesAbsence = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice,s.nom as service, " +
                    "a.datedebut, a.datefin, m.idmotif, m.libelle as motif";
                req += "from absence a join personnel p on (a.idpersonnel = p.idpersonnel)" +
                    "join service s on (p.idservice = s.idservice)" +
                    "join motif m on (a.idmotif = m.idmotif)";
                req += "where idpersonnel = @idpersonnel";
                req += "order by datedebut ASC";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            Motif motif = new Motif((int)record[10], (string)record[11]);
                            Absence absence = new Absence(personnel, (DateTime)record[8], (DateTime)record[9], motif);
                            lesAbsence .Add(absence);
                        
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }

            }
            return lesAbsence;
        }
    }
}
