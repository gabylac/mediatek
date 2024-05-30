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
        /// objet d'accès aux opérations possibles sur Services
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// recupere les acces aux données
        /// </summary>
        public FrmPersonnelControleur()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }
        /// <summary>
        /// recupere et retourne les infos des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnels>GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
        /// <summary>
        /// recupere et retourne les infos des services
        /// </summary>
        /// <returns></returns>
        public List<service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }
        /// <summary>
        /// demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnels personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }
        /// <summary>
        /// demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnels personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }
        /// <summary>
        /// demande la suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void SuppPersonnel (Personnels personnel)
        {
            personnelAccess.SuppPersonnel(personnel);
        }
    }
}
