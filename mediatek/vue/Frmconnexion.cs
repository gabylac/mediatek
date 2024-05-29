using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek
{
    /// <summary>
    /// fenetre dec onnexion de l'utilisateur
    /// </summary>
    public partial class Frmconnexion : Form
    {
        /// <summary>
        /// construction des composants graphiques
        /// </summary>
        public Frmconnexion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// passe à la fenetre de gestion des personnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnok_Click(object sender, EventArgs e)
        {
            Frmpersonnel frmpersonnel = new Frmpersonnel();
            frmpersonnel.ShowDialog();
        }
        
    }
}
