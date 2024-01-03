namespace register
{
    partial class Form1
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
            Register = new Label();
            identifiant = new Label();
            password = new Label();
            login_Id = new TextBox();
            login_Password = new TextBox();
            validateButton = new Button();
            showButton = new CheckBox();
            SuspendLayout();
            // 
            // Register
            // 
            Register.BorderStyle = BorderStyle.FixedSingle;
            Register.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Register.Location = new Point(120, 35);
            Register.Name = "Register";
            Register.Size = new Size(160, 70);
            Register.TabIndex = 1;
            Register.Text = "Register";
            Register.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            identifiant.Location = new Point(90, 120);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(95, 21);
            identifiant.TabIndex = 2;
            identifiant.Text = "Identifiant";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(90, 170);
            password.Name = "password";
            password.Size = new Size(114, 21);
            password.TabIndex = 3;
            password.Text = "Mot de passe";
            // 
            // login_Id
            // 
            login_Id.Location = new Point(85, 140);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 4;
            login_Id.TextChanged += loginIsNotEmpty;
            // 
            // login_Password
            // 
            login_Password.Location = new Point(85, 190);
            login_Password.Name = "login_Password";
            login_Password.PasswordChar = '*';
            login_Password.Size = new Size(230, 23);
            login_Password.TabIndex = 5;
            login_Password.TextChanged += loginIsNotEmpty;
            // 
            // validateButton
            // 
            validateButton.Enabled = false;
            validateButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            validateButton.Location = new Point(130, 250);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(140, 30);
            validateButton.TabIndex = 7;
            validateButton.TabStop = false;
            validateButton.Text = "S'inscrire";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(247, 219);
            showButton.Name = "showButton";
            showButton.Size = new Size(68, 19);
            showButton.TabIndex = 8;
            showButton.Text = "Afficher";
            showButton.UseVisualStyleBackColor = true;
            showButton.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(showButton);
            Controls.Add(validateButton);
            Controls.Add(login_Password);
            Controls.Add(login_Id);
            Controls.Add(password);
            Controls.Add(identifiant);
            Controls.Add(Register);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Register;
        private Label identifiant;
        private Label password;
        private TextBox login_Id;
        private TextBox login_Password;
        private Button validateButton;
        private CheckBox showButton;
    }
}