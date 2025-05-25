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
    public partial class Frm_Utilisateur: Form
    {
        public Frm_Utilisateur()
        {
            InitializeComponent();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Principal frm_prin = new Frm_Principal();
            frm_prin.ShowDialog();
            this.Close();
        }

        private void Txt_Recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Utilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                // Créer une connexion avec la base de données 
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    // Ouvrir la connexion
                    conn.Open();

                    // Requête SQL pour sélectionner tous les enregistrements 
                    string query = "SELECT * FROM UTILISATEUR";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Remplir le DataTable avec les données de la base

                    // Lier les données au DataGridView pour les afficher à l'écran
                    DGV_Utilisateur.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BTN_Fermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if (DGV_Utilisateur.CurrentRow != null)
            {
                string id = DGV_Utilisateur.CurrentRow.Cells["ID_Utilisateur"].Value.ToString();
                string nom = DGV_Utilisateur.CurrentRow.Cells["Nom"].Value.ToString();
                string Prenom = DGV_Utilisateur.CurrentRow.Cells["Prenom"].Value.ToString();
                string poste = DGV_Utilisateur.CurrentRow.Cells["Poste"].Value.ToString();
                string service = DGV_Utilisateur.CurrentRow.Cells["Service"].Value.ToString();
                string login = DGV_Utilisateur.CurrentRow.Cells["Login"].Value.ToString();
                string motPasse = DGV_Utilisateur.CurrentRow.Cells["Mot_Passe"].Value.ToString();

                Frm_modifier_utili frmModifier = new Frm_modifier_utili(id, nom, Prenom, poste, service, login, motPasse);
                frmModifier.ShowDialog();

                
                Frm_Utilisateur_Load(null, null);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ajouter_utili frm_user_a = new Frm_ajouter_utili();
            frm_user_a.ShowDialog();
            
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (DGV_Utilisateur.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Récupérer l'ID de l'utilisateur sélectionné
                        string idUtilisateur = DGV_Utilisateur.SelectedRows[0].Cells["ID_Utilisateur"].Value.ToString();

                        // Connexion à la base de données
                        using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                        {
                            conn.Open();

                            // Requête DELETE
                            string query = "DELETE FROM UTILISATEUR WHERE ID_Utilisateur = ?";
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            cmd.Parameters.AddWithValue("?", idUtilisateur);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Utilisateur supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DGV_Utilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ActualiserDataGrid()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM UTILISATEUR";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_Utilisateur.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du rafraîchissement : " + ex.Message);
            }
        }

    }
}
