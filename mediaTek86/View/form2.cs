using mediaTek86.dal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaTek86.View
{
    /// <summary>
    /// Form2
    /// </summary>
    public partial class form2 : Form
    {
        /// <summary>
        /// Form2
        /// </summary>
        public form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form2 chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void txtNomAjouter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailModification_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAffectationAjouter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerAjoutAbs_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerModification_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom = txtNomAjouter.Text.Trim();
            string prenom = txtPrenomAjouter.Text.Trim();
            string tel = txtTelAjouter.Text.Trim();
            string email = txtMailAjouter.Text.Trim();
            string affectation = lstAffectationAjouter.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(affectation))
            {
                MessageBox.Show("Tous les champs doivent être remplis !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AjouterPersonnel(nom, prenom, tel, email, affectation))
            {
                MessageBox.Show("Personnel ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerListePersonnel(); // Rafraîchir l'affichage après ajout
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }
        private bool AjouterPersonnel(string nom, string prenom, string tel, string email, string affectation)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO personnel (nom, prenom, tel, email, idAffectation) VALUES (@nom, @prenom, @tel, @email, (SELECT idAffectation FROM affectation WHERE libelle = @affectation))";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@affectation", affectation);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ChargerListePersonnel()
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT nom, prenom, tel, email, libelle AS affectation FROM personnel INNER JOIN affectation ON personnel.idAffectation = affectation.idAffectation";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt; // Affecte les données à dataGridView1
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur Affichage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnregistrerAjouter_Click(object sender, EventArgs e)
        {
            ChargerListePersonnel();

        }
    }
}
