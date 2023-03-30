namespace FlappyUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.pboxAlt = new System.Windows.Forms.PictureBox();
            this.pboxKafa = new System.Windows.Forms.PictureBox();
            this.pboxYukari = new System.Windows.Forms.PictureBox();
            this.pboxAsagi = new System.Windows.Forms.PictureBox();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAsagi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScore.Location = new System.Drawing.Point(12, 20);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(53, 20);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Skor:";
            // 
            // pboxAlt
            // 
            this.pboxAlt.Image = global::FlappyUI.Properties.Resources._0a369167f640e62;
            this.pboxAlt.Location = new System.Drawing.Point(-6, 513);
            this.pboxAlt.Name = "pboxAlt";
            this.pboxAlt.Size = new System.Drawing.Size(1145, 115);
            this.pboxAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAlt.TabIndex = 3;
            this.pboxAlt.TabStop = false;
            // 
            // pboxKafa
            // 
            this.pboxKafa.BackColor = System.Drawing.Color.Cyan;
            this.pboxKafa.Image = ((System.Drawing.Image)(resources.GetObject("pboxKafa.Image")));
            this.pboxKafa.Location = new System.Drawing.Point(47, 191);
            this.pboxKafa.Name = "pboxKafa";
            this.pboxKafa.Size = new System.Drawing.Size(56, 48);
            this.pboxKafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKafa.TabIndex = 1;
            this.pboxKafa.TabStop = false;
            // 
            // pboxYukari
            // 
            this.pboxYukari.BackColor = System.Drawing.Color.Cyan;
            this.pboxYukari.Image = ((System.Drawing.Image)(resources.GetObject("pboxYukari.Image")));
            this.pboxYukari.Location = new System.Drawing.Point(414, -66);
            this.pboxYukari.Name = "pboxYukari";
            this.pboxYukari.Size = new System.Drawing.Size(118, 161);
            this.pboxYukari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxYukari.TabIndex = 0;
            this.pboxYukari.TabStop = false;
            // 
            // pboxAsagi
            // 
            this.pboxAsagi.BackColor = System.Drawing.Color.Cyan;
            this.pboxAsagi.Image = ((System.Drawing.Image)(resources.GetObject("pboxAsagi.Image")));
            this.pboxAsagi.Location = new System.Drawing.Point(274, 355);
            this.pboxAsagi.Name = "pboxAsagi";
            this.pboxAsagi.Size = new System.Drawing.Size(118, 161);
            this.pboxAsagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAsagi.TabIndex = 2;
            this.pboxAsagi.TabStop = false;
            // 
            // timerControl
            // 
            this.timerControl.Enabled = true;
            this.timerControl.Interval = 20;
            this.timerControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1127, 621);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pboxAlt);
            this.Controls.Add(this.pboxAsagi);
            this.Controls.Add(this.pboxKafa);
            this.Controls.Add(this.pboxYukari);
            this.Name = "Form1";
            this.Text = "FlappyZort";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAsagi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxYukari;
        private System.Windows.Forms.PictureBox pboxKafa;
        private System.Windows.Forms.PictureBox pboxAlt;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pboxAsagi;
        private System.Windows.Forms.Timer timerControl;
    }
}

