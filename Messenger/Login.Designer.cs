namespace Messenger
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.customImageButton3 = new MyImageButton.CustomImageButton();
            this.customImageButton2 = new MyImageButton.CustomImageButton();
            this.userControl11 = new MyImageButton.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.BackColor = System.Drawing.Color.DodgerBlue;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.ForeColor = System.Drawing.Color.White;
            this.NameText.Location = new System.Drawing.Point(372, 274);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(205, 20);
            this.NameText.TabIndex = 1;
            this.NameText.TabStop = false;
            this.NameText.Text = "Login";
            this.NameText.Enter += new System.EventHandler(this.NameText_Enter);
            this.NameText.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.BackColor = System.Drawing.Color.DodgerBlue;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.ForeColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(372, 328);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(205, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Password";
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(372, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(372, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 1);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Next";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(372, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(330, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(329, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(866, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // customImageButton3
            // 
            this.customImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customImageButton3.Enabled = false;
            this.customImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton3.Image")));
            this.customImageButton3.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton3.ImageHover")));
            this.customImageButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton3.ImageNormal")));
            this.customImageButton3.Location = new System.Drawing.Point(924, -1);
            this.customImageButton3.Name = "customImageButton3";
            this.customImageButton3.Size = new System.Drawing.Size(23, 23);
            this.customImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton3.TabIndex = 18;
            this.customImageButton3.TabStop = false;
            this.customImageButton3.Visible = false;
            // 
            // customImageButton2
            // 
            this.customImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton2.Image")));
            this.customImageButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageHover")));
            this.customImageButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageNormal")));
            this.customImageButton2.Location = new System.Drawing.Point(924, -1);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(23, 23);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 17;
            this.customImageButton2.TabStop = false;
            this.customImageButton2.Click += new System.EventHandler(this.customImageButton2_Click_1);
            this.customImageButton2.MouseEnter += new System.EventHandler(this.customImageButton2_MouseEnter);
            this.customImageButton2.MouseLeave += new System.EventHandler(this.customImageButton2_MouseLeave);
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userControl11.Image = ((System.Drawing.Image)(resources.GetObject("userControl11.Image")));
            this.userControl11.ImageHover = ((System.Drawing.Image)(resources.GetObject("userControl11.ImageHover")));
            this.userControl11.ImageNormal = ((System.Drawing.Image)(resources.GetObject("userControl11.ImageNormal")));
            this.userControl11.Location = new System.Drawing.Point(895, -1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(23, 23);
            this.userControl11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userControl11.TabIndex = 7;
            this.userControl11.TabStop = false;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            this.userControl11.MouseEnter += new System.EventHandler(this.userControl11_MouseEnter);
            this.userControl11.MouseLeave += new System.EventHandler(this.userControl11_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 583);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.customImageButton3);
            this.Controls.Add(this.customImageButton2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hippo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Move += new System.EventHandler(this.Login_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyImageButton.UserControl1 userControl11;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MyImageButton.CustomImageButton customImageButton2;
        private MyImageButton.CustomImageButton customImageButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

