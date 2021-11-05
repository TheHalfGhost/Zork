
namespace ZorkBuilder.Controls
{
    partial class NeighborsUserControl
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
            this.DirectionText = new System.Windows.Forms.TextBox();
            this.NeighborsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DirectionText
            // 
            this.DirectionText.Enabled = false;
            this.DirectionText.Location = new System.Drawing.Point(0, 0);
            this.DirectionText.Name = "DirectionText";
            this.DirectionText.Size = new System.Drawing.Size(201, 26);
            this.DirectionText.TabIndex = 0;
            this.DirectionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborsComboBox
            // 
            this.NeighborsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborsComboBox.FormattingEnabled = true;
            this.NeighborsComboBox.Location = new System.Drawing.Point(0, 33);
            this.NeighborsComboBox.Name = "NeighborsComboBox";
            this.NeighborsComboBox.Size = new System.Drawing.Size(201, 28);
            this.NeighborsComboBox.TabIndex = 1;
            // 
            // NeighborsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborsComboBox);
            this.Controls.Add(this.DirectionText);
            this.Name = "NeighborsUserControl";
            this.Size = new System.Drawing.Size(203, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectionText;
        private System.Windows.Forms.ComboBox NeighborsComboBox;
    }
}
