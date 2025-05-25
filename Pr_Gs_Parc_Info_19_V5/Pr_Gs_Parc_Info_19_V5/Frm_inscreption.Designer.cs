namespace Pr_Gs_Parc_Info_19_V5
{
    partial class Frm_inscreption
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
            this.Txt_num = new System.Windows.Forms.TextBox();
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.Txt_pswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_conf_pswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_cree = new System.Windows.Forms.Button();
            this.Btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crée \r\nmon compte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_num
            // 
            this.Txt_num.Enabled = false;
            this.Txt_num.Location = new System.Drawing.Point(157, 172);
            this.Txt_num.Name = "Txt_num";
            this.Txt_num.ReadOnly = true;
            this.Txt_num.Size = new System.Drawing.Size(219, 26);
            this.Txt_num.TabIndex = 1;
            this.Txt_num.TabStop = false;
            // 
            // Txt_user
            // 
            this.Txt_user.Location = new System.Drawing.Point(157, 221);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.Size = new System.Drawing.Size(219, 26);
            this.Txt_user.TabIndex = 2;
            // 
            // Txt_pswd
            // 
            this.Txt_pswd.Location = new System.Drawing.Point(157, 271);
            this.Txt_pswd.Name = "Txt_pswd";
            this.Txt_pswd.PasswordChar = '*';
            this.Txt_pswd.Size = new System.Drawing.Size(219, 26);
            this.Txt_pswd.TabIndex = 3;
            this.Txt_pswd.TextChanged += new System.EventHandler(this.Txt_pswd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "N°";
            // 
            // Txt_conf_pswd
            // 
            this.Txt_conf_pswd.Location = new System.Drawing.Point(157, 328);
            this.Txt_conf_pswd.Name = "Txt_conf_pswd";
            this.Txt_conf_pswd.PasswordChar = '*';
            this.Txt_conf_pswd.Size = new System.Drawing.Size(219, 26);
            this.Txt_conf_pswd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "LogIn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmation de \r\nmot de passe";
            // 
            // Btn_cree
            // 
            this.Btn_cree.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_cree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cree.Location = new System.Drawing.Point(285, 382);
            this.Btn_cree.Name = "Btn_cree";
            this.Btn_cree.Size = new System.Drawing.Size(91, 39);
            this.Btn_cree.TabIndex = 5;
            this.Btn_cree.Text = "Crée";
            this.Btn_cree.UseVisualStyleBackColor = false;
            this.Btn_cree.Click += new System.EventHandler(this.Btn_cree_Click);
            // 
            // Btn_annuler
            // 
            this.Btn_annuler.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_annuler.Location = new System.Drawing.Point(179, 382);
            this.Btn_annuler.Name = "Btn_annuler";
            this.Btn_annuler.Size = new System.Drawing.Size(91, 39);
            this.Btn_annuler.TabIndex = 13;
            this.Btn_annuler.Text = "Annuler";
            this.Btn_annuler.UseVisualStyleBackColor = false;
            this.Btn_annuler.Click += new System.EventHandler(this.Btn_annuler_Click);
            // 
            // Frm_inscreption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(435, 454);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_annuler);
            this.Controls.Add(this.Btn_cree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_conf_pswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_pswd);
            this.Controls.Add(this.Txt_user);
            this.Controls.Add(this.Txt_num);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_inscreption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_inscreption";
            this.Load += new System.EventHandler(this.Frm_inscreption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_num;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_pswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_conf_pswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_cree;
        private System.Windows.Forms.Button Btn_annuler;
    }
}