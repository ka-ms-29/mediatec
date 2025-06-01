using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatec.model;


namespace mediatec.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login et pwd de responsable)
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>        
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable r  ";
                req += "where r.login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.login);
                parameters.Add("@pwd", responsable.pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
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
