namespace Pigeon
{
    partial class MySecondCustmControl
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
            this.lbBonjour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBonjour
            // 
            this.lbBonjour.AutoSize = true;
            this.lbBonjour.Font = new System.Drawing.Font("Gentium Book Basic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBonjour.Location = new System.Drawing.Point(470, 363);
            this.lbBonjour.Name = "lbBonjour";
            this.lbBonjour.Size = new System.Drawing.Size(152, 42);
            this.lbBonjour.TabIndex = 1;
            this.lbBonjour.Text = "Bonjour";
            this.lbBonjour.Click += new System.EventHandler(this.lbBonjour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Envoyer autant de mail que vous souhaitez sans limites.\r\nCommençons par régler vo" +
    "s configurations";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pigeon.Properties.Resources.waving_hand_emoji_32px;
            this.pictureBox2.Location = new System.Drawing.Point(628, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pigeon.Properties.Resources._1704468133_ai;
            this.pictureBox1.Location = new System.Drawing.Point(439, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Book Basic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue à Pigeon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MySecondCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBonjour);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MySecondCustmControl";
            this.Size = new System.Drawing.Size(1315, 681);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBonjour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
