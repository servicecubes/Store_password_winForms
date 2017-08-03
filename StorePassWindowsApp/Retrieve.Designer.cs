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
            // formRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 117);
            this.Controls.Add(this.linkMainWindow);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.tBoxWebsite);
            this.MaximizeBox = false;
            this.Name = "formRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Retrieve Your Passwords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.LinkLabel linkMainWindow;
    }
}