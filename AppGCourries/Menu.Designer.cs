namespace AppGCourries
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArrivees = new System.Windows.Forms.Button();
            this.btnSuivi = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.pMenu.Controls.Add(this.btnQuitter);
            this.pMenu.Controls.Add(this.btnStatistiques);
            this.pMenu.Controls.Add(this.btnDepart);
            this.pMenu.Controls.Add(this.btnSuivi);
            this.pMenu.Controls.Add(this.btnArrivees);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(908, 76);
            this.pMenu.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 76);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(908, 330);
            this.pContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnArrivees
            // 
            this.btnArrivees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrivees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnArrivees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrivees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrivees.Image = ((System.Drawing.Image)(resources.GetObject("btnArrivees.Image")));
            this.btnArrivees.Location = new System.Drawing.Point(170, 3);
            this.btnArrivees.Name = "btnArrivees";
            this.btnArrivees.Size = new System.Drawing.Size(136, 67);
            this.btnArrivees.TabIndex = 1;
            this.btnArrivees.Text = "Courrier Arrivée";
            this.btnArrivees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArrivees.UseVisualStyleBackColor = true;
            // 
            // btnSuivi
            // 
            this.btnSuivi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuivi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivi.Image = ((System.Drawing.Image)(resources.GetObject("btnSuivi.Image")));
            this.btnSuivi.Location = new System.Drawing.Point(312, 3);
            this.btnSuivi.Name = "btnSuivi";
            this.btnSuivi.Size = new System.Drawing.Size(136, 67);
            this.btnSuivi.TabIndex = 1;
            this.btnSuivi.Text = "Suivi Courrier";
            this.btnSuivi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuivi.UseVisualStyleBackColor = true;
            // 
            // btnDepart
            // 
            this.btnDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepart.Image = ((System.Drawing.Image)(resources.GetObject("btnDepart.Image")));
            this.btnDepart.Location = new System.Drawing.Point(454, 3);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(136, 67);
            this.btnDepart.TabIndex = 1;
            this.btnDepart.Text = "Courrier Départ";
            this.btnDepart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDepart.UseVisualStyleBackColor = true;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistiques.Image")));
            this.btnStatistiques.Location = new System.Drawing.Point(596, 3);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(136, 67);
            this.btnStatistiques.TabIndex = 1;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStatistiques.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.Location = new System.Drawing.Point(816, 0);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(92, 76);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 406);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnArrivees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Button btnSuivi;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnDepart;
        private System.Windows.Forms.Button btnQuitter;
    }
}