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
    public partial class Frm_modifier_equi: Form
    {
        public Frm_modifier_equi()
        {
            InitializeComponent();
        }

        private void Btn_annuler_m_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Btn_enreg_m_Click(object sender, EventArgs e)
        {
            // Vérification des champs
            if (Txt_n_m.Text == "") { MessageBox.Show("Il faut saisir l'ID de l'équipement !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_type_m.Text == "") { MessageBox.Show("Il faut saisir le type !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_nom_m.Text == "") { MessageBox.Show("Il faut saisir le nom !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_marque_m.Text == "") { MessageBox.Show("Il faut saisir la marque !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_modele_m.Text == "") { MessageBox.Show("Il faut saisir le modèle !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_Num_Série_m.Text == "") { MessageBox.Show("Il faut saisir le numéro de série !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Cmb_etat_m.Text == "") { MessageBox.Show("Il faut choisir l'état !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    conn.Open();

                    string query = "UPDATE EQUIPEMENT SET Nom = ?, Type = ?, Marque = ?, Modele = ?, Num_serie = ?, Etat = ? WHERE ID_Equipement = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("?", Txt_nom_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_type_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_marque_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_modele_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Txt_Num_Série_m.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Cmb_etat_m.Text.Trim());
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
    }
}
