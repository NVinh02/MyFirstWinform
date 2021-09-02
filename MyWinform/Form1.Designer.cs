
namespace MyWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num_a = new System.Windows.Forms.TextBox();
            this.num_b = new System.Windows.Forms.TextBox();
            this.num_c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_x1 = new System.Windows.Forms.Label();
            this.lb_x2 = new System.Windows.Forms.Label();
            this.lb_x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num_a
            // 
            this.num_a.Location = new System.Drawing.Point(89, 73);
            this.num_a.Name = "num_a";
            this.num_a.Size = new System.Drawing.Size(100, 50);
            this.num_a.TabIndex = 0;
            // 
            // num_b
            // 
            this.num_b.Location = new System.Drawing.Point(206, 73);
            this.num_b.Name = "num_b";
            this.num_b.Size = new System.Drawing.Size(100, 23);
            this.num_b.TabIndex = 1;
            // 
            // num_c
            // 
            this.num_c.Location = new System.Drawing.Point(330, 73);
            this.num_c.Name = "num_c";
            this.num_c.Size = new System.Drawing.Size(100, 23);
            this.num_c.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_x1
            // 
            this.lb_x1.AutoSize = true;
            this.lb_x1.Location = new System.Drawing.Point(235, 165);
            this.lb_x1.Name = "lb_x1";
            this.lb_x1.Size = new System.Drawing.Size(38, 15);
            this.lb_x1.TabIndex = 4;
            this.lb_x1.Text = "label1";
            // 
            // lb_x2
            // 
            this.lb_x2.AutoSize = true;
            this.lb_x2.Location = new System.Drawing.Point(235, 192);
            this.lb_x2.Name = "lb_x2";
            this.lb_x2.Size = new System.Drawing.Size(38, 15);
            this.lb_x2.TabIndex = 5;
            this.lb_x2.Text = "label1";
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(235, 217);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(38, 15);
            this.lb_x.TabIndex = 6;
            this.lb_x.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(151, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_x);
            this.Controls.Add(this.lb_x2);
            this.Controls.Add(this.lb_x1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_c);
            this.Controls.Add(this.num_b);
            this.Controls.Add(this.num_a);
            this.Name = "Form1";
            this.Text = "Phương trình bậc 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_a;
        private System.Windows.Forms.TextBox num_b;
        private System.Windows.Forms.TextBox num_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_x1;
        private System.Windows.Forms.Label lb_x2;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

