
namespace ZorkBuilder
{
    partial class MainForm
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
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.RoomBox = new System.Windows.Forms.GroupBox();
            this.RoomsList = new System.Windows.Forms.ListBox();
            this.StartingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomNameText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.StartingLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.NeighborGroupBox = new System.Windows.Forms.GroupBox();
            this.neighborsUserControl1 = new ZorkBuilder.Controls.NeighborsUserControl();
            this.neighborsUserControl2 = new ZorkBuilder.Controls.NeighborsUserControl();
            this.neighborsUserControl3 = new ZorkBuilder.Controls.NeighborsUserControl();
            this.neighborsUserControl4 = new ZorkBuilder.Controls.NeighborsUserControl();
            this.setWelcomeMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.NeighborGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(8, 446);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(149, 53);
            this.AddRoomButton.TabIndex = 0;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(163, 446);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(149, 53);
            this.DeleteRoomButton.TabIndex = 1;
            this.DeleteRoomButton.Text = "Delete Room";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoom_Click);
            // 
            // RoomBox
            // 
            this.RoomBox.Controls.Add(this.RoomsList);
            this.RoomBox.Controls.Add(this.DeleteRoomButton);
            this.RoomBox.Controls.Add(this.AddRoomButton);
            this.RoomBox.Location = new System.Drawing.Point(13, 36);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(318, 505);
            this.RoomBox.TabIndex = 2;
            this.RoomBox.TabStop = false;
            this.RoomBox.Text = "List of Rooms";
            // 
            // RoomsList
            // 
            this.RoomsList.FormattingEnabled = true;
            this.RoomsList.ItemHeight = 20;
            this.RoomsList.Location = new System.Drawing.Point(8, 26);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(304, 404);
            this.RoomsList.TabIndex = 2;
            // 
            // StartingLocationComboBox
            // 
            this.StartingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingLocationComboBox.FormattingEnabled = true;
            this.StartingLocationComboBox.Location = new System.Drawing.Point(626, 77);
            this.StartingLocationComboBox.Name = "StartingLocationComboBox";
            this.StartingLocationComboBox.Size = new System.Drawing.Size(224, 28);
            this.StartingLocationComboBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setWelcomeMessageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newFileToolStripMenuItem.Text = "New File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // RoomNameText
            // 
            this.RoomNameText.Location = new System.Drawing.Point(364, 77);
            this.RoomNameText.Name = "RoomNameText";
            this.RoomNameText.Size = new System.Drawing.Size(224, 26);
            this.RoomNameText.TabIndex = 5;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(364, 148);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(486, 132);
            this.DescriptionText.TabIndex = 6;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(427, 54);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(98, 20);
            this.RoomNameLabel.TabIndex = 7;
            this.RoomNameLabel.Text = "Room Name";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartingLabel
            // 
            this.StartingLabel.AutoSize = true;
            this.StartingLabel.Location = new System.Drawing.Point(673, 54);
            this.StartingLabel.Name = "StartingLabel";
            this.StartingLabel.Size = new System.Drawing.Size(130, 20);
            this.StartingLabel.TabIndex = 8;
            this.StartingLabel.Text = "Starting Location";
            this.StartingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Location = new System.Drawing.Point(539, 125);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(136, 20);
            this.DiscriptionLabel.TabIndex = 9;
            this.DiscriptionLabel.Text = "Room Description";
            this.DiscriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NeighborGroupBox
            // 
            this.NeighborGroupBox.Controls.Add(this.neighborsUserControl4);
            this.NeighborGroupBox.Controls.Add(this.neighborsUserControl3);
            this.NeighborGroupBox.Controls.Add(this.neighborsUserControl2);
            this.NeighborGroupBox.Controls.Add(this.neighborsUserControl1);
            this.NeighborGroupBox.Location = new System.Drawing.Point(364, 302);
            this.NeighborGroupBox.Name = "NeighborGroupBox";
            this.NeighborGroupBox.Size = new System.Drawing.Size(486, 239);
            this.NeighborGroupBox.TabIndex = 10;
            this.NeighborGroupBox.TabStop = false;
            this.NeighborGroupBox.Text = "Neighbors";
            // 
            // neighborsUserControl1
            // 
            this.neighborsUserControl1.Location = new System.Drawing.Point(135, 25);
            this.neighborsUserControl1.Name = "neighborsUserControl1";
            this.neighborsUserControl1.Size = new System.Drawing.Size(203, 67);
            this.neighborsUserControl1.TabIndex = 0;
            // 
            // neighborsUserControl2
            // 
            this.neighborsUserControl2.Location = new System.Drawing.Point(262, 97);
            this.neighborsUserControl2.Name = "neighborsUserControl2";
            this.neighborsUserControl2.Size = new System.Drawing.Size(203, 67);
            this.neighborsUserControl2.TabIndex = 1;
            // 
            // neighborsUserControl3
            // 
            this.neighborsUserControl3.Location = new System.Drawing.Point(21, 98);
            this.neighborsUserControl3.Name = "neighborsUserControl3";
            this.neighborsUserControl3.Size = new System.Drawing.Size(203, 67);
            this.neighborsUserControl3.TabIndex = 2;
            // 
            // neighborsUserControl4
            // 
            this.neighborsUserControl4.Location = new System.Drawing.Point(135, 172);
            this.neighborsUserControl4.Name = "neighborsUserControl4";
            this.neighborsUserControl4.Size = new System.Drawing.Size(203, 67);
            this.neighborsUserControl4.TabIndex = 3;
            // 
            // setWelcomeMessageToolStripMenuItem
            // 
            this.setWelcomeMessageToolStripMenuItem.Name = "setWelcomeMessageToolStripMenuItem";
            this.setWelcomeMessageToolStripMenuItem.Size = new System.Drawing.Size(206, 29);
            this.setWelcomeMessageToolStripMenuItem.Text = "Set Welcome Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 553);
            this.Controls.Add(this.NeighborGroupBox);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.StartingLabel);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.RoomNameText);
            this.Controls.Add(this.StartingLocationComboBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ZorkBuilder";
            this.RoomBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NeighborGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.GroupBox RoomBox;
        private System.Windows.Forms.ListBox RoomsList;
        private System.Windows.Forms.ComboBox StartingLocationComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.TextBox RoomNameText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Label StartingLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.GroupBox NeighborGroupBox;
        private Controls.NeighborsUserControl neighborsUserControl1;
        private Controls.NeighborsUserControl neighborsUserControl4;
        private Controls.NeighborsUserControl neighborsUserControl3;
        private Controls.NeighborsUserControl neighborsUserControl2;
        private System.Windows.Forms.ToolStripMenuItem setWelcomeMessageToolStripMenuItem;
    }
}

