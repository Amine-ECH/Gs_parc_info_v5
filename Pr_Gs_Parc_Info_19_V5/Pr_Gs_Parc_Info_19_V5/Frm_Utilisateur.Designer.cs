namespace Pr_Gs_Parc_Info_19_V5
{
    partial class Frm_Utilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Utilisateur));
            this.DGV_Utilisateur = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Utilisateur
            // 
            this.DGV_Utilisateur.AllowUserToResizeColumns = false;
            this.DGV_Utilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Utilisateur.ColumnHeadersHeight = 34;
            this.DGV_Utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Utilisateur.Location = new System.Drawing.Point(8, 69);
            this.DGV_Utilisateur.MultiSelect = false;
            this.DGV_Utilisateur.Name = "DGV_Utilisateur";
            this.DGV_Utilisateur.RowHeadersWidth = 62;
            this.DGV_Utilisateur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Utilisateur.RowTemplate.Height = 28;
            this.DGV_Utilisateur.Size = new System.Drawing.Size(813, 464);
            this.DGV_Utilisateur.TabIndex = 82;
            this.DGV_Utilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Utilisateur_CellContentClick);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(859, 96);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(134, 55);
            this.BTN_Ajouter.TabIndex = 79;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = false;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Supprimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Supprimer.Location = new System.Drawing.Point(859, 251);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(134, 55);
            this.BTN_Supprimer.TabIndex = 81;
            this.BTN_Supprimer.Text = "   Sppprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = false;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Modifier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Modifier.Location = new System.Drawing.Point(859, 178);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Modifier.Size = new System.Drawing.Size(134, 55);
            this.BTN_Modifier.TabIndex = 80;
            this.BTN_Modifier.Text = "  Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = false;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.BackColor = System.Drawing.Color.Crimson;
            this.BTN_Fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Fermer.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Fermer.Location = new System.Drawing.Point(859, 493);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(134, 40);
            this.BTN_Fermer.TabIndex = 83;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = false;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click_1);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 50);
            this.label2.TabIndex = 86;
            this.label2.Text = "Utilisateurs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_Utilisateur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1005, 544);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Utilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Utilisateur";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion D\'un Par Informatique";
            this.Load += new System.EventHandler(this.Frm_Utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Utilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Utilisateur;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
    }
}