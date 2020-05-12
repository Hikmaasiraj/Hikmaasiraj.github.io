namespace LightonAndLightoff
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grayoff = new System.Windows.Forms.PictureBox();
            this.yellowon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grayoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ON";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(430, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grayoff
            // 
            this.grayoff.Image = global::LightonAndLightoff.Properties.Resources.LightOff_1;
            this.grayoff.Location = new System.Drawing.Point(308, 3);
            this.grayoff.Name = "grayoff";
            this.grayoff.Size = new System.Drawing.Size(200, 261);
            this.grayoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayoff.TabIndex = 1;
            this.grayoff.TabStop = false;
            this.grayoff.Visible = false;
            // 
            // yellowon
            // 
            this.yellowon.Image = global::LightonAndLightoff.Properties.Resources.LightOn_1__1_;
            this.yellowon.Location = new System.Drawing.Point(308, 3);
            this.yellowon.Name = "yellowon";
            this.yellowon.Size = new System.Drawing.Size(200, 261);
            this.yellowon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowon.TabIndex = 0;
            this.yellowon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grayoff);
            this.Controls.Add(this.yellowon);
            this.Name = "Form1";
            this.Text = "LightonAndLightoff";
            ((System.ComponentModel.ISupportInitialize)(this.grayoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yellowon;
        private System.Windows.Forms.PictureBox grayoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

