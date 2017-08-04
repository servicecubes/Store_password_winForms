namespace StorePassWindowsApp
{
    partial class formStore
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
            this.lblWeb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBoxWebsite = new System.Windows.Forms.TextBox();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnStoreAndExit = new System.Windows.Forms.Button();
            this.btnStoreAndAddMore = new System.Windows.Forms.Button();
            this.linkMainWindow = new System.Windows.Forms.LinkLabel();
            this.lblEmptyTextWarning = new System.Windows.Forms.Label();
            this.lblNoCommaAllowedWarning = new System.Windows.Forms.Label();
            this.lblPasswordSavedSuccessfullyMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(13, 13);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(52, 13);
            this.lblWeb.TabIndex = 0;
            this.lblWeb.Text = "Website?";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tBoxWebsite
            // 
            this.tBoxWebsite.Location = new System.Drawing.Point(16, 30);
            this.tBoxWebsite.Name = "tBoxWebsite";
            this.tBoxWebsite.Size = new System.Drawing.Size(169, 20);
            this.tBoxWebsite.TabIndex = 2;
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(203, 30);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(169, 20);
            this.tBoxId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(200, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id?";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(394, 30);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(169, 20);
            this.tBoxPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(391, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password?";
            // 
            // btnStoreAndExit
            // 
            this.btnStoreAndExit.Location = new System.Drawing.Point(294, 57);
            this.btnStoreAndExit.Name = "btnStoreAndExit";
            this.btnStoreAndExit.Size = new System.Drawing.Size(272, 23);
            this.btnStoreAndExit.TabIndex = 8;
            this.btnStoreAndExit.Text = "Store and Exit";
            this.btnStoreAndExit.UseVisualStyleBackColor = true;
            this.btnStoreAndExit.Click += new System.EventHandler(this.btnStoreAndExit_Click);
            // 
            // btnStoreAndAddMore
            // 
            this.btnStoreAndAddMore.Location = new System.Drawing.Point(16, 57);
            this.btnStoreAndAddMore.Name = "btnStoreAndAddMore";
            this.btnStoreAndAddMore.Size = new System.Drawing.Size(272, 23);
            this.btnStoreAndAddMore.TabIndex = 7;
            this.btnStoreAndAddMore.Text = "Store and Add More";
            this.btnStoreAndAddMore.UseVisualStyleBackColor = true;
            this.btnStoreAndAddMore.Click += new System.EventHandler(this.btnStoreAndAddMore_Click);
            // 
            // linkMainWindow
            // 
            this.linkMainWindow.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkMainWindow.AutoSize = true;
            this.linkMainWindow.Location = new System.Drawing.Point(454, 88);
            this.linkMainWindow.Name = "linkMainWindow";
            this.linkMainWindow.Size = new System.Drawing.Size(112, 13);
            this.linkMainWindow.TabIndex = 9;
            this.linkMainWindow.TabStop = true;
            this.linkMainWindow.Text = "Back to Main Window";
            this.linkMainWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMainWindow_LinkClicked);
            // 
            // lblEmptyTextWarning
            // 
            this.lblEmptyTextWarning.AutoSize = true;
            this.lblEmptyTextWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyTextWarning.Location = new System.Drawing.Point(17, 88);
            this.lblEmptyTextWarning.Name = "lblEmptyTextWarning";
            this.lblEmptyTextWarning.Size = new System.Drawing.Size(159, 13);
            this.lblEmptyTextWarning.TabIndex = 10;
            this.lblEmptyTextWarning.Text = "*** One or more fields are empty!";
            // 
            // lblNoCommaAllowedWarning
            // 
            this.lblNoCommaAllowedWarning.AutoSize = true;
            this.lblNoCommaAllowedWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNoCommaAllowedWarning.Location = new System.Drawing.Point(17, 88);
            this.lblNoCommaAllowedWarning.Name = "lblNoCommaAllowedWarning";
            this.lblNoCommaAllowedWarning.Size = new System.Drawing.Size(266, 13);
            this.lblNoCommaAllowedWarning.TabIndex = 11;
            this.lblNoCommaAllowedWarning.Text = "*** You cannot use comma in any of these fields. Sorry!";
            // 
            // lblPasswordSavedSuccessfullyMsg
            // 
            this.lblPasswordSavedSuccessfullyMsg.AutoSize = true;
            this.lblPasswordSavedSuccessfullyMsg.ForeColor = System.Drawing.Color.Green;
            this.lblPasswordSavedSuccessfullyMsg.Location = new System.Drawing.Point(17, 88);
            this.lblPasswordSavedSuccessfullyMsg.Name = "lblPasswordSavedSuccessfullyMsg";
            this.lblPasswordSavedSuccessfullyMsg.Size = new System.Drawing.Size(237, 13);
            this.lblPasswordSavedSuccessfullyMsg.TabIndex = 12;
            this.lblPasswordSavedSuccessfullyMsg.Text = ":) Your password has been saved successfully! :)";
            // 
            // formStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 113);
            this.Controls.Add(this.lblPasswordSavedSuccessfullyMsg);
            this.Controls.Add(this.lblNoCommaAllowedWarning);
            this.Controls.Add(this.lblEmptyTextWarning);
            this.Controls.Add(this.linkMainWindow);
            this.Controls.Add(this.btnStoreAndAddMore);
            this.Controls.Add(this.btnStoreAndExit);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tBoxWebsite);
            this.Controls.Add(this.lblWeb);
            this.MaximizeBox = false;
            this.Name = "formStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Your Passwords";
            this.Load += new System.EventHandler(this.formStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.TextBox tBoxWebsite;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnStoreAndExit;
        private System.Windows.Forms.Button btnStoreAndAddMore;
        private System.Windows.Forms.LinkLabel linkMainWindow;
        private System.Windows.Forms.Label lblEmptyTextWarning;
        private System.Windows.Forms.Label lblNoCommaAllowedWarning;
        private System.Windows.Forms.Label lblPasswordSavedSuccessfullyMsg;
    }
}