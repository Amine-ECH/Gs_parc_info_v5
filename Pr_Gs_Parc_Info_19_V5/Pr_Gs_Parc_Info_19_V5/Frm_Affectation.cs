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
    public partial class Frm_Affectation: Form
    {
        public Frm_Affectation()
        {
            InitializeComponent();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Frm_ajouter_aff frm_aff_a = new Frm_ajouter_aff();
            if (frm_aff_a.ShowDialog() == DialogResult.OK)
            {
                ActualiserDataGrid();
            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if (DGV_Affectation.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGV_Affectation.SelectedRows[0];

                string num = row.Cells["Num_Affectation"].Value.ToString();
                string date = row.Cells["Date_affectation"].Value.ToString();
                string equipement = row.Cells["Equipement"].Value.ToString();
                string utilisateur = row.Cells["Utilisateur"].Value.ToString();
                string statut = row.Cells["Statut"].Value.ToString();

                Frm_modifier_aff frmModif = new Frm_modifier_aff(num, date, equipement, utilisateur, statut);
                if (frmModif.ShowDialog() == DialogResult.OK)
                {
                    ActualiserDataGrid(); // Rafraîchir après modification
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Frm_Affectation_Load(object sender, EventArgs e)
        {
            try
            {
                // Créer une connexion avec la base de données 
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    // Ouvrir la connexion
                    conn.Open();

                    // Requête SQL pour sélectionner tous les enregistrements 
                    string query = "SELECT * FROM AFFECTATION";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Remplir le DataTable avec les données de la base

                    // Lier les données au DataGridView pour les afficher à l'écran
                    DGV_Affectation.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (DGV_Affectation.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet Affectation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Récupérer l'ID  sélectionné
                        string idAff = DGV_Affectation.SelectedRows[0].Cells["Num_Affectation"].Value.ToString();

                        // Connexion à la base de données
                        using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                        {
                            conn.Open();

                            // Requête DELETE
                            string query = "DELETE FROM AFFECTATION WHERE Num_Affectation = ?";
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            cmd.Parameters.AddWithValue("?", idAff);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Affectation  supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Actualiser le DataGridView
                        ActualiserDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un affectation à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ActualiserDataGrid()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM AFFECTATION";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_Affectation.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du rafraîchissement : " + ex.Message);
            }
        }
    }
}
