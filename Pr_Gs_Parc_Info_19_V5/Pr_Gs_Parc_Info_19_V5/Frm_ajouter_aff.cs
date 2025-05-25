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
    public partial class Frm_ajouter_aff: Form
    {
        public Frm_ajouter_aff()
        {
            InitializeComponent();
            this.Load += Frm_ajouter_aff_Load;
        }
        

        // fonction pour charger les utilisateurs et les équipements dans les ComboBox
        private void ChargerUtilisateurs()
        {
            Cmb_utili_a.Items.Clear();  
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
            {
                conn.Open();
                string query = "SELECT ID_Utilisateur FROM UTILISATEUR";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cmb_utili_a.Items.Add(reader["ID_Utilisateur"].ToString());
                }
            }
        }

        private void ChargerEquipements()
        {
            Cmb_equi_a.Items.Clear();
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
            {
                conn.Open();
                string query = "SELECT ID_Equipement FROM EQUIPEMENT";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cmb_equi_a.Items.Add(reader["ID_Equipement"].ToString());
                }
            }
        }


        private void Btn_annuler_m_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_n_a_TextChanged(object sender, EventArgs e)
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

        private void Btn_enreg_m_Click(object sender, EventArgs e)
        {

            if (Cmb_utili_a.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur !", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_equi_a.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un équipement !", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Txt_statut_a.Text == "")
            {
                MessageBox.Show("Veuillez saisir le statut !", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Connexion à la base de données
            string numAffectation = Txt_n_a.Text;
            string idUtilisateur = Cmb_utili_a.Text;
            string idEquipement = Cmb_equi_a.Text;
            DateTime dateAffectation = Dt_date_aff_a.Value;
            string statut = Txt_statut_a.Text;

            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO AFFECTATION (Num_Affectation, Utilisateur, Equipement, Date_affectation, Statut) VALUES (?, ?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", numAffectation);
                    cmd.Parameters.AddWithValue("?", idUtilisateur);
                    cmd.Parameters.AddWithValue("?", idEquipement);
                    cmd.Parameters.AddWithValue("?", dateAffectation.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("?", statut);


                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Affectation ajoutée avec succès ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne n’a été insérée ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.DialogResult = DialogResult.OK;
            }
        }


        private void Txt_statut_a_TextChanged(object sender, EventArgs e)
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

        private void Cmb_utili_a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_equi_a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dt_date_aff_a_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GB_modifier_c_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ajouter_aff_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
            ChargerEquipements();
            GenererNumeroAffectation(); 
        }

        private void GenererNumeroAffectation()
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
            {
                conn.Open();
                string query = "SELECT MAX(Num_Affectation) FROM AFFECTATION";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                object result = cmd.ExecuteScalar();

                string nouveauNumero = "AFF001"; 

                if (result != DBNull.Value && result != null)
                {
                    string dernierNum = result.ToString(); 
                    int dernierNombre = int.Parse(dernierNum.Substring(3)); 
                    int nouveauNombre = dernierNombre + 1;
                    nouveauNumero = "AFF" + nouveauNombre.ToString("D3"); 
                }

                Txt_n_a.Text = nouveauNumero;
                Txt_n_a.ReadOnly = true; 
            }
        }

    }
}
