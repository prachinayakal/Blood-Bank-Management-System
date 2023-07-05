
namespace BloodBank
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogress = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank Management System";
            // 
            // Myprogress
            // 
            this.Myprogress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Myprogress.AnimationSpeed = 500;
            this.Myprogress.BackColor = System.Drawing.Color.Transparent;
            this.Myprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Myprogress.ForeColor = System.Drawing.Color.White;
            this.Myprogress.InnerColor = System.Drawing.Color.White;
            this.Myprogress.InnerMargin = 15;
            this.Myprogress.InnerWidth = 15;
            this.Myprogress.Location = new System.Drawing.Point(178, 76);
            this.Myprogress.MarqueeAnimationSpeed = 2000;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.OuterColor = System.Drawing.Color.Gray;
            this.Myprogress.OuterMargin = 0;
            this.Myprogress.OuterWidth = 0;
            this.Myprogress.ProgressColor = System.Drawing.Color.Red;
            this.Myprogress.ProgressWidth = 10;
            this.Myprogress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Myprogress.Size = new System.Drawing.Size(186, 161);
            this.Myprogress.StartAngle = 270;
            this.Myprogress.Step = 1;
            this.Myprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Myprogress.SubscriptColor = System.Drawing.Color.White;
            this.Myprogress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Myprogress.SubscriptText = "";
            this.Myprogress.SuperscriptColor = System.Drawing.Color.White;
            this.Myprogress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Myprogress.SuperscriptText = "°C";
            this.Myprogress.TabIndex = 10;
            this.Myprogress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Myprogress.Value = 68;
            this.Myprogress.Click += new System.EventHandler(this.Myprogress_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar Myprogress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

