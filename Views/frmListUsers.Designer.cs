namespace LazyOff.Views
{
    partial class frmListUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListUsers));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.birthBox = new System.Windows.Forms.TextBox();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.clsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.userRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(1, 39);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(401, 441);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LazyOff.Models.User);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(408, 238);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nome";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(408, 274);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(81, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Sobrenome";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(408, 314);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(69, 17);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Endereço";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(408, 358);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(82, 17);
            this.birthLabel.TabIndex = 4;
            this.birthLabel.Text = "Nascimento";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(408, 396);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 17);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Número";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(408, 432);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Usuário";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(408, 472);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Senha";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(408, 511);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(114, 17);
            this.confirmLabel.TabIndex = 8;
            this.confirmLabel.Text = "Confirmar Senha";
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "nome:name";
            this.nameBox.Location = new System.Drawing.Point(528, 235);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(225, 22);
            this.nameBox.TabIndex = 9;
            this.nameBox.Text = "Digite seu nome...";
            this.nameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.nameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.AccessibleName = "sobrenome:surname";
            this.surnameBox.Location = new System.Drawing.Point(528, 271);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(225, 22);
            this.surnameBox.TabIndex = 10;
            this.surnameBox.Text = "Digite seu sobrenome...";
            this.surnameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.surnameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.AccessibleName = "endereço:address";
            this.addressBox.Location = new System.Drawing.Point(528, 311);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(225, 22);
            this.addressBox.TabIndex = 11;
            this.addressBox.Text = "Digite seu endereço...";
            this.addressBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.addressBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // birthBox
            // 
            this.birthBox.AccessibleName = "data de nascimento:birth date";
            this.birthBox.Location = new System.Drawing.Point(528, 355);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(225, 22);
            this.birthBox.TabIndex = 12;
            this.birthBox.Text = "Digite sua data de nascimento...";
            this.birthBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.birthBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // confirmBox
            // 
            this.confirmBox.AccessibleName = "senha:password";
            this.confirmBox.Location = new System.Drawing.Point(528, 508);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(225, 22);
            this.confirmBox.TabIndex = 16;
            this.confirmBox.Text = "Confirme sua senha...";
            this.confirmBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordBox_MouseClick);
            this.confirmBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "senha:password";
            this.passwordBox.Location = new System.Drawing.Point(528, 469);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(225, 22);
            this.passwordBox.TabIndex = 15;
            this.passwordBox.Text = "Digite sua senha...";
            this.passwordBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordBox_MouseClick);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // usernameBox
            // 
            this.usernameBox.AccessibleName = "nome de usuário:username";
            this.usernameBox.Location = new System.Drawing.Point(528, 429);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(225, 22);
            this.usernameBox.TabIndex = 14;
            this.usernameBox.Text = "Digite seu usuário...";
            this.usernameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.usernameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // numberBox
            // 
            this.numberBox.AccessibleName = "número:number";
            this.numberBox.Location = new System.Drawing.Point(528, 393);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(225, 22);
            this.numberBox.TabIndex = 13;
            this.numberBox.Text = "Digite seu número...";
            this.numberBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.numberBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(67, 496);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(239, 22);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nome:";
            // 
            // userPic
            // 
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.Location = new System.Drawing.Point(545, 12);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(151, 125);
            this.userPic.TabIndex = 19;
            this.userPic.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(528, 152);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 29);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clsButton
            // 
            this.clsButton.Location = new System.Drawing.Point(627, 152);
            this.clsButton.Name = "clsButton";
            this.clsButton.Size = new System.Drawing.Size(80, 29);
            this.clsButton.TabIndex = 21;
            this.clsButton.Text = "Deletar";
            this.clsButton.UseVisualStyleBackColor = true;
            this.clsButton.Click += new System.EventHandler(this.clsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(391, 543);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(498, 543);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Novo";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(588, 543);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(74, 30);
            this.editButton.TabIndex = 25;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(679, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 30);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Deletar";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // idBox
            // 
            this.idBox.AccessibleName = "id:id";
            this.idBox.Location = new System.Drawing.Point(528, 198);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(123, 22);
            this.idBox.TabIndex = 28;
            this.idBox.Text = "Digite seu ID...";
            this.idBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.idBox.MouseLeave += new System.EventHandler(this.textBox_Leave);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(408, 201);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "ID";
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "openFileDialog1";
            // 
            // userRepositoryBindingSource
            // 
            this.userRepositoryBindingSource.DataSource = typeof(LazyOff.Repositories.UserRepository);
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 600);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clsButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.birthBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmListUsers";
            this.Text = "List Users - Lazyoff";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userRepositoryBindingSource;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox birthBox;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}