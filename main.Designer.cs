namespace login_s
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qusestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solvedExamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_part = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbtime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.admin_part,
            this.userToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.arrangementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuItem,
            this.qusestionToolStripMenuItem,
            this.solvedExamplesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.noteToolStripMenuItem.Text = "note";
            // 
            // qusestionToolStripMenuItem
            // 
            this.qusestionToolStripMenuItem.Name = "qusestionToolStripMenuItem";
            this.qusestionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.qusestionToolStripMenuItem.Text = "   Question collection";
            this.qusestionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // solvedExamplesToolStripMenuItem
            // 
            this.solvedExamplesToolStripMenuItem.Name = "solvedExamplesToolStripMenuItem";
            this.solvedExamplesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.solvedExamplesToolStripMenuItem.Text = "Solved Examples";
            // 
            // admin_part
            // 
            this.admin_part.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.blockUserToolStripMenuItem});
            this.admin_part.Name = "admin_part";
            this.admin_part.Size = new System.Drawing.Size(55, 20);
            this.admin_part.Text = "Admin";
            this.admin_part.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addUserToolStripMenuItem.Text = "Create User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // blockUserToolStripMenuItem
            // 
            this.blockUserToolStripMenuItem.Name = "blockUserToolStripMenuItem";
            this.blockUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.blockUserToolStripMenuItem.Text = "Block User";
            this.blockUserToolStripMenuItem.Click += new System.EventHandler(this.blockUserToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introductionToolStripMenuItem,
            this.facilitiesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "Utilities";
            // 
            // introductionToolStripMenuItem
            // 
            this.introductionToolStripMenuItem.Name = "introductionToolStripMenuItem";
            this.introductionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.introductionToolStripMenuItem.Text = "Notepad";
            this.introductionToolStripMenuItem.Click += new System.EventHandler(this.introductionToolStripMenuItem_Click);
            // 
            // facilitiesToolStripMenuItem
            // 
            this.facilitiesToolStripMenuItem.Name = "facilitiesToolStripMenuItem";
            this.facilitiesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.facilitiesToolStripMenuItem.Text = "Calculator";
            this.facilitiesToolStripMenuItem.Click += new System.EventHandler(this.facilitiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportToolStripMenuItem,
            this.dailyReportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.helpToolStripMenuItem.Text = "Report";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            // 
            // arrangementToolStripMenuItem
            // 
            this.arrangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.arrangementToolStripMenuItem.Name = "arrangementToolStripMenuItem";
            this.arrangementToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.arrangementToolStripMenuItem.Text = "Arrangement";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(632, 57);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::login_s.Properties.Resources._20170327_174554;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(124, 54);
            this.toolStripButton1.Text = "Registration";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::login_s.Properties.Resources.SinaProg;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(107, 54);
            this.toolStripButton2.Text = "Message";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::login_s.Properties.Resources._1488786599433;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(84, 54);
            this.toolStripButton3.Text = "Sells";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::login_s.Properties.Resources._1488786305818;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(109, 54);
            this.toolStripButton4.Text = "Purchase";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(99, 54);
            this.toolStripButton5.Text = "Logout";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbtime,
            this.lbdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = " welcome Username";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lbtime
            // 
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(34, 17);
            this.lbtime.Text = "Time";
            this.lbtime.Click += new System.EventHandler(this.lbtime_Click);
            // 
            // lbdate
            // 
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(31, 17);
            this.lbdate.Text = "Date";
            this.lbdate.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login_s.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 275);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qusestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solvedExamplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbtime;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem admin_part;
        private System.Windows.Forms.ToolStripMenuItem arrangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.ToolStripStatusLabel lbdate;
    }
}