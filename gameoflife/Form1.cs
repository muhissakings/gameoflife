using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameoflife
{
    public partial class gameoflifemain : Form
    {
        public gameoflifemain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameoflifemain_Load(object sender, EventArgs e)
        {

            createGridSurface();
        }

        private void createGridSurface()
        {
            Point locPoint;
            Cell newCell;
            Random random = new Random();

            int rows = (int)(pbGrid.Height / numSSize.Value);
            int cols = (int)(pbGrid.Height/numSSize.Value);


            using (Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.DarkOrange))
            {
                g.Clear(Color.Black);
                pbGrid.Image = (Bitmap)bmp;

                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        locPoint = new Point((int)(x * numSSize.Value), (int)(y * numSSize.Value));
                        newCell = new Cell(Location, x, y);
                        newCell.IsAlive = (random.Next(100) < 15) ? true : false;
                        Cell.gridCells.Add(newCell);
                    }
                }

                        //plot all the nemly created cells to the grid
                        foreach(Cell cell in Cell.gridCells)
                        {
                            if (cell.IsAlive)
                            {
                                g.FillRectangle(cellBrush, new Rectangle(cell.Location, 
                                    new Size((int)numSSize.Value - 1, (int)numSSize.Value-1)));
                            }
                        }
                        pbGrid.Image = (Bitmap)bmp.Clone();
                    }
                }

        private void btnRest_Click(object sender, EventArgs e)
        {
            createGridSurface();
        }
    }
        }
    

    public class Cell
    {
        public static List<Cell> gridCells = new List<Cell>();
        private Point cLocation;
        private int cXPos;
        private int cYPos;
        private Boolean cIsAlive;

        public Cell(Point location, int X, int Y)
        {
            this.Location = location;
        }

        public Point Location
        {
            get { return cLocation; }
            set { cLocation = value; }
        }
        public int XPos
        {
            get { return cXPos; }
            set { cXPos = value; }
        }
        public int YPos
        {
            get { return cYPos; }
            set { cYPos = value; }
        }
        public Boolean IsAlive
        {
            get { return cIsAlive; }
            set { cIsAlive = value; }
        }
    }


