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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_mysql
{
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testmysql;port=3306;password="); // definition de la connexion a la bdd

        public Register()
        {
            InitializeComponent();
        }

        private async void validateButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO login (user,password) VALUES ('" + login_Id.Text + "','" + login_Password.Text + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            label1.Text = "Compte créer avec succès";
            await Task.Delay(2000);
            ActiveForm.Close();

        }

        private void showButton_CheckedChanged(object sender, EventArgs e)
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
    }
}

