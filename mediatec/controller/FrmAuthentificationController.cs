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
    /// Contrôleur de FrmAuthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;
        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }
        /// <summary>
        /// verifie l'authentification
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }

    }
}
