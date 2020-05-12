namespace Tempratureconvertion
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
            this.inputtb = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputtb
            // 
            this.inputtb.Location = new System.Drawing.Point(80, 61);
            this.inputtb.Name = "inputtb";
            this.inputtb.Size = new System.Drawing.Size(100, 26);
            this.inputtb.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(337, 63);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(133, 35);
            this.convert.TabIndex = 1;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(80, 132);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(51, 20);
            this.outputlabel.TabIndex = 2;
            this.outputlabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.inputtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputtb;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label outputlabel;
    }
}

