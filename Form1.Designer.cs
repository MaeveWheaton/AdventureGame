
namespace AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.optionThreeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(194, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 356);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // optionOneLabel
            // 
            this.optionOneLabel.BackColor = System.Drawing.Color.White;
            this.optionOneLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOneLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.optionOneLabel.Location = new System.Drawing.Point(145, 491);
            this.optionOneLabel.Name = "optionOneLabel";
            this.optionOneLabel.Size = new System.Drawing.Size(762, 110);
            this.optionOneLabel.TabIndex = 1;
            this.optionOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bullet1
            // 
            this.bullet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet1.BackgroundImage")));
            this.bullet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(37, 491);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(84, 110);
            this.bullet1.TabIndex = 2;
            this.bullet1.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet2.BackgroundImage")));
            this.bullet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bullet2.InitialImage = null;
            this.bullet2.Location = new System.Drawing.Point(37, 596);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(84, 110);
            this.bullet2.TabIndex = 3;
            this.bullet2.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet3.BackgroundImage")));
            this.bullet3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bullet3.InitialImage = null;
            this.bullet3.Location = new System.Drawing.Point(37, 702);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(84, 110);
            this.bullet3.TabIndex = 4;
            this.bullet3.TabStop = false;
            // 
            // optionTwoLabel
            // 
            this.optionTwoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwoLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.optionTwoLabel.Location = new System.Drawing.Point(145, 596);
            this.optionTwoLabel.Name = "optionTwoLabel";
            this.optionTwoLabel.Size = new System.Drawing.Size(762, 110);
            this.optionTwoLabel.TabIndex = 5;
            this.optionTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optionThreeLabel
            // 
            this.optionThreeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionThreeLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.optionThreeLabel.Location = new System.Drawing.Point(145, 702);
            this.optionThreeLabel.Name = "optionThreeLabel";
            this.optionThreeLabel.Size = new System.Drawing.Size(762, 110);
            this.optionThreeLabel.TabIndex = 6;
            this.optionThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 110);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Your Adventure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 879);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionThreeLabel);
            this.Controls.Add(this.optionTwoLabel);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.optionOneLabel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Choose Your Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.Label optionThreeLabel;
        private System.Windows.Forms.Label label1;
    }
}

