
namespace ZorkBuilder.Forms
{
    partial class WelcomeForm
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
            this.NewMessageText = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.CancelMessageButton = new System.Windows.Forms.Button();
            this.NewMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewMessageText
            // 
            this.NewMessageText.Location = new System.Drawing.Point(11, 33);
            this.NewMessageText.Name = "NewMessageText";
            this.NewMessageText.Size = new System.Drawing.Size(303, 26);
            this.NewMessageText.TabIndex = 0;
            this.NewMessageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetButton
            // 
            this.SetButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetButton.Location = new System.Drawing.Point(11, 76);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(128, 57);
            this.SetButton.TabIndex = 2;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CancelMessageButton
            // 
            this.CancelMessageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelMessageButton.Location = new System.Drawing.Point(186, 76);
            this.CancelMessageButton.Name = "CancelMessageButton";
            this.CancelMessageButton.Size = new System.Drawing.Size(128, 57);
            this.CancelMessageButton.TabIndex = 3;
            this.CancelMessageButton.Text = "Cancel";
            this.CancelMessageButton.UseVisualStyleBackColor = true;
            // 
            // NewMessageLabel
            // 
            this.NewMessageLabel.AutoSize = true;
            this.NewMessageLabel.Location = new System.Drawing.Point(108, 10);
            this.NewMessageLabel.Name = "NewMessageLabel";
            this.NewMessageLabel.Size = new System.Drawing.Size(109, 20);
            this.NewMessageLabel.TabIndex = 5;
            this.NewMessageLabel.Text = "New Message";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelMessageButton;
            this.ClientSize = new System.Drawing.Size(326, 141);
            this.Controls.Add(this.NewMessageLabel);
            this.Controls.Add(this.CancelMessageButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.NewMessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewMessageText;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button CancelMessageButton;
        private System.Windows.Forms.Label NewMessageLabel;
    }
}