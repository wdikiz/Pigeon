using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.Crmf;

namespace Pigeon
{
    public partial class ImportationUC : UserControl
    {

        // c'est une instance qui recevera les informations depuis les autres UC comme un proxy ( pont ) entre un user control et un autre

        public static ImportationUC instance;

        public ImportationUC()
        {
            InitializeComponent();
            instance = this;
            btnConfirmer.Enabled = false;
            btnSupp.Enabled = false;
        }

        // Section de déclaration et assigneemnt des string
        string titreInputBox = "ajouter adresse mail manuellement";
        string msgBoxInputBox = "Veuiller ajouter l'adresse mail :";
        string line;
        string reponseDefault;

        //Les élements à executer une fois ce control utilisateur est chargée

        private void ImportationUC_Load(object sender, EventArgs e)
        {
            chkbx_selectionnertt.Checked = true;
            chkbx_selectionnertt.Enabled = true;
            lblNmbrMail.Visible = false;
        }


        // permet de selectionner tout les emails dans la liste
        public void selectionnerTt()
        {

            for (int i = 0; i < checkedListBoxMails.Items.Count; i++)
            {
                checkedListBoxMails.SetItemChecked(i, true);
            }
        }


        // permet de déselectionner tout les emails dans la liste
        public void deselectionnerTt()
        {
            for (int i = 0; i < checkedListBoxMails.Items.Count; i++)
            {
                checkedListBoxMails.SetItemChecked(i, false);
            }
        }


        // Une methode qui permet d'ajouter un mail manuellement ( mail apr mail)
        private void btnPicAddLigne_Click(object sender, EventArgs e)
        {
            Inputbox(); 
        }

        // une methode que qui permet de nettoyer la liste s'il ya des emails invalid ( ex un mail sans @, un mail avec espace etc...)

        private void Inputbox()
        {
            string ajoutToChk = Interaction.InputBox(msgBoxInputBox, titreInputBox, reponseDefault);
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchMail = regexMail.Match(ajoutToChk);

            if (matchMail.Success)
            {
                checkedListBoxMails.Items.Insert(0, ajoutToChk.ToString() );
            }
            else
            {
                const string message = "Votre adresse n'est pas une adresse valide";
                const string titre = "Erreur";
                var result = MessageBox.Show(message, titre,
                                             MessageBoxButtons.RetryCancel,
                                             MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    Inputbox();
                }
            }
        }


        // Appeler la methode "suppLienVide" qui permet de supprimer les lignes vides ( nettoyer la liste)

        private void checkedListBoxMails_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppLienVide();
            btnSupp.Enabled = true;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       //  permet de supprimer les lignes vides(nettoyer la liste)
        public void suppLienVide()
        {

            int i = 0;
            while (checkedListBoxMails.Items.Count - 1 >= i)
            {
                // convertir l'objet listbox en chaîne de caractères afin de pouvoir utiliser Trim() pour supprimer tous les espaces (caractères blancs avant et après le mot). 
                //puis vérifier s'il reste un caractère ou s'il n'y a rien du tout, quel que soit le caractère d'espace ou l'espace.

                if (Convert.ToString(checkedListBoxMails.Items[i]).Trim() == string.Empty)
                {
                    //si la ligne est devenue vide après l'application de Trim(), alors la ligne est vide et la condition est vraie.
                    checkedListBoxMails.Items.RemoveAt(i);
                    //décrémenter l'index "i" car nous supprimoons la ligne et la ligne suivante prendra sa place et son numéro d'indice
                    i -= 1;
                }
                i += 1;
            }

        }

       // c'est uune methode qui se déclance avec action qui fait le meme job que la methode inputbox 
        private void améliroerMethode()
        {
            foreach (string verfiEmail in checkedListBoxMails.Items)
            {
                if (verfiEmail != null && verfiEmail.Contains("@"))
                {

                    Regex regexMail1 = new Regex("^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$");
                    Match matchMail1 = regexMail1.Match(verfiEmail);


                    if (matchMail1.Success)
                    {
                        chdlboxClean.Items.Add(verfiEmail.ToString());           
                    }
                    else

                    {
                    }
                }
            }

            checkedListBoxMails.Items.Clear();

            for (int i = 0; i < chdlboxClean.Items.Count; i++)
            {
                chdlboxClean.SetItemChecked(i, true);
            }
            returnValid();
            bntAmeliorer.Enabled = false;

            string message = "Votre liste maintenant contient" + " " + checkedListBoxMails.Items.Count.ToString() + " " + "adresse(s) mail valides";
            const string titre = "Adresse mail valides";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            lblNmbrMail.Visible = true;
            lblNmbrMail.Text = "Adresses mails importeés :" + checkedListBoxMails.Items.Count.ToString();


        }

        // Faire appel à la methode améliorer

        private void bntAmeliorer_Click(object sender, EventArgs e)
        {
           
            améliroerMethode();

        }

     // methode qui permet de retourner les email nettoyer dans la liste primaire 
        private void returnValid()
        {

            foreach (string reurnEmail in chdlboxClean.Items)
            {
            checkedListBoxMails.Items.Add(reurnEmail.ToString());
            selectionnerTt();
            }
        }


        // Ouvrir / importer un nouveau fichier et l'afficher dans la liste fichier
        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            bntAmeliorer.Enabled = true;

            if (checkedListBoxMails.Items.Count != 0)
            {
                DialogResult d;
                d = MessageBox.Show
                    ("Faite attention si vous avez importer cette liste cela écresera votre liste actuelle , si vous souhaiter garder la lsite actuelle, Veuiller cliquer sur confimrer avaant d'importer une novuelel liste", "Attention",

                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.Cancel)
                {
                    return;
                }
            }

            checkedListBoxMails.Items.Clear();  // Vider la liste lorsque l'utilisateur choisir d'ouvirr un nouveau fichier

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fichier Text | *.xls; *.xlsx ; *.csv ; *.txt";
            openFile.Multiselect = false;

            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Lire le fichier et l'afficher ligne par ligne
                System.IO.StreamReader file = new System.IO.StreamReader(openFile.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    checkedListBoxMails.Items.Add(line);

                }
                file.Close();
                suppLienVide();
                chkbx_selectionnertt.Enabled = true;
                selectionnerTt();
            }
            btnConfirmer.Enabled = true;
            btnSupp.Enabled = true;
            améliroerMethode();
            lblNmbrMail.Visible = true;
            lblNmbrMail.Text = "Adresses mails importeés :" + checkedListBoxMails.Items.Count.ToString(); // pour afficher le nombre des email importée
        
        }

        // Permet d'envoyer la liste des email ( les éelemnts envoyés dans la liste à envoyer liste qui exite dans le UC " Rédiger un mail")
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxMails.CheckedItems.Count; i++)
            {

                MyThirdUserControl.instance.emailReceiver.Items.Add(checkedListBoxMails.CheckedItems[i].ToString()); // envoyer les email à la lite dans le remier UC (la liste centrale)

            }
            string message = "Confirmation terminée !  \\n Vous etes invités à aller à l'étape suivante (Editeur de texte ou importation Excel)";
            const string titre = "Adresses mail confirmées";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        // appeler la methode qui permter d'ajouter un mail et le supprimer
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Inputbox();
        }

        //Permet de supprimer les élemens séléctionés dans la liste
        private void btnSupp_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBoxMails.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBoxMails.GetItemChecked(i))
                {
                    checkedListBoxMails.Items.Remove(checkedListBoxMails.Items[i]);
                }
                lblNmbrMail.Text = "Adresses mails importeés :" + checkedListBoxMails.Items.Count.ToString(); // refraicher le nombre d'email 

            }
        }


        // permet de vider la liste des emails
        private void bntVider_Click(object sender, EventArgs e)
        {
            const string message = "Est-vous sur de vider la liste des emails ?";
            const string titre = "Vider la liste";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                checkedListBoxMails.Items.Clear();
                chkbx_selectionnertt.Enabled = false;

            }
            else if (result == DialogResult.No)
            {
                //ne pas lancer l'action de vidage
            }
            lblNmbrMail.Text = "Adresses mails importeés :" + checkedListBoxMails.Items.Count.ToString();

        }

        // c'est pour sélectionner/ déselectionner les emails dans la liste

        private void chkbx_selectionnertt_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbx_selectionnertt.Checked)
            {
                selectionnerTt();

            } 
            else if (chkbx_selectionnertt.Checked == false)
            {
                deselectionnerTt();
            }
            }

        private void lblNmbrMail_Click(object sender, EventArgs e)
        {


        }

        private void checkedListBoxMails_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }












