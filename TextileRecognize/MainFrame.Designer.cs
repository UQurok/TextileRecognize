namespace TextileRecognizer
{
    partial class MainFrame
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenImg = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMonochrome = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenImg
            // 
            this.buttonOpenImg.Location = new System.Drawing.Point(49, 12);
            this.buttonOpenImg.Name = "buttonOpenImg";
            this.buttonOpenImg.Size = new System.Drawing.Size(141, 23);
            this.buttonOpenImg.TabIndex = 0;
            this.buttonOpenImg.Text = "Загрузить изображение";
            this.buttonOpenImg.UseVisualStyleBackColor = true;
            this.buttonOpenImg.Click += new System.EventHandler(this.buttonOpenImg_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(49, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(274, 266);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(-2, 54);
            this.trackBar.Maximum = 255;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 266);
            this.trackBar.TabIndex = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Интенсивность монохромсти:";
            // 
            // labelMonochrome
            // 
            this.labelMonochrome.AutoSize = true;
            this.labelMonochrome.Location = new System.Drawing.Point(211, 38);
            this.labelMonochrome.Name = "labelMonochrome";
            this.labelMonochrome.Size = new System.Drawing.Size(13, 13);
            this.labelMonochrome.TabIndex = 4;
            this.labelMonochrome.Text = "0";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(248, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Расчет";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нитей основ:";
            // 
            // labelCountX
            // 
            this.labelCountX.AutoSize = true;
            this.labelCountX.Location = new System.Drawing.Point(328, 37);
            this.labelCountX.Name = "labelCountX";
            this.labelCountX.Size = new System.Drawing.Size(13, 13);
            this.labelCountX.TabIndex = 7;
            this.labelCountX.Text = "0";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 527);
            this.Controls.Add(this.labelCountX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelMonochrome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonOpenImg);
            this.Name = "MainFrame";
            this.Text = "ИВГПУ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenImg;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMonochrome;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountX;
    }
}

