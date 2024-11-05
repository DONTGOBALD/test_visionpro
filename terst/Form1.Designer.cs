namespace terst
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
            this.cogRecordsDisplay1 = new Cognex.VisionPro.CogRecordsDisplay();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.程序设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增检测程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RunOnce = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogRecordsDisplay1
            // 
            this.cogRecordsDisplay1.Location = new System.Drawing.Point(12, 35);
            this.cogRecordsDisplay1.Name = "cogRecordsDisplay1";
            this.cogRecordsDisplay1.SelectedRecordKey = null;
            this.cogRecordsDisplay1.ShowRecordsDropDown = true;
            this.cogRecordsDisplay1.Size = new System.Drawing.Size(776, 475);
            this.cogRecordsDisplay1.Subject = null;
            this.cogRecordsDisplay1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 程序设置ToolStripMenuItem
            // 
            this.程序设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增检测程序ToolStripMenuItem});
            this.程序设置ToolStripMenuItem.Name = "程序设置ToolStripMenuItem";
            this.程序设置ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.程序设置ToolStripMenuItem.Text = "程序设置";
            // 
            // 新增检测程序ToolStripMenuItem
            // 
            this.新增检测程序ToolStripMenuItem.Name = "新增检测程序ToolStripMenuItem";
            this.新增检测程序ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.新增检测程序ToolStripMenuItem.Text = "新增检测程序";
            this.新增检测程序ToolStripMenuItem.Click += new System.EventHandler(this.新增检测程序ToolStripMenuItem_Click);
            // 
            // btn_RunOnce
            // 
            this.btn_RunOnce.Location = new System.Drawing.Point(829, 124);
            this.btn_RunOnce.Name = "btn_RunOnce";
            this.btn_RunOnce.Size = new System.Drawing.Size(144, 62);
            this.btn_RunOnce.TabIndex = 2;
            this.btn_RunOnce.Text = "RunOncee";
            this.btn_RunOnce.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 522);
            this.Controls.Add(this.btn_RunOnce);
            this.Controls.Add(this.cogRecordsDisplay1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordsDisplay cogRecordsDisplay1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 程序设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增检测程序ToolStripMenuItem;
        private System.Windows.Forms.Button btn_RunOnce;
    }
}

