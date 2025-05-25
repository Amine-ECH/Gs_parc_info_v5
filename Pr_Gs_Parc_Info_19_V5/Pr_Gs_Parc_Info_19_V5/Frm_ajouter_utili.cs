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
    public partial class Frm_ajouter_utili: Form
    {
        public Frm_ajouter_utili()
        {
            InitializeComponent();
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ajouter_utili_Load(object sender, EventArgs e)
        {
            string newID = GenererNouveauID();
            Txt_Identifiant.Text = newID;
        }
        private string GenererNouveauID()
        {
            string dernierID = "";
            string nouveauID = "U001";


            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb"))
            {
                con.Open();
                string query = "SELECT MAX(ID_Utilisateur) FROM UTILISATEUR";
                OleDbCommand cmd = new OleDbCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    dernierID = result.ToString(); 
                    int numero = int.Parse(dernierID.Substring(1)); 
                    nouveauID = "U" + (numero + 1).ToString("D3");
                }

                con.Close();
            }

            return nouveauID;
        }

        private void Btn_enregistre_Click(object sender, EventArgs e)
        {
            if (Txt_Identifiant.Text == "") { MessageBox.Show("il faut saisir Le ID de L'utilsateur!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_post.Text == "") { MessageBox.Show("il faut saisir Le poste!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_Nom.Text == "") { MessageBox.Show("il faut saisir Le Nom!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_prenom.Text == "") { MessageBox.Show("il faut saisir Le Prenom!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_login.Text == "") { MessageBox.Show("il faut saisir Login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_pswd.Text == "") { MessageBox.Show("il faut saisir le mot de passe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_conf_pswd.Text == "") { MessageBox.Show("il faut confirmer le mot de passe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (Txt_conf_pswd.Text != Txt_pswd.Text) { MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); Txt_conf_pswd.Focus(); return; }
            try
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb"))
                {
                    con.Open();
                    string insertQuery = "INSERT INTO UTILISATEUR (ID_Utilisateur, Poste, Nom, Prenom, Login, Mot_Passe, Service) VALUES (?, ?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("?", Txt_Identifiant.Text);
                        cmd.Parameters.AddWithValue("?", Txt_post.Text);
                        cmd.Parameters.AddWithValue("?", Txt_Nom.Text);
                        cmd.Parameters.AddWithValue("?", Txt_prenom.Text);
                        cmd.Parameters.AddWithValue("?", Txt_login.Text);
                        cmd.Parameters.AddWithValue("?", Txt_pswd.Text);
                        cmd.Parameters.AddWithValue("?", Txt_N_serie.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Utilisateur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Frm_Utilisateur frm_user = new Frm_Utilisateur();
                    frm_user.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
