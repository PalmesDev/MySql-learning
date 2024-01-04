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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            newPassword = new TextBox();
            confirmNewPassword = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // login_Id
            // 
            login_Id.Location = new Point(44, 156);
            login_Id.Name = "login_Id";
            login_Id.Size = new Size(230, 23);
            login_Id.TabIndex = 15;
            // 
            // identifiant
            // 
            identifiant.AutoSize = true;
            identifiant.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            identifiant.Location = new Point(39, 128);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(95, 21);
            identifiant.TabIndex = 14;
            identifiant.Text = "Identifiant";
            // 
            // RegisterMySql
            // 
            RegisterMySql.BorderStyle = BorderStyle.FixedSingle;
            RegisterMySql.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            RegisterMySql.Location = new Point(79, 32);
            RegisterMySql.Name = "RegisterMySql";
            RegisterMySql.Size = new Size(160, 70);
            RegisterMySql.TabIndex = 13;
            RegisterMySql.Text = "Forget Password";
            RegisterMySql.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_secretAwnser
            // 
            login_secretAwnser.Enabled = false;
            login_secretAwnser.Location = new Point(44, 216);
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
            secretAwnser.Location = new Point(39, 188);
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
            secretReponse.Location = new Point(39, 248);
            secretReponse.Name = "secretReponse";
            secretReponse.Size = new Size(138, 21);
            secretReponse.TabIndex = 19;
            secretReponse.Text = "Réponse secrète";
            secretReponse.Visible = false;
            // 
            // login_secretReponse
            // 
            login_secretReponse.Enabled = false;
            login_secretReponse.Location = new Point(44, 276);
            login_secretReponse.Name = "login_secretReponse";
            login_secretReponse.Size = new Size(230, 23);
            login_secretReponse.TabIndex = 18;
            login_secretReponse.Visible = false;
            // 
            // validateButton
            // 
            validateButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            validateButton.Location = new Point(89, 190);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(140, 30);
            validateButton.TabIndex = 20;
            validateButton.Text = "Validé";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(RegisterMySql);
            panel1.Controls.Add(validateButton);
            panel1.Controls.Add(identifiant);
            panel1.Controls.Add(secretReponse);
            panel1.Controls.Add(login_Id);
            panel1.Controls.Add(login_secretReponse);
            panel1.Controls.Add(login_secretAwnser);
            panel1.Controls.Add(secretAwnser);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 416);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(newPassword);
            panel2.Controls.Add(confirmNewPassword);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 416);
            panel2.TabIndex = 22;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(79, 32);
            label1.Name = "label1";
            label1.Size = new Size(160, 70);
            label1.TabIndex = 13;
            label1.Text = "Forget Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(89, 260);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 20;
            button1.Text = "Validé";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(66, 128);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 14;
            label2.Text = "Nouveau mot de passe";
            // 
            // newPassword
            // 
            newPassword.Location = new Point(44, 156);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(230, 23);
            newPassword.TabIndex = 15;
            // 
            // confirmNewPassword
            // 
            confirmNewPassword.Location = new Point(44, 216);
            confirmNewPassword.Name = "confirmNewPassword";
            confirmNewPassword.Size = new Size(230, 23);
            confirmNewPassword.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 188);
            label4.Name = "label4";
            label4.Size = new Size(268, 21);
            label4.TabIndex = 17;
            label4.Text = "Confirmer nouveau mot de passe";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox newPassword;
        private TextBox confirmNewPassword;
        private Label label4;
    }
}