namespace 门禁系统
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看报修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查寝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gpb = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.宿舍管理ToolStripMenuItem,
            this.学生管理ToolStripMenuItem,
            this.个人中心ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.日历ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            this.用户ToolStripMenuItem.Click += new System.EventHandler(this.用户ToolStripMenuItem_Click);
            // 
            // 宿舍管理ToolStripMenuItem
            // 
            this.宿舍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宿舍查询ToolStripMenuItem,
            this.报修ToolStripMenuItem,
            this.查看报修ToolStripMenuItem});
            this.宿舍管理ToolStripMenuItem.Name = "宿舍管理ToolStripMenuItem";
            this.宿舍管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宿舍管理ToolStripMenuItem.Text = "宿舍管理";
            this.宿舍管理ToolStripMenuItem.Click += new System.EventHandler(this.宿舍管理ToolStripMenuItem_Click);
            // 
            // 宿舍查询ToolStripMenuItem
            // 
            this.宿舍查询ToolStripMenuItem.Name = "宿舍查询ToolStripMenuItem";
            this.宿舍查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.宿舍查询ToolStripMenuItem.Text = "宿舍查询";
            this.宿舍查询ToolStripMenuItem.Click += new System.EventHandler(this.宿舍查询ToolStripMenuItem_Click);
            // 
            // 报修ToolStripMenuItem
            // 
            this.报修ToolStripMenuItem.Name = "报修ToolStripMenuItem";
            this.报修ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.报修ToolStripMenuItem.Text = "报修";
            this.报修ToolStripMenuItem.Click += new System.EventHandler(this.报修ToolStripMenuItem_Click);
            // 
            // 查看报修ToolStripMenuItem
            // 
            this.查看报修ToolStripMenuItem.Name = "查看报修ToolStripMenuItem";
            this.查看报修ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看报修ToolStripMenuItem.Text = "查看报修";
            this.查看报修ToolStripMenuItem.Click += new System.EventHandler(this.查看报修ToolStripMenuItem_Click);
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生ToolStripMenuItem,
            this.删除学生ToolStripMenuItem,
            this.学生查询ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加学生ToolStripMenuItem.Text = "学生添加";
            this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // 删除学生ToolStripMenuItem
            // 
            this.删除学生ToolStripMenuItem.Name = "删除学生ToolStripMenuItem";
            this.删除学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除学生ToolStripMenuItem.Text = "删除学生";
            this.删除学生ToolStripMenuItem.Click += new System.EventHandler(this.删除学生ToolStripMenuItem_Click);
            // 
            // 学生查询ToolStripMenuItem
            // 
            this.学生查询ToolStripMenuItem.Name = "学生查询ToolStripMenuItem";
            this.学生查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生查询ToolStripMenuItem.Text = "学生查询";
            this.学生查询ToolStripMenuItem.Click += new System.EventHandler(this.学生查询ToolStripMenuItem_Click);
            // 
            // 个人中心ToolStripMenuItem
            // 
            this.个人中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查寝ToolStripMenuItem,
            this.请假ToolStripMenuItem});
            this.个人中心ToolStripMenuItem.Name = "个人中心ToolStripMenuItem";
            this.个人中心ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人中心ToolStripMenuItem.Text = "个人中心";
            // 
            // 查寝ToolStripMenuItem
            // 
            this.查寝ToolStripMenuItem.Name = "查寝ToolStripMenuItem";
            this.查寝ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查寝ToolStripMenuItem.Text = "查寝";
            this.查寝ToolStripMenuItem.Click += new System.EventHandler(this.查寝ToolStripMenuItem_Click);
            // 
            // 请假ToolStripMenuItem
            // 
            this.请假ToolStripMenuItem.Name = "请假ToolStripMenuItem";
            this.请假ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.请假ToolStripMenuItem.Text = "请假";
            this.请假ToolStripMenuItem.Click += new System.EventHandler(this.请假ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 日历ToolStripMenuItem
            // 
            this.日历ToolStripMenuItem.Name = "日历ToolStripMenuItem";
            this.日历ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.日历ToolStripMenuItem.Text = "日历";
            this.日历ToolStripMenuItem.Click += new System.EventHandler(this.日历ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "学生查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "宿舍查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "请假";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "日历";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gpb
            // 
            this.gpb.BackColor = System.Drawing.Color.Transparent;
            this.gpb.Location = new System.Drawing.Point(175, 52);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(310, 275);
            this.gpb.TabIndex = 5;
            this.gpb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看报修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查寝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日历ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gpb;

    }
}

