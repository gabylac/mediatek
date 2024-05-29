using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek.modele;

namespace mediatek.dal
{
    /// <summary>
    /// classe permettant de gérer les demandes concernant les personnels
    /// </summary>
    class PersonnelAccess
    {
        /// <summary>
        /// instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// recupere et retourne les personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnels> GetLesPersonnels()
        {
            List<Personnels> lesPersonnels = new List<Personnels>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
                req += "from personnel p join service s on (s.idservice = p.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            service service = new service((int)record[5], (string)record[6]);
                            Personnels personnel = new Personnels((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }       
    }
}
