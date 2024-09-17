namespace CryptKeeper.UserControls
{
    partial class UcSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewSecreKey = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKey.Location = new System.Drawing.Point(112, 90);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(29, 33);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "IV:";
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIV.Location = new System.Drawing.Point(112, 123);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(29, 33);
            this.lblIV.TabIndex = 7;
            this.lblIV.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "WARNING! This action cannot be undone!";
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
            this.btnNewSecreKey.Location = new System.Drawing.Point(44, 198);
            this.btnNewSecreKey.Name = "btnNewSecreKey";
            this.btnNewSecreKey.Size = new System.Drawing.Size(228, 50);
            this.btnNewSecreKey.TabIndex = 10;
            this.btnNewSecreKey.Text = "New SecretKey";
            this.btnNewSecreKey.Click += new System.EventHandler(this.btnNewSecreKey_Click);
            // 
            // UcSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewSecreKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label2);
            this.Name = "UcSettings";
            this.Size = new System.Drawing.Size(1100, 665);
            this.Load += new System.EventHandler(this.UcSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNewSecreKey;
    }
}
