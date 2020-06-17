namespace LazyOff.Views
{
    partial class frmUser
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
            this.toPlanesButton = new System.Windows.Forms.Button();
            this.toManagePlaneButton = new System.Windows.Forms.Button();
            this.toManageReportsButton = new System.Windows.Forms.Button();
            this.toManageCompanyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toPlanesButton
            // 
            this.toPlanesButton.Location = new System.Drawing.Point(48, 50);
            this.toPlanesButton.Name = "toPlanesButton";
            this.toPlanesButton.Size = new System.Drawing.Size(236, 186);
            this.toPlanesButton.TabIndex = 1;
            this.toPlanesButton.Text = "Listar aviões";
            this.toPlanesButton.UseVisualStyleBackColor = true;
            // 
            // toManagePlaneButton
            // 
            this.toManagePlaneButton.Location = new System.Drawing.Point(338, 50);
            this.toManagePlaneButton.Name = "toManagePlaneButton";
            this.toManagePlaneButton.Size = new System.Drawing.Size(236, 186);
            this.toManagePlaneButton.TabIndex = 4;
            this.toManagePlaneButton.Text = "Gerenciar avião";
            this.toManagePlaneButton.UseVisualStyleBackColor = true;
            // 
            // toManageReportsButton
            // 
            this.toManageReportsButton.Location = new System.Drawing.Point(338, 293);
            this.toManageReportsButton.Name = "toManageReportsButton";
            this.toManageReportsButton.Size = new System.Drawing.Size(236, 186);
            this.toManageReportsButton.TabIndex = 6;
            this.toManageReportsButton.Text = "Gerenciar relatórios";
            this.toManageReportsButton.UseVisualStyleBackColor = true;
            // 
            // toManageCompanyButton
            // 
            this.toManageCompanyButton.Location = new System.Drawing.Point(48, 293);
            this.toManageCompanyButton.Name = "toManageCompanyButton";
            this.toManageCompanyButton.Size = new System.Drawing.Size(236, 186);
            this.toManageCompanyButton.TabIndex = 5;
            this.toManageCompanyButton.Text = "Gerenciar compahia";
            this.toManageCompanyButton.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.toManageReportsButton);
            this.Controls.Add(this.toManageCompanyButton);
            this.Controls.Add(this.toManagePlaneButton);
            this.Controls.Add(this.toPlanesButton);
            this.Name = "frmUser";
            this.Text = "User Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toPlanesButton;
        private System.Windows.Forms.Button toManagePlaneButton;
        private System.Windows.Forms.Button toManageReportsButton;
        private System.Windows.Forms.Button toManageCompanyButton;
    }
}