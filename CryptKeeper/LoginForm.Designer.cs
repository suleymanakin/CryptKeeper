namespace CryptKeeper
{
    partial class LoginForm
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnNewSecreKey = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(209, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(215, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxUsername.Location = new System.Drawing.Point(332, 144);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(260, 30);
            this.tbxUsername.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxPassword.Location = new System.Drawing.Point(332, 195);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(260, 30);
            this.tbxPassword.TabIndex = 4;
            // 
            // btnNewSecreKey
            // 
            this.btnNewSecreKey.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnNewSecreKey.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewSecreKey.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnNewSecreKey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewSecreKey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewSecreKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewSecreKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewSecreKey.FillColor = System.Drawing.Color.White;
            this.btnNewSecreKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewSecreKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewSecreKey.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnNewSecreKey.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNewSecreKey.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnNewSecreKey.Location = new System.Drawing.Point(419, 264);
            this.btnNewSecreKey.Name = "btnNewSecreKey";
            this.btnNewSecreKey.Size = new System.Drawing.Size(173, 42);
            this.btnNewSecreKey.TabIndex = 11;
            this.btnNewSecreKey.Text = "Login";
            this.btnNewSecreKey.Click += new System.EventHandler(this.btnNewSecreKey_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewSecreKey);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private Guna.UI2.WinForms.Guna2Button btnNewSecreKey;
    }
}