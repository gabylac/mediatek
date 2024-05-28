using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek.bddmanager;

namespace mediatek.dal
{
    class Access
    {
        /// <summary>
        /// chaine de connexion à la BDD
        /// </summary>
        private static readonly string connectionString = "server = localhost; user id = root; database=mediatek; SslMode = none";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }
        /// <summary>
        /// creation unique de l'pbjet de type BddManager
        /// arrête le programme si connexion à la bdd échouée
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// creation d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
