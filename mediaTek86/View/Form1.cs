using mediaTek86.dal;
using mediaTek86.View;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace mediaTek86
{
    /// <summary>
    /// Form1
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form1 chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPwd.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VerifierAuthentification(login, password))
            {
                form2 form2 = new form2();
                form2.Show();
                this.Hide(); // Cache `Form1`
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifierAuthentification(string login, string password)
        {

            try
            {
                string connectionString = Access.GetConnectionString();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Retourne `true` si login/mot de passe valide
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }
    }
}
    

