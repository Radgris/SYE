namespace SYEV3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCasillaX = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelCasillaY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SYEV3.Properties.Resources.SYE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(134, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 758);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // labelX
            // 
            this.labelX.AccessibleName = "LblX";
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 18);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(43, 13);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X cords";
            // 
            // labelY
            // 
            this.labelY.AccessibleName = "LblY";
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 45);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(43, 13);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y cords";
            // 
            // button1
            // 
            this.button1.AccessibleName = "BtnDice";
            this.button1.Location = new System.Drawing.Point(15, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Throw Dice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleName = "TokenBlack";
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(175, 700);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Dice : ";
            // 
            // label2
            // 
            this.label2.AccessibleName = "LblDice";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Casilla : ";
            // 
            // labelCasillaX
            // 
            this.labelCasillaX.AccessibleName = "LblCasilla";
            this.labelCasillaX.AutoSize = true;
            this.labelCasillaX.Location = new System.Drawing.Point(93, 172);
            this.labelCasillaX.Name = "labelCasillaX";
            this.labelCasillaX.Size = new System.Drawing.Size(22, 13);
            this.labelCasillaX.TabIndex = 8;
            this.labelCasillaX.Text = "NA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleName = "TokenWhite";
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(175, 620);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // labelCasillaY
            // 
            this.labelCasillaY.AutoSize = true;
            this.labelCasillaY.Location = new System.Drawing.Point(93, 201);
            this.labelCasillaY.Name = "labelCasillaY";
            this.labelCasillaY.Size = new System.Drawing.Size(22, 13);
            this.labelCasillaY.TabIndex = 10;
            this.labelCasillaY.Text = "NA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 761);
            this.Controls.Add(this.labelCasillaY);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelCasillaX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCasillaX;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelCasillaY;
    }
}

