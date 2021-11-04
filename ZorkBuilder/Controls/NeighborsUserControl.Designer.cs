
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // NeighborsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DirectionText);
            this.Name = "NeighborsUserControl";
            this.Size = new System.Drawing.Size(203, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectionText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
