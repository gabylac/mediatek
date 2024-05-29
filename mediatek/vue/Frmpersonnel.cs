using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek.modele;
using mediatek.controleur;

namespace mediatek
{
    /// <summary>
    /// fenetre d'affichage des personnels et de leurs services
    /// </summary>
    public partial class Frmpersonnel : Form
    {
        /// <summary>
        /// objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// controleur de la fenetre
        /// </summary>
        private FrmPersonnelControleur controleur;
        /// <summary>
        /// construction des composants graphiques et appels des autres initialisations
        /// </summary>
        public Frmpersonnel()
        {
            InitializeComponent();
            init();
        }
        /// <summary>
        /// initialisations
        /// </summary>
        private void init()
        {
            controleur = new FrmPersonnelControleur();
            btnModifier.Enabled = false;
            btnSupp.Enabled = false;
            btnAfficher.Enabled = false;
            grpPersonnel.Enabled = false;
            grpAbsence.Enabled = false;
            remplirListPersonnel();
        }
        /// <summary>
        /// affiches les personnels
        /// </summary>
        private void remplirListPersonnel()
        {
            List<Personnels> lesPersonnels = controleur.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
