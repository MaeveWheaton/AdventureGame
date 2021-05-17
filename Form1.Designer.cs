
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
            this.imageOutput = new System.Windows.Forms.PictureBox();
            this.option1Output = new System.Windows.Forms.Label();
            this.option2Output = new System.Windows.Forms.Label();
            this.option3Output = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.storyOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.healthOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageOutput
            // 
            this.imageOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOutput.BackgroundImage")));
            this.imageOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOutput.Location = new System.Drawing.Point(184, 296);
            this.imageOutput.Name = "imageOutput";
            this.imageOutput.Size = new System.Drawing.Size(665, 356);
            this.imageOutput.TabIndex = 0;
            this.imageOutput.TabStop = false;
            // 
            // option1Output
            // 
            this.option1Output.BackColor = System.Drawing.Color.White;
            this.option1Output.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Output.ForeColor = System.Drawing.Color.Goldenrod;
            this.option1Output.Location = new System.Drawing.Point(148, 678);
            this.option1Output.Name = "option1Output";
            this.option1Output.Size = new System.Drawing.Size(762, 110);
            this.option1Output.TabIndex = 1;
            this.option1Output.Text = "Long Sword";
            this.option1Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option1Output.Visible = false;
            // 
            // option2Output
            // 
            this.option2Output.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Output.ForeColor = System.Drawing.Color.Goldenrod;
            this.option2Output.Location = new System.Drawing.Point(148, 783);
            this.option2Output.Name = "option2Output";
            this.option2Output.Size = new System.Drawing.Size(762, 110);
            this.option2Output.TabIndex = 5;
            this.option2Output.Text = "Polearm";
            this.option2Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option2Output.Visible = false;
            // 
            // option3Output
            // 
            this.option3Output.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Output.ForeColor = System.Drawing.Color.Goldenrod;
            this.option3Output.Location = new System.Drawing.Point(148, 889);
            this.option3Output.Name = "option3Output";
            this.option3Output.Size = new System.Drawing.Size(762, 110);
            this.option3Output.TabIndex = 6;
            this.option3Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Goldenrod;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(409, 803);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(192, 75);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Transparent;
            this.option1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option1Button.BackgroundImage")));
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(40, 686);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(84, 99);
            this.option1Button.TabIndex = 9;
            this.option1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Visible = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Transparent;
            this.option2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option2Button.BackgroundImage")));
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Location = new System.Drawing.Point(40, 791);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(84, 99);
            this.option2Button.TabIndex = 10;
            this.option2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Visible = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Transparent;
            this.option3Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option3Button.BackgroundImage")));
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(40, 897);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(84, 99);
            this.option3Button.TabIndex = 11;
            this.option3Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // storyOutput
            // 
            this.storyOutput.Font = new System.Drawing.Font("Mongolian Baiti", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyOutput.Location = new System.Drawing.Point(55, 113);
            this.storyOutput.Name = "storyOutput";
            this.storyOutput.Size = new System.Drawing.Size(909, 180);
            this.storyOutput.TabIndex = 12;
            this.storyOutput.Text = "Consider your every choice, it may or may not have effect later in the story. Cli" +
    "ck the bullet point next to the option to make your choice.\r\n\r\n";
            this.storyOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storyOutput.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(145, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(762, 110);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Choose Your Adventure";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Goldenrod;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(772, 909);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(192, 75);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // healthOutput
            // 
            this.healthOutput.AutoSize = true;
            this.healthOutput.Font = new System.Drawing.Font("Mongolian Baiti", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthOutput.Location = new System.Drawing.Point(807, 686);
            this.healthOutput.Name = "healthOutput";
            this.healthOutput.Size = new System.Drawing.Size(157, 36);
            this.healthOutput.TabIndex = 14;
            this.healthOutput.Text = "Health: 10";
            this.healthOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 1033);
            this.Controls.Add(this.healthOutput);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.storyOutput);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option3Output);
            this.Controls.Add(this.option2Output);
            this.Controls.Add(this.option1Output);
            this.Controls.Add(this.imageOutput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Choose Your Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOutput;
        private System.Windows.Forms.Label option1Output;
        private System.Windows.Forms.Label option2Output;
        private System.Windows.Forms.Label option3Output;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label storyOutput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label healthOutput;
    }
}

