
namespace ZorkBuilder
{
    partial class ZorkForm
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
            this.ListRooms = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SetWelcomeMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EastControl = new ZorkBuilder.Controls.NeighborsControl();
            this.SouthContorl = new ZorkBuilder.Controls.NeighborsControl();
            this.WestControl = new ZorkBuilder.Controls.NeighborsControl();
            this.NorthControl = new ZorkBuilder.Controls.NeighborsControl();
            this.StartingLocationComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRooms
            // 
            this.ListRooms.DataSource = this.roomsBindingSource;
            this.ListRooms.DisplayMember = "Name";
            this.ListRooms.FormattingEnabled = true;
            this.ListRooms.ItemHeight = 20;
            this.ListRooms.Location = new System.Drawing.Point(22, 90);
            this.ListRooms.Name = "ListRooms";
            this.ListRooms.Size = new System.Drawing.Size(313, 384);
            this.ListRooms.TabIndex = 3;
            this.ListRooms.ValueMember = "Name";
            this.ListRooms.SelectedIndexChanged += new System.EventHandler(this.ListRooms_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(ZorkBuilder.ViewModel.WorldViewModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "List of Rooms";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(564, 128);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(136, 20);
            this.Description.TabIndex = 12;
            this.Description.Text = "Room Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.DescriptionTextBox.Location = new System.Drawing.Point(381, 151);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(494, 109);
            this.DescriptionTextBox.TabIndex = 13;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(22, 490);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(158, 47);
            this.AddRoomButton.TabIndex = 15;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Starting Location";
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(186, 490);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(149, 47);
            this.DeleteRoomButton.TabIndex = 19;
            this.DeleteRoomButton.Text = "Delete Room";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomTextBox.Location = new System.Drawing.Point(381, 90);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(211, 26);
            this.RoomTextBox.TabIndex = 21;
            this.RoomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Room Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 36);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileButton,
            this.OpenFileButton,
            this.SaveFileButton,
            this.SetWelcomeMessage});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // NewFileButton
            // 
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(292, 34);
            this.NewFileButton.Text = "New File";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(292, 34);
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(292, 34);
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SetWelcomeMessage
            // 
            this.SetWelcomeMessage.Name = "SetWelcomeMessage";
            this.SetWelcomeMessage.Size = new System.Drawing.Size(292, 34);
            this.SetWelcomeMessage.Text = "Set Welcome Message";
            this.SetWelcomeMessage.Click += new System.EventHandler(this.SetWelcomeMessage_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "World files (*.json)|*.json";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EastControl);
            this.groupBox1.Controls.Add(this.SouthContorl);
            this.groupBox1.Controls.Add(this.WestControl);
            this.groupBox1.Controls.Add(this.NorthControl);
            this.groupBox1.Location = new System.Drawing.Point(381, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 278);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neighbors";
            // 
            // EastControl
            // 
            this.EastControl.Location = new System.Drawing.Point(298, 117);
            this.EastControl.Name = "EastControl";
            this.EastControl.NeighborLocations = Zork.World.NeighborLocations.EAST;
            this.EastControl.NeighborsNames = null;
            this.EastControl.Rooms = null;
            this.EastControl.Size = new System.Drawing.Size(190, 65);
            this.EastControl.TabIndex = 4;
            // 
            // SouthContorl
            // 
            this.SouthContorl.Location = new System.Drawing.Point(157, 206);
            this.SouthContorl.Name = "SouthContorl";
            this.SouthContorl.NeighborLocations = Zork.World.NeighborLocations.SOUTH;
            this.SouthContorl.NeighborsNames = null;
            this.SouthContorl.Rooms = null;
            this.SouthContorl.Size = new System.Drawing.Size(190, 65);
            this.SouthContorl.TabIndex = 3;
            // 
            // WestControl
            // 
            this.WestControl.Location = new System.Drawing.Point(6, 117);
            this.WestControl.Name = "WestControl";
            this.WestControl.NeighborLocations = Zork.World.NeighborLocations.WEST;
            this.WestControl.NeighborsNames = null;
            this.WestControl.Rooms = null;
            this.WestControl.Size = new System.Drawing.Size(190, 65);
            this.WestControl.TabIndex = 2;
            // 
            // NorthControl
            // 
            this.NorthControl.Location = new System.Drawing.Point(157, 25);
            this.NorthControl.Name = "NorthControl";
            this.NorthControl.NeighborLocations = Zork.World.NeighborLocations.NORTH;
            this.NorthControl.NeighborsNames = null;
            this.NorthControl.Rooms = null;
            this.NorthControl.Size = new System.Drawing.Size(190, 65);
            this.NorthControl.TabIndex = 1;
            // 
            // StartingLocationComboBox
            // 
            this.StartingLocationComboBox.DataSource = this.roomsBindingSource;
            this.StartingLocationComboBox.DisplayMember = "Name";
            this.StartingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingLocationComboBox.FormattingEnabled = true;
            this.StartingLocationComboBox.Location = new System.Drawing.Point(665, 90);
            this.StartingLocationComboBox.Name = "StartingLocationComboBox";
            this.StartingLocationComboBox.Size = new System.Drawing.Size(211, 28);
            this.StartingLocationComboBox.TabIndex = 32;
            this.StartingLocationComboBox.ValueMember = "StartingLocation";
            this.StartingLocationComboBox.BindingContextChanged += new System.EventHandler(this.StartingLocationComboBox_BindingContextChanged);
            // 
            // ZorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 549);
            this.Controls.Add(this.StartingLocationComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteRoomButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListRooms);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ZorkForm";
            this.Text = "ZorkBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileButton;
        private System.Windows.Forms.ToolStripMenuItem SaveFileButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem NewFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem SetWelcomeMessage;
        private Controls.NeighborsControl EastControl;
        private Controls.NeighborsControl SouthContorl;
        private Controls.NeighborsControl WestControl;
        private Controls.NeighborsControl NorthControl;
        private System.Windows.Forms.ComboBox StartingLocationComboBox;
    }
}

