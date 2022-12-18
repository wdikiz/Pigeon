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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            aide1.Visible= false;

        }


        // initliaser les integer

        int mov;
        int movX;
        int movY;

        
        // permet d'affiche le controleur de menu principale
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        myThirdUserControl2.BringToFront();
        }



        // permet d'affiche le controleur de SMTP 

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            smtpConfigControl2.BringToFront();
         button3.Enabled = true;
         button4.Enabled = true;
        }

        // permet d'affiche le controleur de menu principale


        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
         importExcel2.BringToFront();
            button1.Enabled = true;

        }

        //iNITILISATION DES ELEMENTS A CHARGER Y COMPRIS LES BUTTON ET LEUT STATU EN MOMENT DE LANCEMENT
        private void Form1_Load(object sender, EventArgs e)
        {

            panel2.BringToFront();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button5.Enabled = false;
            picbox2click.Visible = false;
          
        }

        //BUTTON DE Quitter en bas 
        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        // permet d'affiche le controleur d'importation Txt et cacher les autres


        private void button4_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
         importationUC2.BringToFront();
            button1.Enabled = true;


        }

        // button de csv prochainement il est actuellement desactive
        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
          //  importationUC1.BringToFront();
        }
        
        // le temps d'ajouter une Readme sur github et l;afficher directement sur cette zone 
        private void button6_Click(object sender, EventArgs e)
        {
           aide1.Visible = true;
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            aide1.BringToFront();
            
        }

        //BUTTON DE fermer EN HAUT
        private void picExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        // button pour agrandir la feneter // desactive pour le moment
        private void picMaximi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaximi.Visible = false;
            picbox2click.Visible = true;
        }

        // pour minimizer en bas la fenetre
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {



        }


        // permet de depalcer la fenetre 
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {

                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);


            }

        }

        // permet de depalcer la fenetre 

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        // permet de depalcer la fenetre 

        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {

            mov = 0;
        }
        // permet de depalcer la fenetre 

        private void picbox2click_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picbox2click.Visible = false;
            picMaximi.Visible = true;
        }



        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            Application.Exit();
            // importExcel1.BringToFront();
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gray;
            button1.BackColor = Color.Empty;
        }

        private void btncommencer_Click(object sender, EventArgs e)
        {
         //   SidePanel.Height = button2.Height;
         //   SidePanel.Top = button2.Top;
            //   mySecondCustmControl1.BringToFront();
         //   button3.Enabled = true;
         //   button4.Enabled = true;
        }

        private void btncommencer_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }


        // un button de test dans la V1 de la spalsh screen / desactive actuellement
        private void button8_Click_1(object sender, EventArgs e)
        {

            panel2.BringToFront();
          //  mySecondCustmControl2.Visible = false;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            smtpConfigControl2.BringToFront();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btncommencer.Visible = false;

        }


    }
}
