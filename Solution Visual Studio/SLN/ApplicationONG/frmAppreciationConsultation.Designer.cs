namespace ApplicationONG
{
    partial class frmAppreciationConsultation
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
            this.lvwAppreciation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntActualiser = new System.Windows.Forms.Button();
            this.bntConsulter = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.bntFermer3 = new System.Windows.Forms.Button();
            this.bntAjouter = new System.Windows.Forms.Button();
            this.txtCritere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwAppreciation
            // 
            this.lvwAppreciation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvwAppreciation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwAppreciation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAppreciation.FullRowSelect = true;
            this.lvwAppreciation.GridLines = true;
            this.lvwAppreciation.HideSelection = false;
            this.lvwAppreciation.Location = new System.Drawing.Point(33, 57);
            this.lvwAppreciation.Name = "lvwAppreciation";
            this.lvwAppreciation.Size = new System.Drawing.Size(754, 293);
            this.lvwAppreciation.TabIndex = 23;
            this.lvwAppreciation.UseCompatibleStateImageBehavior = false;
            this.lvwAppreciation.View = System.Windows.Forms.View.Details;
            this.lvwAppreciation.SelectedIndexChanged += new System.EventHandler(this.lvwAppreciation_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Responsable";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code Activité";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Appréciation";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Justif. Recettes";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Justif. Depense";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 149;
            // 
            // bntActualiser
            // 
            this.bntActualiser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntActualiser.Location = new System.Drawing.Point(665, 12);
            this.bntActualiser.Name = "bntActualiser";
            this.bntActualiser.Size = new System.Drawing.Size(94, 26);
            this.bntActualiser.TabIndex = 22;
            this.bntActualiser.Text = "Actualliser";
            this.bntActualiser.UseVisualStyleBackColor = true;
            this.bntActualiser.Click += new System.EventHandler(this.bntActualiser_Click);
            // 
            // bntConsulter
            // 
            this.bntConsulter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsulter.Location = new System.Drawing.Point(253, 399);
            this.bntConsulter.Name = "bntConsulter";
            this.bntConsulter.Size = new System.Drawing.Size(94, 26);
            this.bntConsulter.TabIndex = 21;
            this.bntConsulter.Text = "&Consulter";
            this.bntConsulter.UseVisualStyleBackColor = true;
            this.bntConsulter.Click += new System.EventHandler(this.bntConsulter_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntModifier.Location = new System.Drawing.Point(353, 399);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(94, 26);
            this.bntModifier.TabIndex = 20;
            this.bntModifier.Text = "&Modifier";
            this.bntModifier.UseVisualStyleBackColor = true;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(453, 399);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(94, 26);
            this.bntSupprimer.TabIndex = 19;
            this.bntSupprimer.Text = "&Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = true;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // bntFermer3
            // 
            this.bntFermer3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFermer3.Location = new System.Drawing.Point(665, 399);
            this.bntFermer3.Name = "bntFermer3";
            this.bntFermer3.Size = new System.Drawing.Size(94, 26);
            this.bntFermer3.TabIndex = 18;
            this.bntFermer3.Text = "&Fermer";
            this.bntFermer3.UseVisualStyleBackColor = true;
            this.bntFermer3.Click += new System.EventHandler(this.bntFermer3_Click);
            // 
            // bntAjouter
            // 
            this.bntAjouter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAjouter.Location = new System.Drawing.Point(153, 399);
            this.bntAjouter.Name = "bntAjouter";
            this.bntAjouter.Size = new System.Drawing.Size(94, 26);
            this.bntAjouter.TabIndex = 17;
            this.bntAjouter.Text = "&Ajouter";
            this.bntAjouter.UseVisualStyleBackColor = true;
            this.bntAjouter.Click += new System.EventHandler(this.bntAjouter_Click);
            // 
            // txtCritere
            // 
            this.txtCritere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritere.Location = new System.Drawing.Point(374, 12);
            this.txtCritere.Name = "txtCritere";
            this.txtCritere.Size = new System.Drawing.Size(251, 26);
            this.txtCritere.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code Activité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(16, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 42);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(16, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(789, 321);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // frmAppreciationConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(813, 442);
            this.Controls.Add(this.lvwAppreciation);
            this.Controls.Add(this.bntActualiser);
            this.Controls.Add(this.bntConsulter);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.bntFermer3);
            this.Controls.Add(this.bntAjouter);
            this.Controls.Add(this.txtCritere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppreciationConsultation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appréciations";
            this.Load += new System.EventHandler(this.frmAppreciationConsulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwAppreciation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button bntActualiser;
        private System.Windows.Forms.Button bntConsulter;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button bntSupprimer;
        private System.Windows.Forms.Button bntFermer3;
        private System.Windows.Forms.Button bntAjouter;
        private System.Windows.Forms.TextBox txtCritere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;


    }
}