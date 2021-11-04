
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
            this.components = new System.ComponentModel.Container();
            this.panelStart = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonEditAd = new System.Windows.Forms.Button();
            this.buttonAddAd = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSearchTitle = new System.Windows.Forms.Label();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.annonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leventsDBDataSet = new ThriftShop.LeventsDBDataSet();
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
            this.buttonBackCreateNewAccount = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelNewAccountEmail = new System.Windows.Forms.Label();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.labelNewAccountPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewAccountUsername = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.annonsTableAdapter = new ThriftShop.LeventsDBDataSetTableAdapters.AnnonsTableAdapter();
            this.labelSearchCategory = new System.Windows.Forms.Label();
            this.textBoxSearchCategory = new System.Windows.Forms.TextBox();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leventsDBDataSet)).BeginInit();
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
            this.panelStart.Controls.Add(this.labelSearchCategory);
            this.panelStart.Controls.Add(this.textBoxSearchCategory);
            this.panelStart.Controls.Add(this.dataGridView1);
            this.panelStart.Controls.Add(this.buttonLogout);
            this.panelStart.Controls.Add(this.buttonEditAd);
            this.panelStart.Controls.Add(this.buttonAddAd);
            this.panelStart.Controls.Add(this.buttonLogin);
            this.panelStart.Controls.Add(this.labelSearchTitle);
            this.panelStart.Controls.Add(this.textBoxSearchTitle);
            this.panelStart.Controls.Add(this.labelTitle);
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(845, 802);
            this.panelStart.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 654);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(697, 60);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logga ut";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonEditAd
            // 
            this.buttonEditAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditAd.Location = new System.Drawing.Point(556, 765);
            this.buttonEditAd.Name = "buttonEditAd";
            this.buttonEditAd.Size = new System.Drawing.Size(105, 23);
            this.buttonEditAd.TabIndex = 6;
            this.buttonEditAd.Text = "Ändra annons";
            this.buttonEditAd.UseVisualStyleBackColor = true;
            this.buttonEditAd.Visible = false;
            this.buttonEditAd.Click += new System.EventHandler(this.buttonEditAd_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAd.Location = new System.Drawing.Point(667, 765);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(105, 23);
            this.buttonAddAd.TabIndex = 5;
            this.buttonAddAd.Text = "Lägg till ny annons";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Visible = false;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(697, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Logga in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelSearchTitle
            // 
            this.labelSearchTitle.AutoSize = true;
            this.labelSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTitle.Location = new System.Drawing.Point(45, 58);
            this.labelSearchTitle.Name = "labelSearchTitle";
            this.labelSearchTitle.Size = new System.Drawing.Size(70, 20);
            this.labelSearchTitle.TabIndex = 2;
            this.labelSearchTitle.Text = "Sök titel:";
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchTitle.Location = new System.Drawing.Point(121, 60);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(211, 20);
            this.textBoxSearchTitle.TabIndex = 1;
            this.textBoxSearchTitle.TextChanged += new System.EventHandler(this.textBoxSearchTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Location = new System.Drawing.Point(265, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(290, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thrift Shop";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // annonsBindingSource
            // 
            this.annonsBindingSource.DataMember = "Annons";
            this.annonsBindingSource.DataSource = this.leventsDBDataSet;
            // 
            // leventsDBDataSet
            // 
            this.leventsDBDataSet.DataSetName = "LeventsDBDataSet";
            this.leventsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(845, 802);
            this.panelLogin.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(469, 211);
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
            this.buttonLoginLogin.Location = new System.Drawing.Point(469, 168);
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
            this.textBoxPassword.Size = new System.Drawing.Size(273, 20);
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
            this.textBoxUserName.Size = new System.Drawing.Size(273, 20);
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
            this.label2.Size = new System.Drawing.Size(290, 45);
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
            this.panelCreateNewAccount.Controls.Add(this.buttonBackCreateNewAccount);
            this.panelCreateNewAccount.Controls.Add(this.buttonCreateAccount);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountEmail);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewEmail);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountPassword);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewPassword);
            this.panelCreateNewAccount.Controls.Add(this.labelNewAccountUsername);
            this.panelCreateNewAccount.Controls.Add(this.textBoxNewUsername);
            this.panelCreateNewAccount.Controls.Add(this.labelCreateNewAccount);
            this.panelCreateNewAccount.Location = new System.Drawing.Point(0, 0);
            this.panelCreateNewAccount.Name = "panelCreateNewAccount";
            this.panelCreateNewAccount.Size = new System.Drawing.Size(845, 802);
            this.panelCreateNewAccount.TabIndex = 9;
            // 
            // buttonBackCreateNewAccount
            // 
            this.buttonBackCreateNewAccount.Location = new System.Drawing.Point(349, 209);
            this.buttonBackCreateNewAccount.Name = "buttonBackCreateNewAccount";
            this.buttonBackCreateNewAccount.Size = new System.Drawing.Size(100, 23);
            this.buttonBackCreateNewAccount.TabIndex = 9;
            this.buttonBackCreateNewAccount.Text = "Tillbaka";
            this.buttonBackCreateNewAccount.UseVisualStyleBackColor = true;
            this.buttonBackCreateNewAccount.Click += new System.EventHandler(this.buttonBackCreateNewAccount_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(467, 209);
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
            this.textBoxNewEmail.Size = new System.Drawing.Size(273, 20);
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
            this.textBoxNewPassword.Size = new System.Drawing.Size(273, 20);
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
            this.textBoxNewUsername.Size = new System.Drawing.Size(273, 20);
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
            this.labelCreateNewAccount.Size = new System.Drawing.Size(290, 45);
            this.labelCreateNewAccount.TabIndex = 0;
            this.labelCreateNewAccount.Text = "Skapa nytt konto";
            this.labelCreateNewAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // annonsTableAdapter
            // 
            this.annonsTableAdapter.ClearBeforeFill = true;
            // 
            // labelSearchCategory
            // 
            this.labelSearchCategory.AutoSize = true;
            this.labelSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchCategory.Location = new System.Drawing.Point(345, 58);
            this.labelSearchCategory.Name = "labelSearchCategory";
            this.labelSearchCategory.Size = new System.Drawing.Size(98, 20);
            this.labelSearchCategory.TabIndex = 10;
            this.labelSearchCategory.Text = "Sök kategori";
            // 
            // textBoxSearchCategory
            // 
            this.textBoxSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchCategory.Location = new System.Drawing.Point(450, 60);
            this.textBoxSearchCategory.Name = "textBoxSearchCategory";
            this.textBoxSearchCategory.Size = new System.Drawing.Size(211, 20);
            this.textBoxSearchCategory.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 826);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelCreateNewAccount);
            this.Controls.Add(this.panelLogin);
            this.Location = new System.Drawing.Point(12, 12);
            this.MinimumSize = new System.Drawing.Size(885, 865);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leventsDBDataSet)).EndInit();
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
        private System.Windows.Forms.Label labelSearchTitle;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
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
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBackCreateNewAccount;
        private LeventsDBDataSet leventsDBDataSet;
        private System.Windows.Forms.BindingSource annonsBindingSource;
        private LeventsDBDataSetTableAdapters.AnnonsTableAdapter annonsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSearchCategory;
        private System.Windows.Forms.TextBox textBoxSearchCategory;
    }
}

