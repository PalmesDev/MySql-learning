namespace test_mysql
{
    partial class ForgetPassword
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
            login_Id = new TextBox();
            identifiant = new Label();
            RegisterMySql = new Label();
            login_secretAwnser = new TextBox();
            secretAwnser = new Label();
            secretReponse = new Label();
            login_secretReponse = new TextBox();
            validateButton = new Button();
            SuspendLayout();
            // 
            // login_Id
            // 
            login_Id.Location = new Point(85, 156);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 15;
            login_Id.TextChanged += login_Id_TextChanged;
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            identifiant.Location = new Point(85, 127);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(95, 21);
            identifiant.TabIndex = 14;
            identifiant.Text = "Identifiant";
            // 
            // RegisterMySql
            // 
            RegisterMySql.BorderStyle = BorderStyle.FixedSingle;
            RegisterMySql.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            RegisterMySql.Location = new Point(120, 32);
            RegisterMySql.Name = "RegisterMySql";
            RegisterMySql.Size = new Size(160, 70);
            RegisterMySql.TabIndex = 13;
            RegisterMySql.Text = "Forget Password";
            RegisterMySql.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_secretAwnser
            // 
            login_secretAwnser.Enabled = false;
            login_secretAwnser.Location = new Point(85, 216);
            login_secretAwnser.Name = "login_secretAwnser";
            login_secretAwnser.Size = new Size(230, 23);
            login_secretAwnser.TabIndex = 16;
            login_secretAwnser.Visible = false;
            // 
            // secretAwnser
            // 
            secretAwnser.AutoSize = true;
            secretAwnser.Enabled = false;
            secretAwnser.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            secretAwnser.Location = new Point(85, 187);
            secretAwnser.Name = "secretAwnser";
            secretAwnser.Size = new Size(142, 21);
            secretAwnser.TabIndex = 17;
            secretAwnser.Text = "Question secrète";
            secretAwnser.Visible = false;
            // 
            // secretReponse
            // 
            secretReponse.AutoSize = true;
            secretReponse.Enabled = false;
            secretReponse.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            secretReponse.Location = new Point(85, 247);
            secretReponse.Name = "secretReponse";
            secretReponse.Size = new Size(138, 21);
            secretReponse.TabIndex = 19;
            secretReponse.Text = "Réponse secrète";
            secretReponse.Visible = false;
            // 
            // login_secretReponse
            // 
            login_secretReponse.Enabled = false;
            login_secretReponse.Location = new Point(85, 276);
            login_secretReponse.Name = "login_secretReponse";
            login_secretReponse.Size = new Size(230, 23);
            login_secretReponse.TabIndex = 18;
            login_secretReponse.Visible = false;
            // 
            // validateButton
            // 
            validateButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            validateButton.Location = new Point(130, 190);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(140, 30);
            validateButton.TabIndex = 20;
            validateButton.Text = "Validé";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 514);
            Controls.Add(validateButton);
            Controls.Add(secretReponse);
            Controls.Add(login_secretReponse);
            Controls.Add(secretAwnser);
            Controls.Add(login_secretAwnser);
            Controls.Add(login_Id);
            Controls.Add(identifiant);
            Controls.Add(RegisterMySql);
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_Id;
        private Label identifiant;
        private Label RegisterMySql;
        private TextBox login_secretAwnser;
        private Label secretAwnser;
        private Label secretReponse;
        private TextBox login_secretReponse;
        private Button validateButton;
    }
}