
namespace Lomey_1
{
    partial class Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            this.triputatri = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.memory3x31 = new Lomey_1.Memory3x3();
            this.memory4x41 = new Lomey_1.Memory4x4();
            this.memory5x51 = new Lomey_1.Memory5x5();
            ((System.ComponentModel.ISupportInitialize)(this.triputatri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // triputatri
            // 
            this.triputatri.BackColor = System.Drawing.Color.Transparent;
            this.triputatri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triputatri.Image = global::Lomey_1.Properties.Resources.Memory_logo_3x4;
            this.triputatri.Location = new System.Drawing.Point(154, 208);
            this.triputatri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triputatri.Name = "triputatri";
            this.triputatri.Size = new System.Drawing.Size(221, 255);
            this.triputatri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triputatri.TabIndex = 0;
            this.triputatri.TabStop = false;
            this.triputatri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trixtri);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Lomey_1.Properties.Resources.Memory_logo_4x4;
            this.pictureBox2.Location = new System.Drawing.Point(477, 208);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Lomey_1.Properties.Resources.Memory_logo_4x5;
            this.pictureBox3.Location = new System.Drawing.Point(823, 208);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 255);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Lomey_1.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(17, 650);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Lomey_1.Properties.Resources.sound_on;
            this.pictureBox5.Location = new System.Drawing.Point(1153, 650);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // memory3x31
            // 
            this.memory3x31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memory3x31.BackgroundImage")));
            this.memory3x31.Location = new System.Drawing.Point(0, -1);
            this.memory3x31.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.memory3x31.Name = "memory3x31";
            this.memory3x31.Size = new System.Drawing.Size(1211, 725);
            this.memory3x31.TabIndex = 6;
            this.memory3x31.Visible = false;
            // 
            // memory4x41
            // 
            this.memory4x41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memory4x41.BackgroundImage")));
            this.memory4x41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memory4x41.Location = new System.Drawing.Point(0, 0);
            this.memory4x41.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memory4x41.Name = "memory4x41";
            this.memory4x41.Size = new System.Drawing.Size(1220, 720);
            this.memory4x41.TabIndex = 7;
            this.memory4x41.Visible = false;
            // 
            // memory5x51
            // 
            this.memory5x51.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memory5x51.BackgroundImage")));
            this.memory5x51.Location = new System.Drawing.Point(0, 0);
            this.memory5x51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memory5x51.Name = "memory5x51";
            this.memory5x51.Size = new System.Drawing.Size(1220, 720);
            this.memory5x51.TabIndex = 8;
            this.memory5x51.Visible = false;
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lomey_1.Properties.Resources.Background_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 720);
            this.Controls.Add(this.memory5x51);
            this.Controls.Add(this.memory4x41);
            this.Controls.Add(this.memory3x31);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.triputatri);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Memory";
            this.Text = "Memory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Memory_FormClosed);
            this.Load += new System.EventHandler(this.Memory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.triputatri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Memory3x3 memory3x31;
        private System.Windows.Forms.PictureBox triputatri;
        private Memory4x4 memory4x41;
        private Memory5x5 memory5x51;
    }
}