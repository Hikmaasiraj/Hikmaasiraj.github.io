namespace PictureBox_Demo__2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kingcard = new System.Windows.Forms.PictureBox();
            this.tencard = new System.Windows.Forms.PictureBox();
            this.Acecard = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kingcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tencard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acecard)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.listBox1.Location = new System.Drawing.Point(233, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 120);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kingcard
            // 
            this.kingcard.Image = global::PictureBox_Demo__2.Properties.Resources.King_Clubs;
            this.kingcard.Location = new System.Drawing.Point(268, 57);
            this.kingcard.Name = "kingcard";
            this.kingcard.Size = new System.Drawing.Size(153, 135);
            this.kingcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kingcard.TabIndex = 2;
            this.kingcard.TabStop = false;
            this.kingcard.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tencard
            // 
            this.tencard.Image = global::PictureBox_Demo__2.Properties.Resources._10_Hearts;
            this.tencard.Location = new System.Drawing.Point(182, 57);
            this.tencard.Name = "tencard";
            this.tencard.Size = new System.Drawing.Size(158, 135);
            this.tencard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tencard.TabIndex = 1;
            this.tencard.TabStop = false;
            // 
            // Acecard
            // 
            this.Acecard.Image = global::PictureBox_Demo__2.Properties.Resources.Ace_Spades;
            this.Acecard.Location = new System.Drawing.Point(93, 57);
            this.Acecard.Name = "Acecard";
            this.Acecard.Size = new System.Drawing.Size(151, 135);
            this.Acecard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Acecard.TabIndex = 0;
            this.Acecard.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kingcard);
            this.Controls.Add(this.tencard);
            this.Controls.Add(this.Acecard);
            this.Name = "Form1";
            this.Text = "PictureBox Demo -2";
            ((System.ComponentModel.ISupportInitialize)(this.kingcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tencard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acecard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Acecard;
        private System.Windows.Forms.PictureBox tencard;
        private System.Windows.Forms.PictureBox kingcard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

