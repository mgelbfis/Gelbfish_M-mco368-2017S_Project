namespace HomeCookingProject
{
    partial class NewAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.passwordMismatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a Username: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create a Password:";
            // 
            // usernameEntry
            // 
            this.usernameEntry.Location = new System.Drawing.Point(48, 54);
            this.usernameEntry.MaxLength = 20;
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(170, 20);
            this.usernameEntry.TabIndex = 2;
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(47, 120);
            this.passwordEntry.MaxLength = 40;
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(171, 20);
            this.passwordEntry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm your Password:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(48, 185);
            this.confirmPassword.MaxLength = 40;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(170, 20);
            this.confirmPassword.TabIndex = 5;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(77, 227);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(115, 23);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // passwordMismatch
            // 
            this.passwordMismatch.AutoSize = true;
            this.passwordMismatch.Location = new System.Drawing.Point(28, 258);
            this.passwordMismatch.Name = "passwordMismatch";
            this.passwordMismatch.Size = new System.Drawing.Size(0, 13);
            this.passwordMismatch.TabIndex = 7;
            this.passwordMismatch.Click += new System.EventHandler(this.label4_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 289);
            this.Controls.Add(this.passwordMismatch);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.usernameEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewAccountForm";
            this.Text = "Create Your New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label passwordMismatch;
    }
}