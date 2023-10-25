namespace Kernel_Testdata_Editor
{
    partial class pixelPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cursorCellLabel = new System.Windows.Forms.Label();
            this.setCellsLabel = new System.Windows.Forms.Label();
            this.CCLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusLayoutPanel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 369);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // statusLayoutPanel
            // 
            this.statusLayoutPanel.ColumnCount = 3;
            this.statusLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.statusLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.statusLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.statusLayoutPanel.Controls.Add(this.CCLabel, 2, 0);
            this.statusLayoutPanel.Controls.Add(this.setCellsLabel, 1, 0);
            this.statusLayoutPanel.Controls.Add(this.cursorCellLabel, 0, 0);
            this.statusLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLayoutPanel.Location = new System.Drawing.Point(0, 345);
            this.statusLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.statusLayoutPanel.Name = "statusLayoutPanel";
            this.statusLayoutPanel.RowCount = 1;
            this.statusLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusLayoutPanel.Size = new System.Drawing.Size(517, 24);
            this.statusLayoutPanel.TabIndex = 1;
            // 
            // cursorCellLabel
            // 
            this.cursorCellLabel.AutoSize = true;
            this.cursorCellLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cursorCellLabel.Location = new System.Drawing.Point(0, 2);
            this.cursorCellLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cursorCellLabel.Name = "cursorCellLabel";
            this.cursorCellLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.cursorCellLabel.Size = new System.Drawing.Size(170, 22);
            this.cursorCellLabel.TabIndex = 0;
            this.cursorCellLabel.Text = "Cursor on cell: (_, _)";
            this.cursorCellLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // setCellsLabel
            // 
            this.setCellsLabel.AutoSize = true;
            this.setCellsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setCellsLabel.Location = new System.Drawing.Point(170, 2);
            this.setCellsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.setCellsLabel.Name = "setCellsLabel";
            this.setCellsLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.setCellsLabel.Size = new System.Drawing.Size(170, 22);
            this.setCellsLabel.TabIndex = 1;
            this.setCellsLabel.Text = "Set cells: 0/0";
            this.setCellsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CCLabel.Location = new System.Drawing.Point(340, 0);
            this.CCLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.CCLabel.Size = new System.Drawing.Size(177, 24);
            this.CCLabel.TabIndex = 2;
            this.CCLabel.Text = "Connected components: 0";
            this.CCLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pixelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "pixelPanel";
            this.Size = new System.Drawing.Size(517, 369);
            this.panel1.ResumeLayout(false);
            this.statusLayoutPanel.ResumeLayout(false);
            this.statusLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cursorCellLabel;
        private System.Windows.Forms.TableLayoutPanel statusLayoutPanel;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.Label setCellsLabel;
    }
}
