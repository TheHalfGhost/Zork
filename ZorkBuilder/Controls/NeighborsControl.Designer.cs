
namespace ZorkBuilder.Controls
{
    partial class NeighborsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NeighborcomboBox = new System.Windows.Forms.ComboBox();
            this.DirectionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NeighborcomboBox
            // 
            this.NeighborcomboBox.DisplayMember = "Name";
            this.NeighborcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborcomboBox.FormattingEnabled = true;
            this.NeighborcomboBox.Location = new System.Drawing.Point(0, 32);
            this.NeighborcomboBox.Name = "NeighborcomboBox";
            this.NeighborcomboBox.Size = new System.Drawing.Size(183, 28);
            this.NeighborcomboBox.TabIndex = 0;
            // 
            // DirectionBox
            // 
            this.DirectionBox.Location = new System.Drawing.Point(0, 4);
            this.DirectionBox.Name = "DirectionBox";
            this.DirectionBox.ReadOnly = true;
            this.DirectionBox.Size = new System.Drawing.Size(183, 26);
            this.DirectionBox.TabIndex = 1;
            this.DirectionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DirectionBox);
            this.Controls.Add(this.NeighborcomboBox);
            this.Name = "NeighborsControl";
            this.Size = new System.Drawing.Size(190, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NeighborcomboBox;
        private System.Windows.Forms.TextBox DirectionBox;
    }
}
