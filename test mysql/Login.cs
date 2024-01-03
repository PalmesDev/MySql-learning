using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using test_mysql.Cryptography;

namespace test_mysql
{
    public partial class Login : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testmysql;port=3306;password="); // definition de la connexion a la bdd


        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                OnClick(new EventArgs());
                login_Password.PasswordChar = '*';
            }
            else
                login_Password.PasswordChar = (char)0;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            connection.Open(); // connexion a la bdd
            logger.Text = "Connexion en cours...";

            Encryption encryption = new Encryption();
            string hashPassword = encryption.CalculateSHA256(login_Password.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE user ='" + login_Id.Text + "' AND sha256password='" + hashPassword + "'", connection);
            // requete SQL qui recupère la ligne ou le login et mot de passe sont identique

            DataTable dt = new DataTable(); // initialise la dataTable dt

            adapter.Fill(dt); // Rempli dt avec les valeurs de la requete sql

            if (dt.Rows[0][0].ToString() == "1")
            {
                logger.Text = "utilisateur reconnu";
                await Task.Delay(2000);
                logger.Text = "";
            }
            else
            {
                logger.Text = "login ou mot de passe incorrect";
                await Task.Delay(2000);
                logger.Text = "";
            }

            connection.Close();




        }

        private void loginIsNotEmpty(object sender, EventArgs e)
        {
            if (login_Id.Text.Length > 0 && login_Password.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void inscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register secondForm = new Register();
            secondForm.Show();
        }

    }
}
