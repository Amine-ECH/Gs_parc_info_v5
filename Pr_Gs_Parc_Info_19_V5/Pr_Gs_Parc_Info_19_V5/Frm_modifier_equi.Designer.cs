namespace Pr_Gs_Parc_Info_19_V5
{
    partial class Frm_modifier_equi
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
            this.Cmb_etat_m = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_marque_m = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_annuler_m = new System.Windows.Forms.Button();
            this.Btn_enreg_m = new System.Windows.Forms.Button();
            this.GB_modifier_c = new System.Windows.Forms.GroupBox();
            this.Txt_Num_Série_m = new System.Windows.Forms.TextBox();
            this.Txt_modele_m = new System.Windows.Forms.TextBox();
            this.Txt_type_m = new System.Windows.Forms.TextBox();
            this.Txt_nom_m = new System.Windows.Forms.TextBox();
            this.Txt_n_m = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GB_modifier_c.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmb_etat_m
            // 
            this.Cmb_etat_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmb_etat_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_etat_m.FormattingEnabled = true;
            this.Cmb_etat_m.Items.AddRange(new object[] {
            "En service",
            "En panne",
            "Remplacé"});
            this.Cmb_etat_m.Location = new System.Drawing.Point(60, 344);
            this.Cmb_etat_m.Name = "Cmb_etat_m";
            this.Cmb_etat_m.Size = new System.Drawing.Size(121, 28);
            this.Cmb_etat_m.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(158, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 10);
            this.panel2.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(154, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 65);
            this.label3.TabIndex = 28;
            this.label3.Text = "Modifier Equipement";
            // 
            // Txt_marque_m
            // 
            this.Txt_marque_m.Location = new System.Drawing.Point(374, 216);
            this.Txt_marque_m.Name = "Txt_marque_m";
            this.Txt_marque_m.Size = new System.Drawing.Size(294, 26);
            this.Txt_marque_m.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(370, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marque";
            // 
            // Btn_annuler_m
            // 
            this.Btn_annuler_m.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_annuler_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_annuler_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_annuler_m.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_annuler_m.Location = new System.Drawing.Point(385, 409);
            this.Btn_annuler_m.Name = "Btn_annuler_m";
            this.Btn_annuler_m.Size = new System.Drawing.Size(123, 35);
            this.Btn_annuler_m.TabIndex = 25;
            this.Btn_annuler_m.Text = "Annuler";
            this.Btn_annuler_m.UseVisualStyleBackColor = false;
            this.Btn_annuler_m.Click += new System.EventHandler(this.Btn_annuler_m_Click);
            // 
            // Btn_enreg_m
            // 
            this.Btn_enreg_m.BackColor = System.Drawing.Color.Lime;
            this.Btn_enreg_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_enreg_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_enreg_m.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_enreg_m.Location = new System.Drawing.Point(529, 409);
            this.Btn_enreg_m.Name = "Btn_enreg_m";
            this.Btn_enreg_m.Size = new System.Drawing.Size(130, 35);
            this.Btn_enreg_m.TabIndex = 24;
            this.Btn_enreg_m.Text = "Enregistre";
            this.Btn_enreg_m.UseVisualStyleBackColor = false;
            this.Btn_enreg_m.Click += new System.EventHandler(this.Btn_enreg_m_Click);
            // 
            // GB_modifier_c
            // 
            this.GB_modifier_c.BackColor = System.Drawing.Color.DarkOrange;
            this.GB_modifier_c.Controls.Add(this.Cmb_etat_m);
            this.GB_modifier_c.Controls.Add(this.panel2);
            this.GB_modifier_c.Controls.Add(this.label3);
            this.GB_modifier_c.Controls.Add(this.Txt_marque_m);
            this.GB_modifier_c.Controls.Add(this.label4);
            this.GB_modifier_c.Controls.Add(this.Btn_annuler_m);
            this.GB_modifier_c.Controls.Add(this.Btn_enreg_m);
            this.GB_modifier_c.Controls.Add(this.Txt_Num_Série_m);
            this.GB_modifier_c.Controls.Add(this.Txt_modele_m);
            this.GB_modifier_c.Controls.Add(this.Txt_type_m);
            this.GB_modifier_c.Controls.Add(this.Txt_nom_m);
            this.GB_modifier_c.Controls.Add(this.Txt_n_m);
            this.GB_modifier_c.Controls.Add(this.label5);
            this.GB_modifier_c.Controls.Add(this.label6);
            this.GB_modifier_c.Controls.Add(this.label7);
            this.GB_modifier_c.Controls.Add(this.label8);
            this.GB_modifier_c.Controls.Add(this.label10);
            this.GB_modifier_c.Controls.Add(this.label11);
            this.GB_modifier_c.Location = new System.Drawing.Point(0, -12);
            this.GB_modifier_c.Name = "GB_modifier_c";
            this.GB_modifier_c.Size = new System.Drawing.Size(749, 500);
            this.GB_modifier_c.TabIndex = 62;
            this.GB_modifier_c.TabStop = false;
            // 
            // Txt_Num_Série_m
            // 
            this.Txt_Num_Série_m.Location = new System.Drawing.Point(374, 277);
            this.Txt_Num_Série_m.Name = "Txt_Num_Série_m";
            this.Txt_Num_Série_m.Size = new System.Drawing.Size(285, 26);
            this.Txt_Num_Série_m.TabIndex = 19;
            // 
            // Txt_modele_m
            // 
            this.Txt_modele_m.Location = new System.Drawing.Point(60, 277);
            this.Txt_modele_m.Name = "Txt_modele_m";
            this.Txt_modele_m.Size = new System.Drawing.Size(294, 26);
            this.Txt_modele_m.TabIndex = 17;
            // 
            // Txt_type_m
            // 
            this.Txt_type_m.Location = new System.Drawing.Point(374, 158);
            this.Txt_type_m.Name = "Txt_type_m";
            this.Txt_type_m.Size = new System.Drawing.Size(285, 26);
            this.Txt_type_m.TabIndex = 13;
            // 
            // Txt_nom_m
            // 
            this.Txt_nom_m.Location = new System.Drawing.Point(60, 216);
            this.Txt_nom_m.Name = "Txt_nom_m";
            this.Txt_nom_m.Size = new System.Drawing.Size(294, 26);
            this.Txt_nom_m.TabIndex = 15;
            // 
            // Txt_n_m
            // 
            this.Txt_n_m.Enabled = false;
            this.Txt_n_m.Location = new System.Drawing.Point(60, 158);
            this.Txt_n_m.Name = "Txt_n_m";
            this.Txt_n_m.ReadOnly = true;
            this.Txt_n_m.Size = new System.Drawing.Size(294, 26);
            this.Txt_n_m.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(56, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Modèle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(56, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Etat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(370, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(370, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numéro Série";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(56, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "N°";
            // 
            // Frm_modifier_equi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 485);
            this.Controls.Add(this.GB_modifier_c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_modifier_equi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_modifier_equi";
            this.GB_modifier_c.ResumeLayout(false);
            this.GB_modifier_c.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_etat_m;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_marque_m;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_annuler_m;
        private System.Windows.Forms.Button Btn_enreg_m;
        private System.Windows.Forms.GroupBox GB_modifier_c;
        private System.Windows.Forms.TextBox Txt_Num_Série_m;
        private System.Windows.Forms.TextBox Txt_modele_m;
        private System.Windows.Forms.TextBox Txt_type_m;
        private System.Windows.Forms.TextBox Txt_nom_m;
        private System.Windows.Forms.TextBox Txt_n_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}