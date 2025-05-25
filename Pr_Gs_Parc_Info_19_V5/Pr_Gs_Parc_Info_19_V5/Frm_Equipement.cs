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
    public partial class Frm_Equipement: Form
    {
        public Frm_Equipement()
        {
            InitializeComponent();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Frm_ajouter_equi frm_equi_a = new Frm_ajouter_equi();
            if (frm_equi_a.ShowDialog() == DialogResult.OK)
            {
                ActualiserDataGrid();
            }

        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Frm_modifier_equi frm_equi_m = new Frm_modifier_equi();
            frm_equi_m.ShowDialog();
        }

        private void Frm_Equipement_Load(object sender, EventArgs e)
        {
            try
            {
                // Créer une connexion avec la base de données 
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    // Ouvrir la connexion
                    conn.Open();

                    // Requête SQL pour sélectionner tous les enregistrements 
                    string query = "SELECT * FROM EQUIPEMENT";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Remplir le DataTable avec les données de la base

                    // Lier les données au DataGridView pour les afficher à l'écran
                    DGV_Equipement.DataSource = dt;
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
            if (DGV_Equipement.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet Equipement ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Récupérer l'ID  sélectionné
                        string idEquipement = DGV_Equipement.SelectedRows[0].Cells["ID_Equipement"].Value.ToString();

                        // Connexion à la base de données
                        using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                        {
                            conn.Open();

                            // Requête DELETE
                            string query = "DELETE FROM EQUIPEMENT WHERE ID_Equipement = ?";
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            cmd.Parameters.AddWithValue("?", idEquipement);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Equipement supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Veuillez sélectionner un equipement à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ActualiserDataGrid()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM EQUIPEMENT";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_Equipement.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du rafraîchissement : " + ex.Message);
            }
        }
    }
}
