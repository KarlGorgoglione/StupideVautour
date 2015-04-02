namespace StupideVautour2
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
            this.btn_jouer = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.nb_joueurs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_jouer
            // 
            this.btn_jouer.Location = new System.Drawing.Point(366, 121);
            this.btn_jouer.Name = "btn_jouer";
            this.btn_jouer.Size = new System.Drawing.Size(181, 89);
            this.btn_jouer.TabIndex = 0;
            this.btn_jouer.Text = "Jouer";
            this.btn_jouer.UseVisualStyleBackColor = true;
            this.btn_jouer.Click += new System.EventHandler(this.btn_jouer_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(366, 280);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(181, 88);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // nb_joueurs
            // 
            this.nb_joueurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nb_joueurs.FormattingEnabled = true;
            this.nb_joueurs.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.nb_joueurs.Location = new System.Drawing.Point(625, 133);
            this.nb_joueurs.Name = "nb_joueurs";
            this.nb_joueurs.Size = new System.Drawing.Size(116, 21);
            this.nb_joueurs.TabIndex = 2;
            this.nb_joueurs.SelectedIndexChanged += new System.EventHandler(this.nb_joueurs_SelectedIndexChanged);
            this.nb_joueurs.TextChanged += new System.EventHandler(this.nb_joueurs_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 488);
            this.Controls.Add(this.nb_joueurs);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_jouer);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_jouer;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.ComboBox nb_joueurs;
    }
}