using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace Download_Manager
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signUp _signUp = new signUp();
            this.Hide();
            _signUp.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idInput.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idInput.Focus();
                return;
            }
            try
            {
                using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    User obj = db.Query<User>($"select *from UserList where Username = '{idInput.Text}'", commandType: CommandType.Text).SingleOrDefault();
                if (obj != null)
                    {
                        if(obj.Password == pwInput.Text)
                        {
                            main _main = new main();
                            this.Hide();
                            _main.Show();
                        }
                        else
                            MessageBox.Show(this, "Kullanıcı Adınızı Veya Şifreniz Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                else
                        MessageBox.Show(this,"Kullanıcı Adınızı Veya Şifreniz Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
