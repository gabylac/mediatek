
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpAbsence = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblModif = new System.Windows.Forms.Label();
            this.lblDFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDDebut = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grpPersonnel.SuspendLayout();
            this.grpAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 275);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(83, 76);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter personnel";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(119, 275);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 76);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(229, 275);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(83, 76);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(338, 275);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(83, 76);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher absence";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.btnAnnuler);
            this.grpPersonnel.Controls.Add(this.btnEnr);
            this.grpPersonnel.Controls.Add(this.comboBox1);
            this.grpPersonnel.Controls.Add(this.textBox4);
            this.grpPersonnel.Controls.Add(this.textBox3);
            this.grpPersonnel.Controls.Add(this.textBox2);
            this.grpPersonnel.Controls.Add(this.textBox1);
            this.grpPersonnel.Controls.Add(this.lblService);
            this.grpPersonnel.Controls.Add(this.lblMail);
            this.grpPersonnel.Controls.Add(this.lblTel);
            this.grpPersonnel.Controls.Add(this.lblPrenom);
            this.grpPersonnel.Controls.Add(this.lblNom);
            this.grpPersonnel.Location = new System.Drawing.Point(12, 373);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(409, 236);
            this.grpPersonnel.TabIndex = 5;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "Personnel";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(287, 131);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 40);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(287, 62);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(96, 40);
            this.btnEnr.TabIndex = 10;
            this.btnEnr.Text = "Enregistrer";
            this.btnEnr.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(14, 189);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(53, 16);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(14, 152);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 111);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(27, 16);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(14, 74);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(54, 16);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(14, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(36, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // grpAbsence
            // 
            this.grpAbsence.Controls.Add(this.dgvAbsence);
            this.grpAbsence.Controls.Add(this.comboBox2);
            this.grpAbsence.Controls.Add(this.btnAnnul);
            this.grpAbsence.Controls.Add(this.btnEnregistrer);
            this.grpAbsence.Controls.Add(this.lblModif);
            this.grpAbsence.Controls.Add(this.lblDFin);
            this.grpAbsence.Controls.Add(this.dtpFin);
            this.grpAbsence.Controls.Add(this.dtpDebut);
            this.grpAbsence.Controls.Add(this.lblDDebut);
            this.grpAbsence.Controls.Add(this.btnSupprimer);
            this.grpAbsence.Controls.Add(this.btnModif);
            this.grpAbsence.Controls.Add(this.btnAjout);
            this.grpAbsence.Location = new System.Drawing.Point(436, 255);
            this.grpAbsence.Name = "grpAbsence";
            this.grpAbsence.Size = new System.Drawing.Size(468, 355);
            this.grpAbsence.TabIndex = 6;
            this.grpAbsence.TabStop = false;
            this.grpAbsence.Text = "Absence";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(244, 299);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(93, 38);
            this.btnAnnul.TabIndex = 11;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(127, 299);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(93, 38);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.Location = new System.Drawing.Point(23, 262);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(35, 16);
            this.lblModif.TabIndex = 8;
            this.lblModif.Text = "Motif";
            // 
            // lblDFin
            // 
            this.lblDFin.AutoSize = true;
            this.lblDFin.Location = new System.Drawing.Point(225, 220);
            this.lblDFin.Name = "lblDFin";
            this.lblDFin.Size = new System.Drawing.Size(57, 16);
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
            this.lblDDebut.Size = new System.Drawing.Size(73, 16);
            this.lblDDebut.TabIndex = 4;
            this.lblDDebut.Text = "Date debut";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(283, 161);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(93, 36);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(172, 161);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(94, 36);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(62, 161);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(94, 36);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
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
            // Frmpersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 622);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.grpAbsence);
            this.Controls.Add(this.grpPersonnel);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "Frmpersonnel";
            this.Text = "Personnel";
            this.grpPersonnel.ResumeLayout(false);
            this.grpPersonnel.PerformLayout();
            this.grpAbsence.ResumeLayout(false);
            this.grpAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpAbsence;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lblDDebut;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label lblDFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}