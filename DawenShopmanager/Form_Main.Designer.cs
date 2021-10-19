
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiHeaderButton3 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton5 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton6 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton7 = new Sunny.UI.UIHeaderButton();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.uiContextMenuStrip_Extend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.uiLabel1);
            this.Footer.Location = new System.Drawing.Point(252, 662);
            this.Footer.Size = new System.Drawing.Size(770, 56);
            this.Footer.Style = Sunny.UI.UIStyle.Custom;
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
            this.Header.Controls.Add(this.uiHeaderButton7);
            this.Header.Controls.Add(this.uiHeaderButton6);
            this.Header.Controls.Add(this.uiHeaderButton5);
            this.Header.Controls.Add(this.uiHeaderButton4);
            this.Header.Controls.Add(this.uiHeaderButton3);
            this.Header.Controls.Add(this.uiPanel1);
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
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.uiContextMenuStrip_Extend.Name = "uiContextMenuStrip_Extend";
            this.uiContextMenuStrip_Extend.Size = new System.Drawing.Size(145, 108);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(92, 15);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(469, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "uiLabel1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.nottop;
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            this.窗口置顶ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.窗口置顶ToolStripMenuItem_MouseUp);
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
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Image = global::DawenShopmanager.Properties.Resources.signout;
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.退出登录ToolStripMenuItem_MouseUp);
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
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiAvatar1);
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(820, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(200, 100);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 8;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar1.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar1.Image = global::DawenShopmanager.Properties.Resources.signout;
            this.uiAvatar1.Location = new System.Drawing.Point(7, 20);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(73, 21);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 32);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "用户名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.uiLabel3.Location = new System.Drawing.Point(73, 57);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(120, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "2021年10月18日 8:58";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiHeaderButton3
            // 
            this.uiHeaderButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton3.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton3.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton3.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton3.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton3.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton3.Location = new System.Drawing.Point(732, 0);
            this.uiHeaderButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton3.Name = "uiHeaderButton3";
            this.uiHeaderButton3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton3.Radius = 0;
            this.uiHeaderButton3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton3.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton3.Symbol = 61487;
            this.uiHeaderButton3.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton3.SymbolSize = 60;
            this.uiHeaderButton3.TabIndex = 17;
            this.uiHeaderButton3.Text = "系统首页";
            // 
            // uiHeaderButton4
            // 
            this.uiHeaderButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton4.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton4.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton4.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton4.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton4.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton4.Location = new System.Drawing.Point(556, 0);
            this.uiHeaderButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton4.Name = "uiHeaderButton4";
            this.uiHeaderButton4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton4.Radius = 0;
            this.uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton4.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton4.Symbol = 61573;
            this.uiHeaderButton4.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton4.SymbolSize = 60;
            this.uiHeaderButton4.TabIndex = 20;
            this.uiHeaderButton4.Text = "系统首页";
            // 
            // uiHeaderButton5
            // 
            this.uiHeaderButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton5.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton5.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton5.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton5.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton5.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton5.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton5.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton5.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton5.Location = new System.Drawing.Point(468, 0);
            this.uiHeaderButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton5.Name = "uiHeaderButton5";
            this.uiHeaderButton5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton5.Radius = 0;
            this.uiHeaderButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton5.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton5.Symbol = 61783;
            this.uiHeaderButton5.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton5.SymbolSize = 60;
            this.uiHeaderButton5.TabIndex = 21;
            this.uiHeaderButton5.Text = "系统首页";
            // 
            // uiHeaderButton6
            // 
            this.uiHeaderButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton6.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton6.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton6.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton6.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton6.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton6.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton6.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton6.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton6.Location = new System.Drawing.Point(380, 0);
            this.uiHeaderButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton6.Name = "uiHeaderButton6";
            this.uiHeaderButton6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton6.Radius = 0;
            this.uiHeaderButton6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton6.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton6.Symbol = 57353;
            this.uiHeaderButton6.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton6.SymbolSize = 60;
            this.uiHeaderButton6.TabIndex = 22;
            this.uiHeaderButton6.Text = "系统首页";
            // 
            // uiHeaderButton7
            // 
            this.uiHeaderButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiHeaderButton7.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton7.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.uiHeaderButton7.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.uiHeaderButton7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton7.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.uiHeaderButton7.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton7.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.uiHeaderButton7.Location = new System.Drawing.Point(644, 0);
            this.uiHeaderButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton7.Name = "uiHeaderButton7";
            this.uiHeaderButton7.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton7.Radius = 0;
            this.uiHeaderButton7.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton7.Size = new System.Drawing.Size(88, 100);
            this.uiHeaderButton7.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton7.Symbol = 163042;
            this.uiHeaderButton7.SymbolOffset = new System.Drawing.Point(0, 12);
            this.uiHeaderButton7.SymbolSize = 60;
            this.uiHeaderButton7.TabIndex = 23;
            this.uiHeaderButton7.Text = "系统首页";
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
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStrip_Extend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip_Extend;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIHeaderButton uiHeaderButton3;
        private Sunny.UI.UIHeaderButton uiHeaderButton7;
        private Sunny.UI.UIHeaderButton uiHeaderButton6;
        private Sunny.UI.UIHeaderButton uiHeaderButton5;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
    }
}

