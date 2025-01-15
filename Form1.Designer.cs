using ConsoleServiceTool.Console.Sony.PlayStation5.Views;

namespace ConsoleServiceTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            sonyToolStripMenuItem = new ToolStripMenuItem();
            playStation5ToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            MainPanel = new Panel();
            label1 = new Label();
            workbenchToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, sonyToolStripMenuItem, stockToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(2234, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            // 
            // sonyToolStripMenuItem
            // 
            sonyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playStation5ToolStripMenuItem });
            sonyToolStripMenuItem.Name = "sonyToolStripMenuItem";
            sonyToolStripMenuItem.Size = new Size(68, 29);
            sonyToolStripMenuItem.Text = "Sony";
            // 
            // playStation5ToolStripMenuItem
            // 
            playStation5ToolStripMenuItem.Name = "playStation5ToolStripMenuItem";
            playStation5ToolStripMenuItem.Size = new Size(216, 34);
            playStation5ToolStripMenuItem.Text = "PlayStation 5";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workbenchToolStripMenuItem });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(116, 29);
            stockToolStripMenuItem.Text = "Repair Hub";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 120);
            MainPanel.Margin = new Padding(4, 5, 4, 5);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(2234, 1532);
            MainPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 35);
            label1.Margin = new Padding(21, 25, 21, 25);
            label1.Name = "label1";
            label1.Padding = new Padding(29, 0, 0, 0);
            label1.Size = new Size(2234, 85);
            label1.TabIndex = 3;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // workbenchToolStripMenuItem
            // 
            workbenchToolStripMenuItem.Name = "workbenchToolStripMenuItem";
            workbenchToolStripMenuItem.Size = new Size(270, 34);
            workbenchToolStripMenuItem.Text = "Workbench";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2234, 1652);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Console Service Tool (C.S.T)";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sonyToolStripMenuItem;
        private ToolStripMenuItem playStation5ToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Panel MainPanel;
        private Label label1;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem workbenchToolStripMenuItem;
    }
}