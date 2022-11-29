using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MazeSolverActivity
{
    public partial class MazeSolverFrame : Form
    {
        private MazeSolver maze; // [17,22]
        private Graphics g;
        private int eX = 5;
        private int eY = 5;
        private RectangleF objEllipse;
        public MazeSolverFrame()
        {
            InitializeComponent();

            maze = MazeSolver.Instance;
            objEllipse = new RectangleF(eX, eY, 15, 15);
            pathShow(false);
        }

        private void pictureMaze_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            Block[,] block = maze.BlockList;

            int rowCount = MazeSolver.BLOCKS_ROW;
            int colCount = MazeSolver.BLOCKS_COLUMN;

            for (int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < colCount; j++)
                {
                    Block b = block[i, j];
                    g.DrawRectangle(MazeSolver.SQUARE_CORNER, b.SquareBlock);
                    if (b.IsWall)
                    {
                        Rectangle rect = new Rectangle(b.SquareBlock.X + 1, b.SquareBlock.Y + 1, b.SquareBlock.Width-1, b.SquareBlock.Height-1);
                        g.FillRectangle(Brushes.DarkGray, rect);
                    }
                    else if (b.BlockColor != null)
                    {
                        Rectangle rect = new Rectangle(b.SquareBlock.X + 1, b.SquareBlock.Y + 1, b.SquareBlock.Width-1, b.SquareBlock.Height-1);
                        g.FillRectangle(b.BlockColor,rect);
                    }

                }
            }

            g.FillEllipse(Brushes.Blue, objEllipse);
        }
       
        private Block destBlock;
        private Queue<Block> queuePath;
        private bool traversing = false;
        private void pictureMaze_MouseMove(object sender, MouseEventArgs e)
        {
        
            if (!traversing)
            {
                SearchAlgorithm sa = new SearchAlgorithm();
                destBlock = sa.GetBlockPointedByCursor(maze.BlockList, new Point(e.X, e.Y));
                if (destBlock != null)
                {
                    lblDestPoint.Text = destBlock.ToString();
                    ClearVisited();

                    if (radioFindPath.Checked)
                    {
                        queuePath = sa.Traverse(maze.BlockList, destBlock, chkDiagonal.Checked);
                        pathShow(true);
                    }
                }
                else
                {
                    lblDestPoint.Text = "-,-";
                }


                pictureMaze.Refresh();
            }
        }

        private void pictureMaze_MouseUp(object sender, MouseEventArgs e)
        {
            Point location = new Point(e.X, e.Y);

            if (radioDrawWall.Checked)
            {
                pathShow(false);
                Block[,] blocks = maze.BlockList;
                if (radioDrawWall.Checked)
                {
                    int rowCount = MazeSolver.BLOCKS_ROW;
                    int colCount = MazeSolver.BLOCKS_COLUMN;
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; ++j)
                        {
                            Block b = blocks[i, j];
                            Rectangle r = b.SquareBlock;
                            if (r.Contains(location.X, location.Y) && !b.IsCurrentPosition)
                            {
                                b.IsWall = !b.IsWall;
                                break;
                            }
                        }
                    }
                }

            }
            else if(radioFindPath.Checked)
            {
                pathShow(true);
                ClearVisited();
                objectTimer.Start();
            }
            pictureMaze.Refresh();

        }

        private void btnClearWalls_Click(object sender, EventArgs e)
        {
            Clear();
            pictureMaze.Refresh();
        }

        private void Clear()
        {
            Block[,] blocks = maze.BlockList;

            for (int i = 0; i < MazeSolver.BLOCKS_ROW; i++)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_COLUMN; j++)
                {
                    blocks[i,j].IsWall = false;
                }
            }
        }

        private void ClearVisited()
        {
            Block[,] blocks = maze.BlockList;

            for (int i = 0; i < MazeSolver.BLOCKS_ROW; i++)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_COLUMN; j++)
                {
                    blocks[i,j].IsVisited = false;
                    blocks[i,j].BlockColor = null;
                }
            }
        }

        Block b;

        private void objectTimer_Tick(object sender, EventArgs e)
        {
            traversing = true;
            while (queuePath.Count != 0)
            {
                b = queuePath.Dequeue();
                b.BlockColor = null;
                b.IsCurrentPosition = false;
                runnerXObject.Enabled = true;

                Invoke((MethodInvoker)delegate {
                    pictureMaze.Refresh();
                });

                if (queuePath.Count == 0)
                {
                    b.IsCurrentPosition = true;
                    objEllipse.X = b.ID.X * 25 + 5;
                    objEllipse.Y = b.ID.Y * 25 + 5;
                }
                runnerXObject.Stop();

            }
            traversing = false;
            objectTimer.Stop();
            pictureMaze.Invalidate();
        }

        private void runnerObject_Tick(object sender, EventArgs e)
        {
            int endX = b.ID.X * 25;
            int i = endX;
            if(i < endX + 25)
            objEllipse.X = b.ID.X + 1;

        }

        void pathShow(bool show)
        {
            if (!show)
            {
                lblDestPoint.Visible = false;
                lblCurrentPosition.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                lblDestPoint.Visible = true;
                lblCurrentPosition.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }
    }
}
