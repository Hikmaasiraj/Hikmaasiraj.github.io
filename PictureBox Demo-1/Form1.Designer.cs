namespace PictureBox_Demo_1
{
    partial class Form1
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
            this.Tossbtu = new System.Windows.Forms.Button();
            this.Exitbtu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tossbtu
            // 
            this.Tossbtu.Location = new System.Drawing.Point(128, 305);
            this.Tossbtu.Name = "Tossbtu";
            this.Tossbtu.Size = new System.Drawing.Size(146, 54);
            this.Tossbtu.TabIndex = 0;
            this.Tossbtu.Text = "TOSS";
            this.Tossbtu.UseVisualStyleBackColor = true;
            this.Tossbtu.Click += new System.EventHandler(this.Tossbtu_Click);
            // 
            // Exitbtu
            // 
            this.Exitbtu.Location = new System.Drawing.Point(372, 319);
            this.Exitbtu.Name = "Exitbtu";
            this.Exitbtu.Size = new System.Drawing.Size(149, 40);
            this.Exitbtu.TabIndex = 1;
            this.Exitbtu.Text = "EXIT";
            this.Exitbtu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBox_Demo_1.Properties.Resources.Heads1_1;
            this.pictureBox1.Location = new System.Drawing.Point(128, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PictureBox_Demo_1.Properties.Resources.Tails1_1;
            this.pictureBox2.Location = new System.Drawing.Point(340, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 433);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exitbtu);
            this.Controls.Add(this.Tossbtu);
            this.Name = "Form1";
            this.Text = "Picture Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tossbtu;
        private System.Windows.Forms.Button Exitbtu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

