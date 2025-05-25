namespace Pr_Gs_Parc_Info_19_V5
{
    partial class Frm_ajouter_equi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_marque_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_annuler_m = new System.Windows.Forms.Button();
            this.Btn_enreg_m = new System.Windows.Forms.Button();
            this.Txt_Num_Série_a = new System.Windows.Forms.TextBox();
            this.Txt_modele_a = new System.Windows.Forms.TextBox();
            this.Txt_type_a = new System.Windows.Forms.TextBox();
            this.Txt_nom_a = new System.Windows.Forms.TextBox();
            this.Txt_n_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GB_modifier_c = new System.Windows.Forms.GroupBox();
            this.Cmb_etat_a = new System.Windows.Forms.ComboBox();
            this.GB_modifier_c.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(159, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 10);
            this.panel2.TabIndex = 58;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(155, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 65);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ajouter Equipement";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_marque_a
            // 
            this.Txt_marque_a.Location = new System.Drawing.Point(375, 228);
            this.Txt_marque_a.Name = "Txt_marque_a";
            this.Txt_marque_a.Size = new System.Drawing.Size(294, 26);
            this.Txt_marque_a.TabIndex = 27;
            this.Txt_marque_a.TextChanged += new System.EventHandler(this.Txt_marque_a_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(371, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marque";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Btn_annuler_m
            // 
            this.Btn_annuler_m.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_annuler_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_annuler_m.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_annuler_m.Location = new System.Drawing.Point(386, 421);
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
            this.Btn_enreg_m.Location = new System.Drawing.Point(530, 421);
            this.Btn_enreg_m.Name = "Btn_enreg_m";
            this.Btn_enreg_m.Size = new System.Drawing.Size(130, 35);
            this.Btn_enreg_m.TabIndex = 24;
            this.Btn_enreg_m.Text = "Enregistre";
            this.Btn_enreg_m.UseVisualStyleBackColor = false;
            this.Btn_enreg_m.Click += new System.EventHandler(this.Btn_enreg_m_Click);
            // 
            // Txt_Num_Série_a
            // 
            this.Txt_Num_Série_a.Location = new System.Drawing.Point(375, 289);
            this.Txt_Num_Série_a.Name = "Txt_Num_Série_a";
            this.Txt_Num_Série_a.Size = new System.Drawing.Size(285, 26);
            this.Txt_Num_Série_a.TabIndex = 19;
            this.Txt_Num_Série_a.TextChanged += new System.EventHandler(this.Txt_Num_Série_a_TextChanged);
            // 
            // Txt_modele_a
            // 
            this.Txt_modele_a.Location = new System.Drawing.Point(61, 289);
            this.Txt_modele_a.Name = "Txt_modele_a";
            this.Txt_modele_a.Size = new System.Drawing.Size(294, 26);
            this.Txt_modele_a.TabIndex = 17;
            this.Txt_modele_a.TextChanged += new System.EventHandler(this.Txt_modele_a_TextChanged);
            // 
            // Txt_type_a
            // 
            this.Txt_type_a.Location = new System.Drawing.Point(375, 170);
            this.Txt_type_a.Name = "Txt_type_a";
            this.Txt_type_a.Size = new System.Drawing.Size(285, 26);
            this.Txt_type_a.TabIndex = 13;
            this.Txt_type_a.TextChanged += new System.EventHandler(this.Txt_type_a_TextChanged);
            // 
            // Txt_nom_a
            // 
            this.Txt_nom_a.Location = new System.Drawing.Point(61, 228);
            this.Txt_nom_a.Name = "Txt_nom_a";
            this.Txt_nom_a.Size = new System.Drawing.Size(294, 26);
            this.Txt_nom_a.TabIndex = 15;
            this.Txt_nom_a.TextChanged += new System.EventHandler(this.Txt_nom_a_TextChanged);
            // 
            // Txt_n_a
            // 
            this.Txt_n_a.Enabled = false;
            this.Txt_n_a.Location = new System.Drawing.Point(61, 170);
            this.Txt_n_a.Name = "Txt_n_a";
            this.Txt_n_a.ReadOnly = true;
            this.Txt_n_a.Size = new System.Drawing.Size(294, 26);
            this.Txt_n_a.TabIndex = 11;
            this.Txt_n_a.TextChanged += new System.EventHandler(this.Txt_n_m_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(57, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(57, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Modèle";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(57, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Etat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(371, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(371, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numéro Série";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(57, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "N°";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // GB_modifier_c
            // 
            this.GB_modifier_c.BackColor = System.Drawing.Color.SlateBlue;
            this.GB_modifier_c.Controls.Add(this.Cmb_etat_a);
            this.GB_modifier_c.Controls.Add(this.panel2);
            this.GB_modifier_c.Controls.Add(this.label3);
            this.GB_modifier_c.Controls.Add(this.Txt_marque_a);
            this.GB_modifier_c.Controls.Add(this.label4);
            this.GB_modifier_c.Controls.Add(this.Btn_annuler_m);
            this.GB_modifier_c.Controls.Add(this.Btn_enreg_m);
            this.GB_modifier_c.Controls.Add(this.Txt_Num_Série_a);
            this.GB_modifier_c.Controls.Add(this.Txt_modele_a);
            this.GB_modifier_c.Controls.Add(this.Txt_type_a);
            this.GB_modifier_c.Controls.Add(this.Txt_nom_a);
            this.GB_modifier_c.Controls.Add(this.Txt_n_a);
            this.GB_modifier_c.Controls.Add(this.label5);
            this.GB_modifier_c.Controls.Add(this.label6);
            this.GB_modifier_c.Controls.Add(this.label7);
            this.GB_modifier_c.Controls.Add(this.label8);
            this.GB_modifier_c.Controls.Add(this.label10);
            this.GB_modifier_c.Controls.Add(this.label11);
            this.GB_modifier_c.Location = new System.Drawing.Point(-1, -14);
            this.GB_modifier_c.Name = "GB_modifier_c";
            this.GB_modifier_c.Size = new System.Drawing.Size(749, 500);
            this.GB_modifier_c.TabIndex = 61;
            this.GB_modifier_c.TabStop = false;
            this.GB_modifier_c.Enter += new System.EventHandler(this.GB_modifier_c_Enter);
            // 
            // Cmb_etat_a
            // 
            this.Cmb_etat_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_etat_a.FormattingEnabled = true;
            this.Cmb_etat_a.Items.AddRange(new object[] {
            "En service",
            "En panne",
            "Remplacé"});
            this.Cmb_etat_a.Location = new System.Drawing.Point(61, 356);
            this.Cmb_etat_a.Name = "Cmb_etat_a";
            this.Cmb_etat_a.Size = new System.Drawing.Size(121, 28);
            this.Cmb_etat_a.TabIndex = 59;
            this.Cmb_etat_a.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frm_ajouter_equi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 474);
            this.ControlBox = false;
            this.Controls.Add(this.GB_modifier_c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ajouter_equi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ajouter_equi";
            this.Load += new System.EventHandler(this.Frm_ajouter_equi_Load);
            this.GB_modifier_c.ResumeLayout(false);
            this.GB_modifier_c.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_marque_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_annuler_m;
        private System.Windows.Forms.Button Btn_enreg_m;
        private System.Windows.Forms.TextBox Txt_Num_Série_a;
        private System.Windows.Forms.TextBox Txt_modele_a;
        private System.Windows.Forms.TextBox Txt_type_a;
        private System.Windows.Forms.TextBox Txt_nom_a;
        private System.Windows.Forms.TextBox Txt_n_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GB_modifier_c;
        private System.Windows.Forms.ComboBox Cmb_etat_a;
    }
}