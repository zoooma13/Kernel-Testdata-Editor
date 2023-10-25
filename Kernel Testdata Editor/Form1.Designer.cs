namespace Kernel_Testdata_Editor
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.showBordersCheckbox = new System.Windows.Forms.CheckBox();
            this.borderSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.cellSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.gridSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.updateButton = new System.Windows.Forms.Button();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.borderSizeLabel = new System.Windows.Forms.Label();
            this.cellSizeLabel = new System.Windows.Forms.Label();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorCCButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.importButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pixelPanel1 = new Kernel_Testdata_Editor.pixelPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeNumeric)).BeginInit();
            this.editGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pixelPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.viewGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.editGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.fileGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(547, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 502);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.showBordersCheckbox);
            this.viewGroupBox.Controls.Add(this.borderSizeNumeric);
            this.viewGroupBox.Controls.Add(this.cellSizeNumeric);
            this.viewGroupBox.Controls.Add(this.gridSizeNumeric);
            this.viewGroupBox.Controls.Add(this.updateButton);
            this.viewGroupBox.Controls.Add(this.gridSizeLabel);
            this.viewGroupBox.Controls.Add(this.borderSizeLabel);
            this.viewGroupBox.Controls.Add(this.cellSizeLabel);
            this.viewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(180, 178);
            this.viewGroupBox.TabIndex = 0;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            // 
            // showBordersCheckbox
            // 
            this.showBordersCheckbox.AutoSize = true;
            this.showBordersCheckbox.Checked = true;
            this.showBordersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBordersCheckbox.Location = new System.Drawing.Point(10, 107);
            this.showBordersCheckbox.Name = "showBordersCheckbox";
            this.showBordersCheckbox.Size = new System.Drawing.Size(118, 21);
            this.showBordersCheckbox.TabIndex = 4;
            this.showBordersCheckbox.Text = "Show Borders";
            this.showBordersCheckbox.UseVisualStyleBackColor = true;
            // 
            // borderSizeNumeric
            // 
            this.borderSizeNumeric.Location = new System.Drawing.Point(98, 77);
            this.borderSizeNumeric.Name = "borderSizeNumeric";
            this.borderSizeNumeric.Size = new System.Drawing.Size(75, 22);
            this.borderSizeNumeric.TabIndex = 3;
            this.borderSizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cellSizeNumeric
            // 
            this.cellSizeNumeric.Location = new System.Drawing.Point(98, 49);
            this.cellSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cellSizeNumeric.Name = "cellSizeNumeric";
            this.cellSizeNumeric.Size = new System.Drawing.Size(75, 22);
            this.cellSizeNumeric.TabIndex = 2;
            this.cellSizeNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // gridSizeNumeric
            // 
            this.gridSizeNumeric.Location = new System.Drawing.Point(98, 21);
            this.gridSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridSizeNumeric.Name = "gridSizeNumeric";
            this.gridSizeNumeric.Size = new System.Drawing.Size(75, 22);
            this.gridSizeNumeric.TabIndex = 1;
            this.gridSizeNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(10, 134);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(163, 32);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSizeLabel.Location = new System.Drawing.Point(7, 23);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(70, 17);
            this.gridSizeLabel.TabIndex = 4;
            this.gridSizeLabel.Text = "Grid SIze:";
            // 
            // borderSizeLabel
            // 
            this.borderSizeLabel.AutoSize = true;
            this.borderSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderSizeLabel.Location = new System.Drawing.Point(7, 79);
            this.borderSizeLabel.Name = "borderSizeLabel";
            this.borderSizeLabel.Size = new System.Drawing.Size(86, 17);
            this.borderSizeLabel.TabIndex = 1;
            this.borderSizeLabel.Text = "Border Size:";
            // 
            // cellSizeLabel
            // 
            this.cellSizeLabel.AutoSize = true;
            this.cellSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellSizeLabel.Location = new System.Drawing.Point(7, 51);
            this.cellSizeLabel.Name = "cellSizeLabel";
            this.cellSizeLabel.Size = new System.Drawing.Size(66, 17);
            this.cellSizeLabel.TabIndex = 0;
            this.cellSizeLabel.Text = "Cell Size:";
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.button5);
            this.editGroupBox.Controls.Add(this.button4);
            this.editGroupBox.Controls.Add(this.clearButton);
            this.editGroupBox.Controls.Add(this.colorCCButton);
            this.editGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupBox.Location = new System.Drawing.Point(3, 187);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(180, 141);
            this.editGroupBox.TabIndex = 10;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(10, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Write";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(93, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Erase";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(10, 59);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 32);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorCCButton
            // 
            this.colorCCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCCButton.Location = new System.Drawing.Point(10, 97);
            this.colorCCButton.Name = "colorCCButton";
            this.colorCCButton.Size = new System.Drawing.Size(163, 32);
            this.colorCCButton.TabIndex = 9;
            this.colorCCButton.Text = "Color CCs";
            this.colorCCButton.UseVisualStyleBackColor = true;
            this.colorCCButton.Click += new System.EventHandler(this.colorCCButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.importButton);
            this.fileGroupBox.Controls.Add(this.button7);
            this.fileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileGroupBox.Location = new System.Drawing.Point(3, 334);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(180, 102);
            this.fileGroupBox.TabIndex = 12;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "File";
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(10, 20);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(163, 32);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(10, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 32);
            this.button7.TabIndex = 11;
            this.button7.Text = "Export";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // pixelPanel1
            // 
            this.pixelPanel1.BackColor = System.Drawing.Color.White;
            this.pixelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelPanel1.Location = new System.Drawing.Point(0, 0);
            this.pixelPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.pixelPanel1.Name = "pixelPanel1";
            this.pixelPanel1.Size = new System.Drawing.Size(547, 502);
            this.pixelPanel1.TabIndex = 12;
            this.pixelPanel1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kernel Testdata Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeNumeric)).EndInit();
            this.editGroupBox.ResumeLayout(false);
            this.fileGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.Label borderSizeLabel;
        private System.Windows.Forms.Label cellSizeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.NumericUpDown borderSizeNumeric;
        private System.Windows.Forms.NumericUpDown cellSizeNumeric;
        private System.Windows.Forms.NumericUpDown gridSizeNumeric;
        private pixelPanel pixelPanel1;
        private System.Windows.Forms.Button colorCCButton;
        private System.Windows.Forms.CheckBox showBordersCheckbox;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button button7;
    }
}

