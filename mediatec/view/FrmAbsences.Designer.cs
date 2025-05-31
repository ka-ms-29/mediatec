namespace mediatec.view
{
    partial class FrmAbsences
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
            this.grbLesAbsence = new System.Windows.Forms.GroupBox();
            this.btnSupprimAbsence = new System.Windows.Forms.Button();
            this.btnModifiAbsence = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblPersonnelSelectionne = new System.Windows.Forms.Label();
            this.grbLesAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grbAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesAbsence
            // 
            this.grbLesAbsence.Controls.Add(this.lblPersonnelSelectionne);
            this.grbLesAbsence.Controls.Add(this.btnSupprimAbsence);
            this.grbLesAbsence.Controls.Add(this.btnModifiAbsence);
            this.grbLesAbsence.Controls.Add(this.dgvAbsence);
            this.grbLesAbsence.Location = new System.Drawing.Point(12, 21);
            this.grbLesAbsence.Name = "grbLesAbsence";
            this.grbLesAbsence.Size = new System.Drawing.Size(658, 361);
            this.grbLesAbsence.TabIndex = 0;
            this.grbLesAbsence.TabStop = false;
            this.grbLesAbsence.Text = "les absences";
            // 
            // btnSupprimAbsence
            // 
            this.btnSupprimAbsence.Location = new System.Drawing.Point(147, 308);
            this.btnSupprimAbsence.Name = "btnSupprimAbsence";
            this.btnSupprimAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnSupprimAbsence.TabIndex = 3;
            this.btnSupprimAbsence.Text = "supprimer";
            this.btnSupprimAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimAbsence.Click += new System.EventHandler(this.btnSupprimAbsence_Click);
            // 
            // btnModifiAbsence
            // 
            this.btnModifiAbsence.Location = new System.Drawing.Point(16, 308);
            this.btnModifiAbsence.Name = "btnModifiAbsence";
            this.btnModifiAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnModifiAbsence.TabIndex = 2;
            this.btnModifiAbsence.Text = "Modifier";
            this.btnModifiAbsence.UseVisualStyleBackColor = true;
            this.btnModifiAbsence.Click += new System.EventHandler(this.btnModifiAbsence_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.AllowUserToResizeColumns = false;
            this.dgvAbsence.AllowUserToResizeRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 57);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.RowHeadersVisible = false;
            this.dgvAbsence.RowHeadersWidth = 62;
            this.dgvAbsence.RowTemplate.Height = 28;
            this.dgvAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsence.Size = new System.Drawing.Size(642, 222);
            this.dgvAbsence.TabIndex = 0;
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.dtpFin);
            this.grbAbsence.Controls.Add(this.dtpDebut);
            this.grbAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.lblMotif);
            this.grbAbsence.Controls.Add(this.lblDateFin);
            this.grbAbsence.Controls.Add(this.lblDateDebut);
            this.grbAbsence.Location = new System.Drawing.Point(12, 400);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(658, 185);
            this.grbAbsence.TabIndex = 1;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "ajouter absence";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(448, 38);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 13;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(117, 38);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 26);
            this.dtpDebut.TabIndex = 12;
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(134, 130);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnAnnulAbsence.TabIndex = 11;
            this.btnAnnulAbsence.Text = "Annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.btnAnnulAbsence_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(16, 130);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnEnregAbsence.TabIndex = 10;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(448, 89);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(200, 28);
            this.cboMotif.TabIndex = 9;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(388, 97);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(44, 20);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(348, 43);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(84, 20);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(12, 43);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(86, 20);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "date debut";
            // 
            // lblPersonnelSelectionne
            // 
            this.lblPersonnelSelectionne.AutoSize = true;
            this.lblPersonnelSelectionne.Location = new System.Drawing.Point(12, 34);
            this.lblPersonnelSelectionne.Name = "lblPersonnelSelectionne";
            this.lblPersonnelSelectionne.Size = new System.Drawing.Size(0, 20);
            this.lblPersonnelSelectionne.TabIndex = 4;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 602);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbLesAbsence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAbsences";
            this.Text = "Gestion absences";
            this.grbLesAbsence.ResumeLayout(false);
            this.grbLesAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnSupprimAbsence;
        private System.Windows.Forms.Button btnModifiAbsence;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lblPersonnelSelectionne;
    }
}