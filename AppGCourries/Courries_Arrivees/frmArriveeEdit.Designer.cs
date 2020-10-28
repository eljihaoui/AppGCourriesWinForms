namespace AppGCourries.Courries_Arrivees
{
    partial class frmArriveeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArriveeEdit));
            this.txtTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCourrier = new System.Windows.Forms.TextBox();
            this.txtDateOrdre = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.txtEntite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCateg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSujet = new System.Windows.Forms.TextBox();
            this.txtDateCourrier = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvArriveeDocs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.PictureBox();
            this.btnUploadMoreFiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArriveeDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.BackColor = System.Drawing.Color.Transparent;
            this.txtTitre.Location = new System.Drawing.Point(36, 9);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(150, 20);
            this.txtTitre.TabIndex = 3;
            this.txtTitre.Text = "Edtion Courrier N° : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Ordre :";
            // 
            // txtNumCourrier
            // 
            this.txtNumCourrier.Location = new System.Drawing.Point(11, 94);
            this.txtNumCourrier.Name = "txtNumCourrier";
            this.txtNumCourrier.Size = new System.Drawing.Size(225, 26);
            this.txtNumCourrier.TabIndex = 6;
            // 
            // txtDateOrdre
            // 
            this.txtDateOrdre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateOrdre.Location = new System.Drawing.Point(11, 33);
            this.txtDateOrdre.Name = "txtDateOrdre";
            this.txtDateOrdre.Size = new System.Drawing.Size(225, 26);
            this.txtDateOrdre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Ordre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRemarque);
            this.groupBox1.Controls.Add(this.txtEntite);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCateg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSujet);
            this.groupBox1.Controls.Add(this.txtDateCourrier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumCourrier);
            this.groupBox1.Controls.Add(this.txtDateOrdre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 318);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Remarques :";
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(295, 222);
            this.txtRemarque.Multiline = true;
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(201, 73);
            this.txtRemarque.TabIndex = 17;
            // 
            // txtEntite
            // 
            this.txtEntite.FormattingEnabled = true;
            this.txtEntite.Location = new System.Drawing.Point(295, 154);
            this.txtEntite.Name = "txtEntite";
            this.txtEntite.Size = new System.Drawing.Size(201, 28);
            this.txtEntite.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entité :";
            // 
            // txtCateg
            // 
            this.txtCateg.FormattingEnabled = true;
            this.txtCateg.Location = new System.Drawing.Point(295, 92);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(201, 28);
            this.txtCateg.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Catégorie :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sujet : ";
            // 
            // txtSujet
            // 
            this.txtSujet.Location = new System.Drawing.Point(11, 222);
            this.txtSujet.Multiline = true;
            this.txtSujet.Name = "txtSujet";
            this.txtSujet.Size = new System.Drawing.Size(225, 73);
            this.txtSujet.TabIndex = 11;
            // 
            // txtDateCourrier
            // 
            this.txtDateCourrier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateCourrier.Location = new System.Drawing.Point(11, 156);
            this.txtDateCourrier.Name = "txtDateCourrier";
            this.txtDateCourrier.Size = new System.Drawing.Size(225, 26);
            this.txtDateCourrier.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Courrier :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvArriveeDocs);
            this.groupBox2.Location = new System.Drawing.Point(522, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 318);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgvArriveeDocs
            // 
            this.dgvArriveeDocs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArriveeDocs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArriveeDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArriveeDocs.Location = new System.Drawing.Point(7, 13);
            this.dgvArriveeDocs.Name = "dgvArriveeDocs";
            this.dgvArriveeDocs.RowHeadersWidth = 62;
            this.dgvArriveeDocs.RowTemplate.Height = 35;
            this.dgvArriveeDocs.Size = new System.Drawing.Size(393, 299);
            this.dgvArriveeDocs.TabIndex = 0;
            this.dgvArriveeDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArriveeDocs_CellContentClick);
            this.dgvArriveeDocs.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArriveeDocs_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(521, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Les pièces Jointes :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("btnEnregistrer.Image")));
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(358, 362);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(157, 33);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.Location = new System.Drawing.Point(898, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(34, 28);
            this.btnQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.TabStop = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnUploadMoreFiles
            // 
            this.btnUploadMoreFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUploadMoreFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadMoreFiles.FlatAppearance.BorderSize = 0;
            this.btnUploadMoreFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadMoreFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadMoreFiles.Image")));
            this.btnUploadMoreFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadMoreFiles.Location = new System.Drawing.Point(724, 9);
            this.btnUploadMoreFiles.Name = "btnUploadMoreFiles";
            this.btnUploadMoreFiles.Size = new System.Drawing.Size(117, 26);
            this.btnUploadMoreFiles.TabIndex = 13;
            this.btnUploadMoreFiles.Text = "     Parcourrir ....";
            this.btnUploadMoreFiles.UseVisualStyleBackColor = false;
            this.btnUploadMoreFiles.Click += new System.EventHandler(this.btnUploadMoreFiles_Click);
            // 
            // frmArriveeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 407);
            this.Controls.Add(this.btnUploadMoreFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArriveeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArriveeAdd";
            this.Load += new System.EventHandler(this.frmArriveeEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArriveeDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCourrier;
        private System.Windows.Forms.DateTimePicker txtDateOrdre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSujet;
        private System.Windows.Forms.DateTimePicker txtDateCourrier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.ComboBox txtEntite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtCateg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvArriveeDocs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadMoreFiles;
    }
}