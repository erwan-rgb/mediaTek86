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
            dataGridViewAbsence.Visible = false;
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
            string nom = txtNomModification.Text.Trim();
            string prenom = txtPrenomModification.Text.Trim();
            string tel = txtTelModification.Text.Trim();
            string email = txtMailModification.Text.Trim();
            string affectation = lstAffectationModification.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(affectation))
            {
                MessageBox.Show("Tous les champs doivent être remplis !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show($"Confirmez-vous la modification de {nom} {prenom} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                if (ModifierPersonnel(nom, prenom, tel, email, affectation))
                {
                    MessageBox.Show("Personnel modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerListePersonnel(); // Met à jour `dataGridView1`
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            dataGridViewAbsence.Visible = false;
            dataGridView1.Visible = true;
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer l'ID du personnel sélectionné
            int idPersonnel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value);

            // Masquer dataGridView1 et afficher dataGridViewAbsences
            dataGridView1.Visible = false;
            dataGridViewAbsence.Visible = true;

            // Charger les absences du personnel sélectionné
            ChargerAbsencesPersonnel(idPersonnel);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nom = dataGridView1.SelectedRows[0].Cells["nom"].Value.ToString();
            string prenom = dataGridView1.SelectedRows[0].Cells["prenom"].Value.ToString();

            DialogResult confirmation = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer {nom} {prenom} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                if (SupprimerPersonnel(nom, prenom))
                {
                    MessageBox.Show("Personnel supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerListePersonnel(); // Rafraîchir l'affichage
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nom = dataGridView1.SelectedRows[0].Cells["nom"].Value.ToString();
            string prenom = dataGridView1.SelectedRows[0].Cells["prenom"].Value.ToString();
            string tel = dataGridView1.SelectedRows[0].Cells["tel"].Value.ToString();
            string email = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
            string affectation = dataGridView1.SelectedRows[0].Cells["affectation"].Value.ToString();

            txtNomModification.Text = nom;
            txtPrenomModification.Text = prenom;
            txtTelModification.Text = tel;
            txtMailModification.Text = email;
            lstAffectationModification.SelectedItem = affectation;
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
                        dataGridView1.DataSource = dt;
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
        private bool SupprimerPersonnel(string nom, string prenom)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM personnel WHERE nom = @nom AND prenom = @prenom";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);

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
        private bool ModifierPersonnel(string nom, string prenom, string tel, string email, string affectation)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE personnel SET tel = @tel, email = @email, idAffectation = (SELECT idAffectation FROM affectation WHERE libelle = @affectation) WHERE nom = @nom AND prenom = @prenom";

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
        private void ChargerAbsencesPersonnel(int idPersonnel)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT dateDebut, dateFin, motif FROM absence WHERE idPersonnel = @idPersonnel ORDER BY dateDebut DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    using (DataTable dt = new DataTable())
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@idPersonnel", idPersonnel);
                        adapter.Fill(dt);
                        dataGridViewAbsence.DataSource = dt; // Affiche les absences dans le DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur Affichage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPersonnel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value);
                ChargerAbsencesPersonnel(idPersonnel); // Affiche les absences
            }
        }
    }
}
