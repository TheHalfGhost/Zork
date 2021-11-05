
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
            this.components = new System.ComponentModel.Container();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.RoomBox = new System.Windows.Forms.GroupBox();
            this.RoomsList = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SetWelcomeMessageTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomNameText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.StartingLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.NeighborGroupBox = new System.Windows.Forms.GroupBox();
            this.SouthUserControl = new ZorkBuilder.Controls.NeighborsUserControl();
            this.WestUserControl = new ZorkBuilder.Controls.NeighborsUserControl();
            this.EastUserControl = new ZorkBuilder.Controls.NeighborsUserControl();
            this.NorthUserControl = new ZorkBuilder.Controls.NeighborsUserControl();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.RoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.NeighborGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(8, 510);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(149, 53);
            this.AddRoomButton.TabIndex = 0;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(163, 510);
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
            this.RoomBox.Size = new System.Drawing.Size(318, 569);
            this.RoomBox.TabIndex = 2;
            this.RoomBox.TabStop = false;
            this.RoomBox.Text = "List of Rooms";
            // 
            // RoomsList
            // 
            this.RoomsList.DataSource = this.roomsBindingSource;
            this.RoomsList.DisplayMember = "Name";
            this.RoomsList.FormattingEnabled = true;
            this.RoomsList.ItemHeight = 20;
            this.RoomsList.Location = new System.Drawing.Point(8, 26);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(304, 464);
            this.RoomsList.TabIndex = 2;
            this.RoomsList.SelectedIndexChanged += new System.EventHandler(this.RoomsList_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(ZorkBuilder.ViewModel.GameViewModel);
            // 
            // StartingLocationComboBox
            // 
            this.StartingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingLocationComboBox.FormattingEnabled = true;
            this.StartingLocationComboBox.Location = new System.Drawing.Point(626, 77);
            this.StartingLocationComboBox.Name = "StartingLocationComboBox";
            this.StartingLocationComboBox.Size = new System.Drawing.Size(224, 28);
            this.StartingLocationComboBox.TabIndex = 3;
            this.StartingLocationComboBox.BindingContextChanged += new System.EventHandler(this.StartingLocationComboBox_BindingContextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.SetWelcomeMessageTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolStripMenu,
            this.OpenFileToolStrip,
            this.SaveFileToolStripMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewFileToolStripMenu
            // 
            this.NewFileToolStripMenu.Name = "NewFileToolStripMenu";
            this.NewFileToolStripMenu.Size = new System.Drawing.Size(270, 34);
            this.NewFileToolStripMenu.Text = "New File";
            this.NewFileToolStripMenu.Click += new System.EventHandler(this.NewFileToolStripMenu_Click);
            // 
            // OpenFileToolStrip
            // 
            this.OpenFileToolStrip.Name = "OpenFileToolStrip";
            this.OpenFileToolStrip.Size = new System.Drawing.Size(270, 34);
            this.OpenFileToolStrip.Text = "Open File";
            this.OpenFileToolStrip.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFileToolStripMenu
            // 
            this.SaveFileToolStripMenu.Name = "SaveFileToolStripMenu";
            this.SaveFileToolStripMenu.Size = new System.Drawing.Size(270, 34);
            this.SaveFileToolStripMenu.Text = "Save File";
            this.SaveFileToolStripMenu.Click += new System.EventHandler(this.SaveFileToolStripMenu_Click);
            // 
            // SetWelcomeMessageTool
            // 
            this.SetWelcomeMessageTool.Name = "SetWelcomeMessageTool";
            this.SetWelcomeMessageTool.Size = new System.Drawing.Size(206, 29);
            this.SetWelcomeMessageTool.Text = "Set Welcome Message";
            this.SetWelcomeMessageTool.Click += new System.EventHandler(this.SetWelcomeMessageTool_Click);
            // 
            // RoomNameText
            // 
            this.RoomNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.RoomNameText.Location = new System.Drawing.Point(364, 77);
            this.RoomNameText.Name = "RoomNameText";
            this.RoomNameText.Size = new System.Drawing.Size(224, 26);
            this.RoomNameText.TabIndex = 5;
            // 
            // DescriptionText
            // 
            this.DescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
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
            this.NeighborGroupBox.Controls.Add(this.SouthUserControl);
            this.NeighborGroupBox.Controls.Add(this.WestUserControl);
            this.NeighborGroupBox.Controls.Add(this.EastUserControl);
            this.NeighborGroupBox.Controls.Add(this.NorthUserControl);
            this.NeighborGroupBox.Location = new System.Drawing.Point(364, 366);
            this.NeighborGroupBox.Name = "NeighborGroupBox";
            this.NeighborGroupBox.Size = new System.Drawing.Size(486, 239);
            this.NeighborGroupBox.TabIndex = 10;
            this.NeighborGroupBox.TabStop = false;
            this.NeighborGroupBox.Text = "Neighbors";
            // 
            // SouthUserControl
            // 
            this.SouthUserControl.Location = new System.Drawing.Point(135, 172);
            this.SouthUserControl.Name = "SouthUserControl";
            this.SouthUserControl.NeighborLocations = Zork.Directions.SOUTH;
            this.SouthUserControl.NeighborsNames = null;
            this.SouthUserControl.Rooms = null;
            this.SouthUserControl.Size = new System.Drawing.Size(203, 67);
            this.SouthUserControl.TabIndex = 3;
            // 
            // WestUserControl
            // 
            this.WestUserControl.Location = new System.Drawing.Point(21, 98);
            this.WestUserControl.Name = "WestUserControl";
            this.WestUserControl.NeighborLocations = Zork.Directions.WEST;
            this.WestUserControl.NeighborsNames = null;
            this.WestUserControl.Rooms = null;
            this.WestUserControl.Size = new System.Drawing.Size(203, 67);
            this.WestUserControl.TabIndex = 2;
            // 
            // EastUserControl
            // 
            this.EastUserControl.Location = new System.Drawing.Point(262, 97);
            this.EastUserControl.Name = "EastUserControl";
            this.EastUserControl.NeighborLocations = Zork.Directions.EAST;
            this.EastUserControl.NeighborsNames = null;
            this.EastUserControl.Rooms = null;
            this.EastUserControl.Size = new System.Drawing.Size(203, 67);
            this.EastUserControl.TabIndex = 1;
            // 
            // NorthUserControl
            // 
            this.NorthUserControl.Location = new System.Drawing.Point(135, 25);
            this.NorthUserControl.Name = "NorthUserControl";
            this.NorthUserControl.NeighborLocations = Zork.Directions.NORTH;
            this.NorthUserControl.NeighborsNames = null;
            this.NorthUserControl.Rooms = null;
            this.NorthUserControl.Size = new System.Drawing.Size(203, 67);
            this.NorthUserControl.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(533, 293);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(144, 20);
            this.WelcomeMessageLabel.TabIndex = 11;
            this.WelcomeMessageLabel.Text = "Welcome Message";
            this.WelcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeText
            // 
            this.WelcomeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true));
            this.WelcomeText.Enabled = false;
            this.WelcomeText.Location = new System.Drawing.Point(459, 316);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(293, 26);
            this.WelcomeText.TabIndex = 12;
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 617);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.WelcomeMessageLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem NewFileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenu;
        private System.Windows.Forms.TextBox RoomNameText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Label StartingLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.GroupBox NeighborGroupBox;
        private Controls.NeighborsUserControl NorthUserControl;
        private Controls.NeighborsUserControl SouthUserControl;
        private Controls.NeighborsUserControl WestUserControl;
        private Controls.NeighborsUserControl EastUserControl;
        private System.Windows.Forms.ToolStripMenuItem SetWelcomeMessageTool;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.TextBox WelcomeText;
    }
}

