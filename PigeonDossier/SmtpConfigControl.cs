using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pigeon
{
    public partial class SmtpConfigControl : UserControl
    {

        // c'est une instance qui communique les informations depuis les autres UC comme un proxy ( pont ) entre un user control et un autre

        public static SmtpConfigControl instance;

        public SmtpConfigControl()
        {
            InitializeComponent();
           instance = this;

        }

        //Les élements à executer une fois ce control utilisateur est chargée
        private void SmtpConfigControl_Load(object sender, EventArgs e)
        {
            
            txtbxIPCnfg.Enabled = true;
            txtbxPassCnfg.Enabled = true;
            txtbxPortCnfg.Enabled = true;
            txtbxUserCnfg.Enabled=true;
            linkipAmazon.Visible = false;
            txtbxPassCnfg.UseSystemPasswordChar = true;

            // c'est pour saisir les cordonées si l'utilistaeur choisi de mémories ses infos

            chkbox_sauv_pass.Checked = Properties.Settings.Default.Chbox_sauv_mdp;
            if (coboxServiceCnfg.Items.Contains("Service de Google") || coboxServiceCnfg.Items.Contains("Service Amazon") || coboxServiceCnfg.Items.Contains("Saisie manuelle")){

                coboxServiceCnfg.Text = Properties.Settings.Default.service_prvd;

            }
            txtbxIPCnfg.Text = Properties.Settings.Default.txtbox_server_ip;
            txtbxUserCnfg.Text = Properties.Settings.Default.txtbox_user;
            txtbxPortCnfg.Text = Convert.ToString(Properties.Settings.Default.txtbox_port);
            txtbxPassCnfg.Text = Properties.Settings.Default.txtbox_password;

            // retransmttre la configuration de SMTP une fois le user control se lance

            MyThirdUserControl.instance.serviceReceiver.Text = coboxServiceCnfg.Text.ToString();
            MyThirdUserControl.instance.ipReceiver.Text = txtbxIPCnfg.Text.ToString();
            MyThirdUserControl.instance.userReceiver.Text = txtbxUserCnfg.Text.ToString();
            MyThirdUserControl.instance.portReceiver.Text = txtbxPortCnfg.Text.ToString();
            MyThirdUserControl.instance.passReceiver.Text = txtbxPassCnfg.Text.ToString();
            MyThirdUserControl.instance.sslReceiver.Checked = chbSSLCnfg.Checked;
            MyThirdUserControl.instance.authReceiver.Checked = chbAuthCnfg.Checked;
        }

        private void labelIP_Click(object sender, EventArgs e)
        {

        }
  
        // permet avec un switch de remplir certains infos oridnaire à partir du service choisi
        private void coboxServiceCnfg_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbxUserCnfg.Enabled = true;
            txtbxPassCnfg.Enabled = true;
            txtbxPortCnfg.Enabled = true;
            txtbxUserCnfg.Enabled = true;

            switch (coboxServiceCnfg.SelectedItem)
                {
                    case "Service de Google":
                        txtbxIPCnfg.Enabled = true;
                        txtbxIPCnfg.Text = "smtp.gmail.com";
                    txtbxPassCnfg.Text = "";
                    txtbxPortCnfg.Text = "";
                    txtbxUserCnfg.Text = "";
                    lklblGoogle.Visible = true;
                        break;

                    case "Service d'Amazon":
                    txtbxIPCnfg.Text = "email.eu-west-3.amazonaws.com";
                    linkipAmazon.Visible = true;
                                        txtbxPassCnfg.Text = "";
                    txtbxPortCnfg.Text = "";
                    txtbxUserCnfg.Text = "";
                        break;

                case "Saisie manuelle":
                    txtbxIPCnfg.Text = "";
                    txtbxPassCnfg.Text = "";
                    txtbxPortCnfg.Text = "";
                    txtbxUserCnfg.Text = "";
                    break;


                }

            }


        // permet d'afficher une page web pour en savoir plus sur un service
        private void linkipAmazon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkipAmazon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.aws.amazon.com/fr_fr/general/latest/gr/ses.html");
        }

        private void checkBoxSSL_CheckedChanged(object sender, EventArgs e)
        {

        }

        // permet 2 actions :
                  // 1 :d'enregistrer les informations pour la prochaine
                  // 2. envoyer les info est les stocker dans la UC principale dans l'attente de l'envoie
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            // pour verifier que les champs ne sont pas vide et valable
            if (String.IsNullOrEmpty(txtbxIPCnfg.Text.ToString())|| String.IsNullOrEmpty(txtbxUserCnfg.Text.ToString()) || String.IsNullOrEmpty(txtbxPortCnfg.ToString())|| String.IsNullOrEmpty(txtbxPassCnfg.Text.ToString()))
            {

                string msg_bad = "Un des champs obligatoire est vide ! \\n Veuillez remplir tous les champs avant de continuer )";
                const string titre_bad = "Configuration SMTP terminée";
                var result_bad = MessageBox.Show(msg_bad, titre_bad,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            
        }else
            {
                Properties.Settings.Default.service_prvd = coboxServiceCnfg.SelectedItem.ToString();
                Properties.Settings.Default.Chbox_sauv_mdp = chkbox_sauv_pass.Checked;
                Properties.Settings.Default.txtbox_server_ip = txtbxIPCnfg.Text;
                Properties.Settings.Default.txtbox_user = txtbxUserCnfg.Text;
                Properties.Settings.Default.txtbox_password = txtbxPassCnfg.Text;
                Properties.Settings.Default.txtbox_port = Convert.ToInt32(txtbxPortCnfg.Text.ToString());
                Properties.Settings.Default.Save();

                MyThirdUserControl.instance.serviceReceiver.Text = coboxServiceCnfg.Text.ToString();
                MyThirdUserControl.instance.ipReceiver.Text = txtbxIPCnfg.Text.ToString();
                MyThirdUserControl.instance.userReceiver.Text = txtbxUserCnfg.Text.ToString();
                MyThirdUserControl.instance.portReceiver.Text = txtbxPortCnfg.Text.ToString();
                MyThirdUserControl.instance.passReceiver.Text = txtbxPassCnfg.Text.ToString();
                MyThirdUserControl.instance.sslReceiver.Checked = chbSSLCnfg.Checked;
                MyThirdUserControl.instance.authReceiver.Checked = chbAuthCnfg.Checked;

                string message_confi = "Configuration terminée !  \\n Vous êtes invités à aller à l'étape suivante (Importation des Emails)";
        const string titre_confi = "Configuration SMTP terminée";
        var result_confi = MessageBox.Show(message_confi, titre_confi,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
    }
}

        // permet d'afficher une page web pour en savoir plus sur coment obtenir un Mdp pour le SMTP google

        private void lklblGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.google.com/accounts/answer/185833?hl=fr");
        }

        private void chkbox_sauv_pass_CheckedChanged(object sender, EventArgs e)
        {

        }

        // afficher le mdp
        private void picmdrphide_Click(object sender, EventArgs e)
        {
            picmdrpvisible.Visible = true;
            picmdrphide.Visible = false;
            txtbxPassCnfg.UseSystemPasswordChar = false;
                    }
        // cacher le mdp
        private void picmdrpvisible_Click(object sender, EventArgs e)
        {
            picmdrpvisible.Visible = false;
            picmdrphide.Visible = true;
            txtbxPassCnfg.UseSystemPasswordChar = true;
        }

        private void txtbxPortCnfg_TextChanged(object sender, EventArgs e)
        {
        }


        //forcer le champs de saisier de port à accepter que les chiffre est seral imité max à 5 chiffres etant donné que le max du port : 65535
        

        private void txtbxPortCnfg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    }

