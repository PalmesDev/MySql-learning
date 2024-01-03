using MySql.Data.MySqlClient;
using System.Data;

namespace register
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testmysql;port=3306;password="); // definition de la connexion a la bdd

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!showButton.Checked)
            {
                OnClick(new EventArgs());
                login_Password.PasswordChar = '*';
            }
            else
                login_Password.PasswordChar = (char)0;
        }

        private void loginIsNotEmpty(object sender, EventArgs e)
        {
            if (login_Id.Text.Length > 0 && login_Password.Text.Length > 0)
            {
                validateButton.Enabled = true;
            }
            else
            {
                validateButton.Enabled = false;
            }
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO login (user,password) VALUES ('" + login_Id.Text + "','" + login_Password.Text + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}