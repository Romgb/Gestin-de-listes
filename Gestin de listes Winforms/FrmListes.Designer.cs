namespace Gestin_de_listes_Winforms
{
    partial class FrmListes
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListes));
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.lbCible = new System.Windows.Forms.ListBox();
            this.lbSource = new System.Windows.Forms.Label();
            this.lbListe = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjouterTout = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSupprimerTout = new System.Windows.Forms.Button();
            this.btnHaut = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "France",
            "Allemagne",
            "Espagne\t",
            "Creuse",
            "Royaume-Uni",
            "Iralnde\t",
            "Etats-Unis\t",
            "Viet-Nam\t",
            "Thailande\t",
            "Namibie",
            "Tanzanie\t\t",
            "Perou\t",
            "Argentine"});
            this.cbSource.Location = new System.Drawing.Point(72, 61);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(201, 21);
            this.cbSource.TabIndex = 0;
            // 
            // lbCible
            // 
            this.lbCible.FormattingEnabled = true;
            this.lbCible.Location = new System.Drawing.Point(482, 61);
            this.lbCible.Name = "lbCible";
            this.lbCible.Size = new System.Drawing.Size(226, 277);
            this.lbCible.TabIndex = 0;
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Location = new System.Drawing.Point(150, 34);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(41, 13);
            this.lbSource.TabIndex = 0;
            this.lbSource.Text = "Source";
            // 
            // lbListe
            // 
            this.lbListe.AutoSize = true;
            this.lbListe.Location = new System.Drawing.Point(589, 34);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(30, 13);
            this.lbListe.TabIndex = 0;
            this.lbListe.Text = "Cible";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(327, 77);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = ">";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter1_Click);
            // 
            // btnAjouterTout
            // 
            this.btnAjouterTout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTout.Location = new System.Drawing.Point(327, 127);
            this.btnAjouterTout.Name = "btnAjouterTout";
            this.btnAjouterTout.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTout.TabIndex = 2;
            this.btnAjouterTout.Text = ">>";
            this.btnAjouterTout.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(327, 260);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "<";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerTout
            // 
            this.btnSupprimerTout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerTout.Location = new System.Drawing.Point(327, 315);
            this.btnSupprimerTout.Name = "btnSupprimerTout";
            this.btnSupprimerTout.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerTout.TabIndex = 4;
            this.btnSupprimerTout.Text = "<<";
            this.btnSupprimerTout.UseVisualStyleBackColor = true;
            // 
            // btnHaut
            // 
            this.btnHaut.Image = ((System.Drawing.Image)(resources.GetObject("btnHaut.Image")));
            this.btnHaut.Location = new System.Drawing.Point(533, 358);
            this.btnHaut.Name = "btnHaut";
            this.btnHaut.Size = new System.Drawing.Size(59, 53);
            this.btnHaut.TabIndex = 5;
            this.btnHaut.UseVisualStyleBackColor = true;
            // 
            // btnBas
            // 
            this.btnBas.Image = ((System.Drawing.Image)(resources.GetObject("btnBas.Image")));
            this.btnBas.Location = new System.Drawing.Point(611, 358);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(51, 53);
            this.btnBas.TabIndex = 6;
            this.btnBas.UseVisualStyleBackColor = true;
            // 
            // FrmListes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.btnHaut);
            this.Controls.Add(this.btnSupprimerTout);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouterTout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.lbCible);
            this.Controls.Add(this.cbSource);
            this.Name = "FrmListes";
            this.Text = "Les listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ListBox lbCible;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Label lbListe;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouterTout;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSupprimerTout;
        private System.Windows.Forms.Button btnHaut;
        private System.Windows.Forms.Button btnBas;
    }
}

