namespace Jump__n_run
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrwalkright = new System.Windows.Forms.Timer(this.components);
            this.tmrwalkleft = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tmrWalk = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbGround2 = new System.Windows.Forms.PictureBox();
            this.pbGround1 = new System.Windows.Forms.PictureBox();
            this.pbBackground2 = new System.Windows.Forms.PictureBox();
            this.pbBackground1 = new System.Windows.Forms.PictureBox();
            this.pbGroundCollision = new System.Windows.Forms.PictureBox();
            this.tmrMomentum = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroundCollision)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrwalkright
            // 
            this.tmrwalkright.Interval = 17;
            this.tmrwalkright.Tick += new System.EventHandler(this.tmrwalkright_Tick);
            // 
            // tmrwalkleft
            // 
            this.tmrwalkleft.Interval = 17;
            this.tmrwalkleft.Tick += new System.EventHandler(this.tmrwalkleft_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Interval = 17;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tmrWalk
            // 
            this.tmrWalk.Interval = 17;
            this.tmrWalk.Tick += new System.EventHandler(this.tmrWalk_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Maroon;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer.Location = new System.Drawing.Point(162, 330);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbGround2
            // 
            this.pbGround2.BackgroundImage = global::Jump__n_run.Properties.Resources.ground;
            this.pbGround2.Location = new System.Drawing.Point(800, 400);
            this.pbGround2.Name = "pbGround2";
            this.pbGround2.Size = new System.Drawing.Size(800, 50);
            this.pbGround2.TabIndex = 4;
            this.pbGround2.TabStop = false;
            // 
            // pbGround1
            // 
            this.pbGround1.BackgroundImage = global::Jump__n_run.Properties.Resources.ground;
            this.pbGround1.Location = new System.Drawing.Point(0, 400);
            this.pbGround1.Name = "pbGround1";
            this.pbGround1.Size = new System.Drawing.Size(800, 50);
            this.pbGround1.TabIndex = 2;
            this.pbGround1.TabStop = false;
            // 
            // pbBackground2
            // 
            this.pbBackground2.Image = global::Jump__n_run.Properties.Resources.background;
            this.pbBackground2.Location = new System.Drawing.Point(800, 0);
            this.pbBackground2.Name = "pbBackground2";
            this.pbBackground2.Size = new System.Drawing.Size(800, 450);
            this.pbBackground2.TabIndex = 1;
            this.pbBackground2.TabStop = false;
            // 
            // pbBackground1
            // 
            this.pbBackground1.Image = global::Jump__n_run.Properties.Resources.background;
            this.pbBackground1.Location = new System.Drawing.Point(0, 0);
            this.pbBackground1.Name = "pbBackground1";
            this.pbBackground1.Size = new System.Drawing.Size(800, 450);
            this.pbBackground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground1.TabIndex = 0;
            this.pbBackground1.TabStop = false;
            // 
            // pbGroundCollision
            // 
            this.pbGroundCollision.Location = new System.Drawing.Point(0, 400);
            this.pbGroundCollision.Name = "pbGroundCollision";
            this.pbGroundCollision.Size = new System.Drawing.Size(800, 50);
            this.pbGroundCollision.TabIndex = 5;
            this.pbGroundCollision.TabStop = false;
            // 
            // tmrMomentum
            // 
            this.tmrMomentum.Interval = 17;
            this.tmrMomentum.Tick += new System.EventHandler(this.tmrMomentum_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbGround2);
            this.Controls.Add(this.pbGround1);
            this.Controls.Add(this.pbBackground2);
            this.Controls.Add(this.pbBackground1);
            this.Controls.Add(this.pbGroundCollision);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Jump \'n run";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroundCollision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground1;
        private System.Windows.Forms.PictureBox pbBackground2;
        private System.Windows.Forms.Timer tmrwalkright;
        private System.Windows.Forms.PictureBox pbGround1;
        private System.Windows.Forms.Timer tmrwalkleft;
        private System.Windows.Forms.PictureBox pbGround2;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.PictureBox pbGroundCollision;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer tmrWalk;
        private System.Windows.Forms.Timer tmrMomentum;
    }
}

