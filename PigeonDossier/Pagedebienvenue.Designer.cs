namespace Pigeon
{
    partial class Pagedebienvenue
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncommencer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Sender ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Creer Dans le cadre de M2i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ce logiciel est déstiné à etre utilisé, pour envoyer des Mails\r\n";
            // 
            // btncommencer
            // 
            this.btncommencer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(162)))), ((int)(((byte)(229)))));
            this.btncommencer.FlatAppearance.BorderSize = 0;
            this.btncommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommencer.ForeColor = System.Drawing.Color.White;
            this.btncommencer.Location = new System.Drawing.Point(132, 373);
            this.btncommencer.Name = "btncommencer";
            this.btncommencer.Size = new System.Drawing.Size(190, 46);
            this.btncommencer.TabIndex = 5;
            this.btncommencer.Text = "Commencer";
            this.btncommencer.UseVisualStyleBackColor = false;
            this.btncommencer.Click += new System.EventHandler(this.btncommencer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pigeon.Properties.Resources._1247607919_ai_3_;
            this.pictureBox1.Location = new System.Drawing.Point(490, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Pagedebienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncommencer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Pagedebienvenue";
            this.Size = new System.Drawing.Size(1315, 681);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncommencer;
    }
}
