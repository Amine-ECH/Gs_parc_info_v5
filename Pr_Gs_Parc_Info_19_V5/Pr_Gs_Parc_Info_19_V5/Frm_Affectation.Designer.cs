namespace Pr_Gs_Parc_Info_19_V5
{
    partial class Frm_Affectation
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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.DGV_Affectation = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Affectation)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.BackColor = System.Drawing.Color.Crimson;
            this.BTN_Fermer.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Fermer.Location = new System.Drawing.Point(866, 493);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(134, 40);
            this.BTN_Fermer.TabIndex = 100;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = false;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Modifier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Modifier.Location = new System.Drawing.Point(866, 178);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Modifier.Size = new System.Drawing.Size(134, 55);
            this.BTN_Modifier.TabIndex = 97;
            this.BTN_Modifier.Text = "  Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = false;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Supprimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Supprimer.Location = new System.Drawing.Point(866, 251);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(134, 55);
            this.BTN_Supprimer.TabIndex = 98;
            this.BTN_Supprimer.Text = "   Sppprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = false;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(866, 96);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(134, 55);
            this.BTN_Ajouter.TabIndex = 96;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = false;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // DGV_Affectation
            // 
            this.DGV_Affectation.AllowUserToResizeColumns = false;
            this.DGV_Affectation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Affectation.ColumnHeadersHeight = 34;
            this.DGV_Affectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Affectation.Location = new System.Drawing.Point(15, 69);
            this.DGV_Affectation.MultiSelect = false;
            this.DGV_Affectation.Name = "DGV_Affectation";
            this.DGV_Affectation.RowHeadersWidth = 62;
            this.DGV_Affectation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Affectation.RowTemplate.Height = 28;
            this.DGV_Affectation.Size = new System.Drawing.Size(813, 464);
            this.DGV_Affectation.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 50);
            this.label2.TabIndex = 102;
            this.label2.Text = "Affectations";
            // 
            // Frm_Affectation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1009, 544);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Affectation);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Affectation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion D\'un Par Informatique";
            this.Load += new System.EventHandler(this.Frm_Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Affectation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.DataGridView DGV_Affectation;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
    }
}