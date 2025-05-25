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
    public partial class Frm_ajouter_equi: Form
    {
        public Frm_ajouter_equi()
        {
            InitializeComponent();
        }

        private void Btn_annuler_m_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_marque_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GB_modifier_c_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_enreg_m_Click(object sender, EventArgs e)
        {
            // Vérification des champs
            if (Txt_n_a.Text == "") { MessageBox.Show("Il faut saisir l'ID de l'équipement !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_type_a.Text == "") { MessageBox.Show("Il faut saisir le type !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_nom_a.Text == "") { MessageBox.Show("Il faut saisir le nom !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_marque_a.Text == "") { MessageBox.Show("Il faut saisir la marque !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_modele_a.Text == "") { MessageBox.Show("Il faut saisir le modèle !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Txt_Num_Série_a.Text == "") { MessageBox.Show("Il faut saisir le numéro de série !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Cmb_etat_a.Text == "") { MessageBox.Show("Il faut choisir l'état !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    con.Open();

                    string query = "INSERT INTO EQUIPEMENT (ID_Equipement, Type, Nom, Marque, Modele, Num_Serie, Etat) " +
                                   "VALUES (@id, @type, @nom, @marque, @modele, @numserie, @etat)";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", Txt_n_a.Text);
                        cmd.Parameters.AddWithValue("@type", Txt_type_a.Text);
                        cmd.Parameters.AddWithValue("@nom", Txt_nom_a.Text);
                        cmd.Parameters.AddWithValue("@marque", Txt_marque_a.Text);
                        cmd.Parameters.AddWithValue("@modele", Txt_modele_a.Text);
                        cmd.Parameters.AddWithValue("@numserie", Txt_Num_Série_a.Text);
                        cmd.Parameters.AddWithValue("@etat", Cmb_etat_a.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Équipement ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement n'a été ajouté !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK; // bach trje3 ok wghadi nhtajoha f actualiser 

        }



        private void Txt_Num_Série_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_modele_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_type_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nom_a_TextChanged(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ajouter_equi_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ParcInformatique_v5.accdb;"))
                {
                    con.Open();

                    string query = "SELECT MAX(ID_Equipement) FROM EQUIPEMENT";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string lastID = result.ToString(); // ex: "E012"
                        int number = int.Parse(lastID.Substring(1)); // 12
                        number++; // 13
                        string newID = "E" + number.ToString("D3"); // E013
                        Txt_n_a.Text = newID;
                    }
                    else
                    {
                        Txt_n_a.Text = "E001"; // premier enregistrement
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

    }
}

