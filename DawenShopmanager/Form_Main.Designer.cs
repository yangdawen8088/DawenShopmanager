
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
            this.uiContextMenuStrip_Extend = new Sunny.UI.UIContextMenuStrip();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.意见反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel_UserInfo = new Sunny.UI.UIPanel();
            this.uiLabel_LoginDate = new Sunny.UI.UILabel();
            this.uiLabel_UserName = new Sunny.UI.UILabel();
            this.uiAvatar_UserAvatar = new Sunny.UI.UIAvatar();
            this.uiHeaderButton_Report = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton_member = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton_Invoicing = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton_HomePage = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton_OA = new Sunny.UI.UIHeaderButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.uiContextMenuStrip_Extend.SuspendLayout();
            this.uiPanel_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(252, 662);
            this.Footer.Size = new System.Drawing.Size(770, 56);
            this.Footer.Style = Sunny.UI.UIStyle.Custom;
            this.Footer.Visible = false;
            // 
            // Aside
            // 
            this.Aside.Location = new System.Drawing.Point(2, 135);
            this.Aside.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Aside.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Aside.Size = new System.Drawing.Size(250, 583);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.Header.Controls.Add(this.uiHeaderButton_OA);
            this.Header.Controls.Add(this.uiHeaderButton_HomePage);
            this.Header.Controls.Add(this.uiHeaderButton_Invoicing);
            this.Header.Controls.Add(this.uiHeaderButton_member);
            this.Header.Controls.Add(this.uiHeaderButton_Report);
            this.Header.Controls.Add(this.uiPanel_UserInfo);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Location = new System.Drawing.Point(2, 35);
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Size = new System.Drawing.Size(1020, 100);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            // 
            // uiContextMenuStrip_Extend
            // 
            this.uiContextMenuStrip_Extend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip_Extend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口置顶ToolStripMenuItem,
            this.退出登录ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.意见反馈ToolStripMenuItem});
            this.uiContextMenuStrip_Extend.Name = "uiContextMenuStrip_Extend";
            this.uiContextMenuStrip_Extend.Size = new System.Drawing.Size(145, 160);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.nottop;
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            this.窗口置顶ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.窗口置顶ToolStripMenuItem_MouseUp);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.signout;
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.退出登录ToolStripMenuItem_MouseUp);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.Help;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.about;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.set;
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 意见反馈ToolStripMenuItem
            // 
            this.意见反馈ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.Feedback;
            this.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem";
            this.意见反馈ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.意见反馈ToolStripMenuItem.Text = "意见反馈";
            // 
            // uiPanel_UserInfo
            // 
            this.uiPanel_UserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel_UserInfo.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_UserInfo.Controls.Add(this.uiLabel_LoginDate);
            this.uiPanel_UserInfo.Controls.Add(this.uiLabel_UserName);
            this.uiPanel_UserInfo.Controls.Add(this.uiAvatar_UserAvatar);
            this.uiPanel_UserInfo.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel_UserInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel_UserInfo.Location = new System.Drawing.Point(820, 0);
            this.uiPanel_UserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_UserInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_UserInfo.Name = "uiPanel_UserInfo";
            this.uiPanel_UserInfo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel_UserInfo.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel_UserInfo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_UserInfo.Size = new System.Drawing.Size(200, 100);
            this.uiPanel_UserInfo.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_UserInfo.TabIndex = 8;
            this.uiPanel_UserInfo.Text = null;
            this.uiPanel_UserInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel_UserInfo.MouseLeave += new System.EventHandler(this.uiPanel_UserInfo_MouseLeave);
            this.uiPanel_UserInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uiPanel_UserInfo_MouseMove);
            // 
            // uiLabel_LoginDate
            // 
            this.uiLabel_LoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel_LoginDate.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel_LoginDate.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.uiLabel_LoginDate.Location = new System.Drawing.Point(73, 57);
            this.uiLabel_LoginDate.Name = "uiLabel_LoginDate";
            this.uiLabel_LoginDate.Size = new System.Drawing.Size(120, 23);
            this.uiLabel_LoginDate.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_LoginDate.TabIndex = 2;
            this.uiLabel_LoginDate.Text = "2021年10月18日 8:58";
            this.uiLabel_LoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel_LoginDate.MouseLeave += new System.EventHandler(this.uiPanel_UserInfo_MouseLeave);
            this.uiLabel_LoginDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uiPanel_UserInfo_MouseMove);
            // 
            // uiLabel_UserName
            // 
            this.uiLabel_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel_UserName.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel_UserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_UserName.Location = new System.Drawing.Point(73, 21);
            this.uiLabel_UserName.Name = "uiLabel_UserName";
            this.uiLabel_UserName.Size = new System.Drawing.Size(120, 32);
            this.uiLabel_UserName.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_UserName.TabIndex = 1;
            this.uiLabel_UserName.Text = "用户名";
            this.uiLabel_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel_UserName.MouseLeave += new System.EventHandler(this.uiPanel_UserInfo_MouseLeave);
            this.uiLabel_UserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uiPanel_UserInfo_MouseMove);
            // 
            // uiAvatar_UserAvatar
            // 
            this.uiAvatar_UserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar_UserAvatar.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar_UserAvatar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar_UserAvatar.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar_UserAvatar.ImageOffset = new System.Drawing.Point(-2, -2);
            this.uiAvatar_UserAvatar.Location = new System.Drawing.Point(7, 20);
            this.uiAvatar_UserAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar_UserAvatar.Name = "uiAvatar_UserAvatar";
            this.uiAvatar_UserAvatar.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar_UserAvatar.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar_UserAvatar.TabIndex = 0;
            this.uiAvatar_UserAvatar.MouseLeave += new System.EventHandler(this.uiPanel_UserInfo_MouseLeave);
            this.uiAvatar_UserAvatar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uiPanel_UserInfo_MouseMove);
            // 
            // uiHeaderButton_Report
            // 
            this.uiHeaderButton_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton_Report.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_Report.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_Report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Report.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Report.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Report.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Report.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton_Report.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton_Report.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_Report.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_Report.Location = new System.Drawing.Point(732, 0);
            this.uiHeaderButton_Report.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton_Report.Name = "uiHeaderButton_Report";
            this.uiHeaderButton_Report.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton_Report.Radius = 0;
            this.uiHeaderButton_Report.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton_Report.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton_Report.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton_Report.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton_Report.Symbol = 62104;
            this.uiHeaderButton_Report.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton_Report.SymbolSize = 60;
            this.uiHeaderButton_Report.TabIndex = 17;
            this.uiHeaderButton_Report.Text = "数据报表";
            this.uiHeaderButton_Report.Click += new System.EventHandler(this.uiHeaderButton_Report_Click);
            // 
            // uiHeaderButton_member
            // 
            this.uiHeaderButton_member.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton_member.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_member.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_member.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_member.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_member.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_member.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_member.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton_member.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton_member.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_member.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_member.Location = new System.Drawing.Point(556, 0);
            this.uiHeaderButton_member.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton_member.Name = "uiHeaderButton_member";
            this.uiHeaderButton_member.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton_member.Radius = 0;
            this.uiHeaderButton_member.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton_member.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton_member.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton_member.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton_member.Symbol = 362727;
            this.uiHeaderButton_member.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton_member.SymbolSize = 60;
            this.uiHeaderButton_member.TabIndex = 20;
            this.uiHeaderButton_member.Text = "会员管理";
            this.uiHeaderButton_member.Click += new System.EventHandler(this.uiHeaderButton_member_Click);
            // 
            // uiHeaderButton_Invoicing
            // 
            this.uiHeaderButton_Invoicing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton_Invoicing.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_Invoicing.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_Invoicing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Invoicing.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Invoicing.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Invoicing.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_Invoicing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton_Invoicing.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton_Invoicing.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_Invoicing.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_Invoicing.Location = new System.Drawing.Point(468, 0);
            this.uiHeaderButton_Invoicing.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton_Invoicing.Name = "uiHeaderButton_Invoicing";
            this.uiHeaderButton_Invoicing.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton_Invoicing.Radius = 0;
            this.uiHeaderButton_Invoicing.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton_Invoicing.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton_Invoicing.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton_Invoicing.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton_Invoicing.Symbol = 362687;
            this.uiHeaderButton_Invoicing.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton_Invoicing.SymbolSize = 60;
            this.uiHeaderButton_Invoicing.TabIndex = 21;
            this.uiHeaderButton_Invoicing.Text = "进销存";
            this.uiHeaderButton_Invoicing.Click += new System.EventHandler(this.uiHeaderButton_Invoicing_Click);
            // 
            // uiHeaderButton_HomePage
            // 
            this.uiHeaderButton_HomePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton_HomePage.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_HomePage.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_HomePage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_HomePage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_HomePage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_HomePage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_HomePage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton_HomePage.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton_HomePage.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_HomePage.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_HomePage.Location = new System.Drawing.Point(380, 0);
            this.uiHeaderButton_HomePage.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton_HomePage.Name = "uiHeaderButton_HomePage";
            this.uiHeaderButton_HomePage.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton_HomePage.Radius = 0;
            this.uiHeaderButton_HomePage.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton_HomePage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton_HomePage.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton_HomePage.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton_HomePage.Symbol = 357446;
            this.uiHeaderButton_HomePage.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton_HomePage.SymbolSize = 60;
            this.uiHeaderButton_HomePage.TabIndex = 22;
            this.uiHeaderButton_HomePage.Text = "首页";
            this.uiHeaderButton_HomePage.Click += new System.EventHandler(this.uiHeaderButton_HomePage_Click);
            // 
            // uiHeaderButton_OA
            // 
            this.uiHeaderButton_OA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton_OA.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_OA.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton_OA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_OA.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_OA.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_OA.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton_OA.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton_OA.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton_OA.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_OA.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton_OA.Location = new System.Drawing.Point(644, 0);
            this.uiHeaderButton_OA.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton_OA.Name = "uiHeaderButton_OA";
            this.uiHeaderButton_OA.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton_OA.Radius = 0;
            this.uiHeaderButton_OA.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton_OA.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton_OA.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton_OA.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton_OA.Symbol = 362576;
            this.uiHeaderButton_OA.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton_OA.SymbolSize = 60;
            this.uiHeaderButton_OA.TabIndex = 23;
            this.uiHeaderButton_OA.Text = "系统 OA";
            this.uiHeaderButton_OA.Click += new System.EventHandler(this.uiHeaderButton_OA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DawenShopmanager.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.Text = "系统名称";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Footer, 0);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStrip_Extend.ResumeLayout(false);
            this.uiPanel_UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip_Extend;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel_UserInfo;
        private Sunny.UI.UILabel uiLabel_LoginDate;
        private Sunny.UI.UILabel uiLabel_UserName;
        private Sunny.UI.UIAvatar uiAvatar_UserAvatar;
        private Sunny.UI.UIHeaderButton uiHeaderButton_Report;
        private Sunny.UI.UIHeaderButton uiHeaderButton_OA;
        private Sunny.UI.UIHeaderButton uiHeaderButton_HomePage;
        private Sunny.UI.UIHeaderButton uiHeaderButton_Invoicing;
        private Sunny.UI.UIHeaderButton uiHeaderButton_member;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 意见反馈ToolStripMenuItem;
    }
}

