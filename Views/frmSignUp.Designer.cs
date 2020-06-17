namespace LazyOff
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.signUpButton = new System.Windows.Forms.Button();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.clsButton = new System.Windows.Forms.Button();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.allFilledWarningLabel = new System.Windows.Forms.Label();
            this.passwordWarningLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select an image file";
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "usuário:user";
            this.nameBox.Location = new System.Drawing.Point(169, 57);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "Digite seu nome...";
            this.nameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.nameBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.nameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "senha:password";
            this.passwordBox.Location = new System.Drawing.Point(169, 216);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(199, 22);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "Digite sua senha...";
            this.passwordBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordBox_MouseClick);
            this.passwordBox.TextChanged += new System.EventHandler(this.confirmPasswordBox_TextChanged);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.AccessibleName = "confirmar senha:confirm password";
            this.confirmPasswordBox.Location = new System.Drawing.Point(169, 248);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(199, 22);
            this.confirmPasswordBox.TabIndex = 3;
            this.confirmPasswordBox.Text = "Confirme sua senha...";
            this.confirmPasswordBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordBox_MouseClick);
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.confirmPasswordBox_TextChanged);
            this.confirmPasswordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.AccessibleName = "sobrenome:surname";
            this.surnameBox.Location = new System.Drawing.Point(384, 57);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(192, 22);
            this.surnameBox.TabIndex = 4;
            this.surnameBox.Text = "Digite seu sobrenome...";
            this.surnameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.surnameBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.surnameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nome";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(27, 176);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(136, 17);
            this.birthLabel.TabIndex = 6;
            this.birthLabel.Text = "Data de Nascimento";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(27, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Senha";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(27, 251);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(69, 17);
            this.confirmLabel.TabIndex = 8;
            this.confirmLabel.Text = "Confirmar";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(27, 99);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(69, 17);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Endereço";
            // 
            // addressBox
            // 
            this.addressBox.AccessibleName = "endereço:address";
            this.addressBox.Location = new System.Drawing.Point(169, 96);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(347, 22);
            this.addressBox.TabIndex = 10;
            this.addressBox.Text = "Digite seu endereço...";
            this.addressBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.addressBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.addressBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // numberBox
            // 
            this.numberBox.AccessibleName = "número:number";
            this.numberBox.Location = new System.Drawing.Point(535, 99);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(41, 22);
            this.numberBox.TabIndex = 11;
            this.numberBox.Text = "Nº";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // signUpButton
            // 
            this.signUpButton.Enabled = false;
            this.signUpButton.Location = new System.Drawing.Point(30, 324);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(501, 30);
            this.signUpButton.TabIndex = 13;
            this.signUpButton.Text = "Cadastrar";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // userPic
            // 
            this.userPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.Location = new System.Drawing.Point(619, 27);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(214, 187);
            this.userPic.TabIndex = 14;
            this.userPic.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.AccessibleName = "Atualizar:Update";
            this.updateButton.Location = new System.Drawing.Point(619, 253);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 30);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // clsButton
            // 
            this.clsButton.AccessibleName = "Deletar:Delete";
            this.clsButton.Location = new System.Drawing.Point(747, 253);
            this.clsButton.Name = "clsButton";
            this.clsButton.Size = new System.Drawing.Size(86, 30);
            this.clsButton.TabIndex = 16;
            this.clsButton.Text = "Deletar";
            this.clsButton.UseVisualStyleBackColor = true;
            this.clsButton.Click += new System.EventHandler(this.clsButton_Click);
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(683, 315);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(82, 21);
            this.isAdmin.TabIndex = 17;
            this.isAdmin.Text = "É Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // allFilledWarningLabel
            // 
            this.allFilledWarningLabel.AutoSize = true;
            this.allFilledWarningLabel.Location = new System.Drawing.Point(52, 18);
            this.allFilledWarningLabel.Name = "allFilledWarningLabel";
            this.allFilledWarningLabel.Size = new System.Drawing.Size(462, 17);
            this.allFilledWarningLabel.TabIndex = 18;
            this.allFilledWarningLabel.Text = "Todos os endereços, exceto os de endereço, devem estar preenchidos.";
            this.allFilledWarningLabel.Visible = false;
            // 
            // passwordWarningLabel
            // 
            this.passwordWarningLabel.AutoSize = true;
            this.passwordWarningLabel.Location = new System.Drawing.Point(27, 282);
            this.passwordWarningLabel.Name = "passwordWarningLabel";
            this.passwordWarningLabel.Size = new System.Drawing.Size(569, 17);
            this.passwordWarningLabel.TabIndex = 19;
            this.passwordWarningLabel.Text = "As senhas devem ter pelo menos uma letra maiúscula, uma letra minúscula e um núme" +
    "ro";
            this.passwordWarningLabel.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(27, 136);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 17);
            this.usernameLabel.TabIndex = 20;
            this.usernameLabel.Text = "Nome de usuário";
            // 
            // usernameBox
            // 
            this.usernameBox.AccessibleName = "nome de usuário: username";
            this.usernameBox.Location = new System.Drawing.Point(169, 133);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(407, 22);
            this.usernameBox.TabIndex = 21;
            this.usernameBox.Text = "Digite seu nome de usuário...";
            this.usernameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OnFocus);
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.usernameBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // frmSignUp
            // 
            this.ClientSize = new System.Drawing.Size(879, 375);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordWarningLabel);
            this.Controls.Add(this.allFilledWarningLabel);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.clsButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Name = "frmSignUp";
            this.Text = "Sign Up - LazyOff";
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clsButton;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.Label allFilledWarningLabel;
        private System.Windows.Forms.Label passwordWarningLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
    }
}

