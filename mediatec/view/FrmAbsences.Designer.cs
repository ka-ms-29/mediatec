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
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbModifiAbsence = new System.Windows.Forms.GroupBox();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.grbLesAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbModifiAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesAbsence
            // 
            this.grbLesAbsence.Controls.Add(this.btnSupprimAbsence);
            this.grbLesAbsence.Controls.Add(this.btnModifiAbsence);
            this.grbLesAbsence.Controls.Add(this.btnAjoutAbsence);
            this.grbLesAbsence.Controls.Add(this.dataGridView1);
            this.grbLesAbsence.Location = new System.Drawing.Point(12, 21);
            this.grbLesAbsence.Name = "grbLesAbsence";
            this.grbLesAbsence.Size = new System.Drawing.Size(776, 346);
            this.grbLesAbsence.TabIndex = 0;
            this.grbLesAbsence.TabStop = false;
            this.grbLesAbsence.Text = "les absences";
            // 
            // btnSupprimAbsence
            // 
            this.btnSupprimAbsence.Location = new System.Drawing.Point(270, 295);
            this.btnSupprimAbsence.Name = "btnSupprimAbsence";
            this.btnSupprimAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnSupprimAbsence.TabIndex = 3;
            this.btnSupprimAbsence.Text = "supprimer";
            this.btnSupprimAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifiAbsence
            // 
            this.btnModifiAbsence.Location = new System.Drawing.Point(143, 295);
            this.btnModifiAbsence.Name = "btnModifiAbsence";
            this.btnModifiAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnModifiAbsence.TabIndex = 2;
            this.btnModifiAbsence.Text = "Modifier";
            this.btnModifiAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(16, 295);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnAjoutAbsence.TabIndex = 1;
            this.btnAjoutAbsence.Text = "Ajouter";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(764, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbModifiAbsence
            // 
            this.grbModifiAbsence.Controls.Add(this.dtpFin);
            this.grbModifiAbsence.Controls.Add(this.dtpDebut);
            this.grbModifiAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbModifiAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbModifiAbsence.Controls.Add(this.comboBox1);
            this.grbModifiAbsence.Controls.Add(this.lblMotif);
            this.grbModifiAbsence.Controls.Add(this.lblDateFin);
            this.grbModifiAbsence.Controls.Add(this.lblDateDebut);
            this.grbModifiAbsence.Location = new System.Drawing.Point(12, 388);
            this.grbModifiAbsence.Name = "grbModifiAbsence";
            this.grbModifiAbsence.Size = new System.Drawing.Size(776, 217);
            this.grbModifiAbsence.TabIndex = 1;
            this.grbModifiAbsence.TabStop = false;
            this.grbModifiAbsence.Text = "modification";
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(143, 157);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnAnnulAbsence.TabIndex = 11;
            this.btnAnnulAbsence.Text = "Annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(16, 157);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(110, 36);
            this.btnEnregAbsence.TabIndex = 10;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(558, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(479, 99);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(44, 20);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(457, 43);
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
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(124, 38);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 26);
            this.dtpDebut.TabIndex = 12;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(558, 37);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 13;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.grbModifiAbsence);
            this.Controls.Add(this.grbLesAbsence);
            this.Name = "FrmAbsences";
            this.Text = "Gestion absences";
            this.grbLesAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbModifiAbsence.ResumeLayout(false);
            this.grbModifiAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSupprimAbsence;
        private System.Windows.Forms.Button btnModifiAbsence;
        private System.Windows.Forms.GroupBox grbModifiAbsence;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
    }
}