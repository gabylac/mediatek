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
        /// objet pour gerer la liste des services
        /// </summary>
        private BindingSource bdgService = new BindingSource();
        /// <summary>
        /// boolean pour savoir si une modification est demandéé
        /// </summary>
        private Boolean enCoursdeModifPersonnel = false;
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
            grbAbsence.Enabled = false;
            remplirListPersonnel();
            remplirListService();
            EnCoursdeModifPersonnel(false);
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
        /// <summary>
        /// affiche les services
        /// </summary>
        private void remplirListService()
        {
            List<service> lesServices = controleur.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }
        /// <summary>
        /// demande d'enregistrement d'ajout ou de modif d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnr_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                service service = (service)bdgService.List[bdgService.Position];
                if (enCoursdeModifPersonnel)
                {
                    Personnels personnel = (Personnels)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controleur.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnels personnel = new Personnels(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controleur.AddPersonnel(personnel);
                }
                remplirListPersonnel();
                EnCoursdeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// modif de l'affichage en fonction de si ajout ou modif d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursdeModifPersonnel(Boolean modif)
        {
            enCoursdeModifPersonnel = modif;
            
            if (modif)
            {
                grbPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grbPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }
        /// <summary>
        /// demande de modifier un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursdeModifPersonnel(true);
                Personnels personnel = (Personnels)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner au moins une ligne.");
            }
        }
        /// <summary>
        /// annule la demande d'ajout ou de modification d'un personnel
        /// vide les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursdeModifPersonnel(false);
            }
        }
        /// <summary>
        /// affiche la zone reservée aux absences et à leurs gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                grbAbsence.Enabled = true;
                grbPersonnel.Enabled = false;
            }
            else
            {
                MessageBox.Show("veuillez selectionner au moins une ligne.");
            }
        }
        /// <summary>
        /// supprime un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnels personnel = (Personnels)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controleur.SuppPersonnel(personnel);
                    remplirListPersonnel();
                }
                else
                {
                    MessageBox.Show("veuillez selectionner au moins une ligne.");
                }
            }
        }
    }
}
