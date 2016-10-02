using AForge.Imaging;
using AForge.Imaging.Filters;
using Config.TextileRecognizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextileRecognizer.Forms;

namespace TextileRecognizer
{
    static class TextileRecognize
    {
        private static MenuForm mf;
        private static MonochromeMatrix monochrMatrix;
        private static List<LineCoords> coordList= new List<LineCoords>();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainConfig.Initialize();

            mf = new MenuForm();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mf);
        }

        public static Bitmap CreateMonochrome(int P, Bitmap bmpImg)//ToDo: Через таск вызывать
        {
            ///Сжатие изображения до 1000px*1000px  если оно больше
            if ((bmpImg.Height > MainConfig.MaxImgHeight) || (bmpImg.Width > MainConfig.MaxImgWidth))
            {
                int compression = bmpImg.Height > bmpImg.Width ? bmpImg.Height / MainConfig.MaxImgHeight : bmpImg.Width / MainConfig.MaxImgWidth;
                bmpImg = new Bitmap(bmpImg, new Size(bmpImg.Width / compression, bmpImg.Height / compression));
            }

            Bitmap result = new Bitmap(bmpImg.Width, bmpImg.Height);
            Color color = new Color();
            monochrMatrix = new MonochromeMatrix(bmpImg.Width, bmpImg.Height);

            try
            {
                for (int j = 0; j < bmpImg.Height; j++)
                {
                    for (int i = 0; i < bmpImg.Width; i++)
                    {
                        color = bmpImg.GetPixel(i, j);
                        int K = ((color.R + color.G + color.B) / 3);
                        result.SetPixel(i, j, (K <= P ? Color.Black : Color.White));
                        monochrMatrix[i,j] =!(K <= P); //В матрице будет true = белому пикселю, т.е. части нити.
                    }
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //EuclideanColorFiltering filter = new EuclideanColorFiltering();
            //// set center colol and radius
            //filter.CenterColor = new RGB(220, 30, 30);
            //filter.Radius = 100;
            //// apply the filter
            //filter.ApplyInPlace(bmpImg);

            return result;
        }

        public static Bitmap Calculate(Bitmap bmpImg)//ToDo: coordList генерить в CreateMonochrome а тут работать с листом координат
        {
            /*           Color color;
                       bool isLine = false;
                       var pen = new Pen(Color.Red, 1.5f);
                       Graphics g = Graphics.FromImage(bmpImg);
                       //g.DrawLine(pen, i, 1, i, bmpImg.Height);
                       for (int j = 0; j < bmpImg.Height; j++)
                       {
                           int xStart = 0 ;
                           for (int i = 0; i < bmpImg.Width; i++)
                           {
                               color = bmpImg.GetPixel(i, j);
                               if (color.Equals(Color.FromArgb(255, 255, 255)))
                               {
                                   isLine = true;
                                   if (!isLine) xStart = i; 
                               }
                               else
                               {
                                   if (isLine)
                                   {

                                       coordList.Add(new LineCoords(xStart, j, i - 1, j));
                                       isLine = false;
                                   }
                               }
                           }
                           isLine = false;
                       }

                       //неверно
                       var countAtLine = from cl in coordList
                                   group cl by cl.y0 into gr
                                   select gr.Count();
                       var avgCount = countAtLine.Average(cal => cal);

                       mf.count = (int) avgCount;
                       return bmpImg;
              */
            return monochrMatrix.GetThreadBorder();
        }
    }
}
