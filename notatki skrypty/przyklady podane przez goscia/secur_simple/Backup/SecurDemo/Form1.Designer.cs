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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMet1
            // 
            this.btnMet1.Location = new System.Drawing.Point(42, 101);
            this.btnMet1.Name = "btnMet1";
            this.btnMet1.Size = new System.Drawing.Size(75, 23);
            this.btnMet1.TabIndex = 1;
            this.btnMet1.Text = "Met1";
            this.btnMet1.UseVisualStyleBackColor = true;
            this.btnMet1.Click += new System.EventHandler(this.btnMet1_Click);
            // 
            // btnMet2
            // 
            this.btnMet2.Location = new System.Drawing.Point(42, 131);
            this.btnMet2.Name = "btnMet2";
            this.btnMet2.Size = new System.Drawing.Size(75, 23);
            this.btnMet2.TabIndex = 2;
            this.btnMet2.Text = "Met2";
            this.btnMet2.UseVisualStyleBackColor = true;
            this.btnMet2.Click += new System.EventHandler(this.btnMet2_Click);
            // 
            // btnMet3
            // 
            this.btnMet3.Location = new System.Drawing.Point(42, 161);
            this.btnMet3.Name = "btnMet3";
            this.btnMet3.Size = new System.Drawing.Size(75, 23);
            this.btnMet3.TabIndex = 3;
            this.btnMet3.Text = "Met3";
            this.btnMet3.UseVisualStyleBackColor = true;
            this.btnMet3.Click += new System.EventHandler(this.btnMet3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnMet3);
            this.Controls.Add(this.btnMet2);
            this.Controls.Add(this.btnMet1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMet1;
        private System.Windows.Forms.Button btnMet2;
        private System.Windows.Forms.Button btnMet3;
    }
}

