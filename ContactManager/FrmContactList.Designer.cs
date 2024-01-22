namespace ContactManager
{
    partial class FrmContactList
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
            this.grdContactList = new System.Windows.Forms.DataGridView();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContactList
            // 
            this.grdContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactName,
            this.Surname,
            this.DateOfBirth,
            this.Sex,
            this.PhoneNumber});
            this.grdContactList.Location = new System.Drawing.Point(32, 85);
            this.grdContactList.Name = "grdContactList";
            this.grdContactList.Size = new System.Drawing.Size(642, 308);
            this.grdContactList.TabIndex = 0;
            // 
            // ContactName
            // 
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // contactModelBindingSource
            // 
            this.contactModelBindingSource.DataSource = typeof(ContactManager.Models.ContactModel);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(32, 40);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(149, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "New Contact";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(450, 40);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(109, 23);
            this.btnEditContact.TabIndex = 2;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(565, 40);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // FrmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 427);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grdContactList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.FrmContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContactList;
        private System.Windows.Forms.BindingSource contactModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnDeleteContact;
    }
}