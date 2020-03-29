namespace WindowsFormsApp4
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
            this.x1_box = new System.Windows.Forms.TextBox();
            this.x2_box = new System.Windows.Forms.TextBox();
            this.z_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.k_box = new System.Windows.Forms.TextBox();
            this.wynik_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patryk krawczak zadanie 4 C#";
            // 
            // x1_box
            // 
            this.x1_box.Location = new System.Drawing.Point(12, 75);
            this.x1_box.Name = "x1_box";
            this.x1_box.Size = new System.Drawing.Size(102, 26);
            this.x1_box.TabIndex = 1;
            // 
            // x2_box
            // 
            this.x2_box.Location = new System.Drawing.Point(12, 155);
            this.x2_box.Name = "x2_box";
            this.x2_box.Size = new System.Drawing.Size(102, 26);
            this.x2_box.TabIndex = 2;
            // 
            // z_box
            // 
            this.z_box.Location = new System.Drawing.Point(12, 229);
            this.z_box.Name = "z_box";
            this.z_box.Size = new System.Drawing.Size(102, 26);
            this.z_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "OBLICZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "k";
            // 
            // k_box
            // 
            this.k_box.Location = new System.Drawing.Point(12, 304);
            this.k_box.Name = "k_box";
            this.k_box.Size = new System.Drawing.Size(102, 26);
            this.k_box.TabIndex = 8;
            // 
            // wynik_box
            // 
            this.wynik_box.Location = new System.Drawing.Point(279, 66);
            this.wynik_box.Multiline = true;
            this.wynik_box.Name = "wynik_box";
            this.wynik_box.Size = new System.Drawing.Size(509, 372);
            this.wynik_box.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wynik_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.k_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.z_box);
            this.Controls.Add(this.x2_box);
            this.Controls.Add(this.x1_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1_box;
        private System.Windows.Forms.TextBox x2_box;
        private System.Windows.Forms.TextBox z_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k_box;
        private System.Windows.Forms.TextBox wynik_box;
    }
}

