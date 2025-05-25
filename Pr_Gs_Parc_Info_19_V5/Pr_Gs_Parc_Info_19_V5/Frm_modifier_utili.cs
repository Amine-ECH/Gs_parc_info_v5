using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Gs_Parc_Info_19_V5
{
    public partial class Frm_modifier_utili: Form
    {
        public Frm_modifier_utili()
        {
            InitializeComponent();
        }

        private void Btn_annuler_m_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Frm_modifier_utili(string id, string Prenom, string nom, string poste, string service, string login, string motPasse)
        {
            InitializeComponent();

            Txt_n_m.Text = id;
            Txt_nom_m.Text = nom;
            Txt_prenom_m.Text = Prenom;
            Txt_post_m.Text = poste;
            Txt_service_m.Text = service;
            Txt_login_m.Text = login;
            Txt_pswd_m.Text = motPasse;
        }

        private void Btn_enreg_m_Click(object sender, EventArgs e)
        {
            if (Txt_n_m.Text == "") { MessageBox.Show("il faut saisir Le ID de L'utilsateur!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_post_m.Text == "") { MessageBox.Show("il faut saisir Le poste!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_nom_m.Text == "") { MessageBox.Show("il faut saisir Le Nom!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_prenom_m.Text == "") { MessageBox.Show("il faut saisir Le Prenom!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_login_m.Text == "") { MessageBox.Show("il faut saisir Login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_pswd_m.Text == "") { MessageBox.Show("il faut saisir le mot de passe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_conf_pswd_m.Text == "") { MessageBox.Show("il faut confirmer le mot de passe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (Txt_conf_pswd_m.Text != Txt_pswd_m.Text) { MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); Txt_conf_pswd_m.Focus(); return; }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();

                    string query = "UPDATE UTILISATEUR SET Nom = ?, Prenom = ?, Poste = ?, Service = ?, Login = ?, Mot_Passe = ? WHERE ID_Utilisateur = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
             
                        cmd.Parameters.AddWithValue("?", Txt_nom_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_prenom_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_post_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_service_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_login_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_pswd_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_n_m.Text.Trim()); 

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Modification effectuée avec succès ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement n’a été modifié ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur: " + ex.Message);
            }
        }

        private void GB_modifier_c_Enter(object sender, EventArgs e)
        {

        }
    }
}
