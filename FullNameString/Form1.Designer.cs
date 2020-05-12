namespace FullNameString
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
            this.FristName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.showname = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FirstTB = new System.Windows.Forms.TextBox();
            this.LastTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FristName
            // 
            this.FristName.AutoSize = true;
            this.FristName.Location = new System.Drawing.Point(47, 48);
            this.FristName.Name = "FristName";
            this.FristName.Size = new System.Drawing.Size(86, 20);
            this.FristName.TabIndex = 0;
            this.FristName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(51, 118);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(51, 193);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(97, 20);
            this.FullName.TabIndex = 2;
            this.FullName.Text = "Full Name Is";
            // 
            // showname
            // 
            this.showname.Location = new System.Drawing.Point(157, 268);
            this.showname.Name = "showname";
            this.showname.Size = new System.Drawing.Size(182, 59);
            this.showname.TabIndex = 3;
            this.showname.Text = "Show Name";
            this.showname.UseVisualStyleBackColor = true;
            this.showname.Click += new System.EventHandler(this.showname_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(416, 272);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 50);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // FirstTB
            // 
            this.FirstTB.Location = new System.Drawing.Point(181, 42);
            this.FirstTB.Name = "FirstTB";
            this.FirstTB.Size = new System.Drawing.Size(100, 26);
            this.FirstTB.TabIndex = 5;
            // 
            // LastTB
            // 
            this.LastTB.Location = new System.Drawing.Point(181, 117);
            this.LastTB.Name = "LastTB";
            this.LastTB.Size = new System.Drawing.Size(100, 26);
            this.LastTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "OutPutlabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastTB);
            this.Controls.Add(this.FirstTB);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.showname);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FristName);
            this.Name = "Form1";
            this.Text = "FullName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FristName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Button showname;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox FirstTB;
        private System.Windows.Forms.TextBox LastTB;
        private System.Windows.Forms.Label label1;
    }
}

