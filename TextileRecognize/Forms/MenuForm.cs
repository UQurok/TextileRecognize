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
    public partial class MenuForm : Form
    {
        private Image image;
        public MenuForm()
        {
            InitializeComponent();
            DefaultInit();
        }

        private void DefaultInit()
        {
            this.Visible = true;
            image = null;

            Ok1.Visible = false;
            Ok2.Visible = false;
            Ok3.Visible = false;

            Step1.Enabled = true;
            Step1.Cursor = Cursors.Hand;
            Step1.ForeColor = SystemColors.ControlText;  

            Step2.Enabled = false;
            Step2.Cursor = Cursors.Arrow;
            Step2.ForeColor = SystemColors.ControlLight;

            Step3.Enabled = false;
            Step3.Cursor = Cursors.Arrow;
            Step3.ForeColor = SystemColors.ControlLight;  

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новый протокол?", "Сброс данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DefaultInit();
            } 
            
        }

        private void Step1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.PNG)|*.bmp;*.jpg;*.gif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dialog.FileName);

                Ok1.Visible = true;
                Step1.Enabled = false;                
                Step1.Cursor = Cursors.Arrow;
                Step1.ForeColor = SystemColors.ControlLight; 

                Step2.Enabled = true;
                Step2.Cursor = Cursors.Hand;
                Step2.ForeColor = SystemColors.ControlText;       
            }
        }

        private void Step2_Click(object sender, EventArgs e)
        {
            ImgEditorForm ief = new ImgEditorForm(this, image);
            this.Visible = false;
            ief.Show();
        }
        public void Step2_Finish()
        {
            Ok2.Visible = true;
            Step2.Enabled = false;
            Step2.Cursor = Cursors.Arrow;
            Step2.ForeColor = SystemColors.ControlLight;

            Step3.Enabled = true;
            Step3.Cursor = Cursors.Hand;
            Step3.ForeColor = SystemColors.ControlText;     

            this.Visible = true;
        }

        private void Step3_Click(object sender, EventArgs e)
        {
            //TODO: Implement this method.
            
                ColorDialog MyDialog = new ColorDialog();                
                MyDialog.AllowFullOpen = true;                    
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    Console.WriteLine(MyDialog.Color);
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }      
        }
    }
}
