
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
            this.RoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(12, 57);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(333, 26);
            this.RoomName.TabIndex = 0;
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
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(188, 89);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 57);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel Button";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 158);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomName);
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

        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}