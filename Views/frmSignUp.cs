using LazyOff.Enums;
using LazyOff.Models;
using LazyOff.Repositories;
using LazyOff.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyOff
{
    public partial class frmSignUp : Form
    {
        private bool useUserDashboard;
        private UserRepository userRepository;
        private Language language;
        public frmSignUp()
        {
            InitializeComponent();
        }

        public frmSignUp(UserRepository userRepository, Language language)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.language = language;
        }

        public frmSignUp(UserRepository userRepository, Language language, bool useUserDashboard) : this(userRepository, language)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.language = language;
            this.useUserDashboard = useUserDashboard;
            this.useUserDashboard = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            nameLabel.Text = language == Language.PORTUGUESE ? "Nome" : "Name";
            addressLabel.Text = language == Language.PORTUGUESE ? "Endereço" : "Address";
            usernameLabel.Text = language == Language.PORTUGUESE ? "Nome de usuário" : "Username";
            birthLabel.Text = language == Language.PORTUGUESE ? "Data de nascimento" : "Birth Date";
            passwordLabel.Text = language == Language.PORTUGUESE ? "Senha" : "Password";
            passwordBox.Text = language == Language.PORTUGUESE ? "Digite sua senha..." : "Input your password...";
            confirmLabel.Text = language == Language.PORTUGUESE ? "Confirmar" : "Confirm";
            confirmPasswordBox.Text = language == Language.PORTUGUESE ? "Confirmar senha..." : "Confirm password...";
            addressBox.Text = language == Language.PORTUGUESE ? "Digite seu endereço..." : "Insert your address...";
            nameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome..." : "Insert your name...";
            surnameBox.Text = language == Language.PORTUGUESE ? "Digite seu sobrenome..." : "Insert your surname...";
            usernameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome de usuário..." : "Insert your username..";
            isAdmin.Text = language == Language.PORTUGUESE ? "É Admin" : "Is Admin";
            clsButton.Text = language == Language.PORTUGUESE ? "Deletar" : "Delete";
            updateButton.Text = language == Language.PORTUGUESE ? "Atualizar" : "Update";
            allFilledWarningLabel.Text = language == Language.PORTUGUESE ? "Todos os campos, exceto os campos de endereço, são obrigatórios" : "All but address fields need to be filled.";
            passwordWarningLabel.Text = language == Language.PORTUGUESE ? "A senha inserida precisa ter uma letra maiúscula, uma minúscula e um número" : "Password needs to have one uppercase, one lowercase letter and a number";
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            userPic.Image = null;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!FormTools.HasEmptyFields(this))
            {
                allFilledWarningLabel.Visible = false;

                if (CanEnableSignUpButton())
                    signUpButton.Enabled = true;

                return;
            }

            allFilledWarningLabel.Visible = true;
        }

        private void textBox_OnFocus(object sender, MouseEventArgs e)
        {
            var box = (TextBox)sender;
            box.BackColor = Color.LightYellow;

            if (box.Text.Contains("Digite seu") || box.Text.Contains("Insert your"))
                box.Text = string.Empty;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            box.BackColor = Color.White;

            if (box.Text.Trim() == string.Empty)
            {
                string[] accName = box.AccessibleName.Split(':');
                string pt = accName[0];
                string eng = accName[1];

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
        }

        private void passwordBox_MouseClick(object sender, MouseEventArgs e)
        {
            var box = sender as TextBox;

            box.BackColor = Color.LightYellow;

            if (box.Text.Contains("Digite")
                || box.Text.Contains("Insert")
                || box.Text.Contains("Confirme")
                || box.Text.Contains("Confirm"))
            {
                box.Text = string.Empty;
                box.UseSystemPasswordChar = true;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            box.BackColor = Color.White;

            if (box.Text.Trim() == string.Empty)
            {
                box.UseSystemPasswordChar = false;
                if (box.Name == "passwordBox")
                {
                    box.Text = language == Language.PORTUGUESE ?
                                                   "Digite sua senha..." :
                                                   "Insert your password...";
                }
                else if (box.Name == "confirmPasswordBox")
                {
                    box.Text = language == Language.PORTUGUESE ?
                                                  "Confirme sua senha..." :
                                                  "Confirm your password...";
                }
            }
        }

        private void confirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (FormTools.HasEmptyFields(this))
            {
                allFilledWarningLabel.Visible = true;
                return;
            }

            if (!PasswordIsValid())
            {
                passwordWarningLabel.Text = language == Language.PORTUGUESE ?
                 "A senha precisa ter pelo menos 8 caracteres, uma letra maiúscula, uma minúscula e um número" :
                 "Password needs to have one uppercase, one lowercase letter and a number";
                passwordWarningLabel.Visible = true;
                return;
            }

            if (passwordBox.Text == confirmPasswordBox.Text)
            {
                // If passwords match, remove password warning label from screen
                passwordWarningLabel.Visible = false;

                // If it's all ok, allow sign up
                if (CanEnableSignUpButton())
                    signUpButton.Enabled = true;

            }
            else
            {
                passwordWarningLabel.Enabled = false;
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                userPic.Load(openFileDialog1.FileName);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            userRepository.Add(new User
            {
                ID = userRepository.GetPrimaryKey(),
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Username = usernameBox.Text,
                Address = addressBox.Text,
                Number = numberBox.Text,
                BirthDate = DateTime.Parse(dateTimePicker1.Text),
                Password = FormTools.To256Hash(passwordBox.Text),
                Type = isAdmin.Checked ? UserType.ADMIN : UserType.USER
            });

            if (useUserDashboard == true)
            {
                new frmUser(language).ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário cadastrado no sistema.");
                this.Dispose();
            }
        }

        private bool CanEnableSignUpButton()
        {
            if (!FormTools.HasEmptyFields(this))
            {
                if (PasswordIsValid() && PasswordsAreMatch())
                {
                    allFilledWarningLabel.Visible = false;
                    passwordWarningLabel.Visible = false;
                    return true;
                }
            }
            return false;
        }

        private bool PasswordsAreMatch()
        {
            if (passwordBox.Text == confirmPasswordBox.Text)
                return true;

            return false;
        }

        private bool PasswordIsValid()
        {
            string pattern = @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])";
            return (Regex.IsMatch(passwordBox.Text, pattern) && passwordBox.Text.Length >= 8);
        }
    }
}
