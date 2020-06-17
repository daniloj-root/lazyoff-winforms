using LazyOff.Enums;
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
    public partial class frmAdmin : Form
    {
        private UserRepository userRepository { get; set; }
        private Language language { get; set; }
        public frmAdmin(UserRepository userRepository, Language language)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.language = language;
            toPlanesButton.Text = language == Language.PORTUGUESE ? "Listar aviões" : "List planes";
            toManagePlaneButton.Text = language == Language.PORTUGUESE ? "Gerenciar aviões" : "Manage planes";
            toManageReportsButton.Text = language == Language.PORTUGUESE ? "Gerenciar relatórios" : "Manage reports";
            toUsersButton.Text = language == Language.PORTUGUESE ? "Listar usuários" : "List users";
            toManageCompanyButton.Text = language == Language.PORTUGUESE ? "Gerenciar compahia" : "Manage compania";
        }

        private void toUsersButton_Click(object sender, EventArgs e)
        {
            new frmListUsers(userRepository, language).ShowDialog();
        }
    }
}
