namespace RussianRoullete_Rajpal
{
    partial class Russiannn
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.shotBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Loading";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Spin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Shoot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Shoot Away";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(626, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "Play Again";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // shotBox
            // 
            this.shotBox.Image = global::RussianRoullete_Rajpal.Properties.Resources.war33;
            this.shotBox.Location = new System.Drawing.Point(246, 42);
            this.shotBox.Name = "shotBox";
            this.shotBox.Size = new System.Drawing.Size(321, 240);
            this.shotBox.TabIndex = 5;
            this.shotBox.TabStop = false;
            // 
            // Russiannn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.shotBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Russiannn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox shotBox;
    }
}

