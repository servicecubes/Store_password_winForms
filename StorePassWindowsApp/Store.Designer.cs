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
            this.contextMenuStrip1.SuspendLayout();
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
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.testToolStripMenuItem.Text = "test";
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
            this.btnStoreAndExit.TabIndex = 7;
            this.btnStoreAndExit.Text = "Store and Exit";
            this.btnStoreAndExit.UseVisualStyleBackColor = true;
            this.btnStoreAndExit.Click += new System.EventHandler(this.btnStoreAndExit_Click);
            // 
            // btnStoreAndAddMore
            // 
            this.btnStoreAndAddMore.Location = new System.Drawing.Point(16, 57);
            this.btnStoreAndAddMore.Name = "btnStoreAndAddMore";
            this.btnStoreAndAddMore.Size = new System.Drawing.Size(272, 23);
            this.btnStoreAndAddMore.TabIndex = 8;
            this.btnStoreAndAddMore.Text = "Store and Add More";
            this.btnStoreAndAddMore.UseVisualStyleBackColor = true;
            this.btnStoreAndAddMore.Click += new System.EventHandler(this.btnStoreAndAddMore_Click);
            // 
            // linkMainWindow
            // 
            this.linkMainWindow.AutoSize = true;
            this.linkMainWindow.Location = new System.Drawing.Point(454, 88);
            this.linkMainWindow.Name = "linkMainWindow";
            this.linkMainWindow.Size = new System.Drawing.Size(112, 13);
            this.linkMainWindow.TabIndex = 9;
            this.linkMainWindow.TabStop = true;
            this.linkMainWindow.Text = "Back to Main Window";
            this.linkMainWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMainWindow_LinkClicked);
            // 
            // formStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 113);
            this.Controls.Add(this.linkMainWindow);
            this.Controls.Add(this.btnStoreAndAddMore);
            this.Controls.Add(this.btnStoreAndExit);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tBoxWebsite);
            this.Controls.Add(this.lblWeb);
            this.Name = "formStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Your Passwords";
            this.contextMenuStrip1.ResumeLayout(false);
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
    }
}