﻿using CryptKeeper.Classes;
using CryptKeeper.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptKeeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void LoadControl(UserControl control)
        {
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(control);
            pnlContainer.BringToFront();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            UcEncrypt uc = new UcEncrypt();
            LoadControl(uc);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            UcDecrypt uc = new UcDecrypt();
            LoadControl(uc);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UcSettings uc = new UcSettings();
            LoadControl(uc);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UcAbout uc = new UcAbout();
            LoadControl(uc);
        }

        private void btnDeveloper_Click(object sender, EventArgs e)
        {
            UcDeveloper uc = new UcDeveloper();
            LoadControl(uc);
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SecretKeyHelper secretKeyHelper = new SecretKeyHelper();
            secretKeyHelper.ReadSecretKey();
            EncryptionHelper.InitializeSecretKey();
        }
    }
}
