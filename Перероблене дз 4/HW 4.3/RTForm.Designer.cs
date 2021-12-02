
namespace HW_4._3
{
    partial class RTForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calculate Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(621, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(349, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 27);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate Perimeter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "c = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "b = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "a = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter the parameters here";
            // 
            // CreateTriangle
            // 
            this.CreateTriangle.Location = new System.Drawing.Point(311, 312);
            this.CreateTriangle.Name = "CreateTriangle";
            this.CreateTriangle.Size = new System.Drawing.Size(163, 51);
            this.CreateTriangle.TabIndex = 18;
            this.CreateTriangle.Text = "Create a triangle";
            this.CreateTriangle.UseVisualStyleBackColor = true;
            this.CreateTriangle.Click += new System.EventHandler(this.button3_Click);
            // 
            // RTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateTriangle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RTForm";
            this.Text = "RTForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateTriangle;
    }
}