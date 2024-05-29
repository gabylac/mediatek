using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.modele
{
    /// <summary>
    /// clasee métier liée à la table absence
    /// </summary>
    class Absence
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence (Personnels idpersonnel, DateTime datedebut, DateTime datefin, Motif idmotif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Idmotif = idmotif;
        }
        public Personnels Idpersonnel { get; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Idmotif { get; set; }
    }
}
