using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek.dal;
using mediatek.modele;

namespace mediatek.controleur
{
    class FrmPersonnelControleur
    {
        /// <summary>
        /// objet d'accès aux operations possibles sur Personnels 
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// recupere les acces aux données
        /// </summary>
        public FrmPersonnelControleur()
        {
            personnelAccess = new PersonnelAccess();
        }
        /// <summary>
        /// recupere et retourne les infos des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnels>GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
    }
}
