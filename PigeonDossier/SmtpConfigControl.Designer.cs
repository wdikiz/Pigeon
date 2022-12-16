namespace Pigeon
{
    partial class SmtpConfigControl
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
            this.chbSSLCnfg = new System.Windows.Forms.CheckBox();
            this.chbAuthCnfg = new System.Windows.Forms.CheckBox();
            this.coboxServiceCnfg = new System.Windows.Forms.ComboBox();
            this.labelSMTPService = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.txtbxPassCnfg = new System.Windows.Forms.TextBox();
            this.txtbxUserCnfg = new System.Windows.Forms.TextBox();
            this.txtbxPortCnfg = new System.Windows.Forms.TextBox();
            this.txtbxIPCnfg = new System.Windows.Forms.TextBox();
            this.linkipAmazon = new System.Windows.Forms.LinkLabel();
            this.lklblGoogle = new System.Windows.Forms.LinkLabel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkbox_sauv_pass = new System.Windows.Forms.CheckBox();
            this.picmdrphide = new System.Windows.Forms.PictureBox();
            this.picmdrpvisible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmdrphide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmdrpvisible)).BeginInit();
            this.SuspendLayout();
            // 
            // chbSSLCnfg
            // 
            this.chbSSLCnfg.AutoSize = true;
            this.chbSSLCnfg.Checked = true;
            this.chbSSLCnfg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSSLCnfg.Enabled = false;
            this.chbSSLCnfg.Location = new System.Drawing.Point(692, 372);
            this.chbSSLCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.chbSSLCnfg.Name = "chbSSLCnfg";
            this.chbSSLCnfg.Size = new System.Drawing.Size(46, 17);
            this.chbSSLCnfg.TabIndex = 36;
            this.chbSSLCnfg.Text = "SSL";
            this.chbSSLCnfg.UseVisualStyleBackColor = true;
            this.chbSSLCnfg.CheckedChanged += new System.EventHandler(this.checkBoxSSL_CheckedChanged);
            // 
            // chbAuthCnfg
            // 
            this.chbAuthCnfg.AutoSize = true;
            this.chbAuthCnfg.Checked = true;
            this.chbAuthCnfg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAuthCnfg.Enabled = false;
            this.chbAuthCnfg.Location = new System.Drawing.Point(478, 372);
            this.chbAuthCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.chbAuthCnfg.Name = "chbAuthCnfg";
            this.chbAuthCnfg.Size = new System.Drawing.Size(152, 17);
            this.chbAuthCnfg.TabIndex = 35;
            this.chbAuthCnfg.Text = "Authentification Obligatoire";
            this.chbAuthCnfg.UseVisualStyleBackColor = true;
            // 
            // coboxServiceCnfg
            // 
            this.coboxServiceCnfg.FormattingEnabled = true;
            this.coboxServiceCnfg.Items.AddRange(new object[] {
            "Service de Google",
            "Service d\'Amazon",
            "Saisie manuelle"});
            this.coboxServiceCnfg.Location = new System.Drawing.Point(478, 120);
            this.coboxServiceCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.coboxServiceCnfg.Name = "coboxServiceCnfg";
            this.coboxServiceCnfg.Size = new System.Drawing.Size(260, 21);
            this.coboxServiceCnfg.TabIndex = 32;
            this.coboxServiceCnfg.SelectedIndexChanged += new System.EventHandler(this.coboxServiceCnfg_SelectedIndexChanged);
            // 
            // labelSMTPService
            // 
            this.labelSMTPService.AutoSize = true;
            this.labelSMTPService.Location = new System.Drawing.Point(313, 120);
            this.labelSMTPService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSMTPService.Name = "labelSMTPService";
            this.labelSMTPService.Size = new System.Drawing.Size(76, 13);
            this.labelSMTPService.TabIndex = 31;
            this.labelSMTPService.Text = "Service SMTP";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(312, 331);
            this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(77, 13);
            this.labelPass.TabIndex = 30;
            this.labelPass.Text = "Mot de passe :";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(313, 280);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(53, 13);
            this.labelUser.TabIndex = 29;
            this.labelUser.Text = "Utilisateur";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(313, 172);
            this.labelIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(106, 13);
            this.labelIP.TabIndex = 28;
            this.labelIP.Text = "Serveur / Adresse IP";
            this.labelIP.Click += new System.EventHandler(this.labelIP_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(314, 228);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(80, 13);
            this.labelPort.TabIndex = 27;
            this.labelPort.Text = "Numero du port";
            // 
            // txtbxPassCnfg
            // 
            this.txtbxPassCnfg.Location = new System.Drawing.Point(477, 331);
            this.txtbxPassCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPassCnfg.Name = "txtbxPassCnfg";
            this.txtbxPassCnfg.Size = new System.Drawing.Size(261, 20);
            this.txtbxPassCnfg.TabIndex = 26;
            // 
            // txtbxUserCnfg
            // 
            this.txtbxUserCnfg.Location = new System.Drawing.Point(477, 280);
            this.txtbxUserCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxUserCnfg.Name = "txtbxUserCnfg";
            this.txtbxUserCnfg.Size = new System.Drawing.Size(261, 20);
            this.txtbxUserCnfg.TabIndex = 25;
            // 
            // txtbxPortCnfg
            // 
            this.txtbxPortCnfg.Location = new System.Drawing.Point(478, 228);
            this.txtbxPortCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPortCnfg.MaxLength = 5;
            this.txtbxPortCnfg.Name = "txtbxPortCnfg";
            this.txtbxPortCnfg.Size = new System.Drawing.Size(260, 20);
            this.txtbxPortCnfg.TabIndex = 24;
            this.txtbxPortCnfg.TextChanged += new System.EventHandler(this.txtbxPortCnfg_TextChanged);
            this.txtbxPortCnfg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPortCnfg_KeyPress);
            // 
            // txtbxIPCnfg
            // 
            this.txtbxIPCnfg.Location = new System.Drawing.Point(478, 172);
            this.txtbxIPCnfg.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxIPCnfg.Name = "txtbxIPCnfg";
            this.txtbxIPCnfg.Size = new System.Drawing.Size(260, 20);
            this.txtbxIPCnfg.TabIndex = 23;
            // 
            // linkipAmazon
            // 
            this.linkipAmazon.AutoSize = true;
            this.linkipAmazon.Location = new System.Drawing.Point(757, 175);
            this.linkipAmazon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkipAmazon.Name = "linkipAmazon";
            this.linkipAmazon.Size = new System.Drawing.Size(73, 13);
            this.linkipAmazon.TabIndex = 37;
            this.linkipAmazon.TabStop = true;
            this.linkipAmazon.Text = "En savoir plus";
            this.linkipAmazon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkipAmazon_LinkClicked);
            // 
            // lklblGoogle
            // 
            this.lklblGoogle.AutoSize = true;
            this.lklblGoogle.Location = new System.Drawing.Point(757, 334);
            this.lklblGoogle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklblGoogle.Name = "lklblGoogle";
            this.lklblGoogle.Size = new System.Drawing.Size(156, 13);
            this.lklblGoogle.TabIndex = 44;
            this.lklblGoogle.TabStop = true;
            this.lklblGoogle.Text = "Ou trouver mon Mot de passe ?";
            this.lklblGoogle.Visible = false;
            this.lklblGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblGoogle_LinkClicked);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Image = global::Pigeon.Properties.Resources.save_22px;
            this.btnEnregistrer.Location = new System.Drawing.Point(634, 439);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 32);
            this.btnEnregistrer.TabIndex = 43;
            this.btnEnregistrer.Text = "   Enregistrer";
            this.btnEnregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pigeon.Properties.Resources.password_22px;
            this.pictureBox5.Location = new System.Drawing.Point(286, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pigeon.Properties.Resources.account_skin_type_4_22px;
            this.pictureBox4.Location = new System.Drawing.Point(286, 271);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pigeon.Properties.Resources.ethernet_on_22px;
            this.pictureBox3.Location = new System.Drawing.Point(286, 219);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pigeon.Properties.Resources.server_22px;
            this.pictureBox2.Location = new System.Drawing.Point(286, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pigeon.Properties.Resources.service_22px;
            this.pictureBox1.Location = new System.Drawing.Point(286, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // chkbox_sauv_pass
            // 
            this.chkbox_sauv_pass.AutoSize = true;
            this.chkbox_sauv_pass.Location = new System.Drawing.Point(477, 448);
            this.chkbox_sauv_pass.Name = "chkbox_sauv_pass";
            this.chkbox_sauv_pass.Size = new System.Drawing.Size(121, 17);
            this.chkbox_sauv_pass.TabIndex = 45;
            this.chkbox_sauv_pass.Text = "Mémoriser mes infos";
            this.chkbox_sauv_pass.UseVisualStyleBackColor = true;
            this.chkbox_sauv_pass.CheckedChanged += new System.EventHandler(this.chkbox_sauv_pass_CheckedChanged);
            // 
            // picmdrphide
            // 
            this.picmdrphide.BackColor = System.Drawing.Color.White;
            this.picmdrphide.Image = global::Pigeon.Properties.Resources.hide_16px;
            this.picmdrphide.Location = new System.Drawing.Point(718, 333);
            this.picmdrphide.Name = "picmdrphide";
            this.picmdrphide.Size = new System.Drawing.Size(16, 16);
            this.picmdrphide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picmdrphide.TabIndex = 46;
            this.picmdrphide.TabStop = false;
            this.picmdrphide.Click += new System.EventHandler(this.picmdrphide_Click);
            // 
            // picmdrpvisible
            // 
            this.picmdrpvisible.BackColor = System.Drawing.Color.White;
            this.picmdrpvisible.Image = global::Pigeon.Properties.Resources.eye_16px;
            this.picmdrpvisible.Location = new System.Drawing.Point(718, 333);
            this.picmdrpvisible.Name = "picmdrpvisible";
            this.picmdrpvisible.Size = new System.Drawing.Size(16, 16);
            this.picmdrpvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picmdrpvisible.TabIndex = 47;
            this.picmdrpvisible.TabStop = false;
            this.picmdrpvisible.Visible = false;
            this.picmdrpvisible.Click += new System.EventHandler(this.picmdrpvisible_Click);
            // 
            // SmtpConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picmdrphide);
            this.Controls.Add(this.picmdrpvisible);
            this.Controls.Add(this.chkbox_sauv_pass);
            this.Controls.Add(this.lklblGoogle);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkipAmazon);
            this.Controls.Add(this.chbSSLCnfg);
            this.Controls.Add(this.chbAuthCnfg);
            this.Controls.Add(this.coboxServiceCnfg);
            this.Controls.Add(this.labelSMTPService);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.txtbxPassCnfg);
            this.Controls.Add(this.txtbxUserCnfg);
            this.Controls.Add(this.txtbxPortCnfg);
            this.Controls.Add(this.txtbxIPCnfg);
            this.Name = "SmtpConfigControl";
            this.Size = new System.Drawing.Size(1071, 675);
            this.Load += new System.EventHandler(this.SmtpConfigControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmdrphide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmdrpvisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbSSLCnfg;
        private System.Windows.Forms.CheckBox chbAuthCnfg;
        private System.Windows.Forms.ComboBox coboxServiceCnfg;
        private System.Windows.Forms.Label labelSMTPService;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox txtbxPassCnfg;
        public System.Windows.Forms.TextBox txtbxUserCnfg;
        public System.Windows.Forms.TextBox txtbxPortCnfg;
        private System.Windows.Forms.TextBox txtbxIPCnfg;
        private System.Windows.Forms.LinkLabel linkipAmazon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.LinkLabel lklblGoogle;
        private System.Windows.Forms.CheckBox chkbox_sauv_pass;
        private System.Windows.Forms.PictureBox picmdrphide;
        private System.Windows.Forms.PictureBox picmdrpvisible;
    }
}
