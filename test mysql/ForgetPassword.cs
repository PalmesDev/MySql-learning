using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_mysql.Cryptography;

namespace test_mysql
{
    public partial class ForgetPassword : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testmysql;port=3306;password="); // definition de la connexion a la bdd

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void login_Id_TextChanged(object sender, EventArgs e)
        {


        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (!login_secretAwnser.Enabled)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE user ='" + login_Id.Text + "'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    connection.Open();
                    string query = "SELECT secretAwnser FROM login WHERE user='" + login_Id.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        login_secretAwnser.Text = reader["secretAwnser"].ToString();
                        connection.Close();
                    }

                    login_secretAwnser.Visible = true;
                    login_secretAwnser.Enabled = true;

                    secretAwnser.Visible = true;
                    secretAwnser.Enabled = true;

                    login_secretReponse.Visible = true;
                    login_secretReponse.Enabled = true;

                    secretReponse.Visible = true;
                    secretReponse.Enabled = true;

                    validateButton.Location = new Point { X = 130, Y = 350 };
                    validateButton.Enabled = true;
                    return;
                }
            }
                

            if (login_secretReponse.Text.Length > 0)
            {
                connection.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT awnserReponse FROM login WHERE user ='" + login_Id.Text + "'", connection);
                DataTable dtt = new DataTable();
                adapt.Fill(dtt);

                if (dtt.Rows[0][0].ToString() == login_secretReponse.Text)
                {
                    MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
