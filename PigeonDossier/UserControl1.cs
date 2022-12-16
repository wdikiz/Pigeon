
using Microsoft.Win32;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shapes;
using Path = System.IO.Path;
using Control = System.Windows.Forms.Control;
using Microsoft.Office.Interop.Word;
using Font = System.Drawing.Font;
using System.Net.Mail;
using System.Windows.Interop;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MimeKit.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using RichTextBox = System.Windows.Controls.RichTextBox;
using Org.BouncyCastle.Utilities;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using Org.BouncyCastle.Utilities.IO;
using System.Net;
using MailMessage = System.Net.Mail.MailMessage;
using SmtpClient = System.Net.Mail.SmtpClient;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Contexts;


//************************************************************************************************************************************************************************************************
// Ce UserControl represente le UC qui permet de recoelr les inforamtion des autres UC et les traiter , il est doté ainsi d'un richtext qui permet d'editer les messges avant de l'envoyer *
//************************************************************************************************************************************************************************************************


namespace Pigeon
{
    public partial class MyThirdUserControl : System.Windows.Forms.UserControl
    {
 
        //******************************************************************************************************************************
        // Section de déclaration et assigneemnt de qulques strings. *
        //******************************************************************************************************************************

        List<string> colorList = new List<string>();    // cette liste contient les noms de "System.Drawing.Color"
        string filenamee;    
        string filenamejoindre = "";
        string extensionrtb;
        const int MIDDLE = 382;    
        string titreInputBox = "ajouter adresse mail manuellement";
        string msgBoxInputBox = "Veuiller ajouter l'adresse mail :";
        string reponseDefault;
        int sumRGB;    // la somme des couleurs sélectionnées RGB pour donner une couleure finale en sommant les 3
        int pos, line, column;   


       // c'est une instance qui recevera les informations depuis les autres UC comme un proxy ( pont ) entre un user control et un autre
       
        public static MyThirdUserControl instance;

       // déclaration des variables qui vont recevoir l'info des autres controleurs ultisateurs (SMTP,Importation....)
        public System.Windows.Forms.ComboBox profileReceiver;
        public System.Windows.Forms.ComboBox serviceReceiver;
        public System.Windows.Forms.TextBox ipReceiver;
        public System.Windows.Forms.TextBox portReceiver;
        public System.Windows.Forms.TextBox userReceiver;
        public System.Windows.Forms.TextBox passReceiver;
        public System.Windows.Forms.CheckBox authReceiver;
        public System.Windows.Forms.CheckBox sslReceiver;
        public CheckedListBox emailReceiver;




        public MyThirdUserControl()
        {
            InitializeComponent();

            instance = this;

            // affectation des varaible aux widgets
            profileReceiver = cmbxProfilHide;
            serviceReceiver = cmbxServiceHide;
            ipReceiver = txtbxIpHide;
            portReceiver = txtbxportHide;
            userReceiver = txtbxuserHide;
            passReceiver = txtbxpassHide;
            authReceiver = chbAuthHide;
            sslReceiver = chbSslHide;
            emailReceiver = chklistBxMailHide;

            // Assignation des proprietes  des controlleurs

            richTextBox1.AllowDrop = true;     // pour permettre le glisser-déposer dans le RichTextBox
            richTextBox1.AcceptsTab = true;    // permet l'onglet 
            richTextBox1.WordWrap = false;    // Désactiver le retour à la ligne au démarrage
            richTextBox1.ShortcutsEnabled = true;    // autoriser les raccourcis (CTRL+A .....)
            richTextBox1.DetectUrls = true;    // permettre détecter s'il ya des url
            fontDialog1.ShowColor = true;
           fontDialog1.ShowApply = true;
            fontDialog1.ShowHelp = true;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.SolidColorOnly = false;
            colorDialog1.ShowHelp = true;
            colorDialog1.AnyColor = true;
            leftAlignStripButton.Checked = true;
            centerAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            boldStripButton3.Checked = false;
            italicStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            bulletListStripButton.Checked = false;
            wordWrapToolStripMenuItem.Image = null;


            // remplir la liste des éléments du bouton zoomDropDownButton pour zoomer ou dézommer le texte
            zoomDropDownButton.DropDown.Items.Add("20%");
            zoomDropDownButton.DropDown.Items.Add("50%");
            zoomDropDownButton.DropDown.Items.Add("70%");
            zoomDropDownButton.DropDown.Items.Add("100%");
            zoomDropDownButton.DropDown.Items.Add("150%");
            zoomDropDownButton.DropDown.Items.Add("200%");
            zoomDropDownButton.DropDown.Items.Add("300%");
            zoomDropDownButton.DropDown.Items.Add("400%");
            zoomDropDownButton.DropDown.Items.Add("500%");




            // permet de regler les tailles de police dans la boîte combo
            for (int i = 8; i < 80; i += 2)
            {
                fontSizeComboBox.Items.Add(i);
            }

            // remplir les couleurs dans la liste déroulante des couleurs
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    colorList.Add(prop.Name);
                }
            }

            // remplir la liste déroulante des éléments
            foreach (string color in colorList)
            {
                colorStripDropDownButton.DropDownItems.Add(color);
            }

            // remplir le "BackColor" pour chaque couleur de la liste déroulante "DropDownItems"
            for (int i = 0; i < colorStripDropDownButton.DropDownItems.Count; i++)
            {
                // créer un objet pour le Color nommé KnowColor
                KnownColor selectedColor;
                selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), colorList[i]);    
                colorStripDropDownButton.DropDownItems[i].BackColor = Color.FromKnownColor(selectedColor);    


                // Set the text color depending on if the barkground is darker or lighter
                // Créer l'objet color
                Color col = Color.FromName(colorList[i]);

                // Comme indiqué en haut la sommation des trois donne une colors : Blanc = 255,255,255 =  Black = 0,0,0 
                // sommation maximu ldes trois c'est 765 -> (255 + 255 + 255 = blanc) ( binaire de 8 bits)
                // la médiane des  valeur des est de 382 -> (765/2)
                // En principe les colors sont considérées foncées s'elles sont <= 382
                // alors les colors sont considirées claire s'elles sont  > 382
                sumRGB = ConvertToRGB(col);    // obtenir la somme des objets de couleur de la valeur RGB
                if (sumRGB <= MIDDLE)    // une background foncée
                {
                    colorStripDropDownButton.DropDownItems[i].ForeColor = Color.White;    // définit comme texte blanc
                }
                else if (sumRGB > MIDDLE)    // une backgrounnd claire
                {
                    colorStripDropDownButton.DropDownItems[i].ForeColor = Color.Black;    // définit comme texte noir
                }
            }

            // remplir les polices dans la liste déroulante des polices
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                fontStripComboBox.Items.Add(family.Name);
            }

            // détermine les numéros de ligne et de colonne de la position de la souris sur le richTextBox
            int pos = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(pos);
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);
            lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
        }

        //Les élements à executer une fois ce control utilisateur est chargée
        private void MyThirdUserControl_Load(object sender, EventArgs e)
        {
            chkbx_selectionnertt.Checked = false;
            chkbx_selectionnertt.Enabled = true;
            lblNmbrMail.Visible = true;
            lblNmbrMail.Text = "Adresses mails importeés :" + chklistBxMailHide.Items.Count.ToString();

        }

        //******************************************************************************************************************************
        // ConvertToRGB - Accepte un objet Couleur comme paramètre. Obtient les valeurs RVB de l'objet qui lui est passé, calcule la somme. *
        //******************************************************************************************************************************
        private int ConvertToRGB(System.Drawing.Color c)
        {
            int r = c.R, // Valeur du composant ROUGE
                g = c.G, // Valeur du composant VERT
                b = c.B; // Valeur du composant BLUE
            int sum = 0;

            // Calculer la somme des 3 couleurs
            sum = r + g + b;

            return sum;
        }

        // Selectionner tt
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();    
        }

       //effacer le texte
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Clear();
        }


        // Coller le texte
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();     
        }

        // copier le texte
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();      
        }
        // couper le texte
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();     
        }


        // définit le texte en BOLD avec un boolean (true;false)
        private void boldStripButton3_Click(object sender, EventArgs e)
        {

            if (boldStripButton3.Checked == false)
            {
                boldStripButton3.Checked = true; // BOLD is true
            }
            else if (boldStripButton3.Checked == true)
            {
                boldStripButton3.Checked = false;    // BOLD is false
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            // Créer un objet pour le style des polices pour type BOLD (font) 
            FontStyle style = richTextBox1.SelectionFont.Style;

            // déterminer le style des polices 
            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);     // définit le style de la police
        }


        // définit le texte en Underligne(souligné) avec un boolean (true;false)

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
            if (underlineStripButton.Checked == false)
            {
                underlineStripButton.Checked = true;     // UNDERLINE est activ
            }
            else if (underlineStripButton.Checked == true)
            {
                underlineStripButton.Checked = false;    // UNDERLINE désactivé
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            // Créer un objet pour le style des polices pour type underligne (soulignée) 
            FontStyle style = richTextBox1.SelectionFont.Style;

            //détermine le styles de police
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);     // définit le style de la police
        }

        // définit le texte en Italics (souligné) avec un boolean (true;false)

        private void italicStripButton_Click(object sender, EventArgs e)
        {
            if (italicStripButton.Checked == false)
            {
                italicStripButton.Checked = true;    // ITALICS activé
            }
            else if (italicStripButton.Checked == true)
            {
                italicStripButton.Checked = false;    // ITALICS désactivé
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // Créer un objet pour le style des polices pour type italics
            FontStyle style = richTextBox1.SelectionFont.Style;

            //détermine le styles de police

            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);     // définit le style de la police
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // définit la taille de la police lorsqu'elle est modifiée
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(fontSizeComboBox.Text), richTextBox1.SelectionFont.Style);
        }

        private void fontStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // définit le style de la famille de polices
                richTextBox1.SelectionFont = new Font(fontStripComboBox.Text, richTextBox1.Font.Size);
            }
            // définit le style de la famille de polices sélectionnée
            richTextBox1.SelectionFont = new Font(fontStripComboBox.Text, richTextBox1.SelectionFont.Size);
        }


        // afficher un show dialog pour pouvoir enregister le texte qui est dans richbox avec le style richbox.
        private void saveStripButton_Click(object sender, EventArgs e)
        {
            try
            {
 
                string fichier;

                saveFileDialog1.Filter  = "Fichier Text/Word(RTB) | *.txt; *.rtb ; *.doc";
         


                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string nomdufichier = saveFileDialog1.FileName;
                
                    richTextBox1.SaveFile(nomdufichier, RichTextBoxStreamType.RichText);
                    fichier = Path.GetFileName(nomdufichier);
                    MessageBox.Show("Fichier " + fichier + " a été sauvegardé avec succès.", "Sauvegarde terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information sur l'erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


      //  j'ai créée un methode qui permet d'ouvrir le fichier parceque je dois l'utiliser plusieurs fois
        private void OpenfileRTBorNot()
        {

            openFileDialog1.Filter = "Fichier Text/word(rtf) | *.docx; *.rtf; *.txt";
            openFileDialog1.Multiselect = false;



            DialogResult dr = openFileDialog1.ShowDialog();


            if (dr == DialogResult.OK)
            {
                filenamee = openFileDialog1.FileName.ToString();


                if (filenamee.Contains(".txt"))
                {

                    richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.PlainText);    // charger le texte en mode brute


                }
                else if (filenamee.Contains(".rtf"))
                {

                    richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.RichText);    // charger le texte en mode Style RTB


                }
                else if (filenamee.ToString().Contains(".docx") || filenamee.ToString().Contains(".doc"))
                {

                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object fileName = openFileDialog1.FileName;
                    object newtemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word._Document document;
                    Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();

                    IDataObject dataObject = Clipboard.GetDataObject();
                    richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                    //      MessageBox.Show("c'est moi fichier word");
                }
            }
        }

        // afficher un show dialog pour pouvoir ouvrir un fichier et le charger dans le richbox avec conditions de détection automatqiue de mode de texte ( brute ou RTB)
        private void openFileStripButton_Click(object sender, EventArgs e)
        {
            // apeller de la methode qui permet d'ouvrir un fichier
            OpenfileRTBorNot();
        }

        private void colorStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // crée un objet "KnownColor"
            KnownColor selectedColor;
            selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);    // converts it to a Color Structure
            richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);    // sets the selected color
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
           // hilighter la bordure des boutons lorsque les boutons sont true

            if (richTextBox1.SelectionFont != null)
            {
                boldStripButton3.Checked = richTextBox1.SelectionFont.Bold;
                italicStripButton.Checked = richTextBox1.SelectionFont.Italic;
                underlineStripButton.Checked = richTextBox1.SelectionFont.Underline;
            }
        }

        // Pour aligner le texte selectionné à gauche
        private void leftAlignStripButton_Click(object sender, EventArgs e)
        {
           
            centerAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if (leftAlignStripButton.Checked == false)
            {
                leftAlignStripButton.Checked = true;    
            }
            else if (leftAlignStripButton.Checked == true)
            {
                leftAlignStripButton.Checked = false;   
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;   
        }

        // Pour aligner le texte selectionné au centre
        private void centerAlignStripButton_Click(object sender, EventArgs e)
        {
            leftAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if (centerAlignStripButton.Checked == false)
            {
                centerAlignStripButton.Checked = true;    
            }
            else if (centerAlignStripButton.Checked == true)
            {
                centerAlignStripButton.Checked = false;    
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;     
        }

        // Pour aligner le texte selectionné à droite
        private void rightAlignStripButton_Click(object sender, EventArgs e)
        {
           
            leftAlignStripButton.Checked = false;
            centerAlignStripButton.Checked = false;

            if (rightAlignStripButton.Checked == false)
            {
                rightAlignStripButton.Checked = true;    
            }
            else if (rightAlignStripButton.Checked == true)
            {
                rightAlignStripButton.Checked = false;    
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;    
        }

        // Pour ajouter des point bullets au texte selectionné

        private void bulletListStripButton_Click(object sender, EventArgs e)
        {
            if (bulletListStripButton.Checked == false)
            {
                bulletListStripButton.Checked = true;
                richTextBox1.SelectionBullet = true;    
            }
            else if (bulletListStripButton.Checked == true)
            {
                bulletListStripButton.Checked = false;
                richTextBox1.SelectionBullet = false;    
            }
        }

        //Augmenter la taille du texte 
        private void increaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable pour contenir la taille sélectionnée         
            try
            {
                int size = Convert.ToInt32(fontSizeNum) + 1;    // convertir (fontSizeNum et ajouter (+ 1))
                if (richTextBox1.SelectionFont == null)
                {
                    return;
                }
                // // définit la taille de la police choisit
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, richTextBox1.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // appliquer l'augmentation
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information sur l'erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); // afficher un Msg d'erreur
            }
        }

        //Diminuer la taille du texte 
        private void decreaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable pour contenir la taille sélectionnée             
            try
            {
                int size = Convert.ToInt32(fontSizeNum) - 1;    // convertir (fontSizeNum et ajouter (+ 1))
                if (richTextBox1.SelectionFont == null)
                {
                    return;
                }
                // sets the updated font size
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, richTextBox1.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // appliquer l'augmentation
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information sur l'erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); // afficher un Msg d'erreur
            }
        }

        //*********************************************************************************************
        // richTextBox1_DragEnter - Événement personnalisé. Copie le texte qui est glissé dans la richTextBox *.
        //*********************************************************************************************
        private void richTextBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;    // Copier le texte vers le RTB
            else
                e.Effect = DragDropEffects.None;    // n'accepte pas les tecxte dans la RTB
        }
        //***************************************************************************************************
        // richTextBox1_DragEnter - Événement personnalisé. Dépose le texte copié qui a été glissé sur la richTextBox *.
        //***************************************************************************************************
        private void richTextBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Les variables
            int i;
            String s;

            // Obtenir la position de départ pour déposer le texte.
            i = richTextBox1.SelectionStart;
            s = richTextBox1.Text.Substring(i);
            richTextBox1.Text = richTextBox1.Text.Substring(0, i);

            // Déposez le texte sur la RichTextBox.
            richTextBox1.Text += e.Data.GetData(DataFormats.Text).ToString();
            richTextBox1.Text += s;
        }

        // annuler l'action
        private void undoStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();    
        }


        // refaire l'action
                private void redoStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();    
        }

        // annuler l'action depusi le menu en haut
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();    
        }

        // annuler l'action depusi le menu en haut
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();     
        }

        // couper le texte
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();     
        }

       // copier le texte
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();     
        }

        //coller le texte
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();  
        }
        //Sélectionner tt  dans le richbox
        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();    
        }

        // effacer le texte dans l richtext
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        // Effacer le texte selectionné 
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            richTextBox1.SelectedText = "";
            richTextBox1.Focus();
        }



        // pour ouvirr un fichier depuis le menu cette fois ci .
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
           // j'a appeler la méthode pour pouvoir ouvrir un fichier
            OpenfileRTBorNot();
        }


        //Commencer un nuveau texte donc effacer le texte actuelle 
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            // La RTB a un contenu - demander à l'utilisateur de sauvegarder les changements.
            if (richTextBox1.Text != string.Empty)    
            {
                // Sauvgarder le texte avant créé un nouveau éléments
                DialogResult result = MessageBox.Show("Voulez-vous enregistrer vos modifications ? L'éditeur n'est pas vide.", "Enregistrer les modifications ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // sauvegarder le contenu de la RTB si l'utilisateur a sélectionné "Oui".
                    saveFileDialog1.ShowDialog();    // show the dialog
                    string file;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        // enregistrer le contenu de la zone RTB
                        richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        file = Path.GetFileName(filename); // obtenir le nom du fichier
                        MessageBox.Show("Le fichier " + file + " a été enregistré avec succès.", "Sauvegarde terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // enfin - effacer le contenu de la RTB 
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }
                else if (result == DialogResult.No)
                {
                  //  effacer le contenu de la RTB
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }
            }
            else // La RTB n'a pas de contenu = vide
            {
                //effacer le contenu de la RTB  
                richTextBox1.ResetText();
                richTextBox1.Focus();
            }
        }


        // permet de sauvegarder le contenu du fichier
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();    // afficher le dialogue 
            string file;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // sauvegarder le contenu de la zone RTB
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
            file = Path.GetFileName(filenamee);    // obtenir le nom du fichier
            MessageBox.Show("Le fichier " + file + " a été sauvegardé avec succès.", "Sauvegarde terminé", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void zoomDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            float zoomPercent = Convert.ToSingle(e.ClickedItem.Text.Trim('%')); // Convertir
            richTextBox1.ZoomFactor = zoomPercent / 100;    // définit le facteur de zoom

            if (e.ClickedItem.Image == null)
            {
                // met toutes les propriétés de l'image à zéro - au cas où l'une d'entre elles serait déjà sélectionnée avant.
                for (int i = 0; i < zoomDropDownButton.DropDownItems.Count; i++)
                {
                    zoomDropDownButton.DropDownItems[i].Image = null;
                }

                // dessine le bmp dans la propriété image de l'élément sélectionné, tant qu'il est actif.
                Bitmap bmp = new Bitmap(5, 5);
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
                }
                e.ClickedItem.Image = bmp;    
            }
            else
            {
                e.ClickedItem.Image = null;
                richTextBox1.ZoomFactor = 1.0f;   
            }
        }

        // Mettre le texte sélectionné en MAJ
        private void uppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();   
        }

        // Mettre le texte sélectionné en MIN
        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();   
        }

        // pour géréer l'option WordWrap
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Bitmap bmp = new Bitmap(5, 5);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
            }

            if (richTextBox1.WordWrap == false)
            {
                richTextBox1.WordWrap = true;    // WordWrap activé
                wordWrapToolStripMenuItem.Image = bmp;  
            }
            else if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;    // WordWrap désactivé
                wordWrapToolStripMenuItem.Image = null;    
            }
        }

        //// Pour gérere/changer le font du texte séléctionné
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fontDialog1.ShowDialog();    
                System.Drawing.Font oldFont = this.Font;    

                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    fontDialog1_Apply(richTextBox1, new System.EventArgs());
                }
                
                else if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    
                    this.Font = oldFont;

                    
                    foreach (Control containedControl in richTextBox1.Controls)
                    {
                        containedControl.Font = oldFont;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information sur l'erreur", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning); // en cas de l'erreur
            }
        }

        //Methode pour aider l'utulisateur sur le choix des polices (fonts)
        private void fontDialog1_HelpRequest(object sender, EventArgs e)
        {
            // afficher le message d'aide 
            MessageBox.Show("Veuillez choisir une police et tout autre attribut, puis cliquez sur Appliquer et OK.", "Aide : boîte de dialogue des polices", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            fontDialog1.FontMustExist = true;    // Erreur si la police n'existe pas 

            richTextBox1.Font = fontDialog1.Font;    // Définir la police sélectionnée (y compris  : FontFamily, taille, et les effet . Il n'est pas nécessaire de les définir séparément)
            richTextBox1.ForeColor = fontDialog1.Color;    // set selected font color

            // définit la police pour les controlleurs  à l'intérieur de RTB
            foreach (Control containedControl in richTextBox1.Controls)
            {
                containedControl.Font = fontDialog1.Font;
            }
        }

        //Supprimer le texte sélectionner
        private void deleteStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = ""; 
        }


        // pour effacer tt les effets sur un texte
        private void clearFormattingStripButton_Click(object sender, EventArgs e)
        {
            fontStripComboBox.Text = "Famille de police";
            fontSizeComboBox.Text = "Taille de police";
            string pureText = richTextBox1.Text;    // selectionner le texte     
            richTextBox1.Clear();    // effacer le RTB
            richTextBox1.ForeColor = Color.Black;    // texte noir ( de base)
            richTextBox1.Font = default(Font);    // le font de base
            richTextBox1.Text = pureText;    // le mettre à l'etat d'origine
            rightAlignStripButton.Checked = false;
            centerAlignStripButton.Checked = false;
            leftAlignStripButton.Checked = true;
        }

        // dessine la chaîne de caractères sur le document d'impression ( préparer pour l'imrpession)
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {  
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 20);
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }


        //   permet d'imprimer le Contenu de RTB
        private void printStripButton_Click(object sender, EventArgs e)
        {
       
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); 
            }
        }

        //   permet d'avoir une aperçu avant impression 

        private void printPreviewStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        //   permet d'imprimer le Contenu de RTB depuis menu
        private void printStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        //   permet d'avoir une aperçu avant impression depuis menu
        private void printPreviewStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }

        private void colorDialog1_HelpRequest(object sender, EventArgs e)
        {
            // display HelpRequest message
            MessageBox.Show("Veuillez sélectionner une couleur en cliquant dessus. Cela changera la couleur du texte.", "Aide pour la boîte de dialogue des couleurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colorOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //****************************************************************************************************************************************
        // richTextBox1_KeyUp - Détermine quelle touche a été relâchée et obtient les numéros de ligne et de colonne de la position actuelle du curseur dans la RTB *.
        //**************************************************************************************************************************************** 
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // déterminer la clé libérée
            switch (e.KeyCode)
            {
                case Keys.Down:
                    pos = richTextBox1.SelectionStart;    // obtenir le point de départ
                    line = richTextBox1.GetLineFromCharIndex(pos);    // obtenir le numéro de ligne
                    column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Ligne " + (line + 1) + ", Colonne " + (column + 1);
                    break;
                case Keys.Right:
                    pos = richTextBox1.SelectionStart; // obtenir le point de départ
                    line = richTextBox1.GetLineFromCharIndex(pos); // obtenir le numéro de ligne
                    column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Ligne " + (line + 1) + ", Colonne " + (column + 1);
                    break;
                case Keys.Up:
                    pos = richTextBox1.SelectionStart; // obtenir le point de départ
                    line = richTextBox1.GetLineFromCharIndex(pos); // obtenir le numéro de ligne
                    column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Ligne " + (line + 1) + ", Colonne " + (column + 1);
                    break;
                case Keys.Left:
                    pos = richTextBox1.SelectionStart; // obtenir le point de départ
                    line = richTextBox1.GetLineFromCharIndex(pos); // obtenir le numéro de ligne
                    column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Ligne " + (line + 1) + ", Colonne " + (column + 1);
                    break;
            }
        }

        //****************************************************************************************************************************
        // richTextBox1_MouseDown - Gets the line and column numbers of the cursor position in the RTB when the mouse clicks an area *
        //****************************************************************************************************************************
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int pos = richTextBox1.SelectionStart;    // obtenir le point de départ
            int line = richTextBox1.GetLineFromCharIndex(pos);    // obtenir le numéro de ligne
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // // obtenir le numéro de colonne
            lineColumnStatusLabel.Text = "Ligne " + (line + 1) + ", Colonne " + (column + 1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {

        }



        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
        }

        // ce bloc permet d'ajouter un texte dans le champs Objet en fontion de type choisit
        private void cmbxProfilHide_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cmbxProfilHide.SelectedItem)
            {
                case "Invitation":
                    textBoxObjet.Text = "[INVITATION]";
                    break;

                case "Convocation":
                    textBoxObjet.Text = "[CONVOCATION]";
                    break;
                case "Urgent":
                    textBoxObjet.Text = "[URGENT]";
                    break;
                case "Avertissement":
                    textBoxObjet.Text = "[AVERTISSEMENT]";
                    break;
                case "Confidentiel":
                    textBoxObjet.Text = "[CONFIDENTIEL]";
                    break;
                case "à ne pas répondre":
                    textBoxObjet.Text = "[A NE PAS REPONDRE]";
                    break;
                default:
                    textBoxObjet.Text = "[INFORMATION]";
                    break;

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // permet de selectionner tout les emails dans la liste
        public void selectionnerTt()
        {
            for (int i = 0; i < chklistBxMailHide.Items.Count; i++)
            {
                chklistBxMailHide.SetItemChecked(i, true);
            }
            lblNmbrMail.Visible = true;
            lblNmbrMail.Text = "Adresses mails importeés :" + chklistBxMailHide.Items.Count.ToString();
        }

        // permet de déselectionner tout les emails dans la liste

        public void deselectionnerTt()
        {
            for (int i = 0; i < chklistBxMailHide.Items.Count; i++)
            {
                chklistBxMailHide.SetItemChecked(i, false);
            }
            lblNmbrMail.Text = "Adresses mails importeés :" + chklistBxMailHide.Items.Count.ToString();
        }

       // c'est le moteur pour envoyer les mail enfin c'est en arreir plan que ça fonctionne
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;

            // Une loop pour que chaque email dans selectionné dans la liste sera envoyé avec une duréé de 1sec entre chaque thraed


            try
            {
            foreach (string email in chklistBxMailHide.CheckedItems)

            {
                    string body = richTextBox1.Text;
                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body);  // en alterative envoyer msg en format HTML
                    MailMessage mailfinal = new MailMessage();
                mailfinal.From = new System.Net.Mail.MailAddress(txtbxuserHide.Text, TxtBoxExpiditeur.Text); // l'expiditeur de mail utilsiteur + l'expiditeur 
                mailfinal.Subject = textBoxObjet.Text;             // lobjet de mail
                mailfinal.IsBodyHtml = true;                       //Accepte le corp de message en HTML
                mailfinal.BodyEncoding = System.Text.Encoding.UTF8; // l'encodage de UTF8 pour aussi les autres langue ( ex arabe)
              mailfinal.AlternateViews.Add(htmlView);
              mailfinal.Body = richTextBox1.Text;
                mailfinal.To.Add(email);
                    
          // Protocle pour que le service (ex Google smtp) securise le trasfer de l'email
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                      | SecurityProtocolType.Tls11
                                                      | SecurityProtocolType.Tls12;
                }

                    
                SmtpClient smtpClient = new SmtpClient(txtbxIpHide.Text); // définir le smtpclient qui chargera de l'envoie
                smtpClient.Timeout = 30000;

                smtpClient.Port = int.Parse(txtbxportHide.Text.ToString()); // port parsé en int
                smtpClient.Credentials = new NetworkCredential(txtbxuserHide.Text, txtbxpassHide.Text); // represnete les élement de connexion user + pass
                smtpClient.EnableSsl = true; // par default c'est toujour activé sinon le mail sera envoyé et reçu ne SPAM


                Attachment atc = new Attachment(filenamejoindre); 
                mailfinal.Attachments.Add(atc);
                    smtpClient.Send(mailfinal); // FINALEMENT ENVOYER LE MESSAGE
            }

                btnEnvoyer.Enabled = true;

            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);

            }
            btnEnvoyer.Enabled = true;
        }


        // // permet de joindre un fichier au message 
        private void btnJPJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog attachment = new OpenFileDialog();
            attachment.Title = "Choisir un fichier";
            attachment.Filter = "Tout type de fichier (*.*) | *.*";


            if (attachment.ShowDialog() == DialogResult.OK)
            {

                Attachement1.Text = attachment.FileName;

                filenamejoindre = attachment.FileName.ToString();

            }
        }


        // une methode que qui permet de nettoyer la liste s'il ya des emails invalid ( ex un mail sans @, un mail avec espace etc...)
        private void Inputbox()
        {
            string ajoutToChk = Interaction.InputBox(msgBoxInputBox, titreInputBox, reponseDefault); // permet d'aajouter un mail individuel
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); // regex pour verifier la bonne format de l'email
            Match matchMail = regexMail.Match(ajoutToChk);


            if (matchMail.Success)

            {

                chklistBxMailHide.Items.Insert(0, ajoutToChk.ToString()); // le format de l'email est bonne >> ajout dans la liste

            }
            else



            ////////////// le format de l'emailn'est pas bonne >> Message pour rercommencer et recitifer 
            {
                const string message = "Votre adresse n'est pas une adresse valide";
                const string titre = "Erreur";
                var result = MessageBox.Show(message, titre,
                                             MessageBoxButtons.RetryCancel,
                                             MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {

                    Inputbox(); //// methode pour verifier le bon format de l'email
                }
            }
        }

        // Ajouter une mail individualement
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Inputbox(); // methode pour verifier le bon format de l'email
        }


        // permet de supprimer
        private void btnSuppri_Click(object sender, EventArgs e)
        {
            for (int i = chklistBxMailHide.Items.Count - 1; i >= 0; i--)
            {
   
                if (chklistBxMailHide.GetItemChecked(i))
                {
                    chklistBxMailHide.Items.Remove(chklistBxMailHide.Items[i]);
                }
                lblNmbrMail.Visible = true;
                lblNmbrMail.Text = "Adresses mails importeés :" + chklistBxMailHide.Items.Count.ToString();

            }
        }


        // permet de vider la liste ( supprimer tout les mail selectionné ou non dans la liste)
        private void bntVider_Click(object sender, EventArgs e)
        {

            // si reponse oui >> vider la lsite
            const string message = "Est-vous sur de vider la liste des email ?";
            const string titre = "Vider la liste";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                chklistBxMailHide.Items.Clear();
                chkbx_selectionnertt.Enabled = false;

            }
            else if (result == DialogResult.No)
            {
                // Si réponse non ne pas vider la liste
            }
            lblNmbrMail.Visible = true;
            lblNmbrMail.Text = "Adresses mails importeés :" + chklistBxMailHide.Items.Count.ToString();
        }

        // permet d'envoyer les emails selectionné dans la liste
        private void btnEnvoyer_Click_1(object sender, EventArgs e)
        {
            btnEnvoyer.Enabled = false;
            loaading_Gif.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void chklistBxMailHide_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        // c'est pour slectionner/ déselectionner les emails dans la liste

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

        private void joindre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            }

        // une fois l'envoie des emails est terminé
             private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
           {

            string message = "Votre message à été envoyé avec succées à " + chklistBxMailHide.Items.Count.ToString() + " " + "adresses mail";

            const string titre = "Message envoyé avec succées";
            var result = MessageBox.Show(message, titre,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }


    }
}
