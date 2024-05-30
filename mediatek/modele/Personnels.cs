using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.modele
{
    /// <summary>
    /// classe métier liée à la table personnel
    /// </summary>
    class Personnels
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnels(int idpersonnel, string nom, string prenom, string tel, string mail, service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }
        public int Idpersonnel { get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }
        public string Tel { set; get; }
        public string Mail { set; get; }
        public service Service { set; get; }
    }
}
