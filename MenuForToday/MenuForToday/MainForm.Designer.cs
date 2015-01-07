namespace MenuForToday
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.catalogTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageTab = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.catalogTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.catalogTab);
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.manageTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // catalogTab
            // 
            this.catalogTab.BackColor = System.Drawing.Color.LightGray;
            this.catalogTab.Controls.Add(this.panel3);
            this.catalogTab.Controls.Add(this.panel1);
            this.catalogTab.Location = new System.Drawing.Point(4, 22);
            this.catalogTab.Name = "catalogTab";
            this.catalogTab.Padding = new System.Windows.Forms.Padding(3);
            this.catalogTab.Size = new System.Drawing.Size(519, 479);
            this.catalogTab.TabIndex = 0;
            this.catalogTab.Text = "Catalogue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 27);
            this.panel1.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.LightGray;
            this.addTab.Controls.Add(this.panel2);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(519, 479);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add Menu";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 276);
            this.panel2.TabIndex = 0;
            // 
            // manageTab
            // 
            this.manageTab.BackColor = System.Drawing.Color.LightGray;
            this.manageTab.Location = new System.Drawing.Point(4, 22);
            this.manageTab.Name = "manageTab";
            this.manageTab.Padding = new System.Windows.Forms.Padding(3);
            this.manageTab.Size = new System.Drawing.Size(519, 479);
            this.manageTab.TabIndex = 2;
            this.manageTab.Text = "Manage Menu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel1.Text = "how many item in catalog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(7, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 439);
            this.panel3.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 547);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Menu For Today";
            this.tabControl1.ResumeLayout(false);
            this.catalogTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addTab.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage catalogTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage manageTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

