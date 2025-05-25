using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pr_Gs_Parc_Info_19_V5
{
    public partial class Frm_connexion : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;");

        public Frm_connexion()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Pic_cover_Click(object sender, EventArgs e)
        {

        }

        private void Frm_connexion_Load(object sender, EventArgs e)
        {
            GB_login.Visible = true;
            GB_info.Visible = false;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            string username = Txt_login.Text;
            string password = Txt_motpass.Text;

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Con_Admin WHERE user=? AND pswd=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                    Txt_login.Clear();
                    Txt_motpass.Clear();
                    Txt_login.Focus();
                    Txt_login.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult Reponse = MessageBox.Show("Voulez-vous quitter l'application ?", "Confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Lnk_propos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GB_login.Visible = false;
            GB_info.Visible = true;
        }

        private void Cbox_affi_pswd_CheckedChanged(object sender, EventArgs e)
        {
            Txt_motpass.PasswordChar = Cbox_affi_pswd.Checked ? '\0' : '*';
        }

        private void Btn_roteur_Click(object sender, EventArgs e)
        {
            GB_login.Visible = true;
            GB_info.Visible = false;
        }

        private void Lnk_inscrire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_inscreption Frm_signin = new Frm_inscreption();
            Frm_signin.ShowDialog();
        }
    }
}
