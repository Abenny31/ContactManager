namespace ContactManager
{
    partial class FrmPhoneNumbers
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
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.btnPhoneNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.lblReqPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddPhone.Location = new System.Drawing.Point(12, 36);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(236, 30);
            this.txtAddPhone.TabIndex = 1;
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPhoneNumber.Location = new System.Drawing.Point(267, 30);
            this.btnPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(44, 39);
            this.btnPhoneNumber.TabIndex = 7;
            this.btnPhoneNumber.Text = "+";
            this.btnPhoneNumber.UseVisualStyleBackColor = true;
            this.btnPhoneNumber.Click += new System.EventHandler(this.btnPhoneNumber_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(319, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(12, 8);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(122, 16);
            this.lblNumbers.TabIndex = 9;
            this.lblNumbers.Text = "Additional numbers";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDiscard.Location = new System.Drawing.Point(196, 349);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(167, 66);
            this.btnDiscard.TabIndex = 110;
            this.btnDiscard.Text = "DISCARD";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(12, 349);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 66);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelNumbers
            // 
            this.panelNumbers.AutoScroll = true;
            this.panelNumbers.BackColor = System.Drawing.SystemColors.Control;
            this.panelNumbers.Location = new System.Drawing.Point(12, 76);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(351, 266);
            this.panelNumbers.TabIndex = 111;
            // 
            // lblReqPhone
            // 
            this.lblReqPhone.AutoSize = true;
            this.lblReqPhone.ForeColor = System.Drawing.Color.Red;
            this.lblReqPhone.Location = new System.Drawing.Point(161, 8);
            this.lblReqPhone.Name = "lblReqPhone";
            this.lblReqPhone.Size = new System.Drawing.Size(150, 16);
            this.lblReqPhone.TabIndex = 116;
            this.lblReqPhone.Text = "Number format is wrong!";
            this.lblReqPhone.Visible = false;
            // 
            // FrmPhoneNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 428);
            this.Controls.Add(this.lblReqPhone);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPhoneNumber);
            this.Controls.Add(this.txtAddPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhoneNumbers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Button btnPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Label lblReqPhone;
    }
}