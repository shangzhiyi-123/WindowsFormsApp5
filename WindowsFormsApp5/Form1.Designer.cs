namespace WindowsFormsApp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按年级查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem,
            this.科目管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            this.账户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账户管理ToolStripMenuItem.Text = "账户管理";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增学生ToolStripMenuItem,
            this.按姓名查询ToolStripMenuItem,
            this.按年级查询ToolStripMenuItem,
            this.学生列表ToolStripMenuItem});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 科目管理ToolStripMenuItem
            // 
            this.科目管理ToolStripMenuItem.Name = "科目管理ToolStripMenuItem";
            this.科目管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.科目管理ToolStripMenuItem.Text = "科目管理";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 新增学生ToolStripMenuItem
            // 
            this.新增学生ToolStripMenuItem.Name = "新增学生ToolStripMenuItem";
            this.新增学生ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增学生ToolStripMenuItem.Text = "新增学生";
            // 
            // 按姓名查询ToolStripMenuItem
            // 
            this.按姓名查询ToolStripMenuItem.Name = "按姓名查询ToolStripMenuItem";
            this.按姓名查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.按姓名查询ToolStripMenuItem.Text = "按姓名查询";
            // 
            // 按年级查询ToolStripMenuItem
            // 
            this.按年级查询ToolStripMenuItem.Name = "按年级查询ToolStripMenuItem";
            this.按年级查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.按年级查询ToolStripMenuItem.Text = "按年级查询";
            // 
            // 学生列表ToolStripMenuItem
            // 
            this.学生列表ToolStripMenuItem.Name = "学生列表ToolStripMenuItem";
            this.学生列表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.学生列表ToolStripMenuItem.Text = "学生列表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按年级查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

