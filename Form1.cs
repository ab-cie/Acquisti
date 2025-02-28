using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Acquisti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
            CaricaDati();
        }

        private void CaricaDati()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        c.ID, 
                        c.Nome, 
                        c.Cognome, 
                        c.Email, 
                        c.Telefono, 
                        IFNULL(MAX(a.DataAcquisto), 'Nessun acquisto') AS UltimoAcquisto, 
                        IFNULL(SUM(a.Prezzo), 0) AS TotaleSpeso
                    FROM 
                        Clienti c
                    LEFT JOIN 
                        Acquisti a ON c.ID = a.ClienteID
                    GROUP BY 
                        c.ID";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void CercaDati(string filtro)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Clienti WHERE Nome LIKE @Filtro OR Cognome LIKE @Filtro OR Email LIKE @Filtro";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCognome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Clienti (Nome, Cognome, Email, Telefono) VALUES (@Nome, @Cognome, @Email, @Telefono)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Cognome", txtCognome.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            CaricaDati();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Clienti WHERE ID = @ID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                CaricaDati();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente da modificare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCognome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Clienti SET Nome = @Nome, Cognome = @Cognome, Email = @Email, Telefono = @Telefono WHERE ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Cognome", txtCognome.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            CaricaDati();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRicerca.Text))
                CaricaDati();
            else
                CercaDati(txtRicerca.Text);
        }

        private void btnRegistraAcquisto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente per registrare l'acquisto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clienteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string prodotto = txtProdotto.Text; // Assumendo un TextBox per il nome del prodotto
            decimal prezzo = numericUpDownPrezzo.Value; // NumericUpDown per l'importo
            DateTime dataAcquisto = dateTimePickerAcquisto.Value; // DateTimePicker per la data dell'acquisto

            if (string.IsNullOrWhiteSpace(prodotto) || prezzo <= 0)
            {
                MessageBox.Show("Compila correttamente il prodotto e il prezzo!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Acquisti (ClienteID, Prodotto, Prezzo, DataAcquisto) VALUES (@ClienteID, @Prodotto, @Prezzo, @DataAcquisto)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cmd.Parameters.AddWithValue("@Prodotto", prodotto);
                    cmd.Parameters.AddWithValue("@Prezzo", prezzo);
                    cmd.Parameters.AddWithValue("@DataAcquisto", dataAcquisto.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
            }

            CaricaDati();
        }
    }
}
