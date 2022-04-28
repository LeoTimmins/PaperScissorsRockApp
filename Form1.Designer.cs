namespace PaperScissorsRockApp
{
    partial class ViewPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPort));
            this.TaskBarBG = new System.Windows.Forms.PictureBox();
            this.MinButton = new System.Windows.Forms.PictureBox();
            this.MaxButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskBarBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskBarBG
            // 
            this.TaskBarBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TaskBarBG.Location = new System.Drawing.Point(0, 0);
            this.TaskBarBG.Margin = new System.Windows.Forms.Padding(5);
            this.TaskBarBG.MinimumSize = new System.Drawing.Size(124, 46);
            this.TaskBarBG.Name = "TaskBarBG";
            this.TaskBarBG.Size = new System.Drawing.Size(2155, 120);
            this.TaskBarBG.TabIndex = 0;
            this.TaskBarBG.TabStop = false;
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MinButton.Image = ((System.Drawing.Image)(resources.GetObject("MinButton.Image")));
            this.MinButton.Location = new System.Drawing.Point(995, 0);
            this.MinButton.MaximumSize = new System.Drawing.Size(140, 120);
            this.MinButton.MinimumSize = new System.Drawing.Size(140, 120);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(140, 120);
            this.MinButton.TabIndex = 3;
            this.MinButton.TabStop = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MaxButton.Image = ((System.Drawing.Image)(resources.GetObject("MaxButton.Image")));
            this.MaxButton.Location = new System.Drawing.Point(1141, 0);
            this.MaxButton.MaximumSize = new System.Drawing.Size(140, 120);
            this.MaxButton.MinimumSize = new System.Drawing.Size(140, 120);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(140, 120);
            this.MaxButton.TabIndex = 2;
            this.MaxButton.TabStop = false;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(1284, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.MaximumSize = new System.Drawing.Size(140, 120);
            this.ExitButton.MinimumSize = new System.Drawing.Size(140, 120);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 120);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ViewPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1422, 725);
            this.ControlBox = false;
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TaskBarBG);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1397, 727);
            this.Name = "ViewPort";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TaskBarBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TaskBarBG;
        private System.Windows.Forms.PictureBox MinButton;
        private System.Windows.Forms.PictureBox MaxButton;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}

