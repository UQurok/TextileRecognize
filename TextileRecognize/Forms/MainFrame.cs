using AForge.Imaging.Filters;
using Config.TextileRecognizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextileRecognizer
{
    public partial class MainFrame : Form
    {
        private Image image;
        private Bitmap originalImg;
        private Bitmap monochromeImg;
        private int monochrome = 0;
        public int count { get; set; }

        public MainFrame()
        {
            InitializeComponent();
            labelMonochrome.Text = monochrome.ToString();
            label1.Visible = false;
            labelMonochrome.Visible = false;
            trackBar.Visible = false;
        }

        private void buttonOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dialog.FileName);
                originalImg = new Bitmap(image);
                if ((originalImg.Height > MainConfig.MaxImgHeight) || (originalImg.Width > MainConfig.MaxImgWidth))
                {
                    int compression = originalImg.Height > originalImg.Width ? originalImg.Height / MainConfig.MaxImgHeight : originalImg.Width / MainConfig.MaxImgWidth;
                    originalImg = new Bitmap(originalImg, new Size(originalImg.Width / compression, originalImg.Height / compression));
                }
                pictureBox.Image = originalImg;
                pictureBox.Height = pictureBox.Image.Height; 
                pictureBox.Width = pictureBox.Image.Width;                

                label1.Visible = true;
                labelMonochrome.Visible = true;
                trackBar.Visible = true;
                trackBar.Enabled = true;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            monochrome = trackBar.Value;
            labelMonochrome.Text = monochrome.ToString();
            monochromeImg = TextileRecognize.CreateMonochrome(monochrome, originalImg);
            pictureBox.Image = monochromeImg;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            pictureBox.Image = TextileRecognize.Calculate(monochromeImg);
            labelCountX.Text = count.ToString();
        }

        
    }
}
