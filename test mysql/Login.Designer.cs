namespace test_mysql
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LAUNCHER = new Label();
            identifiant = new Label();
            password = new Label();
            login_Id = new TextBox();
            login_Password = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            inscription = new LinkLabel();
            logger = new Label();
            forgetpassword = new LinkLabel();
            SuspendLayout();
            // 
            // LAUNCHER
            // 
            LAUNCHER.Anchor = AnchorStyles.None;
            LAUNCHER.BorderStyle = BorderStyle.FixedSingle;
            LAUNCHER.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LAUNCHER.Location = new Point(120, 60);
            LAUNCHER.Name = "LAUNCHER";
            LAUNCHER.Size = new Size(160, 70);
            LAUNCHER.TabIndex = 0;
            LAUNCHER.Text = "LAUNCHER\r\nMySql\r\n";
            LAUNCHER.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            identifiant.Location = new Point(85, 160);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(95, 21);
            identifiant.TabIndex = 1;
            identifiant.Text = "Identifiant";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(85, 220);
            password.Name = "password";
            password.Size = new Size(114, 21);
            password.TabIndex = 2;
            password.Text = "Mot de passe";
            // 
            // login_Id
            // 
            login_Id.Location = new Point(85, 180);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 3;
            login_Id.TextChanged += loginIsNotEmpty;
            // 
            // login_Password
            // 
            login_Password.Location = new Point(85, 240);
            login_Password.Name = "login_Password";
            login_Password.PasswordChar = '*';
            login_Password.Size = new Size(230, 23);
            login_Password.TabIndex = 4;
            login_Password.TextChanged += loginIsNotEmpty;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(247, 269);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Afficher";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(130, 308);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 6;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inscription
            // 
            inscription.Location = new Point(255, 341);
            inscription.Name = "inscription";
            inscription.Size = new Size(60, 15);
            inscription.TabIndex = 8;
            inscription.TabStop = true;
            inscription.Text = "s'inscrire";
            inscription.LinkClicked += inscription_LinkClicked;
            // 
            // logger
            // 
            logger.Dock = DockStyle.Bottom;
            logger.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logger.ForeColor = Color.Red;
            logger.Location = new Point(0, 531);
            logger.Name = "logger";
            logger.Size = new Size(384, 30);
            logger.TabIndex = 9;
            logger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forgetpassword
            // 
            forgetpassword.Location = new Point(85, 341);
            forgetpassword.Name = "forgetpassword";
            forgetpassword.Size = new Size(140, 15);
            forgetpassword.TabIndex = 10;
            forgetpassword.TabStop = true;
            forgetpassword.Text = "mot de passe oublié ?";
            forgetpassword.LinkClicked += forgetpassword_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(forgetpassword);
            Controls.Add(logger);
            Controls.Add(inscription);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(login_Password);
            Controls.Add(login_Id);
            Controls.Add(password);
            Controls.Add(identifiant);
            Controls.Add(LAUNCHER);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LAUNCHER;
        private Label identifiant;
        private Label password;
        private TextBox login_Id;
        private TextBox login_Password;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel inscription;
        private Label logger;
        private LinkLabel forgetpassword;
    }
}
