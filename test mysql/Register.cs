﻿using MySql.Data.MySqlClient;
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
using test_mysql.Cryptography;
using Org.BouncyCastle.Utilities;
using System.Security.Cryptography;


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
            Encryption encryption = new Encryption();
            string hashPassword = encryption.CalculateSHA256(login_Password.Text);
            string query = "INSERT INTO login (user,sha256password,secretAwnser,awnserReponse) VALUES ('" +login_Id.Text+ "','" +hashPassword+ "','"+login_SecretAwnser.Text+"','"+login_Reponse.Text+"')";
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

