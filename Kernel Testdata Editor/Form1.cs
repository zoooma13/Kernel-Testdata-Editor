using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kernel_Testdata_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            updateFormSize(null);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateFormSize(null);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Blue;
            button4.ForeColor = SystemColors.ControlText;
            pixelPanel1.write();
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Blue;
            button5.ForeColor = SystemColors.ControlText;
            pixelPanel1.erase();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pixelPanel1.clear();
        }

        private void colorCCButton_Click(object sender, EventArgs e)
        {
            pixelPanel1.colorConnectedComponents();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "input files (*.in)|*.in|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
                else
                    return;
            }

            int n = 1;
            bool[,] readGrid = new bool[n, n];
            try
            {
                using (StreamReader readText = new StreamReader(filePath))
                {
                    n = int.Parse(readText.ReadLine());
                    readGrid = new bool[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        string row = readText.ReadLine();
                        for (int j = 0; j < n; j++)
                            readGrid[i, j] = row[j] == '1';
                    }
                }
            }
            catch
            {
                MessageBox.Show("Couldn't read file properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gridSizeNumeric.Value = n;
            updateFormSize(readGrid);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            bool[,] grid = pixelPanel1.export();
            int n = grid.GetLength(0);
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    saveFileDialog.Filter = "input files (*.in)|*.in|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream stream = saveFileDialog.OpenFile())
                        using (StreamWriter writeText = new StreamWriter(stream))
                        {
                            writeText.WriteLine(n);
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                    writeText.Write(grid[i, j] == true ? 1 : 0);
                                writeText.WriteLine();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Couldn't save file properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void updateFormSize(bool[,] newGrid)
        {
            int gridSize = int.Parse(gridSizeNumeric.Text);
            int cellSize = int.Parse(cellSizeNumeric.Text);
            int borderSize = int.Parse(borderSizeNumeric.Text);
            int marginSize = 10;
            bool showBorders = showBordersCheckbox.Checked;
            int panelLength = gridSize * cellSize + (gridSize + 1) * borderSize + 2 * marginSize;
            panelLength = Math.Max(panelLength, 400);
            this.Size = new Size(this.Size.Width - pixelPanel1.Width + panelLength, 10 + this.Size.Height - pixelPanel1.Height + panelLength);
            Application.DoEvents();
            pixelPanel1.updateDimensions(gridSize, cellSize, borderSize, marginSize, showBorders, newGrid);
        }
    }
}
