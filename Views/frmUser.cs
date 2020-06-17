using LazyOff.Enums;
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
    public partial class frmUser : Form
    {
        private Language language { get; set; }
        public frmUser(Language language)
        {
            InitializeComponent();

            this.language = language;
            toPlanesButton.Text = language == Language.PORTUGUESE ? "Listar aviões" : "List planes";
            toManagePlaneButton.Text = language == Language.PORTUGUESE ? "Gerenciar aviões" : "Manage planes";
            toManageReportsButton.Text = language == Language.PORTUGUESE ? "Gerenciar relatórios" : "Manage reports";
            toManageCompanyButton.Text = language == Language.PORTUGUESE ? "Gerenciar compahia" : "Manage compania";
        }
    }
}
