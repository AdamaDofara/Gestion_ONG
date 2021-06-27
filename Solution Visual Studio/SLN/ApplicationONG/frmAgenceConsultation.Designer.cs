
namespace ApplicationONG
{
    partial class frmAgenceConsultation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCritere = new System.Windows.Forms.TextBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.bntFermer3 = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.bntConsulter = new System.Windows.Forms.Button();
            this.bntActualiser = new System.Windows.Forms.Button();
            this.lvwAgence = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville de l\'Agence";
            // 
            // txtCritere
            // 
            this.txtCritere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritere.Location = new System.Drawing.Point(364, 12);
            this.txtCritere.Name = "txtCritere";
            this.txtCritere.Size = new System.Drawing.Size(251, 26);
            this.txtCritere.TabIndex = 1;
            this.txtCritere.TextChanged += new System.EventHandler(this.txtCritere_TextChanged);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(143, 399);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(94, 26);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "&Ajouter";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.bntAjouter_Click);
            // 
            // bntFermer3
            // 
            this.bntFermer3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFermer3.Location = new System.Drawing.Point(655, 399);
            this.bntFermer3.Name = "bntFermer3";
            this.bntFermer3.Size = new System.Drawing.Size(94, 26);
            this.bntFermer3.TabIndex = 4;
            this.bntFermer3.Text = "&Fermer";
            this.bntFermer3.UseVisualStyleBackColor = true;
            this.bntFermer3.Click += new System.EventHandler(this.bntFermer3_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(443, 399);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(94, 26);
            this.bntSupprimer.TabIndex = 5;
            this.bntSupprimer.Text = "&Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = true;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntModifier.Location = new System.Drawing.Point(343, 399);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(94, 26);
            this.bntModifier.TabIndex = 6;
            this.bntModifier.Text = "&Modifier";
            this.bntModifier.UseVisualStyleBackColor = true;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // bntConsulter
            // 
            this.bntConsulter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsulter.Location = new System.Drawing.Point(243, 399);
            this.bntConsulter.Name = "bntConsulter";
            this.bntConsulter.Size = new System.Drawing.Size(94, 26);
            this.bntConsulter.TabIndex = 7;
            this.bntConsulter.Text = "&Consulter";
            this.bntConsulter.UseVisualStyleBackColor = true;
            this.bntConsulter.Click += new System.EventHandler(this.bntConsulter_Click);
            // 
            // bntActualiser
            // 
            this.bntActualiser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntActualiser.Location = new System.Drawing.Point(655, 12);
            this.bntActualiser.Name = "bntActualiser";
            this.bntActualiser.Size = new System.Drawing.Size(94, 26);
            this.bntActualiser.TabIndex = 10;
            this.bntActualiser.Text = "Actualliser";
            this.bntActualiser.UseVisualStyleBackColor = true;
            this.bntActualiser.Click += new System.EventHandler(this.bntActualiser_Click);
            // 
            // lvwAgence
            // 
            this.lvwAgence.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvwAgence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwAgence.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAgence.FullRowSelect = true;
            this.lvwAgence.GridLines = true;
            this.lvwAgence.HideSelection = false;
            this.lvwAgence.Location = new System.Drawing.Point(23, 57);
            this.lvwAgence.Name = "lvwAgence";
            this.lvwAgence.Size = new System.Drawing.Size(754, 293);
            this.lvwAgence.TabIndex = 12;
            this.lvwAgence.UseCompatibleStateImageBehavior = false;
            this.lvwAgence.View = System.Windows.Forms.View.Details;
            this.lvwAgence.SelectedIndexChanged += new System.EventHandler(this.lvwAgence_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Agence";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code Responsable";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ville Agence";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pays Agence";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Continent Agence";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 149;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(6, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 42);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(6, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(789, 321);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // frmAgenceConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.lvwAgence);
            this.Controls.Add(this.bntActualiser);
            this.Controls.Add(this.bntConsulter);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.bntFermer3);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.txtCritere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgenceConsultation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agences";
            this.Load += new System.EventHandler(this.frmDepotClientChoix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCritere;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button bntFermer3;
        private System.Windows.Forms.Button bntSupprimer;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button bntConsulter;
        private System.Windows.Forms.Button bntActualiser;
        private System.Windows.Forms.ListView lvwAgence;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}