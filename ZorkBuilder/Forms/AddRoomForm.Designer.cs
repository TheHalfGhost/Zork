
namespace ZorkBuilder.Forms
{
    partial class AddRoomForm
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
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.CancelRoomButton = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddRoomButton.Enabled = false;
            this.AddRoomButton.Location = new System.Drawing.Point(28, 128);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(246, 38);
            this.AddRoomButton.TabIndex = 1;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // CancelRoomButton
            // 
            this.CancelRoomButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRoomButton.Location = new System.Drawing.Point(312, 128);
            this.CancelRoomButton.Name = "CancelRoomButton";
            this.CancelRoomButton.Size = new System.Drawing.Size(246, 38);
            this.CancelRoomButton.TabIndex = 2;
            this.CancelRoomButton.Text = "Cancel";
            this.CancelRoomButton.UseVisualStyleBackColor = true;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(123, 70);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(346, 26);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Name";
            // 
            // AddRoomForm
            // 
            this.AcceptButton = this.AddRoomButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.CancelRoomButton);
            this.Controls.Add(this.AddRoomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button CancelRoomButton;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
    }
}