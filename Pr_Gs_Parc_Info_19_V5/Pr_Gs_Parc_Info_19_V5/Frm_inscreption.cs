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
    public partial class Frm_inscreption : Form
    {
        public Frm_inscreption()
        {
            InitializeComponent();
        }

        private void Txt_pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cree_Click(object sender, EventArgs e)
        {
            string user = Txt_user.Text.Trim();
            string pswd = Txt_pswd.Text.Trim();
            string confPswd = Txt_conf_pswd.Text.Trim();

            // Vérification des champs
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pswd) || string.IsNullOrEmpty(confPswd))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pswd != confPswd)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Vérification pswd
            try
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    con.Open();

                    // Insérer l'utilisateur 
                    string insert = "INSERT INTO Con_Admin ([user], pswd) VALUES (?, ?)";
                    using (OleDbCommand cmdInsert = new OleDbCommand(insert, con))
                    {
                        cmdInsert.Parameters.AddWithValue("?", user);
                        cmdInsert.Parameters.AddWithValue("?", pswd);
                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show("Utilisateur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_inscreption_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    con.Open();

                    // Récupérer dernier N pour affichage +1
                    string getMax = "SELECT MAX(N) FROM Con_Admin";
                    OleDbCommand cmdMax = new OleDbCommand(getMax, con);
                    object result = cmdMax.ExecuteScalar();
                    int nextNum = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                    Txt_num.Text = nextNum.ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du numéro : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Utilisez BeginInvoke pour garantir le focus
            this.BeginInvoke((Action)(() => Txt_user.Focus()));
        }
    }
}
