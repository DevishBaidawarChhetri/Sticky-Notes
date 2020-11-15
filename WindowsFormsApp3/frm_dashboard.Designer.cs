namespace WindowsFormsApp3
{
    partial class frm_dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedStickyNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incompletedStickyNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxt2 = new System.Windows.Forms.ToolStripTextBox();
            this.pieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxt1 = new System.Windows.Forms.ToolStripTextBox();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pieChartToolStripMenuItem,
            this.searchNotesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completedStickyNotesToolStripMenuItem,
            this.incompletedStickyNotesToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.newNoteToolStripMenuItem,
            this.deleteNotesToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // completedStickyNotesToolStripMenuItem
            // 
            this.completedStickyNotesToolStripMenuItem.Name = "completedStickyNotesToolStripMenuItem";
            this.completedStickyNotesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.completedStickyNotesToolStripMenuItem.Text = "Completed";
            this.completedStickyNotesToolStripMenuItem.Click += new System.EventHandler(this.completedStickyNotesToolStripMenuItem_Click);
            // 
            // incompletedStickyNotesToolStripMenuItem
            // 
            this.incompletedStickyNotesToolStripMenuItem.Name = "incompletedStickyNotesToolStripMenuItem";
            this.incompletedStickyNotesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.incompletedStickyNotesToolStripMenuItem.Text = "Incompleted";
            this.incompletedStickyNotesToolStripMenuItem.Click += new System.EventHandler(this.incompletedStickyNotesToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newNoteToolStripMenuItem.Text = "New Notes";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // deleteNotesToolStripMenuItem
            // 
            this.deleteNotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxt2});
            this.deleteNotesToolStripMenuItem.Name = "deleteNotesToolStripMenuItem";
            this.deleteNotesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteNotesToolStripMenuItem.Text = "Delete Notes";
            // 
            // tstxt2
            // 
            this.tstxt2.Name = "tstxt2";
            this.tstxt2.Size = new System.Drawing.Size(100, 23);
            this.tstxt2.Click += new System.EventHandler(this.tstxt2_Click);
            this.tstxt2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged_1);
            // 
            // pieChartToolStripMenuItem
            // 
            this.pieChartToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.pieChartToolStripMenuItem.Name = "pieChartToolStripMenuItem";
            this.pieChartToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.pieChartToolStripMenuItem.Text = "Pie Chart";
            this.pieChartToolStripMenuItem.Click += new System.EventHandler(this.pieChartToolStripMenuItem_Click);
            // 
            // searchNotesToolStripMenuItem
            // 
            this.searchNotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byTitleToolStripMenuItem,
            this.byDateToolStripMenuItem});
            this.searchNotesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.searchNotesToolStripMenuItem.Name = "searchNotesToolStripMenuItem";
            this.searchNotesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.searchNotesToolStripMenuItem.Text = "Search Notes";
            this.searchNotesToolStripMenuItem.Click += new System.EventHandler(this.searchNotesToolStripMenuItem_Click);
            // 
            // byTitleToolStripMenuItem
            // 
            this.byTitleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxt1});
            this.byTitleToolStripMenuItem.Name = "byTitleToolStripMenuItem";
            this.byTitleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byTitleToolStripMenuItem.Text = "By Title";
            this.byTitleToolStripMenuItem.Click += new System.EventHandler(this.byTitleToolStripMenuItem_Click);
            // 
            // tstxt1
            // 
            this.tstxt1.Name = "tstxt1";
            this.tstxt1.Size = new System.Drawing.Size(100, 23);
            this.tstxt1.Click += new System.EventHandler(this.tstxt1_Click_2);
            this.tstxt1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byDateToolStripMenuItem.Text = "By Date";
            this.byDateToolStripMenuItem.Click += new System.EventHandler(this.byDateToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.technicalSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.technicalSupportToolStripMenuItem.Text = "Contact Me";
            this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Sticky Notes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(649, 0);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "NULL";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl2.Location = new System.Drawing.Point(743, 0);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(66, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "NULL";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Dashboard;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 1996);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 609);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedStickyNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incompletedStickyNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox tstxt1;
        private System.Windows.Forms.ToolStripMenuItem deleteNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tstxt2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer timer1;
    }
}