namespace mediatec.view
{
    partial class FrmMediaTec
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnModifiPer = new System.Windows.Forms.Button();
            this.btnAjoutPer = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnSupprPer = new System.Windows.Forms.Button();
            this.grbAjoutPer = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAnnulPer = new System.Windows.Forms.Button();
            this.btnEnregPer = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAjoutPer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnModifiPer);
            this.grbPersonnel.Controls.Add(this.btnAjoutPer);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Controls.Add(this.btnSupprPer);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 25);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(776, 314);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Les personnel";
            // 
            // btnModifiPer
            // 
            this.btnModifiPer.Location = new System.Drawing.Point(155, 258);
            this.btnModifiPer.Name = "btnModifiPer";
            this.btnModifiPer.Size = new System.Drawing.Size(116, 38);
            this.btnModifiPer.TabIndex = 3;
            this.btnModifiPer.Text = "Modifier";
            this.btnModifiPer.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPer
            // 
            this.btnAjoutPer.Location = new System.Drawing.Point(17, 258);
            this.btnAjoutPer.Name = "btnAjoutPer";
            this.btnAjoutPer.Size = new System.Drawing.Size(116, 38);
            this.btnAjoutPer.TabIndex = 1;
            this.btnAjoutPer.Text = "Ajouter";
            this.btnAjoutPer.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(17, 25);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 62;
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.Size = new System.Drawing.Size(740, 227);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnSupprPer
            // 
            this.btnSupprPer.Location = new System.Drawing.Point(294, 258);
            this.btnSupprPer.Name = "btnSupprPer";
            this.btnSupprPer.Size = new System.Drawing.Size(116, 38);
            this.btnSupprPer.TabIndex = 2;
            this.btnSupprPer.Text = "Supprimer";
            this.btnSupprPer.UseVisualStyleBackColor = true;
            // 
            // grbAjoutPer
            // 
            this.grbAjoutPer.Controls.Add(this.txtMail);
            this.grbAjoutPer.Controls.Add(this.txtTel);
            this.grbAjoutPer.Controls.Add(this.txtPrenom);
            this.grbAjoutPer.Controls.Add(this.txtNom);
            this.grbAjoutPer.Controls.Add(this.cboService);
            this.grbAjoutPer.Controls.Add(this.lblService);
            this.grbAjoutPer.Controls.Add(this.lblMail);
            this.grbAjoutPer.Controls.Add(this.lblTel);
            this.grbAjoutPer.Controls.Add(this.lblPrenom);
            this.grbAjoutPer.Controls.Add(this.lblNom);
            this.grbAjoutPer.Controls.Add(this.btnAnnulPer);
            this.grbAjoutPer.Controls.Add(this.btnEnregPer);
            this.grbAjoutPer.Location = new System.Drawing.Point(12, 362);
            this.grbAjoutPer.Name = "grbAjoutPer";
            this.grbAjoutPer.Size = new System.Drawing.Size(776, 254);
            this.grbAjoutPer.TabIndex = 1;
            this.grbAjoutPer.TabStop = false;
            this.grbAjoutPer.Text = "Ajouter personnel";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(506, 92);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(251, 26);
            this.txtMail.TabIndex = 11;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(506, 35);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(251, 26);
            this.txtTel.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(94, 92);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(251, 26);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(94, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(251, 26);
            this.txtNom.TabIndex = 8;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(506, 152);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(251, 28);
            this.cboService.TabIndex = 7;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(439, 160);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(61, 20);
            this.lblService.TabIndex = 6;
            this.lblService.Text = "Service";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(442, 98);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 20);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(449, 38);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(30, 20);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Tel";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(22, 98);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // btnAnnulPer
            // 
            this.btnAnnulPer.Location = new System.Drawing.Point(155, 196);
            this.btnAnnulPer.Name = "btnAnnulPer";
            this.btnAnnulPer.Size = new System.Drawing.Size(116, 38);
            this.btnAnnulPer.TabIndex = 1;
            this.btnAnnulPer.Text = "Annuler";
            this.btnAnnulPer.UseVisualStyleBackColor = true;
            // 
            // btnEnregPer
            // 
            this.btnEnregPer.Location = new System.Drawing.Point(17, 196);
            this.btnEnregPer.Name = "btnEnregPer";
            this.btnEnregPer.Size = new System.Drawing.Size(116, 38);
            this.btnEnregPer.TabIndex = 0;
            this.btnEnregPer.Text = "Enregistrer";
            this.btnEnregPer.UseVisualStyleBackColor = true;
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(12, 629);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(228, 44);
            this.btnAbsence.TabIndex = 2;
            this.btnAbsence.Text = "Les absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmMediaTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.grbAjoutPer);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FrmMediaTec";
            this.Text = "MedieTec";
            this.Load += new System.EventHandler(this.FrmMediaTec_Load);
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAjoutPer.ResumeLayout(false);
            this.grbAjoutPer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnSupprPer;
        private System.Windows.Forms.Button btnAjoutPer;
        private System.Windows.Forms.Button btnModifiPer;
        private System.Windows.Forms.GroupBox grbAjoutPer;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnulPer;
        private System.Windows.Forms.Button btnEnregPer;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
    }
}

