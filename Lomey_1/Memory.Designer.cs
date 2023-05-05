
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
            this.triputatri.Location = new System.Drawing.Point(108, 125);
            this.triputatri.Name = "triputatri";
            this.triputatri.Size = new System.Drawing.Size(155, 153);
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
            this.pictureBox2.Location = new System.Drawing.Point(334, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Lomey_1.Properties.Resources.Memory_logo_4x5;
            this.pictureBox3.Location = new System.Drawing.Point(576, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Lomey_1.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(12, 390);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Lomey_1.Properties.Resources.sound_on;
            this.pictureBox5.Location = new System.Drawing.Point(807, 390);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // memory3x31
            // 
            this.memory3x31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memory3x31.BackgroundImage")));
            this.memory3x31.Location = new System.Drawing.Point(0, 0);
            this.memory3x31.Name = "memory3x31";
            this.memory3x31.Size = new System.Drawing.Size(854, 432);
            this.memory3x31.TabIndex = 6;
            this.memory3x31.Visible = false;
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lomey_1.Properties.Resources.Background_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 432);
            this.Controls.Add(this.memory3x31);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.triputatri);
            this.Name = "Memory";
            this.Text = "Memory";
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
    }
}