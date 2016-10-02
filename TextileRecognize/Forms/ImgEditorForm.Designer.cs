namespace TextileRecognizer.Forms
{
    partial class ImgEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgEditorForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.rbtnConfigImg = new System.Windows.Forms.RadioButton();
            this.rbtnOriginalImg = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(315, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.textBoxColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Note);
            this.panel1.Controls.Add(this.groupBoxPreview);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 319);
            this.panel1.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColor.Location = new System.Drawing.Point(323, 122);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(35, 35);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColor.Enabled = false;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColor.Location = new System.Drawing.Point(144, 126);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(173, 24);
            this.textBoxColor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет материала:";
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Note.Location = new System.Drawing.Point(9, 36);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(380, 72);
            this.Note.TabIndex = 4;
            this.Note.Text = "Необходимо выбрать цвет материала и нажать кнопку предварительного просмотра. На " +
    "полученом изображении должно быть минимальное количество шума и нити должны быть" +
    " хорошо читаемы.";
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.rbtnConfigImg);
            this.groupBoxPreview.Controls.Add(this.rbtnOriginalImg);
            this.groupBoxPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPreview.Location = new System.Drawing.Point(15, 156);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(205, 80);
            this.groupBoxPreview.TabIndex = 3;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Изображение";
            // 
            // rbtnConfigImg
            // 
            this.rbtnConfigImg.AutoSize = true;
            this.rbtnConfigImg.Enabled = false;
            this.rbtnConfigImg.Location = new System.Drawing.Point(6, 51);
            this.rbtnConfigImg.Name = "rbtnConfigImg";
            this.rbtnConfigImg.Size = new System.Drawing.Size(118, 22);
            this.rbtnConfigImg.TabIndex = 1;
            this.rbtnConfigImg.Text = "Настроенное";
            this.rbtnConfigImg.UseVisualStyleBackColor = true;
            // 
            // rbtnOriginalImg
            // 
            this.rbtnOriginalImg.AutoSize = true;
            this.rbtnOriginalImg.Checked = true;
            this.rbtnOriginalImg.Location = new System.Drawing.Point(6, 23);
            this.rbtnOriginalImg.Name = "rbtnOriginalImg";
            this.rbtnOriginalImg.Size = new System.Drawing.Size(126, 22);
            this.rbtnOriginalImg.TabIndex = 0;
            this.rbtnOriginalImg.TabStop = true;
            this.rbtnOriginalImg.Text = "Оригинальное";
            this.rbtnOriginalImg.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPreview.Location = new System.Drawing.Point(3, 280);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(297, 33);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Предварительный просмотр";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(8, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(350, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "Настройка параметров изображения:";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(406, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 320);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // ImgEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 327);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 365);
            this.Name = "ImgEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки параметров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImgEditorForm_FormClosed);
            this.Load += new System.EventHandler(this.ImgEditorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.RadioButton rbtnConfigImg;
        private System.Windows.Forms.RadioButton rbtnOriginalImg;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
    }
}