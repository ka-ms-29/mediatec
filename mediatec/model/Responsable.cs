using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatec.model
{
    /// <summary>
    /// classe corespandant a la table responsable
    /// </summary>
    public class Responsable
    {
        public string login { get; }
        public string pwd { get; }
        /// <summary>
        /// constructeur, valoriser les propriete
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
