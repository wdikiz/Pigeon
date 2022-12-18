namespace Pigeon
{
    partial class Sp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sp));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressOuterPanel = new System.Windows.Forms.Panel();
            this.ProgressInnerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPigeon = new System.Windows.Forms.PictureBox();
            this.picText = new System.Windows.Forms.PictureBox();
            this.ProgressOuterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPigeon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressOuterPanel
            // 
            this.ProgressOuterPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressOuterPanel.Controls.Add(this.ProgressInnerPanel);
            this.ProgressOuterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressOuterPanel.ForeColor = System.Drawing.Color.IndianRed;
            this.ProgressOuterPanel.Location = new System.Drawing.Point(0, 759);
            this.ProgressOuterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressOuterPanel.Name = "ProgressOuterPanel";
            this.ProgressOuterPanel.Size = new System.Drawing.Size(1582, 15);
            this.ProgressOuterPanel.TabIndex = 2;
            this.ProgressOuterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressOuterPanel_Paint);
            // 
            // ProgressInnerPanel
            // 
            this.ProgressInnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(218)))), ((int)(((byte)(157)))));
            this.ProgressInnerPanel.Location = new System.Drawing.Point(0, 0);
            this.ProgressInnerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressInnerPanel.Name = "ProgressInnerPanel";
            this.ProgressInnerPanel.Size = new System.Drawing.Size(0, 8);
            this.ProgressInnerPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pigeon.Properties.Resources.textgood6;
            this.pictureBox1.Location = new System.Drawing.Point(991, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // picPigeon
            // 
            this.picPigeon.BackColor = System.Drawing.Color.Transparent;
            this.picPigeon.Image = global::Pigeon.Properties.Resources.katban_good2;
            this.picPigeon.Location = new System.Drawing.Point(598, 64);
            this.picPigeon.Name = "picPigeon";
            this.picPigeon.Size = new System.Drawing.Size(360, 397);
            this.picPigeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPigeon.TabIndex = 0;
            this.picPigeon.TabStop = false;
            // 
            // picText
            // 
            this.picText.BackColor = System.Drawing.Color.Transparent;
            this.picText.Image = global::Pigeon.Properties.Resources.txtblancgood;
            this.picText.Location = new System.Drawing.Point(608, 488);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(340, 104);
            this.picText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picText.TabIndex = 1;
            this.picText.TabStop = false;
            // 
            // Sp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pigeon.Properties.Resources.backgrd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 774);
            this.ControlBox = false;
            this.Controls.Add(this.picText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picPigeon);
            this.Controls.Add(this.ProgressOuterPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sp";
            this.Load += new System.EventHandler(this.Sp_Load);
            this.ProgressOuterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPigeon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPigeon;
        private System.Windows.Forms.PictureBox picText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ProgressOuterPanel;
        private System.Windows.Forms.Panel ProgressInnerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}