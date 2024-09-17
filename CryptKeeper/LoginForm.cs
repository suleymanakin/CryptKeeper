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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnNewSecreKey_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "admin" && tbxPassword.Text == "admin")
            {
                MessageBox.Show("Giriş başarılı");

                // MainForm örneği oluşturuluyor
                MainForm mainForm = new MainForm();

                // MainForm'u göster
                mainForm.Show();

                // Login formunu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
        }

    }
}
