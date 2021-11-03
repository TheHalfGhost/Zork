
namespace ZorkBuilder.Forms
{
    partial class SetWelcomeForm
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
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CurrentMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.Location = new System.Drawing.Point(28, 95);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(456, 26);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeText.TextChanged += new System.EventHandler(this.WelcomeText_TextChanged);
            // 
            // SetButton
            // 
            this.SetButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetButton.Location = new System.Drawing.Point(58, 127);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(191, 42);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set Welcome";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(255, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(191, 42);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // CurrentMessage
            // 
            this.CurrentMessage.Enabled = false;
            this.CurrentMessage.Location = new System.Drawing.Point(28, 27);
            this.CurrentMessage.Name = "CurrentMessage";
            this.CurrentMessage.Size = new System.Drawing.Size(456, 26);
            this.CurrentMessage.TabIndex = 3;
            this.CurrentMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentMessage.TextChanged += new System.EventHandler(this.CurrentMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Welcome Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Welcome Message";
            // 
            // SetWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentMessage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.WelcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SetWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeText;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox CurrentMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}