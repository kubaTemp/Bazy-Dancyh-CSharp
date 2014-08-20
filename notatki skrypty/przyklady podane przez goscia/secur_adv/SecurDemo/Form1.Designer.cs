namespace SecurDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMet1 = new System.Windows.Forms.Button();
            this.btnMet2 = new System.Windows.Forms.Button();
            this.btnMet3 = new System.Windows.Forms.Button();
            this.tbUName = new System.Windows.Forms.TextBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMet1
            // 
            this.btnMet1.Location = new System.Drawing.Point(56, 124);
            this.btnMet1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMet1.Name = "btnMet1";
            this.btnMet1.Size = new System.Drawing.Size(100, 28);
            this.btnMet1.TabIndex = 1;
            this.btnMet1.Text = "Met1";
            this.btnMet1.UseVisualStyleBackColor = true;
            this.btnMet1.Click += new System.EventHandler(this.btnMet1_Click);
            // 
            // btnMet2
            // 
            this.btnMet2.Location = new System.Drawing.Point(56, 161);
            this.btnMet2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMet2.Name = "btnMet2";
            this.btnMet2.Size = new System.Drawing.Size(100, 28);
            this.btnMet2.TabIndex = 2;
            this.btnMet2.Text = "Met2";
            this.btnMet2.UseVisualStyleBackColor = true;
            this.btnMet2.Click += new System.EventHandler(this.btnMet2_Click);
            // 
            // btnMet3
            // 
            this.btnMet3.Location = new System.Drawing.Point(56, 198);
            this.btnMet3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMet3.Name = "btnMet3";
            this.btnMet3.Size = new System.Drawing.Size(100, 28);
            this.btnMet3.TabIndex = 3;
            this.btnMet3.Text = "Met3";
            this.btnMet3.UseVisualStyleBackColor = true;
            this.btnMet3.Click += new System.EventHandler(this.btnMet3_Click);
            // 
            // tbUName
            // 
            this.tbUName.Location = new System.Drawing.Point(193, 49);
            this.tbUName.Name = "tbUName";
            this.tbUName.Size = new System.Drawing.Size(100, 22);
            this.tbUName.TabIndex = 4;
            this.tbUName.Text = "Rafal";
            this.tbUName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(56, 290);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(100, 23);
            this.btnDemo.TabIndex = 5;
            this.btnDemo.Text = "butDemo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Met4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(205, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.tbUName);
            this.Controls.Add(this.btnMet3);
            this.Controls.Add(this.btnMet2);
            this.Controls.Add(this.btnMet1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMet1;
        private System.Windows.Forms.Button btnMet2;
        private System.Windows.Forms.Button btnMet3;
        private System.Windows.Forms.TextBox tbUName;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
    }
}

