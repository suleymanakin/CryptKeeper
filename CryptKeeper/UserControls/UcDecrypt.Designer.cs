namespace CryptKeeper.UserControls
{
    partial class UcDecrypt
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
            this.btnStartDecryption = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.rbtnFolderDecryption = new System.Windows.Forms.RadioButton();
            this.rbtnFileDecryption = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartDecryption
            // 
            this.btnStartDecryption.Font = new System.Drawing.Font("Tajawal", 13.8F);
            this.btnStartDecryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartDecryption.Location = new System.Drawing.Point(330, 460);
            this.btnStartDecryption.Name = "btnStartDecryption";
            this.btnStartDecryption.Size = new System.Drawing.Size(430, 50);
            this.btnStartDecryption.TabIndex = 4;
            this.btnStartDecryption.Text = "Start Decryption";
            this.btnStartDecryption.UseVisualStyleBackColor = true;
            this.btnStartDecryption.Click += new System.EventHandler(this.btnStartDecryption_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tajawal", 13.8F);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.Location = new System.Drawing.Point(330, 250);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(430, 50);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rbtnFolderDecryption
            // 
            this.rbtnFolderDecryption.AutoSize = true;
            this.rbtnFolderDecryption.Font = new System.Drawing.Font("Tajawal", 13.8F);
            this.rbtnFolderDecryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnFolderDecryption.Location = new System.Drawing.Point(447, 191);
            this.rbtnFolderDecryption.Name = "rbtnFolderDecryption";
            this.rbtnFolderDecryption.Size = new System.Drawing.Size(207, 36);
            this.rbtnFolderDecryption.TabIndex = 1;
            this.rbtnFolderDecryption.TabStop = true;
            this.rbtnFolderDecryption.Text = "Folder Decryption";
            this.rbtnFolderDecryption.UseVisualStyleBackColor = true;
            // 
            // rbtnFileDecryption
            // 
            this.rbtnFileDecryption.AutoSize = true;
            this.rbtnFileDecryption.Checked = true;
            this.rbtnFileDecryption.Font = new System.Drawing.Font("Tajawal", 13.8F);
            this.rbtnFileDecryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnFileDecryption.Location = new System.Drawing.Point(447, 150);
            this.rbtnFileDecryption.Name = "rbtnFileDecryption";
            this.rbtnFileDecryption.Size = new System.Drawing.Size(179, 36);
            this.rbtnFileDecryption.TabIndex = 0;
            this.rbtnFileDecryption.TabStop = true;
            this.rbtnFileDecryption.Text = "File Decryption";
            this.rbtnFileDecryption.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(481, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(552, 615);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(264, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the action you want to perform";
            // 
            // tbxPath
            // 
            this.tbxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPath.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPath.Location = new System.Drawing.Point(343, 350);
            this.tbxPath.Multiline = true;
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxPath.Size = new System.Drawing.Size(708, 60);
            this.tbxPath.TabIndex = 3;
            this.tbxPath.Text = "The chosen path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(267, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path:";
            // 
            // UcDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartDecryption);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.rbtnFolderDecryption);
            this.Controls.Add(this.rbtnFileDecryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "UcDecrypt";
            this.Size = new System.Drawing.Size(1100, 665);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDecryption;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbtnFolderDecryption;
        private System.Windows.Forms.RadioButton rbtnFileDecryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Label label2;
    }
}
