namespace MODBUSRTU_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("系统状态");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("故障信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("实时曲线");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("工作模式");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("工作空间", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("历史信息");
            this.MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.通讯设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本机设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainFormStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainFormStatusStrip.Name = "MainFormStatusStrip";
            this.MainFormStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MainFormStatusStrip.TabIndex = 59;
            this.MainFormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通讯设置ToolStripMenuItem,
            this.本机设置ToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(800, 25);
            this.MainFormMenuStrip.TabIndex = 60;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // 通讯设置ToolStripMenuItem
            // 
            this.通讯设置ToolStripMenuItem.Name = "通讯设置ToolStripMenuItem";
            this.通讯设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.通讯设置ToolStripMenuItem.Text = "通讯设置";
            this.通讯设置ToolStripMenuItem.Click += new System.EventHandler(this.通讯设置ToolStripMenuItem_Click);
            // 
            // 本机设置ToolStripMenuItem
            // 
            this.本机设置ToolStripMenuItem.Name = "本机设置ToolStripMenuItem";
            this.本机设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.本机设置ToolStripMenuItem.Text = "本机设置";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 403);
            this.splitter1.TabIndex = 65;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "SystemStatus";
            treeNode1.Text = "系统状态";
            treeNode2.Name = "FaultMsg";
            treeNode2.Text = "故障信息";
            treeNode3.Name = "Waveforms";
            treeNode3.Text = "实时曲线";
            treeNode4.Name = "WorkMode";
            treeNode4.Text = "工作模式";
            treeNode5.Name = "WorkSpace";
            treeNode5.Text = "工作空间";
            treeNode6.Name = "节点6";
            treeNode6.Text = "历史信息";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(121, 403);
            this.treeView1.TabIndex = 64;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainFormStatusStrip.ResumeLayout(false);
            this.MainFormStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainFormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 通讯设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本机设置ToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

