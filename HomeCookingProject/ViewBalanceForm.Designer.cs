namespace HomeCookingProject
{
    partial class ViewBalanceForm
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
            this.custBalance = new System.Windows.Forms.Label();
            this.payBalanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custBalance
            // 
            this.custBalance.AutoSize = true;
            this.custBalance.Location = new System.Drawing.Point(12, 30);
            this.custBalance.Name = "custBalance";
            this.custBalance.Size = new System.Drawing.Size(0, 13);
            this.custBalance.TabIndex = 0;
            // 
            // payBalanceButton
            // 
            this.payBalanceButton.Location = new System.Drawing.Point(150, 74);
            this.payBalanceButton.Name = "payBalanceButton";
            this.payBalanceButton.Size = new System.Drawing.Size(122, 23);
            this.payBalanceButton.TabIndex = 1;
            this.payBalanceButton.Text = "Make Payment Now";
            this.payBalanceButton.UseVisualStyleBackColor = true;
            this.payBalanceButton.Click += new System.EventHandler(this.payBalanceButton_Click);
            // 
            // ViewBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.payBalanceButton);
            this.Controls.Add(this.custBalance);
            this.Name = "ViewBalanceForm";
            this.Text = "Check My Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custBalance;
        private System.Windows.Forms.Button payBalanceButton;
    }
}