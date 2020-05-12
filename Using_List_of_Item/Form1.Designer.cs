namespace Using_List_of_Item
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIndexof = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 404);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(537, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(217, 404);
            this.listBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Random Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(30, 541);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(217, 26);
            this.txtItem.TabIndex = 5;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(295, 481);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(217, 26);
            this.txtIndex.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remove Index";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnIndexof
            // 
            this.btnIndexof.Location = new System.Drawing.Point(30, 628);
            this.btnIndexof.Name = "btnIndexof";
            this.btnIndexof.Size = new System.Drawing.Size(217, 49);
            this.btnIndexof.TabIndex = 8;
            this.btnIndexof.Text = "Get Index of an Item";
            this.btnIndexof.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Give the Item to Remove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIndexof);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIndexof;
        private System.Windows.Forms.Label label1;
    }
}

