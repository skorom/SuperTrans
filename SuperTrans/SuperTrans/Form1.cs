using Firebase.Login;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Firebase.Database.Query;
using System.Reactive.Linq;

namespace SuperTrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private const string database = "https://test-66179.firebaseio.com/";
        public static string username;
        private async Task Register()
        {
            try
            {
                if (reg_pass.Text == reg_pass2.Text)
                {
                    var client = new FirebaseClient(database);
                    var child = client.Child("Users");
                    var users = await child.OnceAsync<Login>();
                    bool taken = false;
                    foreach (var i in users)
                    {
                        if (i.Object.username == reg_user.Text || i.Object.username == "Everyone")
                        {
                            taken = true;
                        }
                    }
                    if (!taken)
                    {
                        child.PostAsync(new Register { username = reg_user.Text, password = Hash(reg_pass.Text) });
                        MessageBox.Show("Sikeres regisztráció!");
                    }
                    else
                    {
                        throw new DataException("A felhasználónév foglalt.");
                    }
                }
                else
                {
                    throw new DataException("A jelszavak nem egyeznek.");
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FirebaseException ex)
            {
                MessageBox.Show("Hiba az adatbázissal.\r\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
            finally
            {
                reg_user.Text = "";
                reg_pass.Text = "";
                reg_pass2.Text = "";
            }
   
        }

        private async Task Login()
        {
            try
            {
                var client = new FirebaseClient(database);
                var child = client.Child("Users");
                var users = await child.OnceAsync<Login>();
                foreach (var i in users)
                {
                    if (i.Object.username == log_user.Text && i.Object.password == Hash(log_pass.Text))
                    {
                        if (i.Key != "")
                        {
                            username = i.Object.username;
                            await child.Child(i.Key).PutAsync(new Login() { username = i.Object.username, password = i.Object.password, Timestamp = i.Object.Timestamp, online = true });
                            Chat ablak = new Chat();
                            ablak.Show();
                            this.Hide();
                        }
                        else
                        {
                            throw new DataException("Helytelen felhasználónév vagy jelszó.");
                        }
                        break;
                    }
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FirebaseException ex)
            {
                MessageBox.Show("Hiba az adatbázissal.\r\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
            finally
            {
                log_user.Text = "";
                log_pass.Text = "";
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register();
        }

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
