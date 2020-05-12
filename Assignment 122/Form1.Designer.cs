namespace Assignment_122
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBOriginalPrice = new System.Windows.Forms.TextBox();
            this.TBDiscoutPrice = new System.Windows.Forms.TextBox();
            this.TBSalesPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Item\'s original Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the discout percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sales Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate Sales Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(437, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBOriginalPrice
            // 
            this.TBOriginalPrice.Location = new System.Drawing.Point(549, 47);
            this.TBOriginalPrice.Name = "TBOriginalPrice";
            this.TBOriginalPrice.Size = new System.Drawing.Size(100, 26);
            this.TBOriginalPrice.TabIndex = 5;
            // 
            // TBDiscoutPrice
            // 
            this.TBDiscoutPrice.Location = new System.Drawing.Point(549, 138);
            this.TBDiscoutPrice.Name = "TBDiscoutPrice";
            this.TBDiscoutPrice.Size = new System.Drawing.Size(100, 26);
            this.TBDiscoutPrice.TabIndex = 6;
            // 
            // TBSalesPrice
            // 
            this.TBSalesPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBSalesPrice.Location = new System.Drawing.Point(549, 212);
            this.TBSalesPrice.Name = "TBSalesPrice";
            this.TBSalesPrice.Size = new System.Drawing.Size(100, 26);
            this.TBSalesPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBSalesPrice);
            this.Controls.Add(this.TBDiscoutPrice);
            this.Controls.Add(this.TBOriginalPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBOriginalPrice;
        private System.Windows.Forms.TextBox TBDiscoutPrice;
        private System.Windows.Forms.TextBox TBSalesPrice;
    }
}

