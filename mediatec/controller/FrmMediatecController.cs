using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatec.dal;
using mediatec.model;


namespace mediatec.controller
{
    /// <summary>
    /// Contrôleur de FrmMediaTec
    /// </summary>
    public class FrmMediatecController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        

        /// <summary>
        /// constructeur da la class
        /// Récupère les acces aux données
        /// </summary>
        public FrmMediatecController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
            
        }
        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnel()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des service
        /// </summary>
        /// <returns>liste des service</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetService();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }



    }
}
