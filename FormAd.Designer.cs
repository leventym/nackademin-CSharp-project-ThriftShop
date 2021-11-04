
namespace ThriftShop
{
    partial class FormAd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.panelNewAd = new System.Windows.Forms.Panel();
            this.labelTitel = new System.Windows.Forms.Label();
            this.panelEditAd = new System.Windows.Forms.Panel();
            this.labelTitleEdit = new System.Windows.Forms.Label();
            this.buttonDeleteEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitleEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDescriptionEdit = new System.Windows.Forms.Label();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.textBoxDescriptionEdit = new System.Windows.Forms.TextBox();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.textBoxPriceEdit = new System.Windows.Forms.TextBox();
            this.labelCategoryEdit = new System.Windows.Forms.Label();
            this.comboBoxCategoryEdit = new System.Windows.Forms.ComboBox();
            this.labelPriceEdit = new System.Windows.Forms.Label();
            this.panelNewAd.SuspendLayout();
            this.panelEditAd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redigera annons";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(118, 81);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(538, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(118, 179);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(538, 164);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(429, 375);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(227, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(429, 422);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(227, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(115, 151);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(62, 13);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Beskrivning";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(348, 382);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(24, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Pris";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(348, 430);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(46, 13);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Kategori";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(581, 507);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Spara";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(486, 507);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(115, 575);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(35, 13);
            this.labelErrorMessage.TabIndex = 12;
            this.labelErrorMessage.Text = "label2";
            this.labelErrorMessage.Visible = false;
            // 
            // panelNewAd
            // 
            this.panelNewAd.Controls.Add(this.labelTitel);
            this.panelNewAd.Controls.Add(this.label1);
            this.panelNewAd.Controls.Add(this.textBoxTitle);
            this.panelNewAd.Controls.Add(this.labelErrorMessage);
            this.panelNewAd.Controls.Add(this.labelDescription);
            this.panelNewAd.Controls.Add(this.buttonCancel);
            this.panelNewAd.Controls.Add(this.textBoxDescription);
            this.panelNewAd.Controls.Add(this.buttonSave);
            this.panelNewAd.Controls.Add(this.textBoxPrice);
            this.panelNewAd.Controls.Add(this.labelCategory);
            this.panelNewAd.Controls.Add(this.comboBoxCategory);
            this.panelNewAd.Controls.Add(this.labelPrice);
            this.panelNewAd.Location = new System.Drawing.Point(0, 0);
            this.panelNewAd.Name = "panelNewAd";
            this.panelNewAd.Size = new System.Drawing.Size(847, 785);
            this.panelNewAd.TabIndex = 14;
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(118, 46);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(27, 13);
            this.labelTitel.TabIndex = 13;
            this.labelTitel.Text = "Titel";
            // 
            // panelEditAd
            // 
            this.panelEditAd.Controls.Add(this.labelTitleEdit);
            this.panelEditAd.Controls.Add(this.buttonDeleteEdit);
            this.panelEditAd.Controls.Add(this.label2);
            this.panelEditAd.Controls.Add(this.textBoxTitleEdit);
            this.panelEditAd.Controls.Add(this.label3);
            this.panelEditAd.Controls.Add(this.labelDescriptionEdit);
            this.panelEditAd.Controls.Add(this.buttonCancelEdit);
            this.panelEditAd.Controls.Add(this.textBoxDescriptionEdit);
            this.panelEditAd.Controls.Add(this.buttonSaveEdit);
            this.panelEditAd.Controls.Add(this.textBoxPriceEdit);
            this.panelEditAd.Controls.Add(this.labelCategoryEdit);
            this.panelEditAd.Controls.Add(this.comboBoxCategoryEdit);
            this.panelEditAd.Controls.Add(this.labelPriceEdit);
            this.panelEditAd.Location = new System.Drawing.Point(0, 0);
            this.panelEditAd.Name = "panelEditAd";
            this.panelEditAd.Size = new System.Drawing.Size(847, 785);
            this.panelEditAd.TabIndex = 15;
            // 
            // labelTitleEdit
            // 
            this.labelTitleEdit.AutoSize = true;
            this.labelTitleEdit.Location = new System.Drawing.Point(118, 46);
            this.labelTitleEdit.Name = "labelTitleEdit";
            this.labelTitleEdit.Size = new System.Drawing.Size(27, 13);
            this.labelTitleEdit.TabIndex = 14;
            this.labelTitleEdit.Text = "Titel";
            // 
            // buttonDeleteEdit
            // 
            this.buttonDeleteEdit.Location = new System.Drawing.Point(397, 507);
            this.buttonDeleteEdit.Name = "buttonDeleteEdit";
            this.buttonDeleteEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEdit.TabIndex = 13;
            this.buttonDeleteEdit.Text = "Ta bort";
            this.buttonDeleteEdit.UseVisualStyleBackColor = true;
            this.buttonDeleteEdit.Click += new System.EventHandler(this.buttonDeleteEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Redigera annons";
            // 
            // textBoxTitleEdit
            // 
            this.textBoxTitleEdit.Location = new System.Drawing.Point(118, 81);
            this.textBoxTitleEdit.Name = "textBoxTitleEdit";
            this.textBoxTitleEdit.Size = new System.Drawing.Size(538, 20);
            this.textBoxTitleEdit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label2";
            this.label3.Visible = false;
            // 
            // labelDescriptionEdit
            // 
            this.labelDescriptionEdit.AutoSize = true;
            this.labelDescriptionEdit.Location = new System.Drawing.Point(115, 151);
            this.labelDescriptionEdit.Name = "labelDescriptionEdit";
            this.labelDescriptionEdit.Size = new System.Drawing.Size(62, 13);
            this.labelDescriptionEdit.TabIndex = 7;
            this.labelDescriptionEdit.Text = "Beskrivning";
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(486, 507);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelEdit.TabIndex = 11;
            this.buttonCancelEdit.Text = "Avbryt";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
            // 
            // textBoxDescriptionEdit
            // 
            this.textBoxDescriptionEdit.Location = new System.Drawing.Point(118, 179);
            this.textBoxDescriptionEdit.Multiline = true;
            this.textBoxDescriptionEdit.Name = "textBoxDescriptionEdit";
            this.textBoxDescriptionEdit.Size = new System.Drawing.Size(538, 164);
            this.textBoxDescriptionEdit.TabIndex = 2;
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.Location = new System.Drawing.Point(581, 507);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEdit.TabIndex = 10;
            this.buttonSaveEdit.Text = "Spara";
            this.buttonSaveEdit.UseVisualStyleBackColor = true;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // textBoxPriceEdit
            // 
            this.textBoxPriceEdit.Location = new System.Drawing.Point(429, 375);
            this.textBoxPriceEdit.Name = "textBoxPriceEdit";
            this.textBoxPriceEdit.Size = new System.Drawing.Size(227, 20);
            this.textBoxPriceEdit.TabIndex = 3;
            // 
            // labelCategoryEdit
            // 
            this.labelCategoryEdit.AutoSize = true;
            this.labelCategoryEdit.Location = new System.Drawing.Point(348, 430);
            this.labelCategoryEdit.Name = "labelCategoryEdit";
            this.labelCategoryEdit.Size = new System.Drawing.Size(46, 13);
            this.labelCategoryEdit.TabIndex = 9;
            this.labelCategoryEdit.Text = "Kategori";
            // 
            // comboBoxCategoryEdit
            // 
            this.comboBoxCategoryEdit.FormattingEnabled = true;
            this.comboBoxCategoryEdit.Location = new System.Drawing.Point(429, 422);
            this.comboBoxCategoryEdit.Name = "comboBoxCategoryEdit";
            this.comboBoxCategoryEdit.Size = new System.Drawing.Size(227, 21);
            this.comboBoxCategoryEdit.TabIndex = 5;
            // 
            // labelPriceEdit
            // 
            this.labelPriceEdit.AutoSize = true;
            this.labelPriceEdit.Location = new System.Drawing.Point(348, 382);
            this.labelPriceEdit.Name = "labelPriceEdit";
            this.labelPriceEdit.Size = new System.Drawing.Size(24, 13);
            this.labelPriceEdit.TabIndex = 8;
            this.labelPriceEdit.Text = "Pris";
            // 
            // FormAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 809);
            this.Controls.Add(this.panelEditAd);
            this.Controls.Add(this.panelNewAd);
            this.Name = "FormAd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAd";
            this.panelNewAd.ResumeLayout(false);
            this.panelNewAd.PerformLayout();
            this.panelEditAd.ResumeLayout(false);
            this.panelEditAd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Panel panelNewAd;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Panel panelEditAd;
        private System.Windows.Forms.Label labelTitleEdit;
        private System.Windows.Forms.Button buttonDeleteEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitleEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDescriptionEdit;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.TextBox textBoxDescriptionEdit;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.TextBox textBoxPriceEdit;
        private System.Windows.Forms.Label labelCategoryEdit;
        private System.Windows.Forms.ComboBox comboBoxCategoryEdit;
        private System.Windows.Forms.Label labelPriceEdit;
    }
}