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

        /// <summary>
        /// txtNomAjouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNomAjouter_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// txtMailModif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMailModification_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// listAffectationAjouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAffectationAjouter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton pour enregistrer les ajouts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAjoutAbs_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPersonnel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value);
            DateTime dateDebut = dtpDateDebAjout.Value;
            DateTime dateFin = dtpDateFinAjout.Value;
            string motif = txtMotifAjout.Text.Trim();


            if (string.IsNullOrEmpty(motif))
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateFin < dateDebut)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (VerifierAbsenceExistante(idPersonnel, dateDebut, dateFin))
            {
                MessageBox.Show("Une absence existe déjà sur ce créneau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AjouterAbsence(idPersonnel, dateDebut, dateFin, motif))
            {
                MessageBox.Show("Absence ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerAbsencesPersonnel(idPersonnel); // Rafraîchir l'affichage
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'absence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bouton pour enregistrer les Modifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton pour Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            dataGridViewAbsence.Visible = false;
            dataGridView1.Visible = true;
        }

        /// <summary>
        /// Bouton Absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (dataGridViewAbsence.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAbsence = Convert.ToInt32(dataGridViewAbsence.SelectedRows[0].Cells["idAbsence"].Value);
            DateTime dateDebut = Convert.ToDateTime(dataGridViewAbsence.SelectedRows[0].Cells["dateDebut"].Value);
            DateTime dateFin = Convert.ToDateTime(dataGridViewAbsence.SelectedRows[0].Cells["dateFin"].Value);

            DialogResult confirm = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'absence du {dateDebut.ToShortDateString()} au {dateFin.ToShortDateString()} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (SupprimerAbsence(idAbsence))
                {
                    MessageBox.Show("Absence supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerAbsencesPersonnel(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value)); // Rafraîchir l'affichage
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de l'absence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ajout du personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="affectation"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Charger la liste du personnel
        /// </summary>
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

        /// <summary>
        /// Bouton pour enregistrer un ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAjouter_Click(object sender, EventArgs e)
        {
            ChargerListePersonnel();

        }

        /// <summary>
        /// Supprimer le personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Modifier le personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="affectation"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Charger les Absences du personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
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

        /// <summary>
        /// Data Grid View de la liste du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPersonnel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value);
                ChargerAbsencesPersonnel(idPersonnel); // Affiche les absences
            }
        }

        /// <summary>
        /// Ajouter des absences
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        /// <returns></returns>
        private bool AjouterAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO absence (idPersonnel, dateDebut, dateFin, motif) VALUES (@idPersonnel, @dateDebut, @dateFin, @motif)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPersonnel", idPersonnel);
                        cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
                        cmd.Parameters.AddWithValue("@dateFin", dateFin);
                        cmd.Parameters.AddWithValue("@motif", motif);

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

        /// <summary>
        /// Vérifier les absences Existantes
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <returns></returns>
        private bool VerifierAbsenceExistante(int idPersonnel, DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM absence WHERE idPersonnel = @idPersonnel AND ((dateDebut BETWEEN @dateDebut AND @dateFin) OR (dateFin BETWEEN @dateDebut AND @dateFin))";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPersonnel", idPersonnel);
                        cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
                        cmd.Parameters.AddWithValue("@dateFin", dateFin);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Supprimer Absence
        /// </summary>
        /// <param name="idAbsence"></param>
        /// <returns></returns>
        private bool SupprimerAbsence(int idAbsence)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM absence WHERE idAbsence = @idAbsence";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idAbsence", idAbsence);

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

        /// <summary>
        /// Bouton pour enregistrer les modifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModifAbs_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbsence.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAbsence = Convert.ToInt32(dataGridViewAbsence.SelectedRows[0].Cells["idAbsence"].Value);
            DateTime dateDebut = Convert.ToDateTime(dataGridViewAbsence.SelectedRows[0].Cells["dateDebut"].Value);
            DateTime dateFin = Convert.ToDateTime(dataGridViewAbsence.SelectedRows[0].Cells["dateFin"].Value);
            string motif = dataGridViewAbsence.SelectedRows[0].Cells["motif"].Value.ToString();

            // Pré-remplir les champs du formulaire avec les informations actuelles
            dtpDateDebModif.Value = dateDebut;
            dtpDateFinModif.Value = dateFin;
            txtMotifModif.Text = motif;

            int Absence = Convert.ToInt32(dataGridViewAbsence.SelectedRows[0].Cells["idAbsence"].Value);
            DateTime dateDeb = dtpDateDebModif.Value;
            DateTime DateFin = dtpDateDebModif.Value;
            string Motif = txtMotifModif.Text.Trim();

            if (string.IsNullOrEmpty(motif))
            {
                MessageBox.Show("Le motif ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateFin < dateDeb)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VerifierAbsenceExistante(Absence, dateDeb, DateFin))
            {
                MessageBox.Show("Une absence existe déjà sur ce créneau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmation = MessageBox.Show("Confirmez-vous la modification de cette absence ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                if (ModifierAbsence(Absence, dateDeb, DateFin, Motif))
                {
                    MessageBox.Show("Absence modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerAbsencesPersonnel(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPersonnel"].Value)); // Rafraîchir l'affichage
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Modifier Absence
        /// </summary>
        /// <param name="idAbsence"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        /// <returns></returns>
        private bool ModifierAbsence(int idAbsence, DateTime dateDebut, DateTime dateFin, string motif)
        {
            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE absence SET dateDebut = @dateDebut, dateFin = @dateFin, motif = @motif WHERE idAbsence = @idAbsence";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
                        cmd.Parameters.AddWithValue("@dateFin", dateFin);
                        cmd.Parameters.AddWithValue("@motif", motif);
                        cmd.Parameters.AddWithValue("@idAbsence", idAbsence);

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

    }
}
