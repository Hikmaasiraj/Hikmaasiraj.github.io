namespace Practice_List_box
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.addbtu = new System.Windows.Forms.Button();
            this.Removebtu = new System.Windows.Forms.Button();
            this.clearbtu = new System.Windows.Forms.Button();
            this.exitbtu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(82, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 294);
            this.listBox1.TabIndex = 0;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(398, 31);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 26);
            this.InputBox.TabIndex = 1;
            // 
            // addbtu
            // 
            this.addbtu.Location = new System.Drawing.Point(398, 114);
            this.addbtu.Name = "addbtu";
            this.addbtu.Size = new System.Drawing.Size(100, 28);
            this.addbtu.TabIndex = 2;
            this.addbtu.Text = "ADD";
            this.addbtu.UseVisualStyleBackColor = true;
            // 
            // Removebtu
            // 
            this.Removebtu.Location = new System.Drawing.Point(398, 174);
            this.Removebtu.Name = "Removebtu";
            this.Removebtu.Size = new System.Drawing.Size(100, 28);
            this.Removebtu.TabIndex = 3;
            this.Removebtu.Text = "REVOME";
            this.Removebtu.UseVisualStyleBackColor = true;
            // 
            // clearbtu
            // 
            this.clearbtu.Location = new System.Drawing.Point(398, 251);
            this.clearbtu.Name = "clearbtu";
            this.clearbtu.Size = new System.Drawing.Size(100, 27);
            this.clearbtu.TabIndex = 4;
            this.clearbtu.Text = "CLEAR";
            this.clearbtu.UseVisualStyleBackColor = true;
            this.clearbtu.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitbtu
            // 
            this.exitbtu.Location = new System.Drawing.Point(398, 317);
            this.exitbtu.Name = "exitbtu";
            this.exitbtu.Size = new System.Drawing.Size(100, 34);
            this.exitbtu.TabIndex = 5;
            this.exitbtu.Text = "EXIT";
            this.exitbtu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtu);
            this.Controls.Add(this.clearbtu);
            this.Controls.Add(this.Removebtu);
            this.Controls.Add(this.addbtu);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Practice ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button addbtu;
        private System.Windows.Forms.Button Removebtu;
        private System.Windows.Forms.Button clearbtu;
        private System.Windows.Forms.Button exitbtu;
    }
}

