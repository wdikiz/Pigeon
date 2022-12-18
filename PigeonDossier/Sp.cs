using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Ce form represente la Spalsh screen qui se met en affiche le temps que les autres elements se rechargeant 
namespace Pigeon
{
    public partial class Sp : Form
    {
        public Sp()
        {
            InitializeComponent();

           // permet de redemensionner en fonction de la taille de l'ecran ou logiciel et lancer  
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Resolution objFormResizer = new Resolution();
            objFormResizer.ResizeForm(this, screenHeight, screenWidth);
        }

        // une methode timer pour definir le temps necessaire au splash screen
        private void timer1_Tick(object sender, EventArgs e)
        {

            ProgressInnerPanel.Width += ProgressOuterPanel.Width / 30;


            if (ProgressInnerPanel.Width >= 1600)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                //  this.Close();
                frm1.BringToFront();
                // this.StartPosition = FormStartPosition.CenterScreen;
                frm1.MaximizeBox = false;
                frm1.MinimizeBox = false;
                frm1.FormBorderStyle = FormBorderStyle.None;
                frm1.Visible = true; // afficher le frm apres le temps


            }
        }

        Form1 frm1 = new Form1(); // initialisation de la form




        private void ProgressOuterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // pendan tle chargeement de la sp activer le timer / forncer l'affiche en avance de la sp
        private void Sp_Load(object sender, EventArgs e)
        {
            TopMost = true;
            BringToFront();
            timer1.Enabled = true;
        }



        // class pour s'adapter automatiquement au resolution des ecrans
        public class Resolution
        {
            float heightRatio = new float();
            float widthRatio = new float();
            int standardHeight, standardWidth;
            public void ResizeForm(Form objForm, int DesignerHeight, int DesignerWidth)
            {
                standardHeight = DesignerHeight;
                standardWidth = DesignerWidth;
                int presentHeight = Screen.PrimaryScreen.WorkingArea.Height;//.Bounds.Height;
                int presentWidth = Screen.PrimaryScreen.Bounds.Width;
                heightRatio = (float)((float)presentHeight / (float)standardHeight);
                widthRatio = (float)((float)presentWidth / (float)standardWidth);
                objForm.AutoScaleMode = AutoScaleMode.None;
                objForm.Scale(new SizeF(widthRatio, heightRatio));
                foreach (Control c in objForm.Controls)
                {
                    if (c.HasChildren)
                    {
                        ResizeControlStore(c);
                    }
                    else
                    {
                        c.Font = new Font(c.Font.FontFamily, c.Font.Size * heightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                    }
                }
                objForm.Font = new Font(objForm.Font.FontFamily, objForm.Font.Size * heightRatio, objForm.Font.Style, objForm.Font.Unit, ((byte)(0)));
            }

            private void ResizeControlStore(Control objCtl)
            {
                if (objCtl.HasChildren)
                {
                    foreach (Control cChildren in objCtl.Controls)
                    {
                        if (cChildren.HasChildren)
                        {
                            ResizeControlStore(cChildren);

                        }
                        else
                        {
                            cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * heightRatio, cChildren.Font.Style, cChildren.Font.Unit, ((byte)(0)));
                        }
                    }
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }
                else
                {
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }
            }
        }
    }
}
