using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.modele
{
    /// <summary>
    /// classe métier liée à la table service
    /// </summary>
    class service
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public service (int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }
        public int Idservice { get; }
        public string Nom { get; set; }
    }
}
