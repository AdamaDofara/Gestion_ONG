namespace ApplicationONG
{
    partial class frmResponsableConsultation
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
            this.lvwResponsable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntActualiser = new System.Windows.Forms.Button();
            this.bntConsulter = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.bntFermer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.txtCritere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwResponsable
            // 
            this.lvwResponsable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvwResponsable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwResponsable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwResponsable.FullRowSelect = true;
            this.lvwResponsable.GridLines = true;
            this.lvwResponsable.HideSelection = false;
            this.lvwResponsable.HoverSelection = true;
            this.lvwResponsable.Location = new System.Drawing.Point(32, 57);
            this.lvwResponsable.MultiSelect = false;
            this.lvwResponsable.Name = "lvwResponsable";
            this.lvwResponsable.Size = new System.Drawing.Size(754, 293);
            this.lvwResponsable.TabIndex = 34;
            this.lvwResponsable.UseCompatibleStateImageBehavior = false;
            this.lvwResponsable.View = System.Windows.Forms.View.Details;
            this.lvwResponsable.SelectedIndexChanged += new System.EventHandler(this.lvwResponsable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Responsable";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom Responsable";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 269;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom Responsable";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 294;
            // 
            // bntActualiser
            // 
            this.bntActualiser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntActualiser.Location = new System.Drawing.Point(664, 12);
            this.bntActualiser.Name = "bntActualiser";
            this.bntActualiser.Size = new System.Drawing.Size(94, 26);
            this.bntActualiser.TabIndex = 33;
            this.bntActualiser.Text = "Actualliser";
            this.bntActualiser.UseVisualStyleBackColor = true;
            this.bntActualiser.Click += new System.EventHandler(this.bntActualiser_Click);
            // 
            // bntConsulter
            // 
            this.bntConsulter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsulter.Location = new System.Drawing.Point(252, 399);
            this.bntConsulter.Name = "bntConsulter";
            this.bntConsulter.Size = new System.Drawing.Size(94, 26);
            this.bntConsulter.TabIndex = 32;
            this.bntConsulter.Text = "&Consulter";
            this.bntConsulter.UseVisualStyleBackColor = true;
            this.bntConsulter.Click += new System.EventHandler(this.bntConsulter_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntModifier.Location = new System.Drawing.Point(352, 399);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(94, 26);
            this.bntModifier.TabIndex = 31;
            this.bntModifier.Text = "&Modifier";
            this.bntModifier.UseVisualStyleBackColor = true;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(452, 399);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(94, 26);
            this.bntSupprimer.TabIndex = 30;
            this.bntSupprimer.Text = "&Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = true;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // bntFermer
            // 
            this.bntFermer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFermer.Location = new System.Drawing.Point(664, 399);
            this.bntFermer.Name = "bntFermer";
            this.bntFermer.Size = new System.Drawing.Size(94, 26);
            this.bntFermer.TabIndex = 29;
            this.bntFermer.Text = "&Fermer";
            this.bntFermer.UseVisualStyleBackColor = true;
            this.bntFermer.Click += new System.EventHandler(this.bntFermer3_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(152, 399);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(94, 26);
            this.btnNouveau.TabIndex = 28;
            this.btnNouveau.Text = "&Ajouter";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.bntAjouter_Click);
            // 
            // txtCritere
            // 
            this.txtCritere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritere.Location = new System.Drawing.Point(373, 12);
            this.txtCritere.Name = "txtCritere";
            this.txtCritere.Size = new System.Drawing.Size(251, 26);
            this.txtCritere.TabIndex = 27;
            this.txtCritere.TextChanged += new System.EventHandler(this.txtCritere_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom Responsable";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(15, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 42);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(15, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(789, 321);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // frmResponsableConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(821, 442);
            this.Controls.Add(this.lvwResponsable);
            this.Controls.Add(this.bntActualiser);
            this.Controls.Add(this.bntConsulter);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.bntFermer);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.txtCritere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmResponsableConsultation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsables d\'agence";
            this.Load += new System.EventHandler(this.frmResponsableGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwResponsable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button bntActualiser;
        private System.Windows.Forms.Button bntConsulter;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button bntSupprimer;
        private System.Windows.Forms.Button bntFermer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtCritere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}