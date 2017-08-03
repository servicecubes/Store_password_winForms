namespace StorePassWindowsApp
{
    partial class formSetupMasterpass
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tBoxMasterpassInput1 = new System.Windows.Forms.TextBox();
            this.tBoxMasterpassInput2 = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblNotMatchWarning = new System.Windows.Forms.Label();
            this.lblEmptyTextWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(333, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Let\'s setup your masterpass. Enter your password twice and proceed.";
            // 
            // tBoxMasterpassInput1
            // 
            this.tBoxMasterpassInput1.Location = new System.Drawing.Point(16, 30);
            this.tBoxMasterpassInput1.Name = "tBoxMasterpassInput1";
            this.tBoxMasterpassInput1.Size = new System.Drawing.Size(321, 20);
            this.tBoxMasterpassInput1.TabIndex = 1;
            // 
            // tBoxMasterpassInput2
            // 
            this.tBoxMasterpassInput2.Location = new System.Drawing.Point(16, 56);
            this.tBoxMasterpassInput2.Name = "tBoxMasterpassInput2";
            this.tBoxMasterpassInput2.Size = new System.Drawing.Size(321, 20);
            this.tBoxMasterpassInput2.TabIndex = 2;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(16, 83);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(321, 23);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblNotMatchWarning
            // 
            this.lblNotMatchWarning.AutoSize = true;
            this.lblNotMatchWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNotMatchWarning.Location = new System.Drawing.Point(16, 113);
            this.lblNotMatchWarning.Name = "lblNotMatchWarning";
            this.lblNotMatchWarning.Size = new System.Drawing.Size(143, 13);
            this.lblNotMatchWarning.TabIndex = 4;
            this.lblNotMatchWarning.Text = "*** Passwords did not match.";
            // 
            // lblEmptyTextWarning
            // 
            this.lblEmptyTextWarning.AutoSize = true;
            this.lblEmptyTextWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyTextWarning.Location = new System.Drawing.Point(17, 113);
            this.lblEmptyTextWarning.Name = "lblEmptyTextWarning";
            this.lblEmptyTextWarning.Size = new System.Drawing.Size(194, 13);
            this.lblEmptyTextWarning.TabIndex = 5;
            this.lblEmptyTextWarning.Text = "*** You cannot use an empty password.";
            // 
            // formSetupMasterpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 134);
            this.Controls.Add(this.lblEmptyTextWarning);
            this.Controls.Add(this.lblNotMatchWarning);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.tBoxMasterpassInput2);
            this.Controls.Add(this.tBoxMasterpassInput1);
            this.Controls.Add(this.lblHeader);
            this.Name = "formSetupMasterpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Masterpass";
            this.Load += new System.EventHandler(this.formSetupMasterpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tBoxMasterpassInput1;
        private System.Windows.Forms.TextBox tBoxMasterpassInput2;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblNotMatchWarning;
        private System.Windows.Forms.Label lblEmptyTextWarning;
    }
}