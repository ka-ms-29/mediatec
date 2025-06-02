using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <param name="personnelSelectionne"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsence(Personnel personnelSelectionne)
        {
            List<Absence> lesAbsence = new List<Absence>();
            if (access.Manager != null)
            {
                string req = " select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom, a.datedebut, a.datefin, m.idmotif, m.libelle as motif";
                req += " from absence a join motif m on (a.idmotif = m.idmotif)" +
                    "join personnel p on (p.idpersonnel = a.idpersonnel )" +
                    "join service s on (s.idservice = p.idservice)";
                req += "where p.idpersonnel = " + personnelSelectionne.Idpersonnel + " ";

                req += " order by a.datedebut ASC;";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            DateTime datedebut = (DateTime)record[7];
                            DateTime datefin = (DateTime)record[8];
                            Motif motif = new Motif((int)record[9], (string)record[10]);
                            Absence absence = new Absence(personnel, datedebut, datefin, motif);

                            lesAbsence.Add(absence);

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
        /// <summary>
        /// Demande de suppression d'un absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.dateDebut);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// Demande d'ajout un absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {

                
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.dateDebut);
                parameters.Add("@datefin", absence.dateFin);
                parameters.Add("@idmotif", absence.motif.Idmotif);

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur pendant la vérification : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        /// <summary>
        /// Demande de modification d'un absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="ancienneDateDebut"></param>
        public void UpdateAbsence(Absence absence, DateTime ancienneDateDebut)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @ancienneDateDebut ;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.dateDebut);
                parameters.Add("@datefin", absence.dateFin);
                parameters.Add("@idmotif", absence.motif.Idmotif);
                parameters.Add("@ancienneDateDebut", ancienneDateDebut);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// verrification d'existant d'un absence dans la base de donné
        /// </summary>
        /// <param name="absence"></param>
        /// <returns></returns>
        public Boolean AbsenceExist(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "select * from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.dateDebut);
                

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    return (records != null && records.Count > 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}
