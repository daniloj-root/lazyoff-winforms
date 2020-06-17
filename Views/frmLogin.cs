using LazyOff.Enums;
using LazyOff.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyOff.Views
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepository { get; set; }
        private Language language { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            StartTimer();
            userRepository = new UserRepository();
            this.language = language;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public frmLogin(Language language)
        {
            InitializeComponent();
            StartTimer();
            userRepository = new UserRepository();
            this.language = language;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void passwordBox_MouseClick(object sender, MouseEventArgs e)
        {
            var box = sender as TextBox;
            if (!box.Text.Contains("Digite sua") && !box.Text.Contains("Insert your")) return;
            box.Text = string.Empty;
            box.UseSystemPasswordChar = true;
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text.Trim() != string.Empty) return;
            passwordBox.UseSystemPasswordChar = false;
            passwordBox.Text = language == Language.PORTUGUESE ?
                "Digite sua senha..." :
                "Insert your password...";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new frmAdmin(userRepository, language).ShowDialog();
            this.Dispose();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.language = languageComboBox.SelectedItem.ToString() == "Português (PT-BR)" ?
                                                                        Language.PORTUGUESE :
                                                                        Language.ENGLISH;

            new frmSignUp(userRepository, language).ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_OnFocus(object sender, MouseEventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.Contains("Digite seu") || box.Text.Contains("Insert your"))
                box.Text = string.Empty;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.Trim() != string.Empty) return;
            var accName = box.AccessibleName.Split(':');
            var pt = accName[0];
            var eng = accName[1];

            switch (this.language)
            {
                case Language.PORTUGUESE:
                    box.Text = $"Digite seu {pt}...";
                    break;
                case Language.ENGLISH:
                    box.Text = $"Insert your {eng}...";
                    break;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!FormTools.HasEmptyFields(this) &&
                (!passwordBox.Text.Contains("Digite sua senha") && !passwordBox.Text.Contains("Insert your password")))

                loginButton.Enabled = true;
            else
                loginButton.Enabled = false;
        }

        private void languageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            switch (comboBox.Text)
            {
                case "Português (PT-BR)":
                    language = Language.PORTUGUESE;
                    languageLabel.Text = "Idioma";
                    comboBox.Text = "Português (PT-BR)";
                    usernameLabel.Text = "Usuário";
                    usernameBox.Text = "Digite seu nome de usuário...";
                    closeButton.Text = "Sair";
                    loginButton.Text = "Entrar";
                    passwordLabel.Text = "Senha";
                    passwordBox.Text = "Insert your password...";
                    newUserButton.Text = "Novo usuário";
                    break;
                case "English (US)":
                    language = Language.ENGLISH;
                    languageLabel.Text = "Language";
                    comboBox.Text = "English (US)";
                    usernameBox.Text = "Insert your username...";
                    usernameLabel.Text = "Username";
                    closeButton.Text = "Exit";
                    loginButton.Text = "Enter";
                    passwordLabel.Text = "Password";
                    passwordBox.Text = "Insert your password...";
                    passwordBox.UseSystemPasswordChar = false;
                    newUserButton.Text = "New user";
                    break;
            }
        }

        private void StartTimer()
        {
            var t = new Timer
            {
                Interval = 1000
            };
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
