namespace ApplicationONG
{
    partial class frmActiviteNouveau
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
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.txtagencode = new System.Windows.Forms.TextBox();
            this.txtactidepense = new System.Windows.Forms.TextBox();
            this.txtactirecette = new System.Windows.Forms.TextBox();
            this.txtacticode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtactidate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.MistyRose;
            this.btnenregistrer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Location = new System.Drawing.Point(219, 358);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(108, 29);
            this.btnenregistrer.TabIndex = 27;
            this.btnenregistrer.Text = "&Enrégistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnfermer
            // 
            this.btnfermer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnfermer.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfermer.Location = new System.Drawing.Point(404, 358);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(110, 29);
            this.btnfermer.TabIndex = 26;
            this.btnfermer.Text = "&Fermer";
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.bntFermer2_Click);
            // 
            // txtagencode
            // 
            this.txtagencode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagencode.Location = new System.Drawing.Point(219, 84);
            this.txtagencode.Name = "txtagencode";
            this.txtagencode.Size = new System.Drawing.Size(295, 26);
            this.txtagencode.TabIndex = 25;
            // 
            // txtactidepense
            // 
            this.txtactidepense.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtactidepense.Location = new System.Drawing.Point(219, 271);
            this.txtactidepense.Name = "txtactidepense";
            this.txtactidepense.Size = new System.Drawing.Size(295, 26);
            this.txtactidepense.TabIndex = 24;
            this.txtactidepense.TextChanged += new System.EventHandler(this.txtLocalise_TextChanged);
            // 
            // txtactirecette
            // 
            this.txtactirecette.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtactirecette.Location = new System.Drawing.Point(219, 219);
            this.txtactirecette.Name = "txtactirecette";
            this.txtactirecette.Size = new System.Drawing.Size(295, 26);
            this.txtactirecette.TabIndex = 23;
            // 
            // txtacticode
            // 
            this.txtacticode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacticode.Location = new System.Drawing.Point(219, 36);
            this.txtacticode.Name = "txtacticode";
            this.txtacticode.Size = new System.Drawing.Size(295, 26);
            this.txtacticode.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dépenses de l\'Activité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Recettes de l\'Activité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date de l\'Activité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code Activité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 323);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(12, 337);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 66);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Code de l\'Agence";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtactidate
            // 
            this.txtactidate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtactidate.Location = new System.Drawing.Point(219, 149);
            this.txtactidate.Name = "txtactidate";
            this.txtactidate.Size = new System.Drawing.Size(295, 26);
            this.txtactidate.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "(Veuillez entrer le code d\'une agence existante)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "(Format : 31/12/1999 00:00:00)";
            // 
            // frmActiviteNouveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(569, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtactidate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.txtagencode);
            this.Controls.Add(this.txtactidepense);
            this.Controls.Add(this.txtactirecette);
            this.Controls.Add(this.txtacticode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmActiviteNouveau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle Activité";
            this.Load += new System.EventHandler(this.frmActiviteModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.TextBox txtagencode;
        private System.Windows.Forms.TextBox txtactidepense;
        private System.Windows.Forms.TextBox txtactirecette;
        private System.Windows.Forms.TextBox txtacticode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtactidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}