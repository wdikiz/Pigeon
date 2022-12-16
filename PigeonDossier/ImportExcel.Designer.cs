namespace Pigeon
{
    partial class ImportExcel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomFichier = new System.Windows.Forms.TextBox();
            this.chLBoxSync = new System.Windows.Forms.CheckedListBox();
            this.lblNmbrMail = new System.Windows.Forms.Label();
            this.chkbx_selectionnertt = new System.Windows.Forms.CheckBox();
            this.bntextraire = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.bntVider = new System.Windows.Forms.Button();
            this.btnSuppri = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.grpbxExcel = new System.Windows.Forms.GroupBox();
            this.lblGuide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbxExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feuill :";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chemin du fichier :";
            // 
            // txtnomFichier
            // 
            this.txtnomFichier.Enabled = false;
            this.txtnomFichier.Location = new System.Drawing.Point(102, 20);
            this.txtnomFichier.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomFichier.Name = "txtnomFichier";
            this.txtnomFichier.Size = new System.Drawing.Size(550, 20);
            this.txtnomFichier.TabIndex = 4;
            // 
            // chLBoxSync
            // 
            this.chLBoxSync.FormattingEnabled = true;
            this.chLBoxSync.Location = new System.Drawing.Point(747, 122);
            this.chLBoxSync.Margin = new System.Windows.Forms.Padding(2);
            this.chLBoxSync.Name = "chLBoxSync";
            this.chLBoxSync.Size = new System.Drawing.Size(215, 484);
            this.chLBoxSync.TabIndex = 9;
            this.chLBoxSync.SelectedIndexChanged += new System.EventHandler(this.chLBoxSync_SelectedIndexChanged);
            // 
            // lblNmbrMail
            // 
            this.lblNmbrMail.AutoSize = true;
            this.lblNmbrMail.Location = new System.Drawing.Point(833, 614);
            this.lblNmbrMail.Name = "lblNmbrMail";
            this.lblNmbrMail.Size = new System.Drawing.Size(0, 13);
            this.lblNmbrMail.TabIndex = 33;
            // 
            // chkbx_selectionnertt
            // 
            this.chkbx_selectionnertt.AutoSize = true;
            this.chkbx_selectionnertt.Location = new System.Drawing.Point(747, 92);
            this.chkbx_selectionnertt.Name = "chkbx_selectionnertt";
            this.chkbx_selectionnertt.Size = new System.Drawing.Size(188, 17);
            this.chkbx_selectionnertt.TabIndex = 34;
            this.chkbx_selectionnertt.Text = "Sélectionner/ Déselectionner tout ";
            this.chkbx_selectionnertt.UseVisualStyleBackColor = true;
            this.chkbx_selectionnertt.CheckedChanged += new System.EventHandler(this.chkbx_selectionnertt_CheckedChanged);
            // 
            // bntextraire
            // 
            this.bntextraire.Image = global::Pigeon.Properties.Resources.at_sign_22px;
            this.bntextraire.Location = new System.Drawing.Point(980, 342);
            this.bntextraire.Margin = new System.Windows.Forms.Padding(2);
            this.bntextraire.Name = "bntextraire";
            this.bntextraire.Size = new System.Drawing.Size(104, 32);
            this.bntextraire.TabIndex = 32;
            this.bntextraire.Text = "Extraire les @";
            this.bntextraire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntextraire.UseVisualStyleBackColor = true;
            this.bntextraire.Click += new System.EventHandler(this.bntextraire_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Image = global::Pigeon.Properties.Resources.done_22px;
            this.btnConfirmer.Location = new System.Drawing.Point(980, 386);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(104, 32);
            this.btnConfirmer.TabIndex = 31;
            this.btnConfirmer.Text = "   Confirmer";
            this.btnConfirmer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // bntVider
            // 
            this.bntVider.Image = global::Pigeon.Properties.Resources.delete_22px;
            this.bntVider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVider.Location = new System.Drawing.Point(980, 212);
            this.bntVider.Margin = new System.Windows.Forms.Padding(2);
            this.bntVider.Name = "bntVider";
            this.bntVider.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bntVider.Size = new System.Drawing.Size(104, 32);
            this.bntVider.TabIndex = 30;
            this.bntVider.Text = "    Vider";
            this.bntVider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntVider.UseVisualStyleBackColor = true;
            this.bntVider.Click += new System.EventHandler(this.bntVider_Click);
            // 
            // btnSuppri
            // 
            this.btnSuppri.Image = global::Pigeon.Properties.Resources.delete_user_male_22px;
            this.btnSuppri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppri.Location = new System.Drawing.Point(980, 167);
            this.btnSuppri.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppri.Name = "btnSuppri";
            this.btnSuppri.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSuppri.Size = new System.Drawing.Size(104, 32);
            this.btnSuppri.TabIndex = 29;
            this.btnSuppri.Text = "   Supprimer";
            this.btnSuppri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppri.UseVisualStyleBackColor = true;
            this.btnSuppri.Click += new System.EventHandler(this.btnSuppri_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Pigeon.Properties.Resources.add_user_male_22px;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(980, 122);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAjouter.Size = new System.Drawing.Size(104, 32);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "   Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Image = global::Pigeon.Properties.Resources.add_file_22px;
            this.btnOuvrir.Location = new System.Drawing.Point(660, 14);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(104, 32);
            this.btnOuvrir.TabIndex = 27;
            this.btnOuvrir.Text = "   Ouvrir";
            this.btnOuvrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // grpbxExcel
            // 
            this.grpbxExcel.Controls.Add(this.lblGuide);
            this.grpbxExcel.Controls.Add(this.chkbx_selectionnertt);
            this.grpbxExcel.Controls.Add(this.lblNmbrMail);
            this.grpbxExcel.Controls.Add(this.bntextraire);
            this.grpbxExcel.Controls.Add(this.btnConfirmer);
            this.grpbxExcel.Controls.Add(this.bntVider);
            this.grpbxExcel.Controls.Add(this.btnSuppri);
            this.grpbxExcel.Controls.Add(this.btnAjouter);
            this.grpbxExcel.Controls.Add(this.btnOuvrir);
            this.grpbxExcel.Controls.Add(this.chLBoxSync);
            this.grpbxExcel.Controls.Add(this.txtnomFichier);
            this.grpbxExcel.Controls.Add(this.label2);
            this.grpbxExcel.Controls.Add(this.comboBox1);
            this.grpbxExcel.Controls.Add(this.label1);
            this.grpbxExcel.Controls.Add(this.dataGridView1);
            this.grpbxExcel.Location = new System.Drawing.Point(3, 10);
            this.grpbxExcel.Name = "grpbxExcel";
            this.grpbxExcel.Size = new System.Drawing.Size(1106, 644);
            this.grpbxExcel.TabIndex = 35;
            this.grpbxExcel.TabStop = false;
            this.grpbxExcel.Text = "Extraction @ Excel";
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblGuide.Location = new System.Drawing.Point(300, 59);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(269, 13);
            this.lblGuide.TabIndex = 35;
            this.lblGuide.Text = "<=== Vous devez choisir la feuille correspondante";
            this.lblGuide.Visible = false;
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbxExcel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImportExcel";
            this.Size = new System.Drawing.Size(1120, 664);
            this.Load += new System.EventHandler(this.ImportExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbxExcel.ResumeLayout(false);
            this.grpbxExcel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomFichier;
        private System.Windows.Forms.CheckedListBox chLBoxSync;
        private System.Windows.Forms.Button bntextraire;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button bntVider;
        private System.Windows.Forms.Button btnSuppri;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Label lblNmbrMail;
        private System.Windows.Forms.CheckBox chkbx_selectionnertt;
        private System.Windows.Forms.GroupBox grpbxExcel;
        private System.Windows.Forms.Label lblGuide;
    }
}
