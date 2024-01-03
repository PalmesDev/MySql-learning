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
            SuspendLayout();
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(243, 227);
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
            validateButton.Location = new Point(126, 258);
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
            login_Password.Location = new Point(81, 198);
            login_Password.Name = "login_Password";
            login_Password.PasswordChar = '*';
            login_Password.Size = new Size(230, 23);
            login_Password.TabIndex = 13;
            login_Password.TextChanged += loginIsNotEmpty;
            // 
            // login_Id
            // 
            login_Id.Location = new Point(81, 148);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 12;
            login_Id.TextChanged += loginIsNotEmpty;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            password.Location = new Point(86, 178);
            password.Name = "password";
            password.Size = new Size(114, 21);
            password.TabIndex = 11;
            password.Text = "Mot de passe";
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            identifiant.Location = new Point(86, 128);
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
            RegisterMySql.Name = "Register";
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
            label1.Location = new Point(0, 311);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 16;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(label1);
            Controls.Add(showButton);
            Controls.Add(validateButton);
            Controls.Add(login_Password);
            Controls.Add(login_Id);
            Controls.Add(password);
            Controls.Add(identifiant);
            Controls.Add(RegisterMySql);
            Name = "Form2";
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
    }
}