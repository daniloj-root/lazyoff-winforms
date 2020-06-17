using LazyOff.Enums;
using LazyOff.Models;
using LazyOff.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyOff.Views
{
    public partial class frmListUsers : Form
    {
        private UserRepository userRepository { get; set; }
        private Language language { get; set; }
        public frmListUsers(UserRepository userRepository, Language language)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.language = language;
            dgvUsers.DataSource = userRepository.Get();

            idBox.Text = language == Language.PORTUGUESE ? "Digite seu ID..." : "Insert your ID...";
            nameLabel.Text = language == Language.PORTUGUESE ? "Nome" : "Name";
            nameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome..." : "Insert your name...";
            addressLabel.Text = language == Language.PORTUGUESE ? "Endereço" : "Address";
            addressBox.Text = language == Language.PORTUGUESE ? "Digite seu endereço..." : "Input your address...";
            numberLabel.Text = language == Language.PORTUGUESE ? "Número" : "Number";
            numberBox.Text = language == Language.PORTUGUESE ? "Digite seu número..." : "Insert your number...";
            usernameLabel.Text = language == Language.PORTUGUESE ? "Nome de usuário" : "Username";
            usernameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome de usuário..." : "Insert your username...";
            birthLabel.Text = language == Language.PORTUGUESE ? "Data de nascimento" : "Birth Date";
            birthBox.Text = language == Language.PORTUGUESE ? "Digite sua data de nascimento..." : "Insert your birth date...";
            passwordLabel.Text = language == Language.PORTUGUESE ? "Senha" : "Password";
            passwordBox.Text = language == Language.PORTUGUESE ? "Digite sua senha..." : "Insert your password...";
            confirmLabel.Text = language == Language.PORTUGUESE ? "Confirmar" : "Confirm";
            confirmBox.Text = language == Language.PORTUGUESE ? "Confirme sua senha..." : "Confirm your password...";
            surnameLabel.Text = language == Language.PORTUGUESE ? "Sobrenome" : "Surname";
            surnameBox.Text = language == Language.PORTUGUESE ? "Digite seu sobrenome..." : "Insert your surname...";
            clsButton.Text = language == Language.PORTUGUESE ? "Deletar" : "Delete";
            updateButton.Text = language == Language.PORTUGUESE ? "Atualizar" : "Update";
        }

        private void passwordBox_MouseClick(object sender, MouseEventArgs e)
        {
            var box = sender as TextBox;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            new frmAdmin(userRepository, language);
            this.Dispose();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new frmSignUp(userRepository, language, false).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == null)
            {
                MessageBox.Show(language == Language.PORTUGUESE ?
                       "Você precisa fornecer um ID para deletar um usuário." :
                       "You need to provide an ID to delete an user.",
                       language == Language.PORTUGUESE ?
                        "Erro" :
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                return;
            }


            if (userRepository.GetById(int.Parse(idBox.Text)) == null)
            {
                MessageBox.Show(language == Language.PORTUGUESE ?
                        "Seu usuário não existe." :
                        "Your user doesn't exist.",
                        language == Language.PORTUGUESE ?
                        "Erro" :
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            var user = GetUser();

            userRepository.Update(user);

            Reload();

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == null)
            {

                MessageBox.Show(language == Language.PORTUGUESE ?
                       "Você precisa fornecer um ID para deletar um usuário." :
                       "You need to provide an ID to delete an user.",
                       language == Language.PORTUGUESE ?
                       "Erro" :
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);

                return;
            }

            var user = userRepository.GetById(GetUser().ID);

            if ((user = userRepository.GetById(int.Parse(idBox.Text))) == null)
            {
                MessageBox.Show(language == Language.PORTUGUESE ?
                       "Você precisa fornecer um ID para deletar um usuário." :
                       "You need to provide an ID to delete an user.",
                       language == Language.PORTUGUESE ?
                       "Erro" :
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);

                userRepository.Add(user);
            }

            userRepository.Delete(user);

            Reload();
        }

        private User GetUser()
        {
            return new User
            {
                ID = int.Parse(idBox.Text),
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Username = usernameBox.Text,
                Password = usernameBox.Text,
                BirthDate = DateTime.Parse(birthBox.Text),
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ofdPic.ShowDialog() == DialogResult.OK)
                userPic.Load(ofdPic.FileName);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Rows[e.RowIndex] != null)
            {
                DataGridViewRow line = dgvUsers.Rows[e.RowIndex];

                int ID = Convert.ToInt32(line.Cells[0].Value.ToString());

                var user = userRepository.GetById(ID);

                LoadInfo(user);
            }
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            userPic.Image = null;
        }

        private void LoadInfo(User user)
        {
            idBox.Text = user.ID.ToString();
            nameBox.Text = user.Name;
            surnameBox.Text = user.Surname;
            addressBox.Text = user.Address;
            numberBox.Text = user.Number;
            birthBox.Text = user.BirthDate.ToString();
            usernameBox.Text = user.Username;
            passwordBox.Text = user.Password;
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

        private void Reload()
        {
            var source = new BindingSource();
            source.DataSource = userRepository.Get();
            dgvUsers.DataSource = source;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            var filteredUsers = userRepository.Get().Where(x => x.Name.ToUpper().Contains(searchBox.Text.ToUpper()));
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = filteredUsers;
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = userRepository.Get();
            dgvUsers.DataSource = source;

            nameLabel.Text = language == Language.PORTUGUESE ? "Nome" : "Name";
            nameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome" : "Insert your name";
            addressLabel.Text = language == Language.PORTUGUESE ? "Endereço" : "Address";
            addressBox.Text = language == Language.PORTUGUESE ? "Digite seu endereço" : "Input your address";
            numberLabel.Text = language == Language.PORTUGUESE ? "Número" : "Number";
            numberBox.Text = language == Language.PORTUGUESE ? "Digite seu número" : "Insert your number";
            usernameLabel.Text = language == Language.PORTUGUESE ? "Nome de usuário" : "Username";
            usernameBox.Text = language == Language.PORTUGUESE ? "Digite seu nome de usuário" : "Insert your username";
            birthLabel.Text = language == Language.PORTUGUESE ? "Data de nascimento" : "Birth Date";
            birthBox.Text = language == Language.PORTUGUESE ? "Digite sua data de nascimento" : "Insert your birth date";
            passwordLabel.Text = language == Language.PORTUGUESE ? "Senha" : "Password";
            passwordBox.Text = language == Language.PORTUGUESE ? "Digite sua senha" : "Insert your password";
            confirmLabel.Text = language == Language.PORTUGUESE ? "Confirmar" : "Confirm";
            confirmBox.Text = language == Language.PORTUGUESE ? "Confirme sua senha" : "Confirm your password";
            surnameLabel.Text = language == Language.PORTUGUESE ? "Sobrenome" : "Surname";
            surnameBox.Text = language == Language.PORTUGUESE ? "Digite seu sobrenome" : "Insert your surname";
            clsButton.Text = language == Language.PORTUGUESE ? "Deletar" : "Delete";
            updateButton.Text = language == Language.PORTUGUESE ? "Atualizar" : "Update";
        }
    }
}