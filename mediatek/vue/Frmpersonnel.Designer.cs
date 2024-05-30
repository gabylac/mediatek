
namespace mediatek
{
    partial class Frmpersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnr = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnEnregistrerAbs = new System.Windows.Forms.Button();
            this.lblModif = new System.Windows.Forms.Label();
            this.lblDFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDDebut = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grbPersonnel.SuspendLayout();
            this.grbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(61, 276);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 76);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(172, 276);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(83, 76);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(289, 276);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(83, 76);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher absence";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnuler);
            this.grbPersonnel.Controls.Add(this.btnEnr);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.lblService);
            this.grbPersonnel.Controls.Add(this.lblMail);
            this.grbPersonnel.Controls.Add(this.lblTel);
            this.grbPersonnel.Controls.Add(this.lblPrenom);
            this.grbPersonnel.Controls.Add(this.lblNom);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 373);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(409, 236);
            this.grbPersonnel.TabIndex = 5;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Ajouter Personnel";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(287, 131);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 40);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(287, 62);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(96, 40);
            this.btnEnr.TabIndex = 10;
            this.btnEnr.Text = "Enregistrer";
            this.btnEnr.UseVisualStyleBackColor = true;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(83, 186);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(160, 24);
            this.cboService.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(83, 108);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(160, 22);
            this.txtTel.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(83, 149);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(83, 71);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(160, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(83, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 22);
            this.txtNom.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(14, 189);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(55, 17);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(14, 152);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 111);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 17);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(14, 74);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(14, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.dgvAbsence);
            this.grbAbsence.Controls.Add(this.comboBox2);
            this.grbAbsence.Controls.Add(this.btnAnnulAbs);
            this.grbAbsence.Controls.Add(this.btnEnregistrerAbs);
            this.grbAbsence.Controls.Add(this.lblModif);
            this.grbAbsence.Controls.Add(this.lblDFin);
            this.grbAbsence.Controls.Add(this.dtpFin);
            this.grbAbsence.Controls.Add(this.dtpDebut);
            this.grbAbsence.Controls.Add(this.lblDDebut);
            this.grbAbsence.Controls.Add(this.btnSupprimer);
            this.grbAbsence.Controls.Add(this.btnModif);
            this.grbAbsence.Location = new System.Drawing.Point(436, 255);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(468, 355);
            this.grbAbsence.TabIndex = 6;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Absence";
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 21);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.RowHeadersWidth = 51;
            this.dgvAbsence.RowTemplate.Height = 24;
            this.dgvAbsence.Size = new System.Drawing.Size(455, 134);
            this.dgvAbsence.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Location = new System.Drawing.Point(244, 304);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(121, 38);
            this.btnAnnulAbs.TabIndex = 11;
            this.btnAnnulAbs.Text = "Annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbs
            // 
            this.btnEnregistrerAbs.Location = new System.Drawing.Point(87, 304);
            this.btnEnregistrerAbs.Name = "btnEnregistrerAbs";
            this.btnEnregistrerAbs.Size = new System.Drawing.Size(121, 38);
            this.btnEnregistrerAbs.TabIndex = 10;
            this.btnEnregistrerAbs.Text = "Enregistrer";
            this.btnEnregistrerAbs.UseVisualStyleBackColor = true;
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.Location = new System.Drawing.Point(23, 262);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(38, 17);
            this.lblModif.TabIndex = 8;
            this.lblModif.Text = "Motif";
            // 
            // lblDFin
            // 
            this.lblDFin.AutoSize = true;
            this.lblDFin.Location = new System.Drawing.Point(225, 220);
            this.lblDFin.Name = "lblDFin";
            this.lblDFin.Size = new System.Drawing.Size(61, 17);
            this.lblDFin.TabIndex = 7;
            this.lblDFin.Text = "Date Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(292, 215);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(169, 22);
            this.dtpFin.TabIndex = 6;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(87, 215);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(133, 22);
            this.dtpDebut.TabIndex = 5;
            // 
            // lblDDebut
            // 
            this.lblDDebut.AutoSize = true;
            this.lblDDebut.Location = new System.Drawing.Point(3, 220);
            this.lblDDebut.Name = "lblDDebut";
            this.lblDDebut.Size = new System.Drawing.Size(78, 17);
            this.lblDDebut.TabIndex = 4;
            this.lblDDebut.Text = "Date debut";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(244, 161);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 36);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(87, 161);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(121, 36);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(892, 236);
            this.dgvPersonnel.TabIndex = 7;
            // 
            // Frmpersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 622);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Name = "Frmpersonnel";
            this.Text = "Personnel";
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lblDDebut;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label lblDFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Button btnEnregistrerAbs;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}