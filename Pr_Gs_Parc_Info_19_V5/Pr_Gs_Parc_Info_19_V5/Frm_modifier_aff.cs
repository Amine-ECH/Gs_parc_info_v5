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
    public partial class Frm_modifier_aff: Form
    {
        public Frm_modifier_aff(string num, string date, string equipement, string utilisateur, string statut)
        {
            InitializeComponent();

            // Remplir les champs avec les données reçues
            Txt_n_m.Text = num;
            Dt_date_aff_m.Value = DateTime.Parse(date);
            Cmb_equi_m.Text = equipement;
            Cmb_utili_m.Text = utilisateur;
            Txt_statut_m.Text = statut;
        }

        public Frm_modifier_aff()
        {
            InitializeComponent();
        }

        private void Btn_annuler_m_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_modifier_aff_Load(object sender, EventArgs e)
        {

        }

        private void Btn_enreg_m_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des champs
                string num = Txt_n_m.Text;
                string date = Dt_date_aff_m.Value.ToShortDateString();
                string equipement = Cmb_equi_m.Text;
                string utilisateur = Cmb_utili_m.Text;
                string statut = Txt_statut_m.Text;

                // Connexion à la base de données
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();

                    // Requête de mise à jour
                    string query = "UPDATE AFFECTATION SET Date_affectation = ?, Equipement = ?, Utilisateur = ?, Statut = ? WHERE Num_Affectation = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", date);
                        cmd.Parameters.AddWithValue("?", equipement);
                        cmd.Parameters.AddWithValue("?", utilisateur);
                        cmd.Parameters.AddWithValue("?", statut);
                        cmd.Parameters.AddWithValue("?", num);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Affectation modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; 
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne modifiée. Vérifiez les données.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cmb_utili_m_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_equi_m_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dt_date_aff_m_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GB_modifier_c_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_statut_m_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_n_m_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
