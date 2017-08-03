namespace StorePassWindowsApp
{
    partial class formRetrieve
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
            this.tBoxWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.linkMainWindow = new System.Windows.Forms.LinkLabel();
            this.lblSomethingUnexpected = new System.Windows.Forms.Label();
            this.lblNoCommaIsAllowedWarning = new System.Windows.Forms.Label();
            this.lblEmptyTextWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxWebsite
            // 
            this.tBoxWebsite.Location = new System.Drawing.Point(14, 29);
            this.tBoxWebsite.Name = "tBoxWebsite";
            this.tBoxWebsite.Size = new System.Drawing.Size(280, 20);
            this.tBoxWebsite.TabIndex = 0;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(11, 13);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(52, 13);
            this.lblWebsite.TabIndex = 1;
            this.lblWebsite.Text = "Website?";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(14, 56);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(280, 23);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "Retrieve Saved Passwords";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // linkMainWindow
            // 
            this.linkMainWindow.AutoSize = true;
            this.linkMainWindow.Location = new System.Drawing.Point(182, 91);
            this.linkMainWindow.Name = "linkMainWindow";
            this.linkMainWindow.Size = new System.Drawing.Size(112, 13);
            this.linkMainWindow.TabIndex = 10;
            this.linkMainWindow.TabStop = true;
            this.linkMainWindow.Text = "Back to Main Window";
            this.linkMainWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMainWindow_LinkClicked);
            // 
            // lblSomethingUnexpected
            // 
            this.lblSomethingUnexpected.AutoSize = true;
            this.lblSomethingUnexpected.ForeColor = System.Drawing.Color.Red;
            this.lblSomethingUnexpected.Location = new System.Drawing.Point(11, 91);
            this.lblSomethingUnexpected.Name = "lblSomethingUnexpected";
            this.lblSomethingUnexpected.Size = new System.Drawing.Size(164, 13);
            this.lblSomethingUnexpected.TabIndex = 12;
            this.lblSomethingUnexpected.Text = "*** Oops! Something went wrong.";
            // 
            // lblNoCommaIsAllowedWarning
            // 
            this.lblNoCommaIsAllowedWarning.AutoSize = true;
            this.lblNoCommaIsAllowedWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNoCommaIsAllowedWarning.Location = new System.Drawing.Point(11, 91);
            this.lblNoCommaIsAllowedWarning.Name = "lblNoCommaIsAllowedWarning";
            this.lblNoCommaIsAllowedWarning.Size = new System.Drawing.Size(145, 13);
            this.lblNoCommaIsAllowedWarning.TabIndex = 13;
            this.lblNoCommaIsAllowedWarning.Text = "*** Sorry! No comma allowed!";
            // 
            // lblEmptyTextWarning
            // 
            this.lblEmptyTextWarning.AutoSize = true;
            this.lblEmptyTextWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyTextWarning.Location = new System.Drawing.Point(11, 91);
            this.lblEmptyTextWarning.Name = "lblEmptyTextWarning";
            this.lblEmptyTextWarning.Size = new System.Drawing.Size(137, 13);
            this.lblEmptyTextWarning.TabIndex = 14;
            this.lblEmptyTextWarning.Text = "*** Please enter some texts!";
            // 
            // formRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 117);
            this.Controls.Add(this.lblEmptyTextWarning);
            this.Controls.Add(this.lblNoCommaIsAllowedWarning);
            this.Controls.Add(this.lblSomethingUnexpected);
            this.Controls.Add(this.linkMainWindow);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.tBoxWebsite);
            this.MaximizeBox = false;
            this.Name = "formRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Retrieve Your Passwords";
            this.Load += new System.EventHandler(this.formRetrieve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.LinkLabel linkMainWindow;
        private System.Windows.Forms.Label lblSomethingUnexpected;
        private System.Windows.Forms.Label lblNoCommaIsAllowedWarning;
        private System.Windows.Forms.Label lblEmptyTextWarning;
    }
}