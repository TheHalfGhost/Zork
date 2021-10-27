
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
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SetWelcomeMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.ListRooms.Size = new System.Drawing.Size(313, 304);
            this.ListRooms.TabIndex = 3;
            this.ListRooms.ValueMember = "Name";
            // 
            // roomsBindingSource
            // 
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
            this.AddRoomButton.Location = new System.Drawing.Point(22, 402);
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
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(664, 90);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(211, 26);
            this.StartTextBox.TabIndex = 17;
            this.StartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(186, 402);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(149, 47);
            this.DeleteRoomButton.TabIndex = 19;
            this.DeleteRoomButton.Text = "Delete Room";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 26);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 26);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 26);
            this.textBox6.TabIndex = 24;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(277, 95);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(211, 26);
            this.textBox7.TabIndex = 25;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "West";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "North";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "East";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "South";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 33);
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
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(381, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 183);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neighbors";
            // 
            // ZorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteRoomButton);
            this.Controls.Add(this.StartTextBox);
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
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
    }
}

