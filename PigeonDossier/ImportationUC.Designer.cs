namespace Pigeon
{
    partial class ImportationUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxMails = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNmbrMail = new System.Windows.Forms.Label();
            this.chkbx_selectionnertt = new System.Windows.Forms.CheckBox();
            this.chdlboxClean = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bntAmeliorer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.bntVider = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxMails
            // 
            this.checkedListBoxMails.CheckOnClick = true;
            this.checkedListBoxMails.FormattingEnabled = true;
            this.checkedListBoxMails.Location = new System.Drawing.Point(21, 66);
            this.checkedListBoxMails.Margin = new System.Windows.Forms.Padding(8);
            this.checkedListBoxMails.Name = "checkedListBoxMails";
            this.checkedListBoxMails.Size = new System.Drawing.Size(318, 514);
            this.checkedListBoxMails.TabIndex = 4;
            this.checkedListBoxMails.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMails_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNmbrMail);
            this.groupBox1.Controls.Add(this.chkbx_selectionnertt);
            this.groupBox1.Controls.Add(this.chdlboxClean);
            this.groupBox1.Controls.Add(this.bntAmeliorer);
            this.groupBox1.Controls.Add(this.btnConfirmer);
            this.groupBox1.Controls.Add(this.bntVider);
            this.groupBox1.Controls.Add(this.btnSupp);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.checkedListBoxMails);
            this.groupBox1.Controls.Add(this.btnOuvrir);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1176, 608);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importer des @ : Fichier .txt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNmbrMail
            // 
            this.lblNmbrMail.AutoSize = true;
            this.lblNmbrMail.Location = new System.Drawing.Point(197, 587);
            this.lblNmbrMail.Name = "lblNmbrMail";
            this.lblNmbrMail.Size = new System.Drawing.Size(0, 13);
            this.lblNmbrMail.TabIndex = 29;
            this.lblNmbrMail.Click += new System.EventHandler(this.lblNmbrMail_Click);
            // 
            // chkbx_selectionnertt
            // 
            this.chkbx_selectionnertt.AutoSize = true;
            this.chkbx_selectionnertt.Location = new System.Drawing.Point(156, 38);
            this.chkbx_selectionnertt.Name = "chkbx_selectionnertt";
            this.chkbx_selectionnertt.Size = new System.Drawing.Size(188, 17);
            this.chkbx_selectionnertt.TabIndex = 28;
            this.chkbx_selectionnertt.Text = "Sélectionner/ Déselectionner tout ";
            this.chkbx_selectionnertt.UseVisualStyleBackColor = true;
            this.chkbx_selectionnertt.CheckedChanged += new System.EventHandler(this.chkbx_selectionnertt_CheckedChanged);
            // 
            // chdlboxClean
            // 
            this.chdlboxClean.FormattingEnabled = true;
            this.chdlboxClean.Location = new System.Drawing.Point(1120, 18);
            this.chdlboxClean.Name = "chdlboxClean";
            this.chdlboxClean.Size = new System.Drawing.Size(26, 19);
            this.chdlboxClean.TabIndex = 27;
            this.chdlboxClean.Visible = false;
            // 
            // bntAmeliorer
            // 
            this.bntAmeliorer.Image = global::Pigeon.Properties.Resources.broom_22px2;
            this.bntAmeliorer.Location = new System.Drawing.Point(349, 321);
            this.bntAmeliorer.Margin = new System.Windows.Forms.Padding(2);
            this.bntAmeliorer.Name = "bntAmeliorer";
            this.bntAmeliorer.Size = new System.Drawing.Size(104, 32);
            this.bntAmeliorer.TabIndex = 26;
            this.bntAmeliorer.Text = "   Améliorer";
            this.bntAmeliorer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAmeliorer.UseVisualStyleBackColor = true;
            this.bntAmeliorer.Click += new System.EventHandler(this.bntAmeliorer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Image = global::Pigeon.Properties.Resources.done_22px;
            this.btnConfirmer.Location = new System.Drawing.Point(349, 373);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(104, 32);
            this.btnConfirmer.TabIndex = 25;
            this.btnConfirmer.Text = "   Confirmer";
            this.btnConfirmer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // bntVider
            // 
            this.bntVider.Image = global::Pigeon.Properties.Resources.delete_22px;
            this.bntVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVider.Location = new System.Drawing.Point(349, 199);
            this.bntVider.Margin = new System.Windows.Forms.Padding(2);
            this.bntVider.Name = "bntVider";
            this.bntVider.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bntVider.Size = new System.Drawing.Size(104, 32);
            this.bntVider.TabIndex = 24;
            this.bntVider.Text = "    Vider";
            this.bntVider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntVider.UseVisualStyleBackColor = true;
            this.bntVider.Click += new System.EventHandler(this.bntVider_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Image = global::Pigeon.Properties.Resources.delete_user_male_22px;
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupp.Location = new System.Drawing.Point(349, 154);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSupp.Size = new System.Drawing.Size(104, 32);
            this.btnSupp.TabIndex = 23;
            this.btnSupp.Text = "   Supprimer";
            this.btnSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Pigeon.Properties.Resources.add_user_male_22px;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(349, 109);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAjouter.Size = new System.Drawing.Size(104, 32);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "   Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Image = global::Pigeon.Properties.Resources.add_file_22px;
            this.btnOuvrir.Location = new System.Drawing.Point(349, 66);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(104, 32);
            this.btnOuvrir.TabIndex = 20;
            this.btnOuvrir.Text = "   Ouvrir";
            this.btnOuvrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // ImportationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportationUC";
            this.Size = new System.Drawing.Size(1210, 652);
            this.Load += new System.EventHandler(this.ImportationUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxMails;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button bntVider;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button bntAmeliorer;
        private System.Windows.Forms.CheckedListBox chdlboxClean;
        private System.Windows.Forms.CheckBox chkbx_selectionnertt;
        private System.Windows.Forms.Label lblNmbrMail;
    }
}
