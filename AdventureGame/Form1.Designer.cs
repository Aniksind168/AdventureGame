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
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(625, 65);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You\'re planning to rob a bank. Pick a player.";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.redLabel.Location = new System.Drawing.Point(142, 369);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(380, 23);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "Squidward Tentacles";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueLabel.Location = new System.Drawing.Point(142, 407);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(380, 28);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Patrick Star";
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.greenLabel.Location = new System.Drawing.Point(142, 452);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(380, 26);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Spongebob Squarepants";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AdventureGame.Properties.Resources.greenButton;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(78, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 35);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AdventureGame.Properties.Resources.blueButton;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(78, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(78, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::AdventureGame.Properties.Resources.bankImage;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImage.Location = new System.Drawing.Point(93, 77);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(456, 273);
            this.sceneImage.TabIndex = 7;
            this.sceneImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(649, 485);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

