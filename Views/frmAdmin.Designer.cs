namespace LazyOff.Views
{
    partial class frmAdmin
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
            this.toManageReportsButton = new System.Windows.Forms.Button();
            this.toManageCompanyButton = new System.Windows.Forms.Button();
            this.toManagePlaneButton = new System.Windows.Forms.Button();
            this.toPlanesButton = new System.Windows.Forms.Button();
            this.toUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toManageReportsButton
            // 
            this.toManageReportsButton.Location = new System.Drawing.Point(310, 252);
            this.toManageReportsButton.Name = "toManageReportsButton";
            this.toManageReportsButton.Size = new System.Drawing.Size(236, 186);
            this.toManageReportsButton.TabIndex = 10;
            this.toManageReportsButton.Text = "Gerenciar relatórios";
            this.toManageReportsButton.UseVisualStyleBackColor = true;
            // 
            // toManageCompanyButton
            // 
            this.toManageCompanyButton.Location = new System.Drawing.Point(38, 252);
            this.toManageCompanyButton.Name = "toManageCompanyButton";
            this.toManageCompanyButton.Size = new System.Drawing.Size(236, 186);
            this.toManageCompanyButton.TabIndex = 9;
            this.toManageCompanyButton.Text = "Gerenciar compahia";
            this.toManageCompanyButton.UseVisualStyleBackColor = true;
            // 
            // toManagePlaneButton
            // 
            this.toManagePlaneButton.Location = new System.Drawing.Point(600, 12);
            this.toManagePlaneButton.Name = "toManagePlaneButton";
            this.toManagePlaneButton.Size = new System.Drawing.Size(236, 186);
            this.toManagePlaneButton.TabIndex = 8;
            this.toManagePlaneButton.Text = "Gerenciar avião";
            this.toManagePlaneButton.UseVisualStyleBackColor = true;
            // 
            // toPlanesButton
            // 
            this.toPlanesButton.Location = new System.Drawing.Point(310, 12);
            this.toPlanesButton.Name = "toPlanesButton";
            this.toPlanesButton.Size = new System.Drawing.Size(236, 186);
            this.toPlanesButton.TabIndex = 7;
            this.toPlanesButton.Text = "Listar aviões";
            this.toPlanesButton.UseVisualStyleBackColor = true;
            // 
            // toUsersButton
            // 
            this.toUsersButton.Location = new System.Drawing.Point(38, 12);
            this.toUsersButton.Name = "toUsersButton";
            this.toUsersButton.Size = new System.Drawing.Size(236, 186);
            this.toUsersButton.TabIndex = 11;
            this.toUsersButton.Text = "Listar usuários";
            this.toUsersButton.UseVisualStyleBackColor = true;
            this.toUsersButton.Click += new System.EventHandler(this.toUsersButton_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.toUsersButton);
            this.Controls.Add(this.toManageReportsButton);
            this.Controls.Add(this.toManageCompanyButton);
            this.Controls.Add(this.toManagePlaneButton);
            this.Controls.Add(this.toPlanesButton);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toManageReportsButton;
        private System.Windows.Forms.Button toManageCompanyButton;
        private System.Windows.Forms.Button toManagePlaneButton;
        private System.Windows.Forms.Button toPlanesButton;
        private System.Windows.Forms.Button toUsersButton;
    }
}