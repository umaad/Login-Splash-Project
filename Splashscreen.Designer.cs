namespace login_s
{
    partial class Splashscreen
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.txtprogress = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-5, 313);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 10);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(85, 270);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(48, 13);
            this.lblprogress.TabIndex = 2;
            this.lblprogress.Text = "Progress";
            // 
            // txtprogress
            // 
            this.txtprogress.Location = new System.Drawing.Point(191, 263);
            this.txtprogress.Name = "txtprogress";
            this.txtprogress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtprogress.Size = new System.Drawing.Size(117, 20);
            this.txtprogress.TabIndex = 3;
            this.txtprogress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprogress.TextChanged += new System.EventHandler(this.txtprogress_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login_s.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 325);
            this.ControlBox = false;
            this.Controls.Add(this.txtprogress);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.progressBar1);
            this.IsMdiContainer = true;
            this.Name = "Splashscreen";
            this.Load += new System.EventHandler(this.Splashscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.TextBox txtprogress;
        private System.Windows.Forms.Timer timer1;
    }
}