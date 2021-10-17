
namespace DawenShopmanager
{
    partial class Form_Main
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.uiContextMenuStrip_Extend = new Sunny.UI.UIContextMenuStrip();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Header.SuspendLayout();
            this.uiContextMenuStrip_Extend.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(252, 662);
            this.Footer.Size = new System.Drawing.Size(770, 56);
            this.Footer.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Aside
            // 
            this.Aside.Location = new System.Drawing.Point(2, 145);
            this.Aside.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Aside.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Aside.Size = new System.Drawing.Size(250, 573);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.uiLogo1);
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.Location = new System.Drawing.Point(2, 35);
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Size = new System.Drawing.Size(1020, 110);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(957, 24);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLogo1
            // 
            this.uiLogo1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLogo1.Location = new System.Drawing.Point(20, 24);
            this.uiLogo1.MaximumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.MinimumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.Name = "uiLogo1";
            this.uiLogo1.Size = new System.Drawing.Size(300, 80);
            this.uiLogo1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLogo1.TabIndex = 4;
            this.uiLogo1.Text = "uiLogo1";
            // 
            // uiContextMenuStrip_Extend
            // 
            this.uiContextMenuStrip_Extend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip_Extend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出登录ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.uiContextMenuStrip_Extend.Name = "uiContextMenuStrip_Extend";
            this.uiContextMenuStrip_Extend.Size = new System.Drawing.Size(145, 82);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.退出登录ToolStripMenuItem_MouseUp);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(398, 39);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(469, 23);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "uiLabel1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.ExtendBox = true;
            this.ExtendMenu = this.uiContextMenuStrip_Extend;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.ShowDragStretch = true;
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "DaWen 店长";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Footer, 0);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStrip_Extend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILogo uiLogo1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip_Extend;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private Sunny.UI.UILabel uiLabel1;
    }
}

