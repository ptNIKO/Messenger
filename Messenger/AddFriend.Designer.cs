namespace Messenger
{
    partial class AddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriend));
            this.customImageButton3 = new MyImageButton.CustomImageButton();
            this.customImageButton2 = new MyImageButton.CustomImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.placeHolder2 = new Messenger.PlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customImageButton3
            // 
            this.customImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customImageButton3.Enabled = false;
            this.customImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton3.Image")));
            this.customImageButton3.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton3.ImageHover")));
            this.customImageButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton3.ImageNormal")));
            this.customImageButton3.Location = new System.Drawing.Point(378, 1);
            this.customImageButton3.Name = "customImageButton3";
            this.customImageButton3.Size = new System.Drawing.Size(23, 23);
            this.customImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton3.TabIndex = 19;
            this.customImageButton3.TabStop = false;
            this.customImageButton3.Visible = false;
            // 
            // customImageButton2
            // 
            this.customImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton2.Image")));
            this.customImageButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageHover")));
            this.customImageButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageNormal")));
            this.customImageButton2.Location = new System.Drawing.Point(378, 1);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(23, 23);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 20;
            this.customImageButton2.TabStop = false;
            this.customImageButton2.Click += new System.EventHandler(this.customImageButton2_Click);
            this.customImageButton2.MouseEnter += new System.EventHandler(this.customImageButton2_MouseEnter);
            this.customImageButton2.MouseLeave += new System.EventHandler(this.customImageButton2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.placeHolder2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 449);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(255, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 1);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(273, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // placeHolder2
            // 
            this.placeHolder2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.placeHolder2.BackColor = System.Drawing.Color.White;
            this.placeHolder2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeHolder2.ColorText = System.Drawing.Color.Gray;
            this.placeHolder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.placeHolder2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolder2.Location = new System.Drawing.Point(255, 174);
            this.placeHolder2.Multiline = true;
            this.placeHolder2.Name = "placeHolder2";
            this.placeHolder2.Size = new System.Drawing.Size(115, 20);
            this.placeHolder2.TabIndex = 5;
            this.placeHolder2.TabStop = false;
            this.placeHolder2.Text = "Name Lobby";
            this.placeHolder2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.placeHolder2.TextPalace = "Name Lobby";
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(403, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customImageButton3);
            this.Controls.Add(this.customImageButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFriend";
            this.Load += new System.EventHandler(this.AddFriend_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFriend_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyImageButton.CustomImageButton customImageButton3;
        private MyImageButton.CustomImageButton customImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private PlaceHolder placeHolder2;
    }
}