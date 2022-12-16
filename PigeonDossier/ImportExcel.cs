using ExcelDataReader;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using DataTable = System.Data.DataTable;
using UserControl = System.Windows.Forms.UserControl;

namespace Pigeon
{
    public partial class ImportExcel : UserControl
    {
        // c'est une instance qui communique les informations depuis les autres UC comme un proxy ( pont ) entre un user control et un autre

        public static ImportExcel instance;


        // Section de déclaration et assigneemnt des string
        string titreInputBox = "ajouter une adresse mail manuellement";
        string msgBoxInputBox = "Veuiller ajouter l'adresse mail souhaitée :";
        string titreInputBoxErr = "Vous devez Impérativement saisir le nom de la colonne qui contient les emails!";
        string msgBoxInputBoxErr = "Saisir le nom de la colonne :";
        string line;
        string reponseDefault;
        string reponseDefaultErr;
       
        public ImportExcel()
        {
            InitializeComponent();
            instance = this;
        }

        DataTableCollection tableCollection;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
           dt = tableCollection[comboBox1.SelectedItem.ToString()];
           dataGridView1.DataSource = dt;
           bntextraire.Enabled = true;
            lblGuide.Visible = false;

        }

        //Methode qui permet de calculer les emails importés
        public void emailcout ()
        {
            string message = "Importation terminée !" + " " + chLBoxSync.Items.Count.ToString() + " " + "adresse(s) mail importées";
            const string titre = "Nombre d'adress mail importées";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }



        //  permet de supprimer les lignes vides(nettoyer la liste)

        public void suppLienVide ()
        {

            int i = 0;
            while (chLBoxSync.Items.Count - 1 >= i)
            {
                // convertir l'objet listbox en chaîne de caractères afin de pouvoir utiliser Trim() pour supprimer tous les espaces (caractères blancs avant et après le mot). 
                //puis vérifier s'il reste un caractère ou s'il n'y a rien du tout, quel que soit le caractère d'espace ou l'espace.

                if (Convert.ToString(chLBoxSync.Items[i]).Trim() == string.Empty)
                {
                    //si la ligne est devenue vide après l'application de Trim(), alors la ligne est vide et la condition est vraie.
                    chLBoxSync.Items.RemoveAt(i);
                    //décrémenter l'index "i" car nous supprimoons la ligne et la ligne suivante prendra sa place et son numéro d'indice

                    i -= 1;
                }
                i += 1;
            }

        }

        // permet de selectionner tout les emails dans la liste

        public void selectionnerTt()
        {
                 for (int i = 0; i < chLBoxSync.Items.Count; i++)
               {
                  chLBoxSync.SetItemChecked(i, true);
             }

        }
        // permet de déselectionner tout les emails dans la liste

        public void deselectionnerTt()
        {
            for (int i = 0; i < chLBoxSync.Items.Count; i++)
            {
                chLBoxSync.SetItemChecked(i, false);
            }

        }


        private void chLBoxSync_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // une methode que qui permet de nettoyer la liste s'il ya des emails invalid ( ex un mail sans @, un mail avec espace etc...)
        private void Inputbox()
        {
            string ajoutToChk = Interaction.InputBox(msgBoxInputBox, titreInputBox, reponseDefault);
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchMail = regexMail.Match(ajoutToChk);


            if (matchMail.Success)

            {

                chLBoxSync.Items.Insert(0, ajoutToChk.ToString());

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


        // Une methode qui permet d'ajouter un mail manuellement ( mail apr mail)

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Inputbox();
        }

        //Permet de supprimer les élemens choisi dans la liste
        private void btnSuppri_Click(object sender, EventArgs e)
        {
            for (int i = chLBoxSync.Items.Count - 1; i >= 0; i--)
            {
                if (chLBoxSync.GetItemChecked(i))
                {
                    chLBoxSync.Items.Remove(chLBoxSync.Items[i]);
                }
                lblNmbrMail.Text = "Adresses mails importeés :" + chLBoxSync.Items.Count.ToString();

            }
        }

        // Ouvrir / importer un nouveau fichier et l'afficher dans la liste fichier

        private void btnOuvrir_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            chLBoxSync.Items.Clear();

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Fichier Excel | *.xls ; *.xlsx" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)  // lire le fichier excel
                {
                    txtnomFichier.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {

                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {

                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            tableCollection = result.Tables; 
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection) // ajouter les feuille du fichier excel importé
                                comboBox1.Items.Add(table.TableName);
                        }

                    }
                    comboBox1.Enabled = true;
                    lblGuide.Visible = true;
                }
            }
        }


        // c'est pour sélectionner/ déselectionner les emails dans la liste

        private void chkbx_selectionnertt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_selectionnertt.Checked)
            {
                selectionnerTt();

            }
            else if (chkbx_selectionnertt.Checked == false)
            {
                deselectionnerTt();

            }
        }

        // Permet d'envoyer la liste des email ( les éelemnts envoyés dans la liste à envoyer liste qui exite dans le UC " Rédiger un mail")

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < chLBoxSync.CheckedItems.Count; i++)
            {

                MyThirdUserControl.instance.emailReceiver.Items.Add(chLBoxSync.CheckedItems[i].ToString());

            }

            string message = "Confirmation terminée !  \\n Vous etes invités à aller à l'étape suivante (Editeur de texte ou importation Text)";
            const string titre = "Adresses mail confirmées";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }


        // permet de vider la liste des emails

        private void bntVider_Click(object sender, EventArgs e)
        {
            const string message = "Est-vous sur de vider la liste des email ?";
            const string titre = "Vider la liste";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                chLBoxSync.Items.Clear();
                chkbx_selectionnertt.Enabled = true;

            }
            else if (result == DialogResult.No)
            {
                //ne pas lancer l'action de vidage
            }
            lblNmbrMail.Text = "Adresses mails importeés :" + chLBoxSync.Items.Count.ToString();
        }


        //Les élements à executer une fois ce control utilisateur est chargée

        private void ImportExcel_Load(object sender, EventArgs e)
        {
            chkbx_selectionnertt.Checked = true;
            chkbx_selectionnertt.Enabled = true;
            lblNmbrMail.Visible = false;
        }


        // permet d'extraire depuis une colonne toute les emails
        private void bntextraire_Click(object sender, EventArgs e)
        {
            string nomdecolonne = Interaction.InputBox(msgBoxInputBoxErr, titreInputBoxErr, reponseDefaultErr); // demander à l'utilistateur le nom du colonne qui contient les emails

            if (nomdecolonne == string.Empty)
            {
                const string message2 = "Vous devez Impérativement saisir le nom de la colonne qui contient les emails!";
                const string titre2 = "Erreur";
                var result2 = MessageBox.Show(message2, titre2,
                                             MessageBoxButtons.RetryCancel,
                                             MessageBoxIcon.Error);

            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)   // cette loop permet avant d'ajouter les emails dans la lsite box de les vérifier avec un Regex et les nettoyer
                                                                      // Donc les adresses n'ont valides ne seront pas importées
                {

                    var cellValue = row.Cells[nomdecolonne].Value;

                    if (cellValue != null && cellValue.ToString().Contains("@"))
                    {

                        Regex regexMail1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                        Match matchMail1 = regexMail1.Match(cellValue.ToString());

                        if (matchMail1.Success)
                        {



                            chLBoxSync.Enabled = true;
                            chLBoxSync.Items.Add(cellValue.ToString());

                            // Appeler la methode pour supprimer les élements vides pour ne pas laisser une ligne vide dans la listebox 
                            suppLienVide();

                            // Appeler la methode pour séléctionner tout les élements.
                            selectionnerTt();
                        }

                        else
                        {
                        }
                        bntextraire.Enabled = false;
                        chkbx_selectionnertt.Enabled = true;
                    }
                }
                emailcout(); // calculé le nombre des emails importées aprés nettoyage etc..
                lblNmbrMail.Visible = true;
                lblNmbrMail.Text = "Adresses mails importeés :" + chLBoxSync.Items.Count.ToString();

            }
        }
    }
}



