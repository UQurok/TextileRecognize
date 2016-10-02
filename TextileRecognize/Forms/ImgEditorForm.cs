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

namespace TextileRecognizer.Forms
{
    public partial class ImgEditorForm : Form
    {
        private MenuForm menu;
        private Image image;
        private Bitmap originalBitImg;

        public ImgEditorForm(MenuForm mf, Image img)
        {           
            InitializeComponent(); 
            btnOk.Enabled = false;
            image = img;
            menu = mf;
            originalBitImg = new Bitmap(image);
            colorDialog.Color = btnColor.BackColor;
            textBoxColor.Text = String.Format("{0}, {1}, {2}", colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);


            if ((originalBitImg.Height > MainConfig.MaxImgHeight) || (originalBitImg.Width > MainConfig.MaxImgWidth))
            {
                int compression = originalBitImg.Height > originalBitImg.Width ? originalBitImg.Height / MainConfig.MaxImgHeight : originalBitImg.Width / MainConfig.MaxImgWidth;
                originalBitImg = new Bitmap(originalBitImg, new Size(originalBitImg.Width / compression, originalBitImg.Height / compression));
            }
            pictureBox.Image = originalBitImg;
            pictureBox.Height = pictureBox.Image.Height;
            pictureBox.Width = pictureBox.Image.Width;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Step2_Finish();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            rbtnConfigImg.Enabled = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                textBoxColor.Text = String.Format("{0}, {1}, {2}", colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            }
        }

        private void ImgEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void ImgEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Visible = true;
        }
    }
}
