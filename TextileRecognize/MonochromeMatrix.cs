using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextileRecognizer
{
    class MonochromeMatrix
    {
        private bool[,] matrix;
        private int xMax, yMax;

        public MonochromeMatrix(int x, int y)
        {
            xMax = x;
            yMax = y;
            matrix = new bool[xMax,yMax];
        }

        public bool this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        public bool[] GetRow(int rowId)
        {
            bool[] row = new bool[xMax];
            if (rowId < yMax)
            {
                for (int i = 0; i < xMax; i++)
                {
                    row[i] = this[i, rowId];
                }
            }
            return row;
        }
        public bool[] GetColumn(int columnId)
        {
            bool[] column = new bool[yMax];
            if (columnId < xMax)
            {
                for (int i = 0; i < yMax; i++)
                {
                    column[i] = this[columnId, i];
                }
            }
            return column;
        }

        private void SetRow(int rowId, bool[] row)
        {
            if ((rowId < yMax) && (row.Length == xMax))
            {
                for (int i = 0; i < xMax; i++)
                {
                    this[i, rowId] = row[i];
                }
            }
        }
        private void SetColumn(int columnId, bool[] column)
        {
            if ((columnId < xMax) && (column.Length == yMax))
            {
                for (int i = 0; i < yMax; i++)
                {
                    this[columnId, i] = column[i];
                }
            }
        }

        public int GetCountOfWarpGroup(int rowId)
        {
            int count = 0;
            if (rowId<yMax){
                bool group = false;

                for (int i = 0; i < xMax; i++)
                {
                    if (this[i, rowId])
                    {
                        if (!group) 
                        { 
                            group= true ;
                        }
                    }
                    else 
                    {
                        if (group)
                        {
                            group = false;
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public int GetCountOfWeftGroup(int columnId)
        {            
            int count = 0;
            if (columnId < xMax)
            {
                bool group = false;

                for (int i = 0; i < yMax; i++)
                {
                    if (this[columnId, i])
                    {
                        if (!group)
                        {
                            group = true;
                        }
                    }
                    else
                    {
                        if (group)
                        {
                            group = false;
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public Bitmap CreateImg()
        {
            Bitmap img = new Bitmap(xMax, yMax);
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {                   
                    img.SetPixel(i, j, (this[i,j] ? Color.White : Color.Black));
                }
            }
            return img;
        }

        public MonochromeMatrix GetWarpThread()
        {
            MonochromeMatrix mMatrix = new MonochromeMatrix(xMax, yMax);
            for (int column = 0; column < this.xMax; column++)
            {
                int count = this.GetCountOfWeftGroup(column);
                Console.WriteLine(column + "  -  " + count);
                if (count <= 8)
                {
                    mMatrix.SetColumn(column, this.GetColumn(column));
                }
            }
            return mMatrix;
        }
        public Bitmap GetThreadBorder()
        {
            Bitmap result = new Bitmap(xMax, yMax);
            bool group = false;
            int k0, k1;
            k0 = 0;
            k1 = 0;
            for (int x = 0; x < this.xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    result.SetPixel(x, y, Color.Black);
                    if (this[x, y])
                    {
                        if (!group)
                        {
                            k0 = y;
                            group = true;
                        }
                    }
                    else
                    {
                        if (group)
                        {
                            group = false;
                            k1 = y;
                            result.SetPixel(x, y-(k1-k0)/2, Color.Red);
                        }
                    }
                    
                }
            }
            group = false;
            for (int y = 0; y < yMax; y++)            
            {
                for (int x = 0; x < this.xMax; x++)
                {
                    if (this[x, y])
                    {
                        if (!group)
                        {
                            k0 = x;
                            group = true;
                        }
                    }
                    else
                    {
                        if (group)
                        {
                            group = false;
                            k1 = x;
                            result.SetPixel(x - (k1 - k0) / 2, y, Color.Red);
                        }
                    }
                    
                }
            }

            return result;
        }

    }
}
