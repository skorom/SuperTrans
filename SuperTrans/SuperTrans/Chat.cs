using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperTrans
{
    public partial class Chat : Form
    {

        private string partner;
        private FirebaseClient client = new FirebaseClient("https://test-66179.firebaseio.com/");

        public Chat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Run();
            LoginCheck().Wait();
        }

        private async Task Run()
        {
            try
            {
                var child = client.Child("Messages");
                var observable = child.AsObservable<InboundMessage>();
                var data = await client.Child("Users").OnceAsync<Login>();
                foreach (var item in data)
                {
                    if (item.Object.username != Form1.username)
                    {
                        listBox1.Items.Add(item.Object.username);
                    }
                }
                partner = listBox1.Items[0].ToString();
                var subscription = observable.Where(item => !string.IsNullOrEmpty(item.Key)).Subscribe(item => displayMessage(item));
            }
            catch(FirebaseException ex)
            {
                MessageBox.Show("Hiba a felhasználók beolvasása során.\r\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }

        private async Task Send()
        {
            try
            {
                string message = textBox2.Text;
                string recip = partner;
                var child = client.Child("Messages");
                child.PostAsync(new OutboundMessage { Author = Form1.username, Content = message, Recipient = recip });
                textBox3.Text += "Én: " + message+"\r\n";
                textBox2.Text = "";
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba az üzenet küldése során.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }
        private async Task Send(string x)
        {
            try
            {
                string[] file = File.ReadAllLines(x);
                int n = x.Split('\\').Length;
                string filename = x.Split('\\')[n-1];
                string recip = partner;
                var child = client.Child("Messages");
                child.PostAsync(new OutboundMessage { Author = Form1.username, File = file, Recipient = recip, Filename = filename });
                textBox3.Text += filename+" elküldve \r\n";
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba a file küldése során.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }
        private delegate void displayMessageDelegate(FirebaseEvent<InboundMessage> item);
        private void displayMessage(FirebaseEvent<InboundMessage> item)
        {
            if (this.InvokeRequired)
                this.Invoke(new displayMessageDelegate(this.displayMessage), item);
            else
            {
                if (item.Object?.Recipient == Form1.username && item.Object?.Author == partner)
                {
                    textBox3.Text += item.Object.Author + ": " + item.Object.Content + "\r\n";
                }
                else if (item.Object?.Recipient == Form1.username && item.Object?.Author == partner && item.Object?.File != null)
                {
                    textBox3.Text += item.Object.Author+": " + item.Object.Filename + "\r\n";
                    File.WriteAllLines("C:\\Users\\szicsa\\Downloads" + item.Object.Filename, item.Object.File);
                    
                }

            }
        }

        private async Task LoginCheck()
        {
            try
            {
                var child = client.Child("Users");
                var observable = child.AsObservable<Login>();
                var subscription = observable.Where(item => item.Object?.username != Form1.username).Where(item => item.Object?.online == true).Subscribe(item => onUserLogin(item.Object.username));
            }
            catch(FirebaseException ex)
            {
                MessageBox.Show("Hiba az adatbázissal.\r\n" + ex.Message);
            }
        }
        private void onUserLogin(string user)
        {

            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "SuperTrans Belépés";
            notifyIcon.BalloonTipText = user + " belépett a chatbe. Üdvözöld!";
            notifyIcon.ShowBalloonTip(3000);
            notifyIcon.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            partner = listBox1.Text;
            loadConversation();
        }

        private async void loadConversation()
        {
            try
            {
                textBox3.Text = "";
                var data = await client.Child("Messages").OnceAsync<InboundMessage>();
                foreach (var item in data)
                {
                    if (item.Object?.Recipient == Form1.username && item.Object?.Author == partner)
                    {
                        textBox3.Text += item.Object.Author + ": " + item.Object.Content + "\r\n";
                    }
                    else if (item.Object?.Recipient == partner && item.Object?.Author == Form1.username)
                    {
                        textBox3.Text += "Én: " + item.Object.Content + "\r\n";
                    }
                }
            }
            catch(FirebaseException ex)
            {
                MessageBox.Show("Hiba a beszélgetés beolvasása során.\r\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string filename = "";
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            Send(filename).Wait();
        }   
        public class Login
        {
            public string username { get; set; }
            public string password { get; set; }
            public bool online { get; set; }
        }
    }
}