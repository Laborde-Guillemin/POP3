namespace ClientPOP3
{
    partial class ClientPOP3
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
            this.listBoxAffichage = new System.Windows.Forms.ListBox();
            this.labelAffichage = new System.Windows.Forms.Label();
            this.listBoxVerbose = new System.Windows.Forms.ListBox();
            this.labelVerbose = new System.Windows.Forms.Label();
            this.buttonSTAT = new System.Windows.Forms.Button();
            this.buttonQUIT = new System.Windows.Forms.Button();
            this.buttonLIST = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.affichemsg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAffichage
            // 
            this.listBoxAffichage.FormattingEnabled = true;
            this.listBoxAffichage.ItemHeight = 16;
            this.listBoxAffichage.Location = new System.Drawing.Point(32, 47);
            this.listBoxAffichage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAffichage.Name = "listBoxAffichage";
            this.listBoxAffichage.Size = new System.Drawing.Size(864, 532);
            this.listBoxAffichage.TabIndex = 0;
            // 
            // labelAffichage
            // 
            this.labelAffichage.AutoSize = true;
            this.labelAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichage.Location = new System.Drawing.Point(28, 16);
            this.labelAffichage.Name = "labelAffichage";
            this.labelAffichage.Size = new System.Drawing.Size(231, 20);
            this.labelAffichage.TabIndex = 1;
            this.labelAffichage.Text = "Affichage pour l\'utilisateur";
            // 
            // listBoxVerbose
            // 
            this.listBoxVerbose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxVerbose.FormattingEnabled = true;
            this.listBoxVerbose.ItemHeight = 16;
            this.listBoxVerbose.Location = new System.Drawing.Point(935, 47);
            this.listBoxVerbose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxVerbose.Name = "listBoxVerbose";
            this.listBoxVerbose.Size = new System.Drawing.Size(644, 532);
            this.listBoxVerbose.TabIndex = 2;
            // 
            // labelVerbose
            // 
            this.labelVerbose.AutoSize = true;
            this.labelVerbose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerbose.Location = new System.Drawing.Point(932, 16);
            this.labelVerbose.Name = "labelVerbose";
            this.labelVerbose.Size = new System.Drawing.Size(395, 20);
            this.labelVerbose.TabIndex = 3;
            this.labelVerbose.Text = "VERBOSE : Communication \"brute\" avec le serveur";
            // 
            // buttonSTAT
            // 
            this.buttonSTAT.Location = new System.Drawing.Point(1284, 631);
            this.buttonSTAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSTAT.Name = "buttonSTAT";
            this.buttonSTAT.Size = new System.Drawing.Size(103, 47);
            this.buttonSTAT.TabIndex = 4;
            this.buttonSTAT.Text = "STAT";
            this.buttonSTAT.UseVisualStyleBackColor = true;
            this.buttonSTAT.Click += new System.EventHandler(this.buttonSTAT_Click);
            // 
            // buttonQUIT
            // 
            this.buttonQUIT.Location = new System.Drawing.Point(1408, 631);
            this.buttonQUIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQUIT.Name = "buttonQUIT";
            this.buttonQUIT.Size = new System.Drawing.Size(103, 49);
            this.buttonQUIT.TabIndex = 5;
            this.buttonQUIT.Text = "QUIT";
            this.buttonQUIT.UseVisualStyleBackColor = true;
            this.buttonQUIT.Click += new System.EventHandler(this.buttonQUIT_Click);
            // 
            // buttonLIST
            // 
            this.buttonLIST.Location = new System.Drawing.Point(1143, 631);
            this.buttonLIST.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLIST.Name = "buttonLIST";
            this.buttonLIST.Size = new System.Drawing.Size(103, 47);
            this.buttonLIST.TabIndex = 12;
            this.buttonLIST.Text = "LIST";
            this.buttonLIST.UseVisualStyleBackColor = true;
            this.buttonLIST.Click += new System.EventHandler(this.buttonLIST_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(962, 631);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(159, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // affichemsg
            // 
            this.affichemsg.Location = new System.Drawing.Point(962, 656);
            this.affichemsg.Name = "affichemsg";
            this.affichemsg.Size = new System.Drawing.Size(159, 47);
            this.affichemsg.TabIndex = 14;
            this.affichemsg.Text = "Affichage Message";
            this.affichemsg.UseVisualStyleBackColor = true;
            this.affichemsg.Click += new System.EventHandler(this.affichemsg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Prévisualisation des mails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientPOP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.affichemsg);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonLIST);
            this.Controls.Add(this.buttonQUIT);
            this.Controls.Add(this.buttonSTAT);
            this.Controls.Add(this.labelVerbose);
            this.Controls.Add(this.listBoxVerbose);
            this.Controls.Add(this.labelAffichage);
            this.Controls.Add(this.listBoxAffichage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientPOP3";
            this.Text = "ClientPOP3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAffichage;
        private System.Windows.Forms.Label labelAffichage;
        private System.Windows.Forms.ListBox listBoxVerbose;
        private System.Windows.Forms.Label labelVerbose;
        private System.Windows.Forms.Button buttonSTAT;
        private System.Windows.Forms.Button buttonQUIT;
        private System.Windows.Forms.Button buttonLIST;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button affichemsg;
        private System.Windows.Forms.Button button1;
    }
}

