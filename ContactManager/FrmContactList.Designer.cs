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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdContactList = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContactList
            // 
            this.grdContactList.AllowUserToAddRows = false;
            this.grdContactList.AllowUserToDeleteRows = false;
            this.grdContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContactList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactName,
            this.Id,
            this.Surname,
            this.DateOfBirth,
            this.Sex,
            this.PhoneNumber});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdContactList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdContactList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdContactList.Location = new System.Drawing.Point(43, 114);
            this.grdContactList.Margin = new System.Windows.Forms.Padding(4);
            this.grdContactList.MultiSelect = false;
            this.grdContactList.Name = "grdContactList";
            this.grdContactList.ReadOnly = true;
            this.grdContactList.RowHeadersVisible = false;
            this.grdContactList.RowHeadersWidth = 51;
            this.grdContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContactList.Size = new System.Drawing.Size(856, 412);
            this.grdContactList.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNew.Location = new System.Drawing.Point(43, 49);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(199, 28);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "New Contact";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditContact.Location = new System.Drawing.Point(600, 49);
            this.btnEditContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(145, 28);
            this.btnEditContact.TabIndex = 2;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = false;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteContact.Location = new System.Drawing.Point(753, 49);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(145, 28);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "Name";
            this.ContactName.HeaderText = "Name";
            this.ContactName.MinimumWidth = 6;
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // contactModelBindingSource
            // 
            this.contactModelBindingSource.DataSource = typeof(ContactManager.Models.ContactModel);
            // 
            // contactModelBindingSource1
            // 
            this.contactModelBindingSource1.DataSource = typeof(ContactManager.Models.ContactModel);
            // 
            // FrmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 526);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grdContactList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.FrmContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource contactModelBindingSource;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.BindingSource contactModelBindingSource1;
        private System.Windows.Forms.DataGridView grdContactList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}