using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login _login = new login();
            this.Hide();
            _login.Show();
        }

        private async void signUpBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(idInput.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idInput.Focus();
                return;
            }
            if (pwInput.Text !=pwConfirmInput.Text)
            {
                MessageBox.Show("Şifre Doğrulanamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IUserRepo repo = new UserRepo();
            bool result = await repo.Insert(new User() {Username = idInput.Text, Password = pwInput.Text });
            if (result) { 
                MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login _login = new login();
                this.Hide();
            _login.Show();
            }
            else
                MessageBox.Show("Kayıt Başarısız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
