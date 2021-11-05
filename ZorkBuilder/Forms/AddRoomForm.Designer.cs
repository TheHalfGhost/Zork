
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
            this.RoomNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomNameText
            // 
            this.RoomNameText.Location = new System.Drawing.Point(12, 57);
            this.RoomNameText.Name = "RoomNameText";
            this.RoomNameText.Size = new System.Drawing.Size(333, 26);
            this.RoomNameText.TabIndex = 0;
            this.RoomNameText.TextChanged += new System.EventHandler(this.RoomNameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(12, 89);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(157, 57);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Room";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelRoomButton
            // 
            this.CancelRoomButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRoomButton.Location = new System.Drawing.Point(188, 89);
            this.CancelRoomButton.Name = "CancelRoomButton";
            this.CancelRoomButton.Size = new System.Drawing.Size(157, 57);
            this.CancelRoomButton.TabIndex = 3;
            this.CancelRoomButton.Text = "Cancel Button";
            this.CancelRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 158);
            this.Controls.Add(this.CancelRoomButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelRoomButton;
    }
}