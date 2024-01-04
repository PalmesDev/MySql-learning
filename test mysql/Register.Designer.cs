namespace test_mysql
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            showButton = new CheckBox();
            validateButton = new Button();
            login_Password = new TextBox();
            login_Id = new TextBox();
            password = new Label();
            identifiant = new Label();
            RegisterMySql = new Label();
            label1 = new Label();
            secretAwnser = new Label();
            reponse = new Label();
            login_SecretAwnser = new TextBox();
            login_Reponse = new TextBox();
            SuspendLayout();
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(243, 182);
            showButton.Name = "showButton";
            showButton.Size = new Size(68, 19);
            showButton.TabIndex = 15;
            showButton.Text = "Afficher";
            showButton.UseVisualStyleBackColor = true;
            showButton.CheckedChanged += showButton_CheckedChanged;
            // 
            // validateButton
            // 
            validateButton.Enabled = false;
            validateButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            validateButton.Location = new Point(126, 385);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(140, 30);
            validateButton.TabIndex = 14;
            validateButton.TabStop = false;
            validateButton.Text = "S'inscrire";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // login_Password
            // 
            login_Password.Location = new Point(81, 202);
            login_Password.Name = "login_Password";
            login_Password.PasswordChar = '*';
            login_Password.Size = new Size(230, 23);
            login_Password.TabIndex = 13;
            login_Password.TextChanged += loginIsNotEmpty;
            // 
            // login_Id
            // 
            login_Id.Location = new Point(81, 146);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 12;
            login_Id.TextChanged += loginIsNotEmpty;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            password.Location = new Point(81, 178);
            password.Name = "password";
            password.Size = new Size(114, 21);
            password.TabIndex = 11;
            password.Text = "Mot de passe";
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            identifiant.Location = new Point(81, 122);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(95, 21);
            identifiant.TabIndex = 10;
            identifiant.Text = "Identifiant";
            // 
            // RegisterMySql
            // 
            RegisterMySql.BorderStyle = BorderStyle.FixedSingle;
            RegisterMySql.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            RegisterMySql.Location = new Point(116, 43);
            RegisterMySql.Name = "RegisterMySql";
            RegisterMySql.Size = new Size(160, 70);
            RegisterMySql.TabIndex = 9;
            RegisterMySql.Text = "Register";
            RegisterMySql.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 464);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 16;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secretAwnser
            // 
            secretAwnser.AutoSize = true;
            secretAwnser.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            secretAwnser.Location = new Point(81, 234);
            secretAwnser.Name = "secretAwnser";
            secretAwnser.Size = new Size(142, 21);
            secretAwnser.TabIndex = 17;
            secretAwnser.Text = "Question secrète";
            // 
            // reponse
            // 
            reponse.AutoSize = true;
            reponse.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            reponse.Location = new Point(81, 290);
            reponse.Name = "reponse";
            reponse.Size = new Size(77, 21);
            reponse.TabIndex = 18;
            reponse.Text = "Réponse";
            // 
            // login_SecretAwnser
            // 
            login_SecretAwnser.Location = new Point(81, 258);
            login_SecretAwnser.Name = "login_SecretAwnser";
            login_SecretAwnser.Size = new Size(230, 23);
            login_SecretAwnser.TabIndex = 19;
            // 
            // login_Reponse
            // 
            login_Reponse.Location = new Point(81, 314);
            login_Reponse.Name = "login_Reponse";
            login_Reponse.Size = new Size(230, 23);
            login_Reponse.TabIndex = 20;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 514);
            Controls.Add(login_Reponse);
            Controls.Add(login_SecretAwnser);
            Controls.Add(reponse);
            Controls.Add(secretAwnser);
            Controls.Add(label1);
            Controls.Add(showButton);
            Controls.Add(validateButton);
            Controls.Add(login_Password);
            Controls.Add(login_Id);
            Controls.Add(password);
            Controls.Add(identifiant);
            Controls.Add(RegisterMySql);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox showButton;
        private Button validateButton;
        private TextBox login_Password;
        private TextBox login_Id;
        private Label password;
        private Label identifiant;
        private Label RegisterMySql;
        private Label label1;
        private Label secretAwnser;
        private Label reponse;
        private TextBox login_SecretAwnser;
        private TextBox login_Reponse;
    }
}