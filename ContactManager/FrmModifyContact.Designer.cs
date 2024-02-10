namespace ContactManager.Models
{
    partial class FrmModifyContact
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPhoneNumber = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cbM = new System.Windows.Forms.CheckBox();
            this.cbW = new System.Windows.Forms.CheckBox();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.lblReqName = new System.Windows.Forms.Label();
            this.lblReqPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(48, 241);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(149, 25);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(48, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(48, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(48, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Surname:";
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPhoneNumber.Location = new System.Drawing.Point(53, 305);
            this.btnPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(144, 69);
            this.btnPhoneNumber.TabIndex = 106;
            this.btnPhoneNumber.Text = "Addditional numbers ";
            this.btnPhoneNumber.UseVisualStyleBackColor = true;
            this.btnPhoneNumber.Click += new System.EventHandler(this.btnPhoneNumber_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(245, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 30);
            this.txtName.TabIndex = 101;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(245, 239);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(295, 30);
            this.txtPhoneNumber.TabIndex = 105;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSurname.Location = new System.Drawing.Point(245, 85);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(295, 30);
            this.txtSurname.TabIndex = 102;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(53, 437);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 66);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDiscard.Location = new System.Drawing.Point(300, 437);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(167, 66);
            this.btnDiscard.TabIndex = 108;
            this.btnDiscard.Text = "DISCARD";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // dtDob
            // 
            this.dtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtDob.Location = new System.Drawing.Point(245, 136);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(295, 30);
            this.dtDob.TabIndex = 109;
            // 
            // cbM
            // 
            this.cbM.AutoSize = true;
            this.cbM.BackColor = System.Drawing.SystemColors.Control;
            this.cbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbM.Location = new System.Drawing.Point(245, 191);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(77, 29);
            this.cbM.TabIndex = 110;
            this.cbM.Text = "Male";
            this.cbM.UseVisualStyleBackColor = false;
            // 
            // cbW
            // 
            this.cbW.AutoSize = true;
            this.cbW.BackColor = System.Drawing.SystemColors.Control;
            this.cbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbW.Location = new System.Drawing.Point(368, 191);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(99, 29);
            this.cbW.TabIndex = 111;
            this.cbW.Text = "Female";
            this.cbW.UseVisualStyleBackColor = false;
            // 
            // panelNumbers
            // 
            this.panelNumbers.AutoScroll = true;
            this.panelNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.panelNumbers.Location = new System.Drawing.Point(245, 291);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(294, 131);
            this.panelNumbers.TabIndex = 113;
            // 
            // lblReqName
            // 
            this.lblReqName.AutoSize = true;
            this.lblReqName.ForeColor = System.Drawing.Color.Red;
            this.lblReqName.Location = new System.Drawing.Point(242, 66);
            this.lblReqName.Name = "lblReqName";
            this.lblReqName.Size = new System.Drawing.Size(113, 16);
            this.lblReqName.TabIndex = 114;
            this.lblReqName.Text = "Name is required!";
            this.lblReqName.Visible = false;
            // 
            // lblReqPhone
            // 
            this.lblReqPhone.AutoSize = true;
            this.lblReqPhone.ForeColor = System.Drawing.Color.Red;
            this.lblReqPhone.Location = new System.Drawing.Point(242, 272);
            this.lblReqPhone.Name = "lblReqPhone";
            this.lblReqPhone.Size = new System.Drawing.Size(150, 16);
            this.lblReqPhone.TabIndex = 115;
            this.lblReqPhone.Text = "Number format is wrong!";
            this.lblReqPhone.Visible = false;
            // 
            // FrmModifyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 540);
            this.Controls.Add(this.lblReqPhone);
            this.Controls.Add(this.lblReqName);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.cbM);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModifyContact";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmModifyContact";
            this.Load += new System.EventHandler(this.FrmModifyContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.CheckBox cbM;
        private System.Windows.Forms.CheckBox cbW;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Label lblReqName;
        private System.Windows.Forms.Label lblReqPhone;
    }
}