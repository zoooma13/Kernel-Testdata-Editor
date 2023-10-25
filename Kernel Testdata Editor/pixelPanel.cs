using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Kernel_Testdata_Editor
{
    public partial class pixelPanel : UserControl
    {
        int gridSize;
        int cellSize;
        int borderSize;
        int marginSize;
        bool showBorders;

        bool[,] grid;
        Bitmap gridImage = new Bitmap(1 ,1);
        Bitmap borderImage = new Bitmap(1, 1);
        
        Color brushColor = Color.Black;
        Color borderColor = Color.FromArgb(65, 65, 80);

        int connCompsCount;
        int setCellsCount;

        int[] dx = { +1, 0, -1, 0 };
        int[] dy = { 0, +1, 0, -1 };

        public pixelPanel()
        {
            InitializeComponent();
        }

        public void updateDimensions(int gridSize, int cellSize, int borderSize, int marginSize, bool showBorders, bool[,] newGrid)
        {
            if (newGrid == null)
            {
                newGrid = new bool[gridSize, gridSize];
                for (int i = 0; i < Math.Min(gridSize, this.gridSize); i++)
                    for (int j = 0; j < Math.Min(gridSize, this.gridSize); j++)
                        newGrid[i, j] = grid[i, j];
            }

            this.grid = newGrid;
            this.gridSize = gridSize;
            this.cellSize = cellSize;
            this.borderSize = borderSize;
            this.marginSize = marginSize;
            this.showBorders = showBorders;

            int panelLength = gridSize * cellSize + (gridSize + 1) * borderSize + 2 * marginSize;
            gridImage.Dispose();
            borderImage.Dispose();
            gridImage = new Bitmap(panelLength, panelLength);
            borderImage = new Bitmap(panelLength, panelLength);
            using (Graphics b = Graphics.FromImage(borderImage))
            {
                int borderLength = gridSize * cellSize + (gridSize + 1) * borderSize;
                for (int i = marginSize, j = 0; j < gridSize + 1; i += cellSize + borderSize, j++)
                    b.DrawLine(new Pen(borderColor, borderSize), new Point(marginSize - borderSize / 2, i), new Point(marginSize - (borderSize + 1) / 2 + borderLength, i));
                for (int i = marginSize, j = 0; j < gridSize + 1; i += cellSize + borderSize, j++)
                    b.DrawLine(new Pen(borderColor, borderSize), new Point(i, marginSize - borderSize / 2), new Point(i, marginSize - (borderSize + 1) / 2 + borderLength));
            }

            this.Refresh();
            colorConnectedComponents();
            updateSetCells();
            updateStatusBar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (showBorders && borderSize != 0)
                e.Graphics.DrawImage(borderImage, Point.Empty);
            e.Graphics.DrawImage(gridImage, Point.Empty);
            Console.WriteLine("REPAINTING");
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = getCell(panel1.PointToClient(Cursor.Position));
            setGridPixel(point.X, point.Y, brushColor);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = getCell(panel1.PointToClient(Cursor.Position));
            if (Control.MouseButtons == MouseButtons.Left)
                setGridPixel(point.X, point.Y, brushColor);
            updateStatusBar();
        }

        private Point getCell(Point p)
        {
            if (p.X < marginSize || p.Y < marginSize)
                return new Point(-1, -1);
            Point r = new Point(p.X - marginSize, p.Y - marginSize);
            if (r.X % (cellSize + borderSize) < borderSize / 2 || r.X % (cellSize + borderSize) > cellSize + borderSize / 2)
                return new Point(-1, -1);
            if (r.Y % (cellSize + borderSize) < borderSize / 2 || r.Y % (cellSize + borderSize) > cellSize + borderSize / 2)
                return new Point(-1, -1);
            r.X /= (cellSize + borderSize);
            r.Y /= (cellSize + borderSize);
            if (r.X >= gridSize || r.Y >= gridSize)
                return new Point(-1, -1);
            return r;
        }

        private void updateSetCells()
        {
            setCellsCount = 0;
            for (int i = 0; i < gridSize; i++)
                for (int j = 0; j < gridSize; j++)
                    setCellsCount += grid[i, j] ? 1 : 0;
        }

        private void setGridCell(int X ,int Y ,Color cellColor)
        {
            if (grid[Y, X] != (cellColor != Color.White))
                setCellsCount += (cellColor != Color.White? +1 : -1);
            grid[Y, X] = (cellColor != Color.White);
        }
        
        private Rectangle getCellRectangle(int X, int Y)
        {
            return new Rectangle(new Point(X * (cellSize + borderSize) + (borderSize + 1) / 2 + marginSize, Y * (cellSize + borderSize) + (borderSize + 1) / 2 + marginSize), new Size(cellSize, cellSize)); ;
        }

        private void setGridPixel(int X, int Y, Color cellColor)
        {
            if (!isValidCell(X, Y))
                return;
            using (Graphics gfx = panel1.CreateGraphics())
            using (Graphics gfc = Graphics.FromImage(gridImage))
            {
                gfx.FillRectangle(new SolidBrush(cellColor), getCellRectangle(X ,Y));
                gfc.FillRectangle(new SolidBrush(cellColor), getCellRectangle(X, Y));
                setGridCell(X, Y, cellColor);
            }
        }

        private bool isValidCell(int X, int Y)
        {
            return 0 <= X && X < gridSize && 0 <= Y && Y < gridSize;
        }

        public void colorConnectedComponents()
        {
            Random rnd = new Random();
            connCompsCount = 0;

            bool[,] visGrid = new bool[gridSize, gridSize];
            Graphics gfx = panel1.CreateGraphics();
            Graphics gfc = Graphics.FromImage(gridImage);
            
            for (int i = 0; i < gridSize; i++)
                for (int j = 0; j < gridSize; j++)
                    if (grid[i, j] && !visGrid[i, j])
                    {
                        connCompsCount++;
                        Color cellColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                        Queue<Point> q = new Queue<Point>();
                        q.Enqueue(new Point(j ,i));
                        visGrid[i, j] = true;
                        while (q.Count > 0)
                        {
                            int x = q.Peek().X;
                            int y = q.Peek().Y;
                            q.Dequeue();
                            gfx.FillRectangle(new SolidBrush(cellColor), getCellRectangle(x, y));
                            gfc.FillRectangle(new SolidBrush(cellColor), getCellRectangle(x, y));
                            setGridCell(x, y, cellColor);
                            for (int d = 0; d < 4; d++)
                                if (isValidCell(x + dx[d], y + dy[d]) && !visGrid[y + dy[d], x + dx[d]] && grid[y + dy[d], x + dx[d]])
                                {
                                    q.Enqueue(new Point(x + dx[d], y + dy[d]));
                                    visGrid[y + dy[d], x + dx[d]] = true;
                                }
                        }
                    }

            gfx.Dispose();
            gfc.Dispose();
            updateStatusBar();
        }

        public void write()
        {
            brushColor = Color.Black;
        }

        public void erase()
        {
            brushColor = Color.White;
        }

        public void clear()
        {
            int panelLength = gridSize * cellSize + (gridSize + 1) * borderSize + 2 * marginSize;
            gridImage.Dispose();
            gridImage = new Bitmap(panelLength, panelLength);
            this.Refresh();
            for (int i = 0; i < gridSize; i++)
                for (int j = 0; j < gridSize; j++)
                    grid[i, j] = false;
            setCellsCount = 0;
            connCompsCount = 0;
            updateStatusBar();
        }

        public bool[,] export()
        {
            return grid;
        }

        private void updateStatusBar()
        {
            Point point = getCell(panel1.PointToClient(Cursor.Position));
            String px = point.X == -1 ? "_" : point.X.ToString();
            String py = point.Y == -1 ? "_" : point.Y.ToString();
            cursorCellLabel.Text = String.Format("Cursor on cell: ({0}, {1})", py, px);
            setCellsLabel.Text = "Set cells: " + setCellsCount + "/" + (gridSize*gridSize);
            CCLabel.Text = "Connected components: " + connCompsCount;
        }
    }
}
