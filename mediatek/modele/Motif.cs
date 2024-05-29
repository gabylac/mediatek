using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.modele
{
    /// <summary>
    /// classe métier liée à la table motif
    /// </summary>
    class Motif
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif (int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
        public int Idmotif { get; }
        public string Libelle { get; set; }
    }
}
