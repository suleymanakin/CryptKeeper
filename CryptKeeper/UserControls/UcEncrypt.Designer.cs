namespace CryptKeeper.UserControls
{
    partial class UcEncrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnFileEncryption = new System.Windows.Forms.RadioButton();
            this.rbtnFolderEncryption = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStartEncryption = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(264, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the action you want to perform";
            // 
            // rbtnFileEncryption
            // 
            this.rbtnFileEncryption.AutoSize = true;
            this.rbtnFileEncryption.Checked = true;
            this.rbtnFileEncryption.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFileEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnFileEncryption.Location = new System.Drawing.Point(447, 150);
            this.rbtnFileEncryption.Name = "rbtnFileEncryption";
            this.rbtnFileEncryption.Size = new System.Drawing.Size(178, 36);
            this.rbtnFileEncryption.TabIndex = 0;
            this.rbtnFileEncryption.TabStop = true;
            this.rbtnFileEncryption.Text = "File Encryption";
            this.rbtnFileEncryption.UseVisualStyleBackColor = true;
            // 
            // rbtnFolderEncryption
            // 
            this.rbtnFolderEncryption.AutoSize = true;
            this.rbtnFolderEncryption.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFolderEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnFolderEncryption.Location = new System.Drawing.Point(447, 191);
            this.rbtnFolderEncryption.Name = "rbtnFolderEncryption";
            this.rbtnFolderEncryption.Size = new System.Drawing.Size(206, 36);
            this.rbtnFolderEncryption.TabIndex = 1;
            this.rbtnFolderEncryption.Text = "Folder Encryption";
            this.rbtnFolderEncryption.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.Location = new System.Drawing.Point(330, 250);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(430, 50);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnStartEncryption
            // 
            this.btnStartEncryption.Font = new System.Drawing.Font("Tajawal", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartEncryption.Location = new System.Drawing.Point(330, 460);
            this.btnStartEncryption.Name = "btnStartEncryption";
            this.btnStartEncryption.Size = new System.Drawing.Size(430, 50);
            this.btnStartEncryption.TabIndex = 4;
            this.btnStartEncryption.Text = "Start Encryption";
            this.btnStartEncryption.UseVisualStyleBackColor = true;
            this.btnStartEncryption.Click += new System.EventHandler(this.btnStartEncryption_Click);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(552, 615);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Ready";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tajawal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(481, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
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
            // UcEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btnStartEncryption);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.rbtnFolderEncryption);
            this.Controls.Add(this.rbtnFileEncryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcEncrypt";
            this.Size = new System.Drawing.Size(1100, 665);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnFileEncryption;
        private System.Windows.Forms.RadioButton rbtnFolderEncryption;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnStartEncryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
