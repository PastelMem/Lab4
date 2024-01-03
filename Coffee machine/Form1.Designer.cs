namespace Coffee_machine
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
            this.Black_Coffee = new System.Windows.Forms.Button();
            this.Latte = new System.Windows.Forms.Button();
            this.Mocca = new System.Windows.Forms.Button();
            this.Chocolate = new System.Windows.Forms.Button();
            this.วัตถุดิบคงเหลือ = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.water_Box = new System.Windows.Forms.TextBox();
            this.Chocolate_Box = new System.Windows.Forms.TextBox();
            this.milk_Box = new System.Windows.Forms.TextBox();
            this.Coffee_Box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.วัตถุดิบคงเหลือ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Black_Coffee
            // 
            this.Black_Coffee.Location = new System.Drawing.Point(644, 118);
            this.Black_Coffee.Name = "Black_Coffee";
            this.Black_Coffee.Size = new System.Drawing.Size(99, 23);
            this.Black_Coffee.TabIndex = 1;
            this.Black_Coffee.Text = "BlackCoffee";
            this.Black_Coffee.UseVisualStyleBackColor = true;
            this.Black_Coffee.Click += new System.EventHandler(this.Black_Coffee_Click);
            // 
            // Latte
            // 
            this.Latte.Location = new System.Drawing.Point(644, 144);
            this.Latte.Name = "Latte";
            this.Latte.Size = new System.Drawing.Size(99, 23);
            this.Latte.TabIndex = 2;
            this.Latte.Text = "Latte";
            this.Latte.UseVisualStyleBackColor = true;
            this.Latte.Click += new System.EventHandler(this.Latte_Click);
            // 
            // Mocca
            // 
            this.Mocca.Location = new System.Drawing.Point(644, 173);
            this.Mocca.Name = "Mocca";
            this.Mocca.Size = new System.Drawing.Size(99, 23);
            this.Mocca.TabIndex = 3;
            this.Mocca.Text = "Mocca";
            this.Mocca.UseVisualStyleBackColor = true;
            this.Mocca.Click += new System.EventHandler(this.Mocca_Click);
            // 
            // Chocolate
            // 
            this.Chocolate.Location = new System.Drawing.Point(644, 202);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(106, 23);
            this.Chocolate.TabIndex = 4;
            this.Chocolate.Text = "Hot Chocolate";
            this.Chocolate.UseVisualStyleBackColor = true;
            this.Chocolate.Click += new System.EventHandler(this.Chocolate_Click);
            // 
            // วัตถุดิบคงเหลือ
            // 
            this.วัตถุดิบคงเหลือ.Controls.Add(this.Coffee_Box);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.milk_Box);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.Chocolate_Box);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.water_Box);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.label4);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.label3);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.label2);
            this.วัตถุดิบคงเหลือ.Controls.Add(this.label1);
            this.วัตถุดิบคงเหลือ.Location = new System.Drawing.Point(359, 182);
            this.วัตถุดิบคงเหลือ.Name = "วัตถุดิบคงเหลือ";
            this.วัตถุดิบคงเหลือ.Size = new System.Drawing.Size(213, 171);
            this.วัตถุดิบคงเหลือ.TabIndex = 6;
            this.วัตถุดิบคงเหลือ.TabStop = false;
            this.วัตถุดิบคงเหลือ.Text = "วัตถุดิบที่เหลือ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "น้ำ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ช็อคโกแลต";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "นม";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "กาแฟ";
            // 
            // water_Box
            // 
            this.water_Box.Location = new System.Drawing.Point(6, 31);
            this.water_Box.Name = "water_Box";
            this.water_Box.Size = new System.Drawing.Size(100, 22);
            this.water_Box.TabIndex = 7;
            // 
            // Chocolate_Box
            // 
            this.Chocolate_Box.Location = new System.Drawing.Point(6, 73);
            this.Chocolate_Box.Name = "Chocolate_Box";
            this.Chocolate_Box.Size = new System.Drawing.Size(100, 22);
            this.Chocolate_Box.TabIndex = 11;
            // 
            // milk_Box
            // 
            this.milk_Box.Location = new System.Drawing.Point(6, 110);
            this.milk_Box.Name = "milk_Box";
            this.milk_Box.Size = new System.Drawing.Size(100, 22);
            this.milk_Box.TabIndex = 12;
            // 
            // Coffee_Box
            // 
            this.Coffee_Box.Location = new System.Drawing.Point(6, 143);
            this.Coffee_Box.Name = "Coffee_Box";
            this.Coffee_Box.Size = new System.Drawing.Size(100, 22);
            this.Coffee_Box.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Coffee_machine.Properties.Resources.Sorry_Out_of_order;
            this.pictureBox2.Location = new System.Drawing.Point(650, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_machine.Properties.Resources.เต่าบินนน;
            this.pictureBox1.Location = new System.Drawing.Point(359, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 516);
            this.Controls.Add(this.วัตถุดิบคงเหลือ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Chocolate);
            this.Controls.Add(this.Mocca);
            this.Controls.Add(this.Latte);
            this.Controls.Add(this.Black_Coffee);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.วัตถุดิบคงเหลือ.ResumeLayout(false);
            this.วัตถุดิบคงเหลือ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Black_Coffee;
        private System.Windows.Forms.Button Latte;
        private System.Windows.Forms.Button Mocca;
        private System.Windows.Forms.Button Chocolate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox วัตถุดิบคงเหลือ;
        private System.Windows.Forms.TextBox Coffee_Box;
        private System.Windows.Forms.TextBox milk_Box;
        private System.Windows.Forms.TextBox Chocolate_Box;
        private System.Windows.Forms.TextBox water_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

