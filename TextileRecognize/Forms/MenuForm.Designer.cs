namespace TextileRecognizer.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Ok1 = new System.Windows.Forms.Label();
            this.Ok2 = new System.Windows.Forms.Label();
            this.Ok3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Step1 = new System.Windows.Forms.Label();
            this.Step2 = new System.Windows.Forms.Label();
            this.Step3 = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ok1
            // 
            this.Ok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ok1.Location = new System.Drawing.Point(9, 54);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(33, 23);
            this.Ok1.TabIndex = 0;
            this.Ok1.Text = "✓";
            this.Ok1.Visible = false;
            // 
            // Ok2
            // 
            this.Ok2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ok2.Location = new System.Drawing.Point(9, 87);
            this.Ok2.Name = "Ok2";
            this.Ok2.Size = new System.Drawing.Size(33, 25);
            this.Ok2.TabIndex = 1;
            this.Ok2.Text = "✓";
            this.Ok2.Visible = false;
            // 
            // Ok3
            // 
            this.Ok3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ok3.Location = new System.Drawing.Point(9, 122);
            this.Ok3.Name = "Ok3";
            this.Ok3.Size = new System.Drawing.Size(33, 25);
            this.Ok3.TabIndex = 2;
            this.Ok3.Text = "✓";
            this.Ok3.Visible = false;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(9, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(470, 45);
            this.Title.TabIndex = 3;
            this.Title.Text = "Меню";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Step1
            // 
            this.Step1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step1.Location = new System.Drawing.Point(48, 54);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(431, 23);
            this.Step1.TabIndex = 4;
            this.Step1.Text = "1. Загрузить изображение.";
            this.Step1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Step1.Click += new System.EventHandler(this.Step1_Click);
            // 
            // Step2
            // 
            this.Step2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step2.Enabled = false;
            this.Step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Step2.Location = new System.Drawing.Point(48, 87);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(437, 25);
            this.Step2.TabIndex = 5;
            this.Step2.Text = "2. Настроить параметры распознавания нитей.";
            this.Step2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Step2.Click += new System.EventHandler(this.Step2_Click);
            // 
            // Step3
            // 
            this.Step3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step3.Enabled = false;
            this.Step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Step3.Location = new System.Drawing.Point(48, 122);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(437, 25);
            this.Step3.TabIndex = 6;
            this.Step3.Text = "3. Сформировать протокол.";
            this.Step3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Step3.Click += new System.EventHandler(this.Step3_Click);
            // 
            // Reload
            // 
            this.Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reload.Location = new System.Drawing.Point(9, 208);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(170, 35);
            this.Reload.TabIndex = 7;
            this.Reload.Text = "Новый протокол";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(374, 208);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 35);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 252);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Ok3);
            this.Controls.Add(this.Ok2);
            this.Controls.Add(this.Ok1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Геотекстиль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ok1;
        private System.Windows.Forms.Label Ok2;
        private System.Windows.Forms.Label Ok3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Step1;
        private System.Windows.Forms.Label Step2;
        private System.Windows.Forms.Label Step3;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Exit;
    }
}