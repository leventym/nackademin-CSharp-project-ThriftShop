
namespace ThriftShop
{
    partial class FormMain
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
            this.panelStart = new System.Windows.Forms.Panel();
            this.buttonEditAd = new System.Windows.Forms.Button();
            this.buttonAddAd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNewAccount = new System.Windows.Forms.Button();
            this.buttonLoginLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCreateNewAccount = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelNewAccountEmail = new System.Windows.Forms.Label();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.labelNewAccountPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewAccountUsername = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelCreateNewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStart
            // 
            this.panelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelStart.Controls.Add(this.buttonEditAd);
            this.panelStart.Controls.Add(this.buttonAddAd);
            this.panelStart.Controls.Add(this.dataGridView1);
            this.panelStart.Controls.Add(this.buttonLogin);
            this.panelStart.Controls.Add(this.labelSearch);
            this.panelStart.Controls.Add(this.textBoxSearch);
            this.panelStart.Controls.Add(this.labelTitle);
            this.panelStart.Location = new System.Drawing.Point(12, 12);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(868, 802);
            this.panelStart.TabIndex = 0;
            // 
            // buttonEditAd
            // 
            this.buttonEditAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditAd.Location = new System.Drawing.Point(579, 765);
            this.buttonEditAd.Name = "buttonEditAd";
            this.buttonEditAd.Size = new System.Drawing.Size(105, 23);
            this.buttonEditAd.TabIndex = 6;
            this.buttonEditAd.Text = "Ändra annons";
            this.buttonEditAd.UseVisualStyleBackColor = true;
            this.buttonEditAd.Visible = false;
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAd.Location = new System.Drawing.Point(690, 765);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(105, 23);
            this.buttonAddAd.TabIndex = 5;
            this.buttonAddAd.Text = "Lägg till ny annons";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Visible = false;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 660);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(720, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Logga in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(75, 58);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 20);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Sök:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(121, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(593, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Location = new System.Drawing.Point(265, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(313, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thrift Shop";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogin.Controls.Add(this.buttonBack);
            this.panelLogin.Controls.Add(this.buttonNewAccount);
            this.panelLogin.Controls.Add(this.buttonLoginLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.textBoxUserName);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(868, 802);
            this.panelLogin.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(492, 211);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Tillbaka";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNewAccount
            // 
            this.buttonNewAccount.Location = new System.Drawing.Point(271, 168);
            this.buttonNewAccount.Name = "buttonNewAccount";
            this.buttonNewAccount.Size = new System.Drawing.Size(100, 23);
            this.buttonNewAccount.TabIndex = 7;
            this.buttonNewAccount.Text = "Skapa nytt konto";
            this.buttonNewAccount.UseVisualStyleBackColor = true;
            this.buttonNewAccount.Click += new System.EventHandler(this.buttonNewAccount_Click_1);
            // 
            // buttonLoginLogin
            // 
            this.buttonLoginLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoginLogin.Location = new System.Drawing.Point(492, 168);
            this.buttonLoginLogin.Name = "buttonLoginLogin";
            this.buttonLoginLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginLogin.TabIndex = 6;
            this.buttonLoginLogin.Text = "Logga in";
            this.buttonLoginLogin.UseVisualStyleBackColor = true;
            this.buttonLoginLogin.Click += new System.EventHandler(this.buttonLoginLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(185, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Lösenord:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(271, 120);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(296, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(144, 81);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(121, 20);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Användarnamn:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserName.Location = new System.Drawing.Point(271, 81);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(296, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logga in";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCreateNewAccount
            // 
            this.panelCreateNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCreateNewAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCreateNewAccount.Controls.Add(this.buttonCreateAccount);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountEmail);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewEmail);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountPassword);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewPassword);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountUsername);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewUsername);
            this.panelCreateNewAccount.Controls.Add(this.labelCreateNewAccount);
            this.panelCreateNewAccount.Location = new System.Drawing.Point(12, 12);
            this.panelCreateNewAccount.Name = "panelCreateNewAccount";
            this.panelCreateNewAccount.Size = new System.Drawing.Size(868, 802);
            this.panelCreateNewAccount.TabIndex = 9;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(444, 206);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateAccount.TabIndex = 8;
            this.buttonCreateAccount.Text = "Skapa konto";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelNewAccountEmail
            // 
            this.labelNewAccountEmail.AutoSize = true;
            this.labelNewAccountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAccountEmail.Location = new System.Drawing.Point(208, 158);
            this.labelNewAccountEmail.Name = "labelNewAccountEmail";
            this.labelNewAccountEmail.Size = new System.Drawing.Size(57, 20);
            this.labelNewAccountEmail.TabIndex = 7;
            this.labelNewAccountEmail.Text = "E-mail:";
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewEmail.Location = new System.Drawing.Point(271, 158);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.Size = new System.Drawing.Size(296, 20);
            this.textBoxNewEmail.TabIndex = 6;
            // 
            // labelNewAccountPassword
            // 
            this.labelNewAccountPassword.AutoSize = true;
            this.labelNewAccountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAccountPassword.Location = new System.Drawing.Point(185, 120);
            this.labelNewAccountPassword.Name = "labelNewAccountPassword";
            this.labelNewAccountPassword.Size = new System.Drawing.Size(80, 20);
            this.labelNewAccountPassword.TabIndex = 5;
            this.labelNewAccountPassword.Text = "Lösenord:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(271, 120);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(296, 20);
            this.textBoxNewPassword.TabIndex = 4;
            // 
            // labelNewAccountUsername
            // 
            this.labelNewAccountUsername.AutoSize = true;
            this.labelNewAccountUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAccountUsername.Location = new System.Drawing.Point(144, 81);
            this.labelNewAccountUsername.Name = "labelNewAccountUsername";
            this.labelNewAccountUsername.Size = new System.Drawing.Size(121, 20);
            this.labelNewAccountUsername.TabIndex = 3;
            this.labelNewAccountUsername.Text = "Användarnamn:";
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewUsername.Location = new System.Drawing.Point(271, 81);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(296, 20);
            this.textBoxNewUsername.TabIndex = 2;
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(265, 12);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(313, 45);
            this.labelCreateNewAccount.TabIndex = 0;
            this.labelCreateNewAccount.Text = "Skapa nytt konto";
            this.labelCreateNewAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 826);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelCreateNewAccount);
            this.Controls.Add(this.panelLogin);
            this.Location = new System.Drawing.Point(12, 12);
            this.MinimumSize = new System.Drawing.Size(885, 865);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCreateNewAccount.ResumeLayout(false);
            this.panelCreateNewAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNewAccount;
        private System.Windows.Forms.Button buttonLoginLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Panel panelCreateNewAccount;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelNewAccountEmail;
        private System.Windows.Forms.TextBox textBoxNewEmail;
        private System.Windows.Forms.Label labelNewAccountPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewAccountUsername;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.Label labelCreateNewAccount;
        private System.Windows.Forms.Button buttonEditAd;
        private System.Windows.Forms.Button buttonAddAd;
    }
}

