namespace Acquisti
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtProdotto;
        private System.Windows.Forms.NumericUpDown numericUpDownPrezzo;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcquisto;
        private System.Windows.Forms.Button btnRegistraAcquisto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCognome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelProdotto;
        private System.Windows.Forms.Label labelPrezzo;
        private System.Windows.Forms.Label labelDataAcquisto;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtProdotto = new System.Windows.Forms.TextBox();
            this.numericUpDownPrezzo = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerAcquisto = new System.Windows.Forms.DateTimePicker();
            this.btnRegistraAcquisto = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCognome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelProdotto = new System.Windows.Forms.Label();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.labelDataAcquisto = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrezzo)).BeginInit();
            this.SuspendLayout();
            
            // DataGridView
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 250);
            this.dataGridView1.TabIndex = 0;

            // Nome TextBox
            this.txtNome.Location = new System.Drawing.Point(90, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;

            // Cognome TextBox
            this.txtCognome.Location = new System.Drawing.Point(90, 50);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(150, 20);
            this.txtCognome.TabIndex = 2;

            // Email TextBox
            this.txtEmail.Location = new System.Drawing.Point(90, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 3;

            // Telefono TextBox
            this.txtTelefono.Location = new System.Drawing.Point(90, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtTelefono.TabIndex = 4;

            // Aggiungi Button
            this.btnAggiungi.Location = new System.Drawing.Point(270, 20);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);

            // Elimina Button
            this.btnElimina.Location = new System.Drawing.Point(270, 50);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);

            // Modifica Button
            this.btnModifica.Location = new System.Drawing.Point(270, 80);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);

            // Ricerca TextBox
            this.txtRicerca.Location = new System.Drawing.Point(90, 140);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(150, 20);
            this.txtRicerca.TabIndex = 8;

            // Cerca Button
            this.btnCerca.Location = new System.Drawing.Point(270, 140);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 9;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);

            // Prodotto TextBox
            this.txtProdotto.Location = new System.Drawing.Point(500, 20);
            this.txtProdotto.Name = "txtProdotto";
            this.txtProdotto.Size = new System.Drawing.Size(150, 20);
            this.txtProdotto.TabIndex = 10;

            // Prezzo NumericUpDown
            this.numericUpDownPrezzo.Location = new System.Drawing.Point(500, 50);
            this.numericUpDownPrezzo.Name = "numericUpDownPrezzo";
            this.numericUpDownPrezzo.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownPrezzo.TabIndex = 11;

            // DataAcquisto DateTimePicker
            this.dateTimePickerAcquisto.Location = new System.Drawing.Point(500, 80);
            this.dateTimePickerAcquisto.Name = "dateTimePickerAcquisto";
            this.dateTimePickerAcquisto.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerAcquisto.TabIndex = 12;

            // Registra Acquisto Button
            this.btnRegistraAcquisto.Location = new System.Drawing.Point(500, 110);
            this.btnRegistraAcquisto.Name = "btnRegistraAcquisto";
            this.btnRegistraAcquisto.Size = new System.Drawing.Size(150, 23);
            this.btnRegistraAcquisto.TabIndex = 13;
            this.btnRegistraAcquisto.Text = "Registra Acquisto";
            this.btnRegistraAcquisto.UseVisualStyleBackColor = true;
            this.btnRegistraAcquisto.Click += new System.EventHandler(this.btnRegistraAcquisto_Click);

            // Labels
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(20, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome";

            this.labelCognome.AutoSize = true;
            this.labelCognome.Location = new System.Drawing.Point(20, 50);
            this.labelCognome.Name = "labelCognome";
            this.labelCognome.Size = new System.Drawing.Size(58, 13);
            this.labelCognome.TabIndex = 15;
            this.labelCognome.Text = "Cognome";

            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";

            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(20, 110);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(53, 13);
            this.labelTelefono.TabIndex = 17;
            this.labelTelefono.Text = "Telefono";

            this.labelProdotto.AutoSize = true;
            this.labelProdotto.Location = new System.Drawing.Point(400, 20);
            this.labelProdotto.Name = "labelProdotto";
            this.labelProdotto.Size = new System.Drawing.Size(50, 13);
            this.labelProdotto.TabIndex = 18;
            this.labelProdotto.Text = "Prodotto";

            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Location = new System.Drawing.Point(400, 50);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(39, 13);
            this.labelPrezzo.TabIndex = 19;
             this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Location = new System.Drawing.Point(400, 50);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(39, 13);
            this.labelPrezzo.TabIndex = 19;
            this.labelPrezzo.Text = "Prezzo";

            this.labelDataAcquisto.AutoSize = true;
            this.labelDataAcquisto.Location = new System.Drawing.Point(400, 80);
            this.labelDataAcquisto.Name = "labelDataAcquisto";
            this.labelDataAcquisto.Size = new System.Drawing.Size(80, 13);
            this.labelDataAcquisto.TabIndex = 20;
            this.labelDataAcquisto.Text = "Data Acquisto";

            // Form1
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelDataAcquisto);
            this.Controls.Add(this.labelPrezzo);
            this.Controls.Add(this.labelProdotto);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCognome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnRegistraAcquisto);
            this.Controls.Add(this.dateTimePickerAcquisto);
            this.Controls.Add(this.numericUpDownPrezzo);
            this.Controls.Add(this.txtProdotto);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Gestione Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
