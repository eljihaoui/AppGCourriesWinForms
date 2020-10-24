namespace AppGCourries
{
    partial class ListArrivee
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListArrivee));
            this.dataGridArrivee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.txtCritere = new System.Windows.Forms.TextBox();
            this.txtDateDeb = new System.Windows.Forms.DateTimePicker();
            this.txtDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.useDate = new System.Windows.Forms.CheckBox();
            this.btnPrintListArrivee = new System.Windows.Forms.Button();
            this.btnExporterToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArrivee
            // 
            this.dataGridArrivee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArrivee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArrivee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridArrivee.Location = new System.Drawing.Point(4, 37);
            this.dataGridArrivee.Name = "dataGridArrivee";
            this.dataGridArrivee.Size = new System.Drawing.Size(890, 276);
            this.dataGridArrivee.TabIndex = 0;
            this.dataGridArrivee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArrivee_CellClick);
            this.dataGridArrivee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArrivee_CellContentClick);
            this.dataGridArrivee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArrivee_CellContentDoubleClick);
            this.dataGridArrivee.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArrivee_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste de Courriers Arrivées";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNouveau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.Location = new System.Drawing.Point(4, 328);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(140, 37);
            this.btnNouveau.TabIndex = 3;
            this.btnNouveau.Text = "Nouveau ";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // txtCritere
            // 
            this.txtCritere.Location = new System.Drawing.Point(271, 7);
            this.txtCritere.Name = "txtCritere";
            this.txtCritere.Size = new System.Drawing.Size(145, 26);
            this.txtCritere.TabIndex = 4;
            // 
            // txtDateDeb
            // 
            this.txtDateDeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateDeb.Location = new System.Drawing.Point(507, 7);
            this.txtDateDeb.Name = "txtDateDeb";
            this.txtDateDeb.Size = new System.Drawing.Size(110, 26);
            this.txtDateDeb.TabIndex = 5;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateFin.Location = new System.Drawing.Point(623, 7);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(116, 26);
            this.txtDateFin.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(743, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // useDate
            // 
            this.useDate.AutoSize = true;
            this.useDate.Location = new System.Drawing.Point(422, 7);
            this.useDate.Name = "useDate";
            this.useDate.Size = new System.Drawing.Size(64, 24);
            this.useDate.TabIndex = 8;
            this.useDate.Text = "Date";
            this.useDate.UseVisualStyleBackColor = true;
            // 
            // btnPrintListArrivee
            // 
            this.btnPrintListArrivee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintListArrivee.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrintListArrivee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintListArrivee.FlatAppearance.BorderSize = 0;
            this.btnPrintListArrivee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintListArrivee.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintListArrivee.Image")));
            this.btnPrintListArrivee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintListArrivee.Location = new System.Drawing.Point(161, 328);
            this.btnPrintListArrivee.Name = "btnPrintListArrivee";
            this.btnPrintListArrivee.Size = new System.Drawing.Size(140, 37);
            this.btnPrintListArrivee.TabIndex = 9;
            this.btnPrintListArrivee.Text = "Imprimer";
            this.btnPrintListArrivee.UseVisualStyleBackColor = false;
            this.btnPrintListArrivee.Click += new System.EventHandler(this.btnPrintListArrivee_Click);
            // 
            // btnExporterToExcel
            // 
            this.btnExporterToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExporterToExcel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExporterToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExporterToExcel.FlatAppearance.BorderSize = 0;
            this.btnExporterToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporterToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExporterToExcel.Image")));
            this.btnExporterToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExporterToExcel.Location = new System.Drawing.Point(326, 328);
            this.btnExporterToExcel.Name = "btnExporterToExcel";
            this.btnExporterToExcel.Size = new System.Drawing.Size(140, 37);
            this.btnExporterToExcel.TabIndex = 10;
            this.btnExporterToExcel.Text = "Exporter";
            this.btnExporterToExcel.UseVisualStyleBackColor = false;
            this.btnExporterToExcel.Click += new System.EventHandler(this.btnExporterToExcel_Click);
            // 
            // ListArrivee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExporterToExcel);
            this.Controls.Add(this.btnPrintListArrivee);
            this.Controls.Add(this.useDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDeb);
            this.Controls.Add(this.txtCritere);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridArrivee);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListArrivee";
            this.Size = new System.Drawing.Size(905, 389);
            this.Load += new System.EventHandler(this.ListArrivee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArrivee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtCritere;
        private System.Windows.Forms.DateTimePicker txtDateDeb;
        private System.Windows.Forms.DateTimePicker txtDateFin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox useDate;
        private System.Windows.Forms.Button btnPrintListArrivee;
        private System.Windows.Forms.Button btnExporterToExcel;
    }
}
