namespace StorePassWindowsApp
{
    partial class formPasswords
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
            this.lblCountDisplayText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCountDisplayText
            // 
            this.lblCountDisplayText.AutoSize = true;
            this.lblCountDisplayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDisplayText.Location = new System.Drawing.Point(13, 13);
            this.lblCountDisplayText.Name = "lblCountDisplayText";
            this.lblCountDisplayText.Size = new System.Drawing.Size(0, 25);
            this.lblCountDisplayText.TabIndex = 0;
            // 
            // formPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 180);
            this.Controls.Add(this.lblCountDisplayText);
            this.MaximizeBox = false;
            this.Name = "formPasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.formPasswords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountDisplayText;
    }
}